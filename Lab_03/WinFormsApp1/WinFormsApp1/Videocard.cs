using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [DataContract]
    public class Videocard
    {
        [DataMember]
        public string producer;
        [DataMember]
        public int series;
        [DataMember]
        public string model;
        [DataMember]
        public string frequency;
        [DataMember]
        public string support_directx11;
        [DataMember]
        public int vc_memory;
        public Videocard(string _producer, int _series, string _model, string _frequency, string _support_directx11, int _vc_memory)
        {
            producer = _producer;
            series = _series;
            model = _model;
            frequency = _frequency;
            support_directx11 = _support_directx11;
            vc_memory = _vc_memory;
        }
    }
}
