﻿using System;
using System.Collections.Generic;
using System.Text;
using FogBugzNet;
using System.Diagnostics;
using System.Windows.Forms;

namespace FogBugzCaseTracker
{
    public partial class HoverWindow
    {
        private Case _caseBeforePause;
        private bool _switchToNothinUponClosing = false;
        private object _currentState;
        private Case _trackedCase = null;


        public bool ClientTrackingCase
        {
            get
            {
                return TrackedCase != null;
            }
        }

        public Case TrackedCase
        {
            get
            {
                return _trackedCase;
            }

            set
            {
                if (!_fb.ToggleWorkingOnCase(value != null ? value.ID : 0))
                {
                    Process.Start(_fb.CaseEditURL(0));
                    _trackedCase = null;
                    trayIcon.ShowBalloonTip(3000, "FogBugz", "Sorry, I need a time estimate on that case.\nMeanwhile, you're working on \"nothing\"", ToolTipIcon.Info);
                }
                _trackedCase = value;

                SetState(ClientTrackingCase ? new StateTrackingCase(this) : new StateLoggedIn(this));
            }
        }
        private void UpdateStateAccordingToTracking()
        {
            // Handle also case where a case is being tracked on the server side, but not on the client
            if (ClientTrackingCase || _fb.CaseWorkedOnNow != 0)
            {
                if (!SelectWorkedOnCase())
                {
                    TrackedCase = null;
                    SetState(new StateLoggedIn(this));
                }
                else
                    SetState(new StateTrackingCase(this));
            }
            else
                SetState(new StateLoggedIn(this));
        }
        private int FindWorkedOnCaseIndexInDropDown()
        {
            for (int i = 1; i < CaseDropDown.Items.Count; ++i)
            {
                if (((Case)CaseDropDown.Items[i]).ID == _fb.CaseWorkedOnNow)
                {
                    return i;
                }
            }
            return -1;
        }
        private void SelectCase(int i)
        {
            CaseDropDown.SelectedIndex = i;
            TrackedCase = ((Case)CaseDropDown.Items[i]);
        }

        private bool SelectWorkedOnCase()
        {
            int i = FindWorkedOnCaseIndexInDropDown();
            if (i == -1)
                return false;
            SelectCase(i);
            return true;
        }

        private void UpdateTrackedItem()
        {
            try
            {
                // If the selected item is changed as part of the update process, 
                // don't count it as the user changing selection
                if (_currentState.GetType() == typeof(StateUpdatingCases))
                    return;
                TrackedCase = SelectedItemIsCase() ? (Case)CaseDropDown.SelectedItem : null;
            }
            catch (System.InvalidCastException x)
            {
                Utils.LogError(x.ToString() + "Selected item (index:{0}) is not a Case!", CaseDropDown.SelectedIndex);
            }
        }


        private bool SelectedItemIsCase()
        {
            return CaseDropDown.SelectedItem.GetType() == typeof(Case);
        }

    }
}