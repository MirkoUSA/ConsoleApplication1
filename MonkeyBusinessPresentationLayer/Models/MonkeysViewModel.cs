using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MonkeyBusinessPresentationLayer.Models
{
    /// <summary>
    /// Created ViewModel to use in the front-end 
    /// </summary>

    [DataContract]
    public class MonkeysViewModel
    {
        [DataMember]
        public int LeftValue { get; set; }
        [DataMember]
        public int RiteValue { get; set; }

        [DataMember]
        public string[] CrossingMonkeys { get; set; }
    }
}