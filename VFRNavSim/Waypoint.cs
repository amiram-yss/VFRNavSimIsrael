using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using GMap.NET.WindowsForms;

namespace VFRNavSim
{
    public enum CallRequestType
    {
        REQUEST, MUST, ARP, CUSTOM, ROUTEBREAKER ,NOINFO
    }
    public class Waypoint
    {
        public string Name { get; set; }
        public string FiveCharName { get; set; }
        public double Latitude
        {
            get { return this.GetLatitude(); }
            private set { }
        }
        public double Longitude
        {
            get { return this.GetLongitude(); }
            private set { }
        }
        public CallRequestType RequestType;
        [Browsable(false)]
        public GMap.NET.PointLatLng Position { get; set; }
        public GMap.NET.PointLatLng SetPosition(double lng, double lat)
        {
            Position = new GMap.NET.PointLatLng { Lat = lat, Lng = lng };
            return Position;
        }
        public double GetLatitude()
        {
            return this.Position.Lat;
        }
        public double GetLongitude()
        {
            return this.Position.Lng;
        }
        public void SetLatitude(double latitude)
        {
            var lng = this.Position.Lng;
            Position = new GMap.NET.PointLatLng(latitude, lng);
        }
        public void SetLongitude(double longitude)
        {
            var lat = this.Position.Lat;
            Position = new GMap.NET.PointLatLng(lat, longitude);
        }
        public Waypoint()
        {
            Name = "-";
            FiveCharName = "-";
            RequestType = CallRequestType.NOINFO;
            Position = new GMap.NET.PointLatLng(0, 0);
        }
        public Waypoint(string name, GMap.NET.PointLatLng position, string fiveCharName = "", CallRequestType requestType = CallRequestType.NOINFO)
        {
            Name = name;
            Position = position;
            FiveCharName = fiveCharName;
            RequestType = requestType;
        }
        public Waypoint(string name, double lat, double lng, string fiveCharName = "", CallRequestType requestType = CallRequestType.NOINFO)
        {
            Name = name;
            Position = new GMap.NET.PointLatLng(lat, lng);
            FiveCharName = fiveCharName;
            RequestType = requestType;
        }
     
        public Waypoint(XmlNode xNode)
        {
            try
            {
                Name = "-";
                if(xNode["description"] != null)
                    Name = xNode["description"].InnerText;
                this.FiveCharName = xNode["name"].InnerText;
                string coords = xNode["Point"]["coordinates"].InnerText;
                var splitResult = coords.Split(new char[] { ',' });
                var lat = double.Parse(splitResult[1]);
                var lng = double.Parse(splitResult[0]);
                this.Position = new GMap.NET.PointLatLng(lat, lng);
            }
            catch { }
        }
        public Waypoint(Waypoint waypoint)
        {
            this.FiveCharName = waypoint.FiveCharName;
            this.Latitude = waypoint.Latitude;
            this.Longitude = waypoint.Longitude;
            this.Name = waypoint.Name;
            this.Position = new GMap.NET.PointLatLng(waypoint.Latitude, waypoint.Longitude);
        }
    }
}
