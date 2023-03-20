using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [DataContract]
    public class Processor
    {
        [DataMember]
        public string producer;
        [DataMember]
        public int series;
        [DataMember]
        [ProcessorValidation]
        public string model { get; set; }
        [DataMember]
        public int frequency;
        [DataMember]
        public int max_frequency;
        [DataMember]
        public int cores_amount;
        [DataMember]
        public string cpu_architecture;
        public Processor(string _producer, int _series, string _model, int _frequency, int _max_frequency, int _cores_amount, string _cpu_architecture)
        {
            producer = _producer;
            series = _series;
            model = _model;
            frequency = _frequency;
            max_frequency = _max_frequency;
            cores_amount = _cores_amount;
            cpu_architecture = _cpu_architecture;
        }
    }
}
