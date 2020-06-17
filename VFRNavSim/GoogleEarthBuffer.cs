using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharpKml.Base;
using System.Xml;
using System.Xml.Linq;
using GMap.NET;
using SharpKml;
using System.Diagnostics;

namespace VFRNavSim
{
    class GoogleEarthBuffer
    {
        public static bool RunOnGoogleEarthWithIdentPoint(PointLatLng _pntCurrentEyePoint, PointLatLng _pntIdentPoint, int alt, double bearing)
        {
            if (!CreateKmlWithIdent(_pntCurrentEyePoint, (int)Math.Round(bearing), alt, _pntIdentPoint))
                return false;
            if (!LoadKmlToGoogleEarth())
                return false;
            return true;
        }
        public static bool RunOnGoogleEarthWithoutIdentPoint(PointLatLng _pntCurrentEyePoint,  int alt, double bearing)
        {
            if (!CreateKmlWithoutIdent(_pntCurrentEyePoint, (int)Math.Round(bearing), alt))
                return false;
            if (!LoadKmlToGoogleEarth())
                return false;
            return true;
        }
        private static bool LoadKmlToGoogleEarth()
        {
            try
            {
                Process.Start(/*@"C:\Program Files\Google\Google Earth Pro\client\googleearth.exe", */"buffer.kml");
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static bool CreateKmlWithoutIdent(PointLatLng _pntCurrentEyePoint, int hdg, int alt)
        {
            int altFt = (int)((double)alt / 3.281);
            string kmlContent = String.Copy(VFRNavSim.Properties.Resources._currentEyePointCam);
            kmlContent.Replace("%dir%", hdg.ToString());
            kmlContent = kmlContent.Replace("%lng%", _pntCurrentEyePoint.Lng.ToString());
            kmlContent = kmlContent.Replace("%lat%", _pntCurrentEyePoint.Lat.ToString());
            kmlContent = kmlContent.Replace("%alt%", altFt.ToString());
            kmlContent = kmlContent.Replace("%hdg%", hdg.ToString());
            try
            {
                using (FileStream fs = File.Create("buffer.kml"))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(kmlContent);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        private static bool CreateKmlWithIdent(PointLatLng _pntCurrentEyePoint, int hdg, int alt, PointLatLng _pntIdentPoint)
        {
            int altFt = (int)((double)alt / 3.281);
            string kmlContent = String.Copy(VFRNavSim.Properties.Resources._currentEyePointAndIdentPointCam);
            kmlContent.Replace("%dir%", hdg.ToString());
            //CurrentEyePoint set on .KML
            kmlContent = kmlContent.Replace("%cLng%", _pntCurrentEyePoint.Lng.ToString());
            kmlContent = kmlContent.Replace("%cLat%", _pntCurrentEyePoint.Lat.ToString());
            kmlContent = kmlContent.Replace("%alt%", altFt.ToString());
            kmlContent = kmlContent.Replace("%hdg%", hdg.ToString());
            //Ident point set on .KML
            kmlContent = kmlContent.Replace("%iLng%", _pntIdentPoint.Lng.ToString());
            kmlContent = kmlContent.Replace("%iLat%", _pntIdentPoint.Lat.ToString());
            try
            {
                using (FileStream fs = File.Create("buffer.kml"))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(kmlContent);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
