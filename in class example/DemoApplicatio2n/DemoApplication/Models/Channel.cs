using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Linq.Mapping;
using System.Runtime.Serialization;

namespace DemoApplication.Models
{
    [DataContract]
    [Table (Name="CHANNELS")]
    public class Channel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
        [Column]
        [DataMember]
        public string name { get; set;}
        [Column]
        [DataMember]
        public string desciption {get;set;}
        [Column]
        [DataMember]
        public string logoURL {get;set;}
        [Column]
        [DataMember]
        public string channelID {get;set;}
        [Column]
        [DataMember]
        public string weight {get;set;}
    }
}