using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GMap;

namespace VFRNavSim
{
    public static class FileHandler
    {
        public static List<Waypoint> WaypointsDataSet;
        /// <summary>
        /// Imports KML file to variable. Works with VFR point dataset only.
        /// </summary>
        /// <returns>Reference to the dataset. List of Waypoints</returns>
        public static IEnumerable<Waypoint> WaypointDatasetSetup()
        {
            var datasetXmlDoc = GetXMLWaypointDoc();
            var datasetXmlSections = SeperateToPlacemarkNodeTextSections(datasetXmlDoc);
            WaypointsDataSet = ConvertXmlNodesToWaypoint(datasetXmlSections);
            return WaypointsDataSet;
        }
        /// <summary>
        /// Makes a list of points according to xml file, and converts them to points.
        /// </summary>
        /// <param name="datasetXmlSections">XML node list</param>
        /// <returns>Convertion of the list into a wayopint list</returns>
        private static List<Waypoint> ConvertXmlNodesToWaypoint(XmlNodeList datasetXmlSections)
        {
            List<Waypoint> lst = new List<Waypoint>();
            foreach (XmlNode wpt in datasetXmlSections)
            {
                var x = new Waypoint(wpt);
                if(x.Name != null)
                    lst.Add(x);
            }
            return lst;
        }
        /// <summary>
        /// Split XML file into Placemaker Nodes.
        /// </summary>
        /// <param name="xDoc">Raw XML documentation</param>
        /// <returns>Relevant Placemaker XML nodes list</returns>
        private static XmlNodeList SeperateToPlacemarkNodeTextSections(XmlDocument xDoc)
        {
            var xNodes = xDoc.GetElementsByTagName("Placemark");
            return xNodes;
        }
        /// <summary>
        /// Load XML Doc
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static XmlDocument GetXMLWaypointDoc()
        {
            WaypointsDataSet = new List<Waypoint>();
            XmlDocument xDoc = new XmlDocument();
            try {
                xDoc.Load("VFRPointDataset.kml");
                return xDoc;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
