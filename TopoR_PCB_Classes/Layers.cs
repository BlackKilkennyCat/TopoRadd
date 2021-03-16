/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System;
using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Слои». (Обязательный раздел)
    /// </summary>
    public class Layers
    {
        /// <summary>
        /// Описание слоя.
        /// </summary>
        public class Layer
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Тип слоя. Значение по умолчанию – Signal.
            /// </summary>
            [XmlAttribute("type")]
            public layer_type _type;

            /// <summary>
            /// Параметр слоя: слой содержит очертания компонентов. 
            /// </summary>
            /// <remarks>! Для сигнальных, опорных, диэлектрических и документирующих слоёв параметр compsOutline отсутствует.</remarks>
            [XmlAttribute("compsOutline")]
            public Bool _compsOutline;

            [XmlIgnore]
            public bool _compsOutlineSpecified { get { return _type == layer_type.Assy; } }

            /// <summary>
            /// Параметр слоя: толщина.
            /// </summary>
            /// <remarks>! Для документирующих слоёв и слоёв с типом Assy параметр thickness отсутствует.</remarks>
            [XmlAttribute("thickness", DataType = "float")]
            public float _thickness;

            [XmlIgnore]
            public bool _thicknessSpecified { get { return _type != layer_type.Assy; } }

            public Layer()
            {

            }

            public Layer(string name, layer_type type, Bool compsOutline, float thickness)
            {
                _name = name;
                _type = type;
                _compsOutline = compsOutline;
                _thickness = thickness;
            }
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Описание слоёв в стеке. Порядок описания должен соответствовать порядку слоёв в стеке.
        /// </summary>
        [XmlArray("StackUpLayers")]
        [XmlArrayItem("Layer")]
        public Layer[] _StackUpLayers;

        /// <summary>
        /// Описание слоёв вне стека.
        /// </summary>
        [XmlArray("UnStackLayers")]
        [XmlArrayItem("Layer")]
        public Layer[] _UnStackLayers;


        public int FindLayerStackUp(LayerRef lref)
        {
            if (_StackUpLayers?.Length > 0)
                for (int i = 0; i < _StackUpLayers.Length; i++)
                    if (_StackUpLayers[i]._name == lref._ReferenceName)
                        return i;
            return -1;
        }

        public void AddLayerStackUp(string name, layer_type type, Bool compsOutline, float thickness)
        { 
            AddLayerStackUp(new Layer(name,type,compsOutline,thickness));
        }

        public void AddLayerStackUp(Layer layer)
        {
            if (_StackUpLayers == null)
                _StackUpLayers = new Layer[0];
            Array.Resize(ref _StackUpLayers, _StackUpLayers.Length + 1);
            _StackUpLayers[_StackUpLayers.Length - 1] = layer;
        }
    }
}
