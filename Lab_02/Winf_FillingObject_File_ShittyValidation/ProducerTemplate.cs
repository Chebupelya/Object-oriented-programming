using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Winf_FillingObject_File_ShittyValidation
{
    [DataContract]
    public class Processor
    {
        [DataMember]
        private string _producer;
        [DataMember]
        private int _series;
        [DataMember]
        private string _model;
        [DataMember]
        private int _amount_cores;
        [DataMember]
        private double _frequency;
        [DataMember]
        private double _max_frequency;
        [DataMember]
        private string _architecture;
        [DataMember]
        private string _cache;

        public Processor(string producer, int series, string model, int amount_cores, double frequency, double max_frequency, string architecture, string cache)
        {
            _producer = producer;
            _series = series;
            _model = model;
            _amount_cores = amount_cores;
            _frequency = frequency;
            _max_frequency = max_frequency;
            _architecture = architecture;
            _cache = cache;
        }

        public override string ToString()
        {
            return $"==== Процессор ====\n" +
                   $"Производитель: {_producer}\n" +
                   $"Серия: {_series}\n" +
                   $"Модель: {_model}\n" +
                   $"Количество ядер: {_amount_cores}.\n" +
                   $"Частота: {_frequency}\n" +
                   $"Максимальная частота: {_max_frequency}\n" +
                   $"Разрядность архитектуры: {_architecture}\n" +
                   $"Размер кэша: {_cache}\n";
        }
    }
}
