/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Компоненты на плате (обязательный раздел).
    /// </summary>
    public class ComponentsOnBoard
    {
        /// <summary>
        /// Описание компонента на плате.
        /// </summary>
        /// <remarks>! Если компонент расположен на нижней стороне платы, его посадочное место отображается зеркально относительно вертикальной оси посадочного места, описанного в библиотеке(т.е.без угла поворота). Стеки контактных площадок переворачиваются.</remarks>
        public class CompInstance
        {

            /// <summary>
            /// Описание контакта компонента на плате.
            /// </summary>
            /// <remarks>! Если PadstackRef не указан, то стек контактных площадок берётся из посадочного места.</remarks>
            public class CompInstance_Pin
            {
                /// <summary>
                /// Номер контакта компонента.
                /// </summary>
                [XmlAttribute("padNum", DataType = "int")]
                public int _padNum;

                /// <summary>
                /// Ссылка на стек контактных площадок.
                /// </summary>
                [XmlElement("PadstackRef")]
                public PadstackRef _PadstackRef;

                /// <summary>
                /// Точка привязки объекта.
                /// </summary>
                [XmlElement("Org")]
                public Org _Org;
            }

            /// <summary>
            /// Описание монтажного отверстия в компоненте на плате.
            /// </summary>
            public class CompInstance_Mnthole
            {
                /// <summary>
                /// Ссылка на монтажное отверстие в посадочном месте.
                /// </summary>
                [XmlAttribute("mntholeRef")]
                public string _mntholeRef;

                /// <summary>
                /// Задаёт угол в градусах c точностью до тысячных долей.
                /// </summary>
                [XmlAttribute("angle", DataType = "float")]
                public float _angle;

                /// <summary>
                /// Ссылка на стек контактных площадок.
                /// </summary>
                [XmlElement("PadstackRef")]
                public PadstackRef _PadstackRef;

                /// <summary>
                /// Cсылка на цепь.
                /// </summary>
                [XmlElement("NetRef")]
                public NetRef _NetRef;
            }

            /// <summary>
            /// Описание атрибута компонента на плате.
            /// </summary>
            public class CompInstance_Attribute
            {
                /// <summary>
                /// Описание ярлыка компонента на плате.
                /// </summary>
                public class CompInstance_Attribute_Label
                {
                    /// <summary>
                    /// Задаёт угол в градусах c точностью до тысячных долей.
                    /// </summary>
                    [XmlAttribute("angle", DataType = "float")]
                    public float _angle;

                    /// <summary>
                    /// Параметр надписей и ярлыков: зеркальность отображения.
                    /// </summary>
                    [XmlAttribute("mirror")]
                    public Bool _mirror;
                    [XmlIgnore]
                    public bool _mirrorSpecified { get { return _mirror != Bool.off; } }

                    /// <summary>
                    /// Параметр надписей (ярлыков): способ выравнивания текста.
                    /// </summary>
                    [XmlAttribute("align")]
                    public align _align;

                    /// <summary>
                    /// Флаг видимости.
                    /// </summary>
                    [XmlAttribute("visible")]
                    public Bool _visible;
                    [XmlIgnore]
                    public bool _visibleSpecified { get { return _visible != Bool.off; } }

                    /// <summary>
                    /// Ссылка на слой.
                    /// </summary>
                    [XmlElement("LayerRef")]
                    public LayerRef _LayerRef;

                    /// <summary>
                    /// Ссылка на стиль надписей.
                    /// </summary>
                    [XmlElement("TextStyleRef")]
                    public TextStyleRef _TextStyleRef;

                    /// <summary>
                    /// Точка привязки объекта.
                    /// </summary>
                    [XmlElement("Org")]
                    public Org _Org;
                }

                /// <summary>
                /// Тип предопределённого атрибута компонента.
                /// </summary>
                [XmlAttribute("type")]
                public type _type;

                /// <summary>
                /// Имя объекта или ссылка на именованный объект.
                /// </summary>
                [XmlAttribute("name")]
                public string _name;

                /// <summary>
                /// Значение атрибута.
                /// </summary>
                [XmlAttribute("value")]
                public string _value;

                /// <summary>
                /// Ярлыки.
                /// </summary>
                [XmlElement("Label")]
                public CompInstance_Attribute_Label[] _Labels;
            }

            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Уникальный идентификатор компонента. Используется при синхронизации. Необязательный атрибут.
            /// Если не задан, то будет создан при импорте файла.
            /// </summary>
            [XmlAttribute("uniqueId")]
            public string _uniqueId;

            /// <summary>
            /// Сторона объекта.
            /// </summary>
            /// <remarks>!Значение Both возможно только при описании запретов размещения.</remarks>
            [XmlAttribute("side")]
            public side _side;

            /// <summary>
            /// Задаёт угол в градусах c точностью до тысячных долей.
            /// </summary>
            [XmlAttribute("angle", DataType = "float")]
            public float _angle;

            /// <summary>
            /// Признак фиксации.
            /// </summary>
            [XmlAttribute("fixed")]
            public Bool _fixed;
            [XmlIgnore]
            public bool _fixedSpecified { get { return _fixed != Bool.off; } }

            /// <summary>
            /// Ссылка на схемный компонент.
            /// </summary>
            [XmlElement("ComponentRef")]
            public ComponentRef _ComponentRef;

            /// <summary>
            /// Ссылка на посадочное место.
            /// </summary>
            [XmlElement("FootprintRef")]
            public FootprintRef _FootprintRef;

            /// <summary>
            /// Точка привязки объекта.
            /// </summary>
            [XmlElement("Org")]
            public Org _Org;

            /// <summary>
            /// Контакты компонента на плате.
            /// </summary>
            [XmlArray("Pins")]
            [XmlArrayItem("Pin")]
            public CompInstance_Pin[] _Pins;

            /// <summary>
            /// Монтажные отверстия.
            /// </summary>
            [XmlArray("Mntholes")]
            [XmlArrayItem("Mnthole")]
            public CompInstance_Mnthole[] _Mntholes;

            /// <summary>
            /// Атрибуты компонента.
            /// </summary>
            [XmlArray("Attributes")]
            [XmlArrayItem("Attribute")]
            public CompInstance_Attribute[] _Attributes;

        }

        /// <summary>
        /// Описание одиночного контакта..
        /// </summary>
        public class FreePad
        {
            /// <summary>
            /// Сторона объекта.
            /// </summary>
            [XmlAttribute("side")]
            public side _side;

            /// <summary>
            /// Задаёт угол в градусах c точностью до тысячных долей.
            /// </summary>
            [XmlAttribute("angle", DataType = "float")]
            public float _angle;

            /// <summary>
            /// Признак фиксации.
            /// </summary>
            [XmlAttribute("fixed")]
            public Bool _fixed;
            [XmlIgnore]
            public bool _fixedSpecified { get { return _fixed != Bool.off; } }

            /// <summary>
            /// Ссылка на стек контактных площадок.
            /// </summary>
            [XmlElement("PadstackRef")]
            public PadstackRef _PadstackRef;

            /// <summary>
            /// Cсылка на цепь.
            /// </summary>
            [XmlElement("NetRef")]
            public NetRef _NetRef;

            /// <summary>
            /// Точка привязки объекта.
            /// </summary>
            [XmlElement("Org")]
            public Org _Org;
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Описание компонентов на плате (инстанции компонентов)
        /// </summary>
        [XmlArray("Components")]
        [XmlArrayItem("CompInstance")]
        public CompInstance[] _Components;

        /// <summary>
        /// Описание одиночных контактов.(инстанции компонентов)
        /// </summary>
        [XmlArray("FreePads")]
        [XmlArrayItem("FreePad")]
        public FreePad[] _FreePads;
    }
}
