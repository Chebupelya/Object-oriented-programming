using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [ProcessorValidation]
        public Processor processor;
        [DataMember]
        public Videocard videocard;
        [DataMember]
        [Required(ErrorMessage = "Отсутствует тип компьютера.")]
        public string computer_type { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Отсутствует память ОЗУ.")]
        public string ram_memory { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Отсутствует память ЖД.")]
        public string hd_memory { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Отсутствует тип ОЗУ.")]
        public string ram_type { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Отсутствует тип ЖД.")]
        public string hd_type { get; set; }
        [DataMember]
        public DateTime purchase_date;
        [DataMember]
        public int cost_comp { get; set; }
    }
}
