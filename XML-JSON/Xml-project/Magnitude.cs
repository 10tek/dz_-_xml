using System;
using System.Collections.Generic;
using System.Text;

namespace Xml_project
{
    public class Magnitude
    {
        public Mag Mag { get; set; }
        public string Type { get; set; }
        public string OriginID { get; set; }
        public string EvaluationMode { get; set; }
        public CreationInfo CreationInfo { get; set; }
        public string Datasource { get; set; }
        public string Dataid { get; set; }
        public string Eventsource { get; set; }
        public string Eventid { get; set; }
        public string PublicID { get; set; }
        public string StationCount { get; set; }
    }
}
