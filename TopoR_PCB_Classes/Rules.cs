/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Правила».
    /// </summary>
    /// <remarks>! Порядок следования правил в каждой секции определяет приоритет правил. Чем выше приоритет у правила, тем ниже оно описано.</remarks>
    public class Rules
    {
        /// <summary>
        /// Описание правила ширины проводников.
        /// </summary>
        public class WidthOfWires
        {
            /// <summary>
            /// Флаг применения правила.
            /// </summary>
            [XmlAttribute("enabled")]
            public Bool _enabled;
            [XmlIgnore]
            public bool _enabledSpecified { get { return _enabled != Bool.off; } }

            /// <summary>
            /// Параметр правила ширины проводников: минимальная ширина проводника.
            /// </summary>
            [XmlAttribute("widthMin", DataType = "float")]
            public float _widthMin;

            /// <summary>
            /// Параметр правила ширины проводников: номинальная ширина проводника.
            /// </summary>
            [XmlAttribute("widthNom", DataType = "float")]
            public float _widthNom;

            /// <summary>
            /// Ссылка на слои.
            /// </summary>
            [
                 XmlElement("AllLayers", typeof(AllLayers)),
                 XmlElement("AllLayersInner", typeof(AllLayersInner)),
                 XmlElement("AllLayersInnerSignal", typeof(AllLayersInnerSignal)),
                 XmlElement("AllLayersSignal", typeof(AllLayersSignal)),
                 XmlElement("AllLayersOuter", typeof(AllLayersOuter)),
                 XmlElement("LayerGroupRef", typeof(LayerGroupRef)),
                 XmlElement("LayerRef", typeof(LayerRef)) //Внимание! тут может быть массив
            ]
            public object _LayersRef;

            /// <summary>
            /// Объекты воздействия правила.
            /// </summary>
            [XmlArray("ObjectsAffected")]
            [
                XmlArrayItem("NetRef", typeof(NetRef)),
                XmlArrayItem("NetGroupRef", typeof(NetGroupRef)),
                XmlArrayItem("AllNets", typeof(AllNets))
            ]
            public object[] _ObjectsAffected;
        }

        /// <summary>
        /// Описание правила зазоров между цепями.
        /// </summary>
        public class ClearanceNetToNet
        {
            /// <summary>
            /// Флаг применения правила.
            /// </summary>
            [XmlAttribute("enabled")]
            public Bool _enabled;
            [XmlIgnore]
            public bool _enabledSpecified { get { return _enabled != Bool.off; } }

            /// <summary>
            /// Параметр правила зазоров между цепями: минимальный зазор.
            /// </summary>
            [XmlAttribute("clrnMin", DataType = "float")]
            public float _clrnMin;

            /// <summary>
            /// Параметр правила зазоров между цепями: номинальный зазор.
            /// </summary>
            [XmlAttribute("clrnNom", DataType = "float")]
            public float _clrnNom;

            /// <summary>
            /// Ссылка на слои.
            /// </summary>
            [
                 XmlElement("AllLayers", typeof(AllLayers)),
                 XmlElement("AllLayersInner", typeof(AllLayersInner)),
                 XmlElement("AllLayersInnerSignal", typeof(AllLayersInnerSignal)),
                 XmlElement("AllLayersSignal", typeof(AllLayersSignal)),
                 XmlElement("AllLayersOuter", typeof(AllLayersOuter)),
                 XmlElement("LayerGroupRef", typeof(LayerGroupRef)),
                 XmlElement("LayerRef", typeof(LayerRef)) //Внимание! тут может быть массив
            ]
            public object _LayersRef;

            /// <summary>
            /// Объекты воздействия правила.
            /// </summary>
            [XmlArray("ObjectsAffected")]
            [
                XmlArrayItem("NetRef", typeof(NetRef)),
                XmlArrayItem("NetGroupRef", typeof(NetGroupRef)),
                XmlArrayItem("AllNets", typeof(AllNets)),

                XmlArrayItem("SignalRef", typeof(SignalRef)),
                XmlArrayItem("DiffSignalRef", typeof(DiffSignalRef)),
                XmlArrayItem("SignalGroupRef", typeof(SignalGroupRef))
            ]
            public object[] _ObjectsAffected;
        }

        /// <summary>
        /// Описание правила зазоров между компонентами.
        /// </summary>
        public class ClearanceCompToComp
        {
            /// <summary>
            /// Флаг применения правила.
            /// </summary>
            [XmlAttribute("enabled")]
            public Bool _enabled;
            [XmlIgnore]
            public bool _enabledSpecified { get { return _enabled != Bool.off; } }

            /// <summary>
            /// Параметр правила зазоров между цепями: минимальный зазор.
            /// </summary>
            [XmlAttribute("clrn", DataType = "float")]
            public float _clrn;

            /// <summary>
            /// Объекты воздействия правила.
            /// </summary>
            [XmlArray("ObjectsAffected")]
            [
                XmlArrayItem("ComponentRef", typeof(ComponentRef)),
                XmlArrayItem("CompGroupRef", typeof(CompGroupRef)),
                XmlArrayItem("AllComps", typeof(AllComps))
            ]
            public object[] _ObjectsAffected;
        }

        /// <summary>
        /// Описание зазоров до края платы.
        /// </summary>
        public class RulesClearancesToBoard
        {
            /// <summary>
            /// Устанавливает зазор от проводников до края платы.
            /// </summary>
            [XmlAttribute("wires", DataType = "float")]
            public float _clrn;

            /// <summary>
            /// Устанавливает зазор от компонентов до края платы.
            /// </summary>
            [XmlAttribute("comps", DataType = "float")]
            public float _comps;
        }

        /// <summary>
        /// Описание правила назначения цепям стеков переходных отверстий.
        /// </summary>
        public class ViastacksOfNets
        {
            /// <summary>
            /// Флаг применения правила.
            /// </summary>
            [XmlAttribute("enabled")]
            public Bool _enabled;
            [XmlIgnore]
            public bool _enabledSpecified { get { return _enabled != Bool.off; } }

            /// <summary>
            /// Объекты воздействия правила.
            /// </summary>
            [XmlArray("ObjectsAffected")]
            [
                XmlArrayItem("NetRef", typeof(NetRef)),
                XmlArrayItem("NetGroupRef", typeof(NetGroupRef)),
                XmlArrayItem("AllNets", typeof(AllNets)),

                XmlArrayItem("SignalRef", typeof(SignalRef)),
                XmlArrayItem("DiffSignalRef", typeof(DiffSignalRef)),
                XmlArrayItem("SignalGroupRef", typeof(SignalGroupRef))
            ]
            public object[] _ObjectsAffected;

            /// <summary>
            /// Назначенные типы переходных отверстий.
            /// </summary>
            [XmlArray("Viastacks")]
            [
                XmlArrayItem("AllViastacks", typeof(AllViastacks)),
                XmlArrayItem("AllViastacksThrough", typeof(AllViastacksThrough)),
                XmlArrayItem("AllViastacksNotThrough", typeof(AllViastacksNotThrough)),

                XmlArrayItem("ViastackRef", typeof(ViastackRef))
            ]
            public object[] _Viastacks;
        }

        /// <summary>
        /// Описание правила назначения цепям опорных слоёв.
        /// </summary>
        public class PlaneLayerNets
        {
            /// <summary>
            /// Флаг применения правила.
            /// </summary>
            [XmlAttribute("enabled")]
            public Bool _enabled;
            [XmlIgnore]
            public bool _enabledSpecified { get { return _enabled != Bool.off; } }

            /// <summary>
            /// Ссылка на слои.
            /// </summary>
            [
                 XmlElement("AllLayers", typeof(AllLayers)),
                 XmlElement("AllLayersInner", typeof(AllLayersInner)),
                 XmlElement("AllLayersInnerSignal", typeof(AllLayersInnerSignal)),
                 XmlElement("AllLayersSignal", typeof(AllLayersSignal)),
                 XmlElement("AllLayersOuter", typeof(AllLayersOuter)),
                 XmlElement("LayerGroupRef", typeof(LayerGroupRef)),
                 XmlElement("LayerRef", typeof(LayerRef)) //Внимание! тут может быть массив
            ]
            public object _LayersRef;

            /// <summary>
            /// Объекты воздействия правила.
            /// </summary>
            [XmlArray("ObjectsAffected")]
            [XmlArrayItem("NetRef")]
            public NetRef[] _ObjectsAffected;
        }

        /// <summary>
        /// Описание правила назначения цепям сигнальных слоёв.
        /// </summary>
        public class SignalLayerNets
        {
            /// <summary>
            /// Флаг применения правила.
            /// </summary>
            [XmlAttribute("enabled")]
            public Bool _enabled;
            [XmlIgnore]
            public bool _enabledSpecified { get { return _enabled != Bool.off; } }

            /// <summary>
            /// Ссылка на слои.
            /// </summary>
            [
                 XmlElement("AllLayers", typeof(AllLayers)),
                 XmlElement("AllLayersInner", typeof(AllLayersInner)),
                 XmlElement("AllLayersInnerSignal", typeof(AllLayersInnerSignal)),
                 XmlElement("AllLayersSignal", typeof(AllLayersSignal)),
                 XmlElement("AllLayersOuter", typeof(AllLayersOuter)),
                 XmlElement("LayerGroupRef", typeof(LayerGroupRef)),
                 XmlElement("LayerRef", typeof(LayerRef)) //Внимание! тут может быть массив
            ]
            public object _LayersRef;

            /// <summary>
            /// Объекты воздействия правила.
            /// </summary>
            [XmlArray("ObjectsAffected")]
            [
                XmlArrayItem("NetRef", typeof(NetRef)),
                XmlArrayItem("NetGroupRef", typeof(NetGroupRef))
            ]
            public object[] _ObjectsAffected;
        }

        /// <summary>
        /// Свойства цепи.
        /// </summary>
        public class NetProperty
        {
            /// <summary>
            /// Свойство цепи: гибкая фиксация.
            /// </summary>
            [XmlAttribute("flexfix")]
            public Bool _flexfix;
            [XmlIgnore]
            public bool _flexfixSpecified { get { return _flexfix != Bool.off; } }

            /// <summary>
            /// Свойство цепи: флаг трассировки для автоматического трассировщика.
            /// </summary>
            [XmlAttribute("route")]
            public Bool _route;
            [XmlIgnore]
            public bool _routeSpecified { get { return _route != Bool.off; } }

            /// <summary>
            /// Ссылка на цепь.
            /// </summary>
            [XmlElement("NetRef")]
            public NetRef[] _NetRefs;
        }

        /// <summary>
        /// Настройки подключения к углам прямоугольных контактных площадок.
        /// </summary>
        public class PadConnectSettings
        {
            /// <summary>
            /// Настройка подключения к углам прямоугольных контактных площадок: режим подключения.
            /// </summary>
            [XmlAttribute("mode")]
            public mode_PadConnectSettings _mode;

            /// <summary>
            /// Ссылки на стеки контактных площадок.
            /// </summary>
            [XmlElement("PadstackRef")]
            public PadstackRef[] _PadstackRefs;

            /// <summary>
            /// Ссылки на контакты.
            /// </summary>
            [XmlElement("PinRef")]
            public PinRef[] _PinRefs;

            /// <summary>
            /// Ссылки на выводы посадочных мест.
            /// </summary>
            [XmlElement("PadRef")]
            public PadRef[] _PadRefs;
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Правила ширин проводников.
        /// </summary>
        [XmlArray("RulesWidthOfWires")]
        [XmlArrayItem("WidthOfWires")]
        public WidthOfWires[] _RulesWidthOfWires;

        /// <summary>
        /// Правила зазоров между цепями.
        /// </summary>
        [XmlArray("RulesClearancesNetToNet")]
        [XmlArrayItem("ClearanceNetToNet")]
        public ClearanceNetToNet[] _RulesClearancesNetToNet;
 
        /// <summary>
       /// Правила зазоров между компонентами.
        /// </summary>
        [XmlArray("RulesClearancesCompToComp")]
        [XmlArrayItem("ClearanceCompToComp")]
        public ClearanceCompToComp[] _RulesClearancesCompToComp;

        /// <summary>
        /// Правило зазоров до края платы.
        /// </summary>
        [XmlElement("RulesClearancesToBoard")]
        public RulesClearancesToBoard _RulesClearancesToBoard;

        /// <summary>
        /// Правила назначения цепям стеков переходных отверстий.
        /// </summary>
        [XmlArray("RulesViastacksOfNets")]
        [XmlArrayItem("ViastacksOfNets")]
        public ViastacksOfNets[] _RulesViastacksOfNets;

        /// <summary>
        /// Правила назначения цепям опорных слоёв.
        /// </summary>
        [XmlArray("RulesPlaneLayersNets")]
        [XmlArrayItem("PlaneLayerNets")]
        public PlaneLayerNets[] _RulesPlaneLayersNets;

        /// <summary>
        /// Правила назначения цепям сигнальных слоёв.
        /// </summary>
        [XmlArray("RulesSignalLayersNets")]
        [XmlArrayItem("SignalLayerNets")]
        public SignalLayerNets[] _RulesSignalLayersNets;
 
        /// <summary>
        /// Свойства цепей
        /// </summary>
        [XmlArray("NetsProperties")]
        [XmlArrayItem("NetProperty")]
        public NetProperty[] _NetsProperties;

        /// <summary>
        /// Настройки подключения к углам прямоугольных контактных площадок.
        /// </summary>
        [XmlElement("PadConnectSettings")]
        public PadConnectSettings _PadConnectSettings;
    }
}
