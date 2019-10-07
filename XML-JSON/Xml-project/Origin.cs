using System;
using System.Collections.Generic;
using System.Text;

namespace Xml_project
{
    public class Origin
    {
        public string Time { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public Depth Depth { get; set; }
        public OriginUncertainty OriginUncertainty { get; set; }
        public Quality Quality { get; set; }
        public string EvaluationMode { get; set; }
        public CreationInfo CreationInfo { get; set; }
        public string Datasource { get; set; }
        public string Dataid { get; set; }
        public string Eventsource { get; set; }
        public string Eventid { get; set; }
        public string PublicID { get; set; }
    }
}
