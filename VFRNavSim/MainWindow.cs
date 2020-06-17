using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFRNavSim
{
    public partial class MainWindow : Form
    {
        PointSelector _frmPointSelectorStart, _frmPointSelectorDestination;
        Waypoint _wptStart, _wptDestination;
        //InformationWindow win;
        public MainWindow()
        {
            InitializeComponent();
            InitializeBasicControlsEvent();
            FileHandler.WaypointDatasetSetup();
            InitializeVariables();   
        }

        /// <summary>
        /// Sets local variables up.
        /// </summary>
        private void InitializeVariables()
        {
            _wptStart = new Waypoint();
            _wptDestination = new Waypoint();
            _frmPointSelectorStart = new PointSelector(_wptStart);
            _frmPointSelectorDestination = new PointSelector(_wptDestination);
            _frmPointSelectorStart.PointUpdated += StartPointUpdate;
            _frmPointSelectorDestination.PointUpdated += DestinationPointUpdate;
        }

        private void DestinationPointUpdate(object sender, EventArgs e)
        {
            _wptDestination = (e as PointChangedEventArgs).waypoint;
            _lblWaypointDestinationName.Text = _wptDestination.Name+ " [" +_wptDestination.FiveCharName+"]";
            _lblWaypointDestinationType.Text = _wptDestination.RequestType.ToString();
            _lblWaypointDestinationLat.Text = _wptDestination.GetLatitude().ToString();
            _lblWaypointDestinationLong.Text = _wptDestination.GetLongitude().ToString();
        }

        private void StartPointUpdate(object sender, EventArgs e)
        {
            _wptStart = (e as PointChangedEventArgs).waypoint;
            _lblWaypointStartName.Text = _wptStart.Name + " [" + _wptStart.FiveCharName + "]";
            _lblWaypointStartType.Text = _wptStart.RequestType.ToString();
            _lblWaypointStartLat.Text = _wptStart.GetLatitude().ToString();
            _lblWaypointStartLong.Text = _wptStart.GetLongitude().ToString();
        }
        #region Simple Controls Setup
        /// <summary>
        /// Sets behaviour of the basic control on the main form.
        /// </summary>
        private void InitializeBasicControlsEvent()
        {
            this._txtCurrentMinutes.MouseWheel += _txtCurrentMinutes_MouseWheel;
            this._txtCurrentSeconds.MouseWheel += _txtCurrentSeconds_MouseWheel;
            this._txtCheckpointMinutes.MouseWheel += _txtCheckpointMinutes_MouseWheel;
            this._txtCheckpointSeconds.MouseWheel += _txtCheckpointSeconds_MouseWheel;
            this._txtCruizeSpeed.MouseWheel += _txtCruizeSpeed_MouseWheel;
            this._txtCruizeAltitude.MouseWheel += _txtCruizeAltitude_MouseWheel;
            this._txtWindSpeed.MouseWheel += _txtWindSpeed_MouseWheel;
            this._txtWindDirection.MouseWheel += _txtWindDirection_MouseWheel;
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            //Buttons
            //Set _btnSetDestinationPoint
            this._btnSetDestinationPoint.Click += _btnSetDestinationPoint_Click1;
            this._btnSetDestinationPoint.Text = "הגדר נקודת יעד";
            this._btnSetStartingPoint.FontSize = 14;
            //Set _btnSetStartingPoint
            this._btnSetStartingPoint.Click += _btnSetStartingPoint_Click;
            this._btnSetStartingPoint.Text = "הגדר נקודת מוצא";
            this._btnSetDestinationPoint.FontSize = 14;
            //Set _btnExecute
            this._btnExecute.Click += _btnExecute_Click;
            this._btnExecute.Text = "העלה ל\n Google Earth";
            //Groupbox
            //Set
            roundedGroupBox2.Text = "נתוני מסלול כלליים";
            roundedGroupBox1.Text = "נתוני לג";
        }

        private void _btnSetDestinationPoint_Click1(object sender, EventArgs e)
        {
            _frmPointSelectorDestination.Show();
        }

        private void _txtCurrentSeconds_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _txtCurrentSeconds.Value != 59 ? _txtCurrentSeconds.Value : 60;
            var newVal = firstVar + (e.Delta > 0 ? 5 : -5);
            try
            {
                _txtCurrentSeconds.Value = newVal;
            }
            catch
            {
                if (newVal > _txtCurrentSeconds.Maximum)
                    newVal = _txtCurrentSeconds.Maximum;
                else
                    newVal = _txtCurrentSeconds.Minimum;
                _txtCurrentSeconds.Value = newVal;
            }
        }

        private void _txtCurrentMinutes_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _txtCurrentMinutes.Value;
            var newVal = firstVar + (e.Delta > 0 ? 1 : -1);
            try
            {
                _txtCurrentMinutes.Value = newVal;
            }
            catch
            {
                if (newVal > _txtCurrentMinutes.Maximum)
                    newVal = _txtCurrentMinutes.Maximum;
                else
                    newVal = _txtCurrentMinutes.Minimum;
                _txtCurrentMinutes.Value = newVal;
            }
        }

        private void _txtCheckpointMinutes_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _txtCheckpointMinutes.Value;
            var newVal = firstVar + (e.Delta > 0 ? 1 : -1);
            try
            {
                _txtCheckpointMinutes.Value = newVal;
            }
            catch
            {
                if (newVal > _txtCheckpointMinutes.Maximum)
                    newVal = _txtCheckpointMinutes.Maximum;
                else
                    newVal = _txtCheckpointMinutes.Minimum;
                _txtCheckpointMinutes.Value = newVal;
            }
        }
        private void _txtCheckpointSeconds_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _txtCheckpointSeconds.Value != 59 ? _txtCheckpointSeconds.Value : 60;
            var newVal = firstVar + (e.Delta > 0 ? 5 : -5);
            try {
                _txtCheckpointSeconds.Value = newVal;
            }
            catch
            {
                if (newVal > _txtCheckpointSeconds.Maximum)
                    newVal = _txtCheckpointSeconds.Maximum;
                else
                    newVal = _txtCheckpointSeconds.Minimum;
                _txtCheckpointSeconds.Value = newVal;
            }
        }
        private void _txtCruizeSpeed_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _txtCruizeSpeed.Value;
            var newVal = firstVar + (e.Delta > 0 ? 5 : -5);
            try
            {
                _txtCruizeSpeed.Value = newVal;
            }
            catch
            {
                if (newVal > _txtCruizeSpeed.Maximum)
                    newVal = _txtCruizeSpeed.Maximum;
                else
                    newVal = _txtCruizeSpeed.Minimum;
                _txtCruizeSpeed.Value = newVal;
            }
        }
        private void _txtCruizeAltitude_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _txtCruizeAltitude.Value;
            var newVal = firstVar + (e.Delta > 0 ? 500 : -500);
            try
            {
                _txtCruizeAltitude.Value = newVal;
            }
            catch
            {
                if (newVal > _txtCruizeAltitude.Maximum)
                    newVal = _txtCruizeAltitude.Maximum;
                else
                    newVal = _txtCruizeAltitude.Minimum;
                _txtCruizeAltitude.Value = newVal;
            }
        }
        private void _txtWindSpeed_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _txtWindSpeed.Value;
            var newVal = firstVar + (e.Delta > 0 ? 1 : -1);
            try
            {
                _txtWindSpeed.Value = newVal;
            }
            catch
            {
                if (newVal > _txtWindSpeed.Maximum)
                    newVal = _txtWindSpeed.Maximum;
                else
                    newVal = _txtWindSpeed.Minimum;
                _txtWindSpeed.Value = newVal;
            }
        }
        private void _txtWindDirection_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _txtWindDirection.Value != 359 ? _txtWindDirection.Value : 360;
            var newVal = firstVar + (e.Delta > 0 ? 10 : -10);
            try
            {
                _txtWindDirection.Value = newVal;
            }
            catch
            {
                if (newVal > _txtWindDirection.Maximum)
                    newVal = _txtWindDirection.Maximum;
                else
                    newVal = _txtWindDirection.Minimum;
                _txtWindDirection.Value = newVal;
            }
        }
        private void _chkCheckpointAvilable_CheckedChanged(object sender, EventArgs e)
        {
            _txtCheckpointMinutes.Enabled = _chkCheckpointAvilable.Checked;
            _txtCheckpointSeconds.Enabled = _chkCheckpointAvilable.Checked;


        }
        private void _chkWindRandom_CheckedChanged(object sender, EventArgs e)
        {
            _txtWindSpeed.Enabled = !_chkWindRandom.Checked;
            _txtWindDirection.Enabled = !_chkWindRandom.Checked;
        }

        private void _btnExecute_Click(object sender, EventArgs e)
        {
            if(_wptStart.Position.Lat == 0 || _wptStart.Position.Lat == 0)
            {
                MessageBox.Show("אנא הכנס נקודת התחלת לג.");
                return;
            }
            if (_wptDestination.Position.Lat == 0 || _wptDestination.Position.Lat == 0)
            {
                MessageBox.Show("אנא הכנס נקודת סיום לג.");
                return;
            }
            int wndDir = (int)_txtWindDirection.Value;
            int wndSpd = (int)_txtWindSpeed.Value;
            TimeSpan crtTime = new TimeSpan(0, (int)_txtCurrentMinutes.Value, (int)_txtCurrentSeconds.Value);
            TimeSpan idntTime = new TimeSpan(0, (int)_txtCheckpointMinutes.Value, (int)_txtCheckpointSeconds.Value);
            int spd = (int)_txtCruizeSpeed.Value;
            int height = (int)_txtCruizeAltitude.Value;
            var win = new InformationWindow
                (_wptStart,
                _wptDestination,
                wndDir,
                wndSpd,
                crtTime,
                idntTime,
                height,
                spd,
                !_chkTimeSet.Checked,
                _chkCheckpointAvilable.Checked,
                _chkWindRandom.Checked
                );
            win.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _txtCurrentMinutes.Enabled = _chkTimeSet.Checked;
            _txtCurrentSeconds.Enabled = _chkTimeSet.Checked;
        }

        private void ElementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void הגדרותרוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow SettingsWindow = new SettingsWindow();
            SettingsWindow.Show();
        }

        private void Host2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void _txtCruizeAltitude_ValueChanged(object sender, EventArgs e)
        {

        }

        private void צאToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btnSetStartingPoint_Click(object sender, EventArgs e)
        {
            _frmPointSelectorStart.Show();
        }
        #endregion
    }
}
