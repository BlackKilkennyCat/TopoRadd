/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Правила для высокоскоростных устройств».
    /// </summary>
    public class HiSpeedRules
    {
        /// <summary>
        /// Волновое сопротивление и правила разводки сигналов по слоям.
        /// </summary>
        public class Impedance
        {
            public class LayerRule_Impendance
            {
                /// <summary>
                /// Ширина проводника.
                /// </summary>
                [XmlAttribute("width", DataType = "float")]
                public float _width;

                /// <summary>
                /// Ссылка на слой.
                /// </summary>
                [XmlElement("LayerRef")]
                public LayerRef _LayerRef;
            }

            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Параметр правила разводки дифференциальной пары: значение волнового сопротивления в Омах.
            /// </summary>
            [XmlAttribute("Z0", DataType = "float")]
            public float _z0;

            /// <summary>
            /// Правило разводки сигнала для слоя.
            /// </summary>
            [XmlElement("LayerRule")]
            public LayerRule_Impendance[] _LayerImpedanceRules;
        }

        /// <summary>
        /// Волновое сопротивление и правила разводки сигналов по слоям для дифференциальных сигналов.
        /// </summary>
        public class ImpedanceDiff
        {
            public class LayerRule_ImpendanceDiff
            {
                /// <summary>
                /// Ширина проводника.
                /// </summary>
                [XmlAttribute("width", DataType = "float")]
                public float _width;

                /// <summary>
                /// Параметр правила разводки дифференциальных пар: зазор между проводниками пары.
                /// </summary>
                [XmlAttribute("gap", DataType = "float")]
                public float _gap;

                /// <summary>
                /// Ссылка на слой.
                /// </summary>
                [XmlElement("LayerRef")]
                public LayerRef _LayerRef;
            }

            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Параметр правила разводки дифференциальной пары: значение волнового сопротивления в Омах.
            /// </summary>
            [XmlAttribute("Z0", DataType = "float")]
            public float _z0;

            /// <summary>
            /// Правило разводки дифференциальной пары для слоя.
            /// </summary>
            [XmlElement("LayerRule")]
            public LayerRule_ImpendanceDiff[] _LayerImpedanceDiffRules;
        }

        /// <summary>
        /// Описание сигнального кластера цепей.
        /// </summary>
        public class SignalCluster
        {
            /// <summary>
            /// Описание заданной связи.
            /// </summary>
            public class PinPair
            {
                /// <summary>
                /// Ссылка на контакт источника сигнала.
                /// </summary>
                [XmlElement("PinRef")]
                public PinRef[] _PinRefs;
            }

            /// <summary>
            /// Описание сигнала.
            /// </summary>
            public class Signal
            {
                /// <summary>
                /// Имя объекта или ссылка на именованный объект.
                /// </summary>
                [XmlAttribute("name")]
                public string _name;

                /// <summary>
                /// Ссылка на контакт источника сигнала.
                /// </summary>
                [XmlElement("ReceiverPinRef")]
                public ReceiverPinRef _ReceiverPinRef;

                /// <summary>
                /// Пассивные компоненты на пути следования сигнала.
                /// </summary>
                [XmlArray("Components")]
                [XmlArrayItem("CompInstanceRef")]
                public CompInstanceRef[] _Components;
            }

            /// <summary>
            /// Ссылка на волновое сопротивление.
            /// </summary>
            [XmlElement("ImpedanceRef")]
            public ImpedanceRef _ImpedanceRef;

            /// <summary>
            /// Ссылка на контакт источника сигнала.
            /// </summary>
            [XmlElement("SourcePinRef")]
            public SourcePinRef _SourcePinRef;

            /// <summary>
            /// Цепи сигнального кластера.
            /// </summary>
            [XmlArray("Nets")]
            [XmlArrayItem("NetRef")]
            public NetRef[] _Nets;

            /// <summary>
            /// Описание заданных связей сигнального кластера.
            /// </summary>
            [XmlArray("PinPairs")]
            [XmlArrayItem("PinPair")]
            public PinPair[] _PinPairs;

            /// <summary>
            /// Ссылки на сигналы.
            /// </summary>
            [XmlElement("Signal")]
            public Signal[] _Signals;
        }

        /// <summary>
        /// Описание дифференциального сигнала (дифференциальной пары).
        /// </summary>
        public class DiffSignal
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Параметр дифференциальной пары: допустимый разброс длины между проводниками пары.
            /// </summary>
            [XmlAttribute("mismatch", DataType = "float")]
            public float _mismatch;

            /// <summary>
            /// Ссылка на волновое сопротивление.
            /// </summary>
            [XmlElement("ImpedanceRef")]
            public ImpedanceRef _ImpedanceRef;

            /// <summary>
            /// Ссылки на сигналы.
            /// </summary>
            [XmlElement("SignalRef")]
            public SignalRef[] _SignalRefs;
        }

        /// <summary>
        /// Описание группы сигналов.
        /// </summary>
        public class SignalGroup
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Ссылки на сигнал, диф.сигнал, или группу сигналов
            /// </summary>
            /// <value>SignalRef, DiffSignalRef, SignalGroupRef</value>
            [
                XmlElement("SignalRef", typeof(SignalRef)),
                XmlElement("DiffSignalRef", typeof(DiffSignalRef)),
                XmlElement("SignalGroupRef", typeof(SignalGroupRef))
            ]
            public object[] _References;
        }

        /// <summary>
        /// Описание правил выравнивания задержек.
        /// </summary>
        public class RulesDelay
        {
            /// <summary>
            /// Описание правила выравнивания задержек для группы цепей или группы дифференциальных пар.
            /// </summary>
            public class DelayEqual
            {
                /// <summary>
                /// Флаг применения правила.
                /// </summary>
                [XmlAttribute("enabled")]
                public Bool _enabled;
                [XmlIgnore]
                public bool _enabledSpecified { get { return _enabled != Bool.off; } }

                /// <summary>
                /// Параметр правил выравнивания задержек: тип значений констант и допусков.
                /// </summary>
                [XmlAttribute("valueType")]
                public valueType _valueType;

                /// <summary>
                /// Параметр правила выравнивания задержек внутри группы цепей: допуск.
                /// </summary>
                /// <remarks>! Единицы измерения значения зависят от параметра valueType и единиц заданных для всего файла(см.Units).</remarks>
                [XmlAttribute("tolerance", DataType = "float")]
                public float _tolerance;

                /// <summary>
                /// Объекты воздействия правила.
                /// </summary>
                [XmlArray("ObjectsAffected")]
                [XmlArrayItem("SignalGroupRef")]
                public SignalGroupRef[] _ObjectsAffected;
            }

            /// <summary>
            /// Описание правила задания абсолютного значения задержки.
            /// </summary>
            public class DelayConstant
            {
                /// <summary>
                /// Флаг применения правила.
                /// </summary>
                [XmlAttribute("enabled")]
                public Bool _enabled;
                [XmlIgnore]
                public bool _enabledSpecified { get { return _enabled != Bool.off; } }

                /// <summary>
                /// Параметр правил выравнивания задержек: тип значений констант и допусков.
                /// </summary>
                [XmlAttribute("valueType")]
                public valueType _valueType;

                /// <summary>
                /// Значение константы в правилах выравнивания задержек.
                /// </summary>
                /// <remarks>! Единицы измерения значения зависят от параметра valueType и единиц заданных для всего файла(см.Units).</remarks>
                [XmlAttribute("constant", DataType = "float")]
                public float _constant;

                /// <summary>
                /// Параметр правила выравнивания задержек: нижний допуск.
                /// </summary>
                /// <remarks>! Единицы измерения значения зависят от параметра valueType и единиц заданных для всего файла(см.Units).</remarks>
                [XmlAttribute("toleranceUnder", DataType = "float")]
                public float _toleranceUnder;

                /// <summary>
                /// Параметр правила выравнивания задержек: верхний допуск.
                /// </summary>
                /// <remarks>! Единицы измерения значения зависят от параметра valueType и единиц заданных для всего файла(см.Units).</remarks>
                [XmlAttribute("toleranceOver", DataType = "float")]
                public float _toleranceOver;

                /// <summary>
                /// Объекты воздействия правила.
                /// </summary>
                [XmlArray("ObjectsAffected")]
                [
                    XmlArrayItem("SignalRef", typeof(SignalRef)),
                    XmlArrayItem("DiffSignalRef", typeof(DiffSignalRef)),
                    XmlArrayItem("SignalGroupRef", typeof(SignalGroupRef))
                ]
                public object[] _ObjectsAffected;
            }

            /// <summary>
            /// Описание правила взаимного выравнивания задержек.
            /// </summary>
            /// <remarks>! Правило несимметрично относительно ObjectLeft и ObjectRight</remarks>
            public class DelayRelation
            {
                /// <summary>
                /// Флаг применения правила.
                /// </summary>
                [XmlAttribute("enabled")]
                public Bool _enabled;
                [XmlIgnore]
                public bool _enabledSpecified { get { return _enabled != Bool.off; } }

                /// <summary>
                /// Параметр правил выравнивания задержек: тип значений констант и допусков.
                /// </summary>
                [XmlAttribute("valueType")]
                public valueType _valueType;

                /// <summary>
                /// Значение константы в правилах выравнивания задержек.
                /// </summary>
                /// <remarks>! Единицы измерения значения зависят от параметра valueType и единиц заданных для всего файла(см.Units).</remarks>
                [XmlAttribute("constant", DataType = "float")]
                public float _constant;

                /// <summary>
                /// Параметр правила выравнивания задержек: нижний допуск.
                /// </summary>
                /// <remarks>! Единицы измерения значения зависят от параметра valueType и единиц заданных для всего файла(см.Units).</remarks>
                [XmlAttribute("toleranceUnder", DataType = "float")]
                public float _toleranceUnder;

                /// <summary>
                /// Параметр правила выравнивания задержек: верхний допуск.
                /// </summary>
                /// <remarks>! Единицы измерения значения зависят от параметра valueType и единиц заданных для всего файла(см.Units).</remarks>
                [XmlAttribute("toleranceOver", DataType = "float")]
                public float _toleranceOver;

                /// <summary>
                /// Первый объект воздействия правила взаимного выравнивания задержек.
                /// </summary>
                [XmlElement("ObjectLeft")]
                public ObjectSignal _ObjectLeft;

                /// <summary>
                /// Второй объект воздействия правила взаимного выравнивания задержек.
                /// </summary>
                [XmlElement("ObjectRight")]
                public ObjectSignal _ObjectRight;
            }

            /// <summary>
            /// Правила выравнивания задержек для группы цепей или группы дифференциальных пар.
            /// </summary>
            [XmlElement("DelayEqual")]
            public DelayEqual[] _DelayEquals;

            /// <summary>
            /// Правила задания абсолютного значения задержки.
            /// </summary>
            [XmlElement("DelayConstant")]
            public DelayConstant[] _DelayConstants;

            /// <summary>
            /// Правила взаимного выравнивания задержек. 
            /// </summary>
            /// <remarks>! Правила несимметричны относительно ObjectLeft и ObjectRight</remarks>
            [XmlElement("DelayRelation")]
            public DelayRelation[] _DelayRelations;
        }

        /// <summary>
        /// Настройки поиска сигналов.
        /// </summary>
        public class SignalSearchSettings
        {
            /// <summary>
            /// Правило именования цепей дифференциальных сигналов.
            /// </summary>
            public class RuleDiffSignalNetsNames
            {
                /// <summary>
                /// Флаг применения правила.
                /// </summary>
                [XmlAttribute("enabled")]
                public Bool _enabled;
                [XmlIgnore]
                public bool _enabledSpecified { get { return _enabled != Bool.off; } }

                /// <summary>
                /// Параметр правила именования цепей дифференциальных сигналов: подстрока, определяющая цепь позитивного сигнала.
                /// </summary>
                [XmlAttribute("posStr")]
                public string _posStr;

                /// <summary>
                /// Параметр правила именования цепей дифференциальных сигналов: подстрока, определяющая цепь негативного сигнала.
                /// </summary>
                [XmlAttribute("negStr")]
                public string _negStr;
            }

            /// <summary>
            /// Список цепей, исключённых из поиска сигналов.
            /// </summary>
            public class ExcludedNets
            {
                /// <summary>
                /// Минимальное количество контактов в силовой цепи. Параметр используется для автоматического определения силовых цепей.
                /// </summary>
                [XmlAttribute("minPinsNumber", DataType = "int")]
                public int _minPinsNumber;

                /// <summary>
                /// Cсылки на цепи.
                /// </summary>
                [XmlElement("NetRef")]
                public NetRef[] _NetRefs;
            }

            /// <summary>
            /// Максимальное число цепей в сигнальном кластере. Параметр используется при автоматическом определении цепей сигнального кластера.
            /// </summary>
            [XmlAttribute("maxNetsInCluster", DataType = "int")]
            public int _maxNetsInCluster;

            /// <summary>
            /// Автоматически задавать связи.
            /// </summary>
            [XmlAttribute("createPinPairs")]
            public Bool _createPinPairs;
            [XmlIgnore]
            public bool _createPinPairsSpecified { get { return _createPinPairs != Bool.off; } }

            /// <summary>
            /// Правила именования цепей дифференциальных сигналов.
            /// </summary>
            /// <remarks>! Порядок следования правил в этой секции определяет приоритет правил. Правила следуют в порядке убывания приоритета.</remarks>
            [XmlArray("RulesDiffSignalNetsNames")]
            [XmlArrayItem("RuleDiffSignalNetsNames")]
            public RuleDiffSignalNetsNames[] _RulesDiffSignalNetsNames;

            /// <summary>
            /// Список цепей, исключённых из поиска сигналов.
            /// </summary>
            [XmlElement("ExcludedNets")]
            public ExcludedNets _ExcludedNets;
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Волновые сопротивления и правила разводки сигналов.
        /// </summary>
        [XmlArray("RulesImpedances")]
        [
            XmlArrayItem("Impedance", typeof(Impedance)),
            XmlArrayItem("ImpedanceDiff", typeof(ImpedanceDiff))
        ]
        public object[] _RulesImpedances;

       /// <summary>
        /// Сигнальные кластеры цепей.
        /// </summary>
        [XmlArray("SignalClusters")]
        [XmlArrayItem("SignalCluster")]
        public SignalCluster[] _SignalClusters;

        /// <summary>
        /// Дифференциальные сигналы.
        /// </summary>
        [XmlArray("DiffSignals")]
        [XmlArrayItem("DiffSignal")]
        public DiffSignal[] _DiffSignals;

        /// <summary>
        /// Группы сигналов.
        /// </summary>
        [XmlArray("SignalGroups")]
        [XmlArrayItem("SignalGroup")]
        public SignalGroup[] _SignalGroups;

        /// <summary>
        /// Правила выравнивания задержек.
        /// </summary>
        [XmlElement("RulesDelay")]
        public RulesDelay _RulesDelay;

        /// <summary>
        /// Настройки автоматического поиска сигналов.
        /// </summary>
        [XmlElement("SignalSearchSettings")]
        public SignalSearchSettings _SignalSearchSettings;
    }
}
