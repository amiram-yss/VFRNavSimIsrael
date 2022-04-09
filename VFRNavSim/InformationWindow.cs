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
    public partial class InformationWindow : Form
    {
        const int SMALL_WINDOW_HEIGHT = 140, BIG_WINDOW_HEIGHT = 500, MINIMIZED_UPPER_SPLIT_SIZE = 100;
        Waypoint _wptStart, _wptDestination;
        int _windDir, _windSpeed, _cruizeHeight, _cruizeSpeed, _camAngel;
        TimeSpan _timCurrent, _timIdent;
        GeoVector _vctPlannedPath, _vctVfrRoute, _vctWindPath, _vctRealPath, _vctIdent, _vctEyeIdentPoint;

        private void _gmpResultMap_Load(object sender, EventArgs e)
        {

        }

        private void _btnShowInfo_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            if (splitContainer1.Panel2Collapsed)
                this.Height = SMALL_WINDOW_HEIGHT;
            else
                this.Height = BIG_WINDOW_HEIGHT;
            splitContainer1.SplitterDistance = MINIMIZED_UPPER_SPLIT_SIZE;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        GMap.NET.WindowsForms.GMapOverlay marksLayout, linesLayout;

        private void _txtGagueHeading_Click(object sender, EventArgs e)
        {
            
        }

        private void InformationWindow_Load(object sender, EventArgs e)
        {

        }


        private void InformationWindow_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GaugeHelpWindow helpeWindow = new GaugeHelpWindow();
            helpeWindow.Show();
        }

        /// <summary>
        /// Sets Information Window which will run Parallely with GOOGLE EARTH
        /// </summary>
        /// <param name="_srart">Starting point</param>
        /// <param name="_destination">Destination point</param>
        /// <param name="_windDir">Wind direction</param>
        /// <param name="_windSpd">Wind Speed</param>
        /// <param name="_currentTime">Current timer. started at the begging of the leg.</param>
        /// <param name="_identTime">Checkpoint time</param>
        /// <param name="_cruizeHeight">Cruize height</param>
        /// <param name="_cruizeSpeed">Cruize speed</param>
        public InformationWindow(Waypoint _start, Waypoint _destination, int _windDir, int _windSpd, TimeSpan _currentTime, TimeSpan _identTime, int _cruizeHeight, int _cruizeSpeed, bool _randomCrntTime, bool _hasIdentPoint, bool _randomWind)
        {
            InitializeComponent();
            InitializeVariables(_start, _destination, _windDir, _windSpd, _currentTime, _identTime, _cruizeHeight, _cruizeSpeed, _randomCrntTime, _hasIdentPoint, _randomWind);
            InitializeMap();
            InitializeVectors();
            SetVectorsOnTheMap();
            SetMarkersOnTheMap();
            InitializeControls();
            ChangeEyeAndCompass();
            PutCamOnGoogleEarth(_hasIdentPoint);
        }

        private void ChangeEyeAndCompass()
        {
            _camAngel = EyePointAngle((int)Math.Round(this._vctVfrRoute.TrueBearing), (_windDir <= 180 ? _windDir + 180 : _windDir - 180));
            this._txtPathBearing.Text = "כיוון נתיב: ["+ Math.Round(this._vctVfrRoute.MagneticBearing) + "]";
            this._txtGagueHeading.Text = "כיוון: ["+_camAngel+"]";
        }

        private void PutCamOnGoogleEarth(bool _hasIdentPoint)
        {
            if (!_hasIdentPoint)
                GoogleEarthBuffer.RunOnGoogleEarthWithoutIdentPoint(_vctRealPath.DestinationPoint, _cruizeHeight, _camAngel+4.25>360?_camAngel+4.25:_camAngel-355.75);
            else
                GoogleEarthBuffer.RunOnGoogleEarthWithIdentPoint(_vctRealPath.DestinationPoint, _vctIdent.DestinationPoint, _cruizeHeight, _camAngel + 4.25 > 360 ? _camAngel + 4.25 : _camAngel - 355.75);
        }

        /// <summary>
        /// Sets markers on the map.
        /// </summary>
        private void SetMarkersOnTheMap()
        {
            
            marksLayout = new GMap.NET.WindowsForms.GMapOverlay();

            var startingMarker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(_vctRealPath.StartingPoint, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            startingMarker.ToolTipText = "נקודת התחלת לג";
            var destinationMarker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(_wptDestination.Position, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_dot);
            destinationMarker.ToolTipText = "נקודת יעד";
            var currentEyePoint = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(_vctRealPath.DestinationPoint, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.arrow);
            currentEyePoint.ToolTipText = "נקודה נוכחית";
            if (_timIdent.Minutes > 0 ||_timIdent.Seconds > 0)
            {
                var identPoint = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(_vctIdent.DestinationPoint, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);
                identPoint.ToolTipText = "נקודת זיהוי";
                var identPointEye = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(_vctEyeIdentPoint.DestinationPoint, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.purple_dot);
                identPoint.ToolTipText = "מיקומך ביחס לנקודת הזיהוי";
                marksLayout.Markers.Add(identPoint);
                marksLayout.Markers.Add(identPointEye);
            }
            marksLayout.Markers.Add(startingMarker);
            marksLayout.Markers.Add(destinationMarker);
            marksLayout.Markers.Add(currentEyePoint);
            _gmpResultMap.Overlays.Add(marksLayout);

            _gmpResultMap.Position = currentEyePoint.Position;
        }
        private void SetVectorsOnTheMap()
        {
            linesLayout = new GMap.NET.WindowsForms.GMapOverlay();
            GMap.NET.WindowsForms.GMapRoute _plannedRoutePaint = new GMap.NET.WindowsForms.GMapRoute(new List<GMap.NET.PointLatLng> { _vctVfrRoute.StartingPoint, _vctVfrRoute.DestinationPoint }, "Planned Path");
            _plannedRoutePaint.Stroke = (Pen)_plannedRoutePaint.Stroke.Clone();
            _plannedRoutePaint.Stroke.Color = Color.Red;
            _plannedRoutePaint.Stroke.Width = 4;
            linesLayout.Routes.Add(_plannedRoutePaint);

            GMap.NET.WindowsForms.GMapRoute _windVectorPaint = new GMap.NET.WindowsForms.GMapRoute(new List<GMap.NET.PointLatLng> { _vctWindPath.StartingPoint, _vctWindPath.DestinationPoint }, "Wind Vector");
            _windVectorPaint.Stroke = (Pen)_windVectorPaint.Stroke.Clone();
            _windVectorPaint.Stroke.Color = Color.Blue;
            _windVectorPaint.Stroke.Width = 4;
            linesLayout.Routes.Add(_windVectorPaint);

            GMap.NET.WindowsForms.GMapRoute _realRoutePaint = new GMap.NET.WindowsForms.GMapRoute(new List<GMap.NET.PointLatLng> { _vctRealPath.StartingPoint, _vctRealPath.DestinationPoint }, "Real Path");
            _realRoutePaint.Stroke = (Pen)_realRoutePaint.Stroke.Clone();
            _windVectorPaint.Stroke.Color = Color.Green;
            _windVectorPaint.Stroke.Width = 5;
            linesLayout.Routes.Add(_realRoutePaint);
            _gmpResultMap.Overlays.Add(linesLayout);
        }
        /// <summary>
        /// Initializes Vectors
        /// </summary>
        private void InitializeVectors()
        {
            _vctVfrRoute = new GeoVector(new GMap.NET.PointLatLng(_wptStart.Latitude, _wptStart.Longitude), new GMap.NET.PointLatLng(_wptDestination.Latitude, _wptDestination.Longitude));
            _vctPlannedPath = new GeoVector(new GMap.NET.PointLatLng(_wptStart.Latitude, _wptStart.Longitude), new GMap.NET.PointLatLng(_wptDestination.Latitude, _wptDestination.Longitude));
            double d = (double)_cruizeSpeed * (double)_timCurrent.TotalSeconds / 3600;
            _vctPlannedPath.Distance = d;
            _vctWindPath = new GeoVector(_vctPlannedPath.DestinationPoint, _windDir, _windSpeed * _timCurrent.TotalHours);
            _vctRealPath = _vctPlannedPath + _vctWindPath;
            _vctIdent = new GeoVector(_vctVfrRoute.StartingPoint, _vctVfrRoute.DestinationPoint);
            _vctIdent.Distance = (double)_cruizeSpeed * (double)_timIdent.TotalSeconds / 3600; ;
            _vctEyeIdentPoint = new GeoVector(_vctRealPath.StartingPoint, _vctRealPath.DestinationPoint);
            _vctEyeIdentPoint.Distance = (double)_cruizeSpeed * (double)_timIdent.TotalSeconds / 3600; ;
            _vctEyeIdentPoint = _vctEyeIdentPoint+ new GeoVector(_vctIdent.DestinationPoint, _windDir, _windSpeed * _timIdent.TotalHours);
        }
        #region Do not touch
        private void InitializeControls()
        {
            InitializeCockpit();
            InitializeInformationControls();
        }

        private void InitializeInformationControls()
        {
            splitContainer1.Panel2Collapsed = true;
            this.Height = SMALL_WINDOW_HEIGHT;
            _lblWind.Text = "רוח: "+(_windDir<=180?_windDir+180:_windDir-180) + "/" + _windSpeed;
        }

        private void InitializeCockpit()
        {
            _txtGagueAltitude.Text = "גובה: [" + this._cruizeHeight.ToString() + "]";
            _txtGagueHeading.Text = "כיוון: [" + Math.Round(this._vctVfrRoute.MagneticBearing) + "]";
            _txtGagueSpeed.Text = "מהירות: [" + this._cruizeSpeed.ToString() + "]";
            _txtGagueTimer.Text = "טיימר: [" + this._timCurrent.ToString() + "]";
        }
        /// <summary>
        /// Initilizes Variables.
        /// </summary>
        /// <param name="_start"> Starting point</param>
        /// <param name="_destination">VFR leg destination point</param>
        /// <param name="_windDir">Wind direction</param>
        /// <param name="_windSpd">Wind Speed</param>
        /// <param name="_currentTime">Time on the timer</param>
        /// <param name="_identTime">Time of identification time</param>
        /// <param name="_cruizeHeight">Cruize height</param>
        /// <param name="_cruizeSpeed">Cruize speed</param>
        private void InitializeVariables(Waypoint _start, Waypoint _destination, int _windDir, int _windSpd, TimeSpan _currentTime, TimeSpan _identTime, int _cruizeHeight, int _cruizeSpeed, bool _randomCrntTime, bool _hasIdentPoint, bool _randomWind )
        {
            this._wptStart = new Waypoint(_start);
            this._wptDestination = new Waypoint(_destination);
            if (_randomWind)
            {
                int sR, eR;
                sR = Properties.Settings.Default._propWindStartRange / 10;
                sR+=sR > 18 ? -18 : 18;
                eR = Properties.Settings.Default._propWindEndRange/10;
                eR += eR > 18 ? -18 : 18;
                if (sR < eR)
                {
                    this._windDir = new Random().Next(sR, eR + 1);
                    //MessageBox.Show(this._windDir.ToString());
                }
                else
                {
                    this._windDir = new Random().Next(sR, sR + Math.Abs(sR - eR));
                    this._windDir -= this._windDir > 36 ? 36 : 0;
                    this._windDir += this._windDir > 18 ? -18 : 18;
                }
                this._windDir *= 10;
                //this._windDir += _windDir > 180 ? -180 : +180;
                this._windSpeed = new Random().Next(Properties.Settings.Default._propWindMaxSpeed);
            }
            else
            {
                this._windDir = _windDir;
                if (_windDir > 180)
                    this._windDir = _windDir - 180;
                else
                    this._windDir = _windDir + 180;
                this._windSpeed = _windSpd; //TODO: Define max settings in main window.
            }
            if(!_randomCrntTime)
                this._timCurrent = new TimeSpan(0, _currentTime.Minutes, _currentTime.Seconds);
            else
            {
                var rnd = new Random();
                int sec = rnd.Next(60);
                int min = rnd.Next(16);
                this._timCurrent = new TimeSpan(0, min, sec);
            }
            if (_hasIdentPoint)
                this._timIdent = new TimeSpan(0, _identTime.Minutes, _identTime.Seconds);
            else
                this._timIdent = new TimeSpan(0,0,-1);
            this._cruizeHeight = _cruizeHeight;
            this._cruizeSpeed = _cruizeSpeed;
        }
        /// <summary>
        /// Initilizes map.
        /// </summary>
        public void InitializeMap()
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            _gmpResultMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            _gmpResultMap.MinZoom = 9;
            _gmpResultMap.MaxZoom = 14;
            _gmpResultMap.Zoom = 10;
            _gmpResultMap.DragButton = MouseButtons.Left;
            _gmpResultMap.ShowCenter = false;
        }
        #endregion
        private int EyePointAngle(int bearing, int windDir)
        {
            int rightStart, rightEnd;
            rightStart = bearing;
            int viewAngle=(new Random().Next(Properties.Settings.Default._propViewAngleDeltaToTheWind+ Properties.Settings.Default._propViewAngleDeltaWithTheWind))-Properties.Settings.Default._propViewAngleDeltaWithTheWind;
            rightEnd = rightStart > 180 ? rightStart - 180 : rightStart + 180;
            if(IsToTheRight(windDir,rightStart,rightEnd))
            {
                viewAngle += bearing;
            }
            else
            {
                viewAngle = bearing - viewAngle;
            }
            if (viewAngle > 360)
                viewAngle -= 360;
            if (viewAngle <= 0)
                viewAngle += 360;
            return viewAngle;
        }
        private bool IsToTheRight(int windDir, int rightStart, int rightEnd)
        {
            if (rightStart < rightEnd)
                if (windDir > rightStart && windDir < rightEnd)
                    return true;
            if (rightStart > rightEnd)
                if ((windDir > rightEnd || windDir < rightStart))
                    return true;
            return false;
        }
    }
}
