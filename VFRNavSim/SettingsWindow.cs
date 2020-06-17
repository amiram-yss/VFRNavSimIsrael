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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            InitializeControls();
            LoadSettingsToControls();
        }

        private void InitializeControls()
        {
            //Save Button
            _btnSave.Text = "שמור";
            _btnSave.Click += _btnSave_Click;
            //Wind Speed
            _numWindMaxSpeed.MouseWheel += _numWindMaxSpeed_MouseWheel;
            //WindRange
            _numWindRangeStart.MouseWheel += _numWindRangeStart_MouseWheel;
            _numWindRangeEnd.MouseWheel += _numWindRangeEnd_MouseWheel;
        }

        private void _numWindRangeEnd_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _numWindRangeEnd.Value != 359 ? _numWindRangeEnd.Value : 360;
            var newVal = firstVar + (e.Delta > 0 ? 10 : -10);
            try
            {
                _numWindRangeEnd.Value = newVal;
            }
            catch
            {
                if (newVal > _numWindRangeEnd.Maximum)
                    newVal = _numWindRangeEnd.Maximum;
                else
                    newVal = _numWindRangeEnd.Minimum;
                _numWindRangeEnd.Value = newVal;
            }
        }

        private void _numWindRangeStart_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            var firstVar = _numWindRangeStart.Value != 359 ? _numWindRangeStart.Value : 360;
            var newVal = firstVar + (e.Delta > 0 ? 10 : -10);
            try
            {
                _numWindRangeStart.Value = newVal;
            }
            catch
            {
                if (newVal > _numWindRangeStart.Maximum)
                    newVal = _numWindRangeStart.Maximum;
                else
                    newVal = _numWindRangeStart.Minimum;
                _numWindRangeStart.Value = newVal;
            }
        }

        private void _numWindMaxSpeed_MouseWheel(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default._propTimerOffset = (int)this._numMaxTimeOffset.Value;
            Properties.Settings.Default._propViewAngleDeltaWithTheWind = (int)this._numViewAngleDeltaWithTheWind.Value;
            Properties.Settings.Default._propViewAngleDeltaToTheWind = (int)this._numViewAngleDeltaToTheWind.Value;
            Properties.Settings.Default._propWindEndRange = (int)this._numWindRangeEnd.Value;
            Properties.Settings.Default._propWindStartRange = (int)this._numWindRangeStart.Value;
            Properties.Settings.Default._propWindMaxSpeed = (int)this._numWindMaxSpeed.Value;
            Properties.Settings.Default.Save();
            this.Dispose();
        }

        private void LoadSettingsToControls()
        {
            LoadWindSettings();
            LoadViewSettings();
            LoadTimeOffsetSetting();
        }

        private void LoadTimeOffsetSetting()
        {
            this._numMaxTimeOffset.Value = Properties.Settings.Default._propTimerOffset;
        }

        private void LoadViewSettings()
        {
            this._numViewAngleDeltaToTheWind.Value = Properties.Settings.Default._propViewAngleDeltaToTheWind;
            this._numViewAngleDeltaWithTheWind.Value = Properties.Settings.Default._propViewAngleDeltaWithTheWind;
        }

        private void LoadWindSettings()
        {
            this._numWindMaxSpeed.Value = Properties.Settings.Default._propWindMaxSpeed;
            this._numWindRangeStart.Value = Properties.Settings.Default._propWindStartRange;
            this._numWindRangeEnd.Value = Properties.Settings.Default._propWindEndRange;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
