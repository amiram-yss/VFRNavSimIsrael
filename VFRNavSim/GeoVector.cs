using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using System.Device.Location;

namespace VFRNavSim
{
    /// <summary>
    /// Can handle short geo vectors, can't handle big circle calculations.
    /// </summary>
    public class GeoVector
    {
        #region Private properties
        private PointLatLng _pntStart, _pntDestination;
        //private double? _distance, _bearing;
        #endregion
        #region Public properties
        /// <summary>
        /// [Readonly] Gets Distance in Nautical Miles.
        /// </summary>
        public double Distance
        {
            
            get
            {
                var lat1 = _pntStart.Lat;
                var lon1 = _pntStart.Lng;
                var lat2 = _pntDestination.Lat;
                var lon2 = _pntDestination.Lng;

                // distance between latitudes and longitudes 
                double dLat = (Math.PI / 180) * (lat2 - lat1);
                double dLon = (Math.PI / 180) * (lon2 - lon1);

                // convert to radians 
                lat1 = (Math.PI / 180) * (lat1);
                lat2 = (Math.PI / 180) * (lat2);

                // apply formulae 
                double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                            Math.Pow(Math.Sin(dLon / 2), 2) *
                            Math.Cos(lat1) * Math.Cos(lat2);
                double rad = 6371;
                double c = 2 * Math.Asin(Math.Sqrt(a));
                return rad * c * 0.54;
            }
            set
            {
                this.SetDestinationPointUsingVectorDistanceAndBearing(this.TrueBearing, value);
            }
        }
        /// <summary>
        /// [Readonly] Gets True Bearing in Degrees.
        /// </summary>
        public double TrueBearing {
            get
            {
                var lat1 = DegreesToRadians(_pntStart.Lat);
                var lat2 = DegreesToRadians(_pntDestination.Lat);
                var long1 = DegreesToRadians(_pntDestination.Lng);
                var long2 = DegreesToRadians(_pntStart.Lng);
                var dLon = long1 - long2;

                var y = Math.Sin(dLon) * Math.Cos(lat2);
                var x = Math.Cos(lat1) * Math.Sin(lat2) - Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(dLon);
                var brng = Math.Atan2(y, x);

                return (RadiansToDegrees(brng) + 360) % 360;
            }
        }
        /// <summary>
        /// [Readonly] Gets True Magnetic in Degrees.
        /// </summary>
        public double MagneticBearing
        {
            get
            {
                return this.TrueBearing-4.25 > 0 ? TrueBearing - 4.25 : 360 + (TrueBearing - 4.25);
            }
        }
        /// <summary>
        /// Starting Point of the Vector.
        /// </summary>
        public PointLatLng StartingPoint
        {
            get {
                return this._pntStart;
            }
            set {
                this._pntStart = new PointLatLng(value.Lat, value.Lng);
            }
        }
        /// <summary>
        /// Destination Point of the Vector.
        /// </summary>
        public PointLatLng DestinationPoint
        {
            get {
                return this._pntDestination;
            }
            set
            {
                this._pntDestination = new PointLatLng(value.Lat, value.Lng);
            }
        }
        /// <summary>
        /// [Readonly] ∆X [Destination's-Starting Longitudes]
        /// </summary>
        public double dx
        {
            get
            {
                return _pntDestination.Lng - _pntStart.Lng;
            }
        }
        /// <summary>
        /// [Readonly] ∆Y [Destination's-Starting Longitudes]
        /// </summary>
        public double dy
        {
            get
            {
                return _pntDestination.Lat - _pntStart.Lat;
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Returns a default GeoVector
        /// </summary>
        public GeoVector()
        {
            _pntDestination = new PointLatLng();
            _pntStart = new PointLatLng();
        }
        /// <summary>
        /// Returns GeoVector as a Vector between two point.
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="destination">Destination point</param>
        public GeoVector(PointLatLng start, PointLatLng destination)
        {
            _pntStart = new PointLatLng(start.Lat, start.Lng);
            _pntDestination = new PointLatLng(destination.Lat, destination.Lng);
        }
        /// <summary>
        /// Returns a GeoVector as a Vector starting from a point and ending at the end of a vector
        /// </summary>
        /// <param name="start">Starting point.</param>
        /// <param name="bearing">Angle of the vector.</param>
        /// <param name="distance">The distance between the tow edges of the vector.</param>
        public GeoVector(PointLatLng start, double bearing, double distance)
        {
            _pntStart = new PointLatLng(start.Lat, start.Lng);
            SetDestinationPointUsingVectorDistanceAndBearing(bearing, distance);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Sets destination at a given distance and angle from the current point.
        /// </summary>
        /// <param name="bearing">Bearing from point</param>
        /// <param name="distance">Distance from point</param>
        private void SetDestinationPointUsingVectorDistanceAndBearing(double bearing, double distance)
        {
            var R = 3443.9; //#Radius of the Nautical Miles
            var brng = DegreesToRadians(bearing); //#Bearing is 90 degrees converted to radians.
            var d = distance; //#Distance in NM

            var lat1 = DegreesToRadians(_pntStart.Lat); //#Current lat point converted to radians
            var lon1 = DegreesToRadians(_pntStart.Lng); //#Current long point converted to radians

            var lat2 = Math.Asin(Math.Sin(lat1) * Math.Cos(d / R) +
                 Math.Cos(lat1) * Math.Sin(d / R) * Math.Cos(brng));

            var lon2 = lon1 + Math.Atan2(Math.Sin(brng) * Math.Sin(d / R) * Math.Cos(lat1),
                         Math.Cos(d / R) - Math.Sin(lat1) * Math.Sin(lat2));

            lat2 = RadiansToDegrees(lat2);
            lon2 = RadiansToDegrees(lon2);
            this._pntDestination = new PointLatLng(lat2, lon2);
        }
        #endregion
        #region DO NOT TOUCH!
        #region Operators
        public static GeoVector operator +(GeoVector v1, GeoVector v2)
        {
            var sCpy = new PointLatLng(v1._pntStart.Lat, v1._pntStart.Lng);
            var eCpy = new PointLatLng(v2._pntDestination.Lat, v2._pntDestination.Lng);
            return new GeoVector(sCpy, eCpy);
        }
        public static GeoVector operator -(GeoVector v)
        {
            var start = new PointLatLng(v._pntDestination.Lat, v._pntDestination.Lng);
            var end = new PointLatLng(v._pntStart.Lat, v._pntStart.Lng);
            return new GeoVector(start, end);
        }
        public static GeoVector operator -(GeoVector v1, GeoVector v2)
        {
            var eCpy = new PointLatLng(v1._pntStart.Lat, v1._pntStart.Lng);
            var sCpy = new PointLatLng(v2._pntStart.Lat, v2._pntStart.Lng);
            return new GeoVector(sCpy, eCpy);
        }
        public static bool operator ==(GeoVector v1, GeoVector v2)
        {
            return (v1.DestinationPoint.Lat == v2.DestinationPoint.Lat) && (v1.DestinationPoint.Lng == v2.DestinationPoint.Lng) &&
                (v1.StartingPoint.Lat == v2.StartingPoint.Lat)&& (v1.StartingPoint.Lng == v2.StartingPoint.Lng);
        }
        public static bool operator !=(GeoVector v1, GeoVector v2)
        {
            return !(v1 == v2);
        }
        #endregion
        #region Mathematical Static Functions
        public static double Tan(double angle)
        {
            return Math.Tan(angle * (Math.PI / 180));
        }
        public static double ShiftTan(double tan)
        {
            var degInRad = Math.Atan(tan);
            var angle = degInRad * (180 / Math.PI);
            return angle;
        }//todo
        public static double DegreesToRadians(double angle)
        {
            return angle * Math.PI / 180.0d;
        }
        public static double RadiansToDegrees(double angle)
        {
            return angle / Math.PI * 180.0d;
        }
        #endregion
        #endregion
    }
}
