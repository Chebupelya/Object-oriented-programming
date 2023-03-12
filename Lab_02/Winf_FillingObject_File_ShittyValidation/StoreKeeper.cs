using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Winf_FillingObject_File_ShittyValidation
{
    [DataContract]
    public class VideoCard
    {
        [DataMember]
        private string _manufacturer;
        [DataMember]
        private int _series;
        [DataMember]
        private string _model;
        [DataMember]
        private double _frequency;
        [DataMember]
        private bool _support_DirectX11;
        [DataMember]
        private int _memory;
        
        public VideoCard(string manufacturer, int series, string model, double frequency, bool support, int memory)
        {
            _manufacturer = manufacturer;
            _series = series;
            _model = model;
            _frequency = frequency;
            _support_DirectX11 = support;
            _memory = memory;
        }

        public override string ToString()
        {
            if (_support_DirectX11 == true)
            {
                return $"==== Процессор ====\n" +
                       $"Производитель: {_manufacturer}\n" +
                       $"Серия: {_series}\n" +
                       $"Модель: {_model}\n" +
                       $"Частота: {_frequency}\n" +
                       $"Поддержка DirectX11: Имеется\n" +
                       $"Память: {_memory}";
            }
            else
            {
                return $"==== Процессор ====\n" +
                       $"Производитель: {_manufacturer}\n" +
                       $"Серия: {_series}\n" +
                       $"Модель: {_model}\n" +
                       $"Частота: {_frequency}\n" +
                       $"Поддержка DirectX11: Не имеется\n" +
                       $"Память: {_memory}";
            }
        }
    }
}
