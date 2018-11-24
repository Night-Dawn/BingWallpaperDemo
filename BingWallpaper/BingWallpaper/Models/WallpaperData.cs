using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static BingWallpaper.Models.WallpaperData;

namespace BingWallpaper.Models
{
  
    public class WallpaperData
    {
        [DataContract]
        public class Rootobject
        {
            [DataMember]
            public Image[] images { get; set; }
            [DataMember]
            public Tooltips tooltips { get; set; }
        }
        [DataContract]
        public class Tooltips
        {
            [DataMember]
            public string loading { get; set; }
            [DataMember]
            public string previous { get; set; }
            [DataMember]
            public string next { get; set; }
            [DataMember]
            public string walle { get; set; }
            [DataMember]
            public string walls { get; set; }
        }
        [DataContract]
        public class Image
        {
            [DataMember]
            public string startdate { get; set; }
            [DataMember]
            public string fullstartdate { get; set; }
            [DataMember]
            public string enddate { get; set; }
            [DataMember]
            public string url { get; set; }
            [DataMember]
            public string urlbase { get; set; }
            [DataMember]
            public string copyright { get; set; }
            [DataMember]
            public string copyrightlink { get; set; }
            [DataMember]
            public string title { get; set; }
            [DataMember]
            public string quiz { get; set; }
            [DataMember]
            public bool wp { get; set; }
            [DataMember]
            public string hsh { get; set; }
            [DataMember]
            public int drk { get; set; }
            [DataMember]
            public int top { get; set; }
            [DataMember]
            public int bot { get; set; }
            [DataMember]
            public object[] hs { get; set; }
        }


    }
}
