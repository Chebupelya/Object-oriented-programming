using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [DataContract]
    public class Computer
    {
        [DataMember]
        public Processor processor;
        [DataMember]
        public Videocard videocard;
        [DataMember]
        public string computer_type;
        [DataMember]
        public string ram_memory;
        [DataMember]
        public string hd_memory;
        [DataMember]
        public string ram_type;
        [DataMember]
        public string hd_type;
        [DataMember]
        public DateTime purchase_date;
        [DataMember]
        public int cost_comp;
    }
}
