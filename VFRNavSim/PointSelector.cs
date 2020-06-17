using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows.Forms;

namespace VFRNavSim
{
    
    public partial class PointSelector : Form
    {
        private Dictionary<GMap.NET.WindowsForms.GMapMarker, Waypoint> _dicMrkWpt;
        Waypoint _wptEditedWaypoint;
        BindingList<Waypoint> bindingList;
        public event EventHandler PointUpdated;
        public PointSelector(Waypoint _wpt)
        {
            InitializeComponent();
            InitializeLocalVariables(_wpt);
            InitializeControls();
        }
        private void InitializeLocalVariables(Waypoint _wpt)
        {
            _wptEditedWaypoint = new Waypoint(_wpt.Name, _wpt.Position, _wpt.FiveCharName, _wpt.RequestType);
            _dicMrkWpt = new Dictionary<GMap.NET.WindowsForms.GMapMarker, Waypoint>();
            foreach (var item in FileHandler.WaypointsDataSet)
            {
                var mrk = (GMap.NET.WindowsForms.GMapMarker)
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle
                    (item.Position, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_small);
                mrk.ToolTipText = item.Name + "\n" + item.FiveCharName;
                _dicMrkWpt.Add(mrk,item);
            }
        }
        /// <summary>
        /// מגדיר רכיבי ממשק משתמש
        /// </summary>
        private void InitializeControls()
        {
            InitializeWaypointTable();
            InitializeVfrMap();
            SetVfrLandmarks();
            FocusSearchTextBox();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            _txtWaypointSearch.Focus();
            _txtWaypointSearch.Text = "";
            _txtWaypointSearch.TextChanged += _txtWaypointSearch_TextChanged;
            _txtWaypointSearch.KeyPress += _txtWaypointSearch_KeyPress;
        }

        private void _txtWaypointSearch_KeyPress(object sender, EventArgs ev)
        {
            var e = ev as KeyPressEventArgs;
            if (e.KeyChar == '\u0006')
            {
                if (_dgvWaypointsList.Rows.Count > 0)
                {
                    _wptEditedWaypoint = _dgvWaypointsList.Rows[0].DataBoundItem as Waypoint;
                    _btnOk_Click(this, null);
                }
            }
        }

        private void FocusSearchTextBox()
        {
            
        }

        private void SetVfrLandmarks()
        {
            GMap.NET.WindowsForms.GMapOverlay marksLayout = new GMap.NET.WindowsForms.GMapOverlay();
            foreach (var item in _dicMrkWpt)
            {
                marksLayout.Markers.Add(item.Key);
            }
            _gmpVfrMap.Overlays.Add(marksLayout);
        }
        /// <summary>
        /// מאתחל את המפה מבלי להכניס לתוכה תוכן
        /// </summary>
        private void InitializeVfrMap()
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            _gmpVfrMap.MapProvider = GMap.NET.MapProviders.OpenStreet4UMapProvider.Instance; //OpenStreet4U,opencycle
            _gmpVfrMap.MinZoom = 7;
            _gmpVfrMap.MaxZoom = 13;
            _gmpVfrMap.Zoom = 10;
            _gmpVfrMap.DragButton = MouseButtons.Left;
            _gmpVfrMap.Position = new GMap.NET.PointLatLng(32.006833306, 34.885329792);
            _gmpVfrMap.ShowCenter = false;
            _gmpVfrMap.OnMarkerClick += LandmarkSelectedOnMap;
            _gmpVfrMap.DoubleClick += LandmarkDoubleClicked;
        }

        private void LandmarkDoubleClicked(object sender, EventArgs e)
        {
            _btnOk_Click(this, e);
        }

        private void LandmarkSelectedOnMap(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e)
        {
            foreach (var i in _dicMrkWpt)
            {
                if (i.Key == item)
                {
                    _wptEditedWaypoint = i.Value;
                    _lblWaypointSelectedName.Text = _wptEditedWaypoint.Name + " [" + _wptEditedWaypoint.FiveCharName+"]";
                    _lblWaypointSelectedLongitude.Text = "Longitude: " + _wptEditedWaypoint.Longitude.ToString();
                    _lblWaypointSelectedLatitude.Text = "Latitude: " + _wptEditedWaypoint.Latitude.ToString();
                    FocusOnPoint();
                    break;
                }
            }
        }
        /// <summary>
        /// מאתחל את טבלת כלל נקודות הציון
        /// </summary>
        private void InitializeWaypointTable()
        {
            bindingList = new BindingList<Waypoint>(FileHandler.WaypointsDataSet);
            _dgvWaypointsList.DataSource = bindingList;
        }
        private void _btnOk_Click(object sender, EventArgs e)
        {
            PointUpdated(this, new PointChangedEventArgs(_wptEditedWaypoint));
            this.Hide();
        }
        private void _btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void _txtWaypointSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            
            //Task.Start וכו... 
            //TODO
            if (_txtWaypointSearch.Text == "")
            {
                _dgvWaypointsList.DataSource = bindingList;
                return;
            }
            BindingList<Waypoint> cpy = new BindingList<Waypoint>();

            foreach (var item in bindingList)
            {
                if (item.Name == null)
                {
                    continue;
                }
                if (item.Name.Contains(_txtWaypointSearch.Text))
                {
                    cpy.Add(item);
                }
            }
            _dgvWaypointsList.DataSource = cpy;
           
        }

        private void _dgvWaypointsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (e.RowIndex < 0)
                    return;
                var i = _dgvWaypointsList.Rows[e.RowIndex].DataBoundItem as Waypoint;
                _lblWaypointSelectedLatitude.Text = i.Latitude.ToString();
                _lblWaypointSelectedLongitude.Text = i.Longitude.ToString();
                _lblWaypointSelectedName.Text = i.Name + " [" + i.FiveCharName + "]";
                _wptEditedWaypoint = i;
                FocusOnPoint();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void FocusOnPoint()
        {
            _gmpVfrMap.Position = _wptEditedWaypoint.Position;
            _gmpVfrMap.Zoom = 11;
            _gmpVfrMap.ShowCenter = true;
        }

        private void _gmpVfrMap_MouseDown(object sender, MouseEventArgs e)
        {
            _gmpVfrMap.ShowCenter = false;
        }

        private void PointSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void _dgvWaypointsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _dgvWaypointsList_CellClick(this, e);
            _btnOk_Click(this, e);
        }

        private void _dgvWaypointsList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (_dgvWaypointsList.Rows.Count > 0)
                {
                    _wptEditedWaypoint = _dgvWaypointsList.Rows[0].DataBoundItem as Waypoint;
                    _btnOk_Click(this, null);
                }
            }
        }

        private void _gmpVfrMap_DoubleClick(object sender, EventArgs e)
        {
            _btnOk_Click(this, e);
        }

        private void PointSelector_Load(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //_txtWaypointSearch
        }
        private void SetDGVBackground()
        {
            
        }
    }
    public class PointChangedEventArgs : EventArgs
    {
        public Waypoint waypoint;
        public PointChangedEventArgs(Waypoint _wpt)
        {
            waypoint = _wpt;
        }
    }
}
