using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

using System.Windows;
using System.ComponentModel;

namespace Brand7.Models
{
    [DataContract]
    class BrandModel
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Tip { get; set; }
        [DataMember]
        public bool IsFinished { get; set; }

        public string Image { get; set; }
        public bool IsSelected { get; set; }
    }
}
