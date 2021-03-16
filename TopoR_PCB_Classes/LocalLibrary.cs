/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Библиотечные элементы». (Обязательный раздел)
    /// </summary>
    public class LocalLibrary
    {
        /// <summary>
        /// Описание круглой контактной площадки.
        /// </summary>
        public class PadCircle
        {
            /// <summary>
            /// Диаметр окружности, круга, овала.
            /// </summary>
            [XmlAttribute("diameter", DataType = "float")]
            public float _diameter;

            /// <summary>
            /// Ссылка на слой или тип слоя. 
            /// </summary>
            /// <remarks>! Если в дизайне определён только один слой с заданным именем, то тип слоя не указывается.</remarks>
            /// <value>LayerTypeRef | LayerRef</value>
            [
                XmlElement("LayerTypeRef", typeof(LayerTypeRef)),
                XmlElement("LayerRef", typeof(LayerRef))
            ]
            public object _Reference;
        }

        /// <summary>
        /// Описание овальной контактной площадки.
        /// </summary>
        public class PadOval
        {
            /// <summary>
            /// Диаметр окружности, круга, овала.
            /// </summary>
            [XmlAttribute("diameter", DataType = "float")]
            public float _diameter;

            /// <summary>
            /// Ссылка на слой или тип слоя. 
            /// </summary>
            /// <remarks>! Если в дизайне определён только один слой с заданным именем, то тип слоя не указывается.</remarks>
            /// <value>LayerTypeRef | LayerRef</value>
            [
                XmlElement("LayerTypeRef", typeof(LayerTypeRef)),
                XmlElement("LayerRef", typeof(LayerRef))
            ]
            public object _Reference;

            /// <summary>
            /// Параметр овальной контактной площадки: вытягивание по осям x и y.
            /// </summary>
            [XmlElement("Stretch")]
            public Stretch _Stretch;

            /// <summary>
            /// Параметр контактной площадки: смещение точки привязки по осям x и y.
            /// </summary>
            [XmlElement("Shift")]
            public Shift _Shift;
        }

        /// <summary>
        /// Описание прямоугольной контактной площадки.
        /// Дополнительные атрибуты(handling и handlingValue) позволяют задавать тип и величину обработки углов.
        /// В качестве типа обработки допускается скругление или срез.
        /// Тип для всех углов должен быть одинаковым: нельзя скруглять один угол и срезать другой.
        /// Если флаг custom не установлен, обрабатываются все углы, иначе будут обработаны только углы, 
        /// соответствующие установленным флагам - cornerLB, cornerRB, cornerRT, cornerLT.
        /// Основные формы КП, которые данный формат позволяет описать:
        /// прямоугольные КП;
        /// прямоугольные КП со скруглёнными углами;
        /// прямоугольные КП со срезанными углами;
        /// Finger pads.
        /// </summary>
        public class PadRect
        {
            /// <summary>
            /// Ширина прямоугольной контактной площадки.
            /// </summary>
            [XmlAttribute("width", DataType = "float")]
            public float _width;

            /// <summary>
            /// Высота прямоугольной контактной площадки.
            /// </summary>
            [XmlAttribute("height", DataType = "float")]
            public float _height;

            /// <summary>
            /// Тип обработки углов прямоугольной контактной площадки.
            /// </summary>
            [XmlAttribute("handling")]
            public type_handling _handling;
            [XmlIgnore]
            public bool _handlingSpecified { get { return _handling != type_handling.None; } }

            /// <summary>
            /// Величина обработки углов прямоугольной контактной площадки. Значение зависит от типа обработки. Для скругления это радиус. Для среза это высота среза.
            /// </summary>
            [XmlAttribute("handlingValue", DataType = "float")]
            public float _handlingValue;
            [XmlIgnore]
            public bool _handlingValueSpecified { get { return _handlingValue != 0; } }

            /// <summary>
            /// Флаг выборочной обработки углов прямоугольной контактной площадки. Если не установлен, то все углы обрабатываются одинаковым образом.
            /// </summary>
            [XmlAttribute("custom")]
            public Bool _custom;
            [XmlIgnore]
            public bool _customSpecified { get { return _custom != Bool.off; } }

            /// <summary>
            /// Флаг обработки левого нижнего угла прямоугольной контактной площадки.
            /// </summary>
            [XmlAttribute("cornerLB")]
            public Bool _cornerLB;
            [XmlIgnore]
            public bool _cornerLBSpecified { get { return _cornerLB != Bool.off; } }

            /// <summary>
            /// Флаг обработки правого нижнего угла прямоугольной контактной площадки.
            /// </summary>
            [XmlAttribute("cornerRB")]
            public Bool _cornerRB;
            [XmlIgnore]
            public bool _cornerRBSpecified { get { return _cornerRB != Bool.off; } }

            /// <summary>
            /// Флаг обработки правого нижнего угла прямоугольной контактной площадки.
            /// </summary>
            [XmlAttribute("cornerRT")]
            public Bool _cornerRT;
            [XmlIgnore]
            public bool _cornerRTSpecified { get { return _cornerRT != Bool.off; } }

            /// <summary>
            /// Флаг обработки левого верхнего угла прямоугольной контактной площадки.
            /// </summary>
            [XmlAttribute("cornerLT")]
            public Bool _cornerLT;
            [XmlIgnore]
            public bool _cornerLTSpecified { get { return _cornerLT != Bool.off; } }

            /// <summary>
            /// Ссылка на слой или тип слоя. 
            /// </summary>
            /// <remarks>! Если в дизайне определён только один слой с заданным именем, то тип слоя не указывается.</remarks>
            /// <value>LayerTypeRef | LayerRef</value>
            [
                XmlElement("LayerTypeRef", typeof(LayerTypeRef)),
                XmlElement("LayerRef", typeof(LayerRef))
            ]
            public object _Reference;

            /// <summary>
            /// Параметр контактной площадки: смещение точки привязки по осям x и y.
            /// </summary>
            [XmlElement("Shift")]
            public Shift _Shift;
        }

        /// <summary>
        /// Описание полигональной контактной площадки.
        /// </summary>
        public class PadPoly
        {
            /// <summary>
            /// Ссылка на слой или тип слоя. 
            /// </summary>
            /// <remarks>! Если в дизайне определён только один слой с заданным именем, то тип слоя не указывается.</remarks>
            /// <value>LayerTypeRef | LayerRef</value>
            [
                XmlElement("LayerTypeRef", typeof(LayerTypeRef)),
                XmlElement("LayerRef", typeof(LayerRef))
            ]
            public object _Reference;

            /// <summary>
            /// Массив координат точек, вершин.
            /// </summary>
            /// <remarks>! Минимум 3 элемента</remarks>
            [XmlElement("Dot")]
            public Dot[] _Dots;
        }

        /// <summary>
        /// Описание стека контактных площадок.
        /// </summary>
        public class Padstack
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Тип стека контактных площадок.
            /// </summary>
            [XmlAttribute("type")]
            public type_padstack _type;

            /// <summary>
            /// Диаметр отверстия.
            /// </summary>
            [XmlAttribute("holeDiameter", DataType = "float")]
            public float _holeDiameter;

            /// <summary>
            /// Параметр стека контактной площадки: металлизация отверстия.
            /// </summary>
            [XmlAttribute("metallized")]
            public Bool _metallized;
            [XmlIgnore]
            public bool _metallizedSpecified { get { return _metallized != Bool.off; } }

            /// <summary>
            /// Параметр стека контактной площадки: подключение к области металлизации (полигону).
            /// </summary>
            [XmlAttribute("connectToCopper")]
            public type_connectToCopper _connectToCopper;

            /// <summary>
            /// Описание термобарьера.
            /// </summary>
            [XmlElement("Thermal")]
            public Thermal _Thermal;

            /// <summary>
            /// Контактные площадки стека.
            /// </summary>
            /// <value>PadCircle, PadOval, PadRect, PadPoly</value>
            [XmlArray("Pads")]
            [
                XmlArrayItem("PadCircle", typeof(PadCircle)),
                XmlArrayItem("PadOval", typeof(PadOval)),
                XmlArrayItem("PadRect", typeof(PadRect)),
                XmlArrayItem("PadPoly", typeof(PadPoly))
            ]
            public object[] _Pads;
        }

        /// <summary>
        /// Описание типа (стека) переходного отверстия.
        /// </summary>
        public class Viastack
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Диаметр отверстия.
            /// </summary>
            [XmlAttribute("holeDiameter", DataType = "float")]
            public float _holeDiameter;

            /// <summary>
            /// Параметр типа переходного отверстия: возможность установить переходное отверстие на контактной площадке.
            /// </summary>
            [XmlAttribute("viaOnPin")]
            public Bool _viaOnPin;
            [XmlIgnore]
            public bool _viaOnPinSpecified { get { return _viaOnPin != Bool.off; } }

            /// <summary>
            /// Диапазон слоев.
            /// </summary>
            /// <value>AllLayers | [LayerRef]</value>
            [XmlArray("LayerRange")]
            [
                XmlArrayItem("AllLayers", typeof(AllLayers)),/// AllLayers - yстанавливает область действия правила: все слои.
                XmlArrayItem("LayerRef", typeof(LayerRef))
            ]
            public object[] _LayerRanges;

            /// <summary>
            /// Описание площадок стека переходного отверстия.
            /// </summary>
            [XmlArray("ViaPads")]
            [XmlArrayItem("PadCircle", typeof(PadCircle))]
            public PadCircle[] _ViaPads;
        }

        /// <summary>
        /// Описание посадочного места.
        /// </summary>
        public class Footprint
        {
            /// <summary>
            /// Описание области металлизации (полигона) в посадочном месте компонента.
            /// </summary>
            public class Copper_Footprint
            {
                /// <summary>
                /// Толщина линии.
                /// </summary>
                [XmlAttribute("lineWidth", DataType = "float")]
                public float _lineWidth;

                /// <summary>
                /// Ссылка на слой.
                /// </summary>
                [XmlElement("LayerRef")]
                public LayerRef _LayerRef;

                /// <summary>
                /// Описание фигуры.
                /// </summary>
                /// <value>ArcCCW, ArcCW, ArcByAngle, ArcByMiddle, Line, Circle, Rect, FilledCircle, FilledRect, Polygon</value>
                [
                    XmlElement("ArcCCW", typeof(ArcCCW)),
                    XmlElement("ArcCW", typeof(ArcCW)),
                    XmlElement("ArcByAngle", typeof(ArcByAngle)),
                    XmlElement("ArcByMiddle", typeof(ArcByMiddle)),
                    XmlElement("Line", typeof(Line)),
                    XmlElement("Circle", typeof(Circle)),
                    XmlElement("Rect", typeof(Rect)),
                    XmlElement("FilledCircle", typeof(FilledCircle)),
                    XmlElement("FilledRect", typeof(FilledRect)),
                    XmlElement("Polygon", typeof(Polygon)),
                    XmlElement("FilledContour", typeof(FilledContour))
                ]
                public object _Figure;
            }

            /// <summary>
            /// Описание запрета в посадочном месте Footprint. Для запрета размещения должен быть указан слой с типом Assy.
            /// </summary>
            public class Keepout_Place_Trace
            {
                /// <summary>
                /// Ссылка на слой.
                /// </summary>
                [XmlElement("LayerRef")]
                public LayerRef _LayerRef;

                /// <summary>
                /// Описание фигуры.
                /// </summary>
                /// <value>ArcCCW, ArcCW, ArcByAngle, ArcByMiddle, Line, Circle, Rect, FilledCircle, FilledRect, Polygon</value>
                [ 
                    XmlElement("ArcCCW", typeof(ArcCCW)),
                    XmlElement("ArcCW", typeof(ArcCW)),
                    XmlElement("ArcByAngle", typeof(ArcByAngle)),
                    XmlElement("ArcByMiddle", typeof(ArcByMiddle)),
                    XmlElement("Line", typeof(Line)),
                    XmlElement("Circle", typeof(Circle)),
                    XmlElement("Rect", typeof(Rect)),
                    XmlElement("FilledCircle", typeof(FilledCircle)),
                    XmlElement("FilledRect", typeof(FilledRect)),
                    XmlElement("Polygon", typeof(Polygon)),
                    XmlElement("FilledContour", typeof(FilledContour))
                ]
                public object _Figure;
            }

            /// <summary>
            /// Описание монтажного отверстия в посадочном месте.
            /// </summary>
            public class Mnthole
            {
                /// <summary>
                /// Идентификатор неименованных объектов.
                /// </summary>
                [XmlAttribute("id")]
                public string _id;

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
            /// Описание ярлыка в посадочном месте.
            /// </summary>
            public class Label_Footprint
            {
                /// <summary>
                /// Имя объекта или ссылка на именованный объект.
                /// </summary>
                [XmlAttribute("name")]
                public string _name;

                /// <summary>
                /// Параметр надписей (ярлыков): способ выравнивания текста.
                /// </summary>
                [XmlAttribute("align")]
                public align _align;

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
            /// Описание контактной площадки (вывода) посадочного места.
            /// </summary>
            /// <remarks>! В системе TopoR поддерживаются планарные контакты на внешних металлических слоях и не поддерживаются на внутренних.
            /// Т.е.у планарного контакта может быть только одна площадка или на верхней стороне, или на нижней.
            /// В описании планарного контакта используется только слой Top.
            /// Это означает, что контактная площадка будет находиться на одной стороне с компонентом.
            /// Если же площадка находится на противоположной стороне, то должен быть установлен флаг flipped.
            /// Этот флаг устанавливается в описании контакта посадочного места.
            /// </remarks>
            public class Pad
            {
                /// <summary>
                /// Номер контактной площадки (вывода) посадочного места.
                /// </summary>
                [XmlAttribute("padNum", DataType = "int")]
                public int _padNum;

                /// <summary>
                /// Имя объекта или ссылка на именованный объект.
                /// </summary>
                [XmlAttribute("name")]
                public string _name;

                /// <summary>
                /// Задаёт угол в градусах c точностью до тысячных долей.
                /// </summary>
                [XmlAttribute("angle", DataType = "float")]
                public float _angle;

                /// <summary>
                /// Параметр контакта (вывода) посадочного места: перевёрнутость. 
                /// Если флаг не установлен, площадка планарного контакта будет находиться на одной стороне с компонентом,
                /// иначе площадка будет расположена на противоположной стороне.
                /// </summary>
                [XmlAttribute("flipped")]
                public Bool _flipped;
                [XmlIgnore]
                public bool _flippedSpecified { get { return _flipped != Bool.off; } }

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
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Описание контактных площадок посадочного места.
            /// </summary>
            [XmlArray("Pads")]
            [XmlArrayItem("Pad")]
            public Pad[] _Pads;

            /// <summary>
            /// Надписи.
            /// </summary>
            [XmlArray("Texts")]
            [XmlArrayItem("Text")]
            public Text[] _Texts;

            /// <summary>
            /// Детали посадочного места.
            /// </summary>
            [XmlArray("Details")]
            [XmlArrayItem("Detail")]
            public Detail[] _Details;

            /// <summary>
            /// Области металлизации (полигонов) в посадочных местах компонентов.
            /// </summary>
            [XmlArray("Coppers")]
            [XmlArrayItem("Copper")]
            public Copper_Footprint[] _Coppers;

            /// <summary>
            /// Запреты размещения в посадочном месте.
            /// </summary>
            [XmlArray("KeepoutsPlace")]
            [XmlArrayItem("Keepout")]
            public Keepout_Place_Trace[] _KeepoutsPlace;

            /// <summary>
            /// Запреты трассировки в посадочном месте.
            /// </summary>
            [XmlArray("KeepoutsTrace")]
            [XmlArrayItem("Keepout")]
            public Keepout_Place_Trace[] _KeepoutsTrace;

            /// <summary>
            /// Монтажные отверстия.
            /// </summary>
            [XmlArray("Mntholes")]
            [XmlArrayItem("Mnthole")]
            public Mnthole[] _Mntholes;

            /// <summary>
            /// Ярлыки.
            /// </summary>
            [XmlArray("Labels")]
            [XmlArrayItem("Label")]
            public Label_Footprint[] _Labels;
        }

        /// <summary>
        /// Описание схемного компонента.
        /// </summary>
        public class Component
        {
            /// <summary>
            /// Описание контакта схемного компонента.
            /// </summary>
            public class Pin_Component
            {
                /// <summary>
                /// Номер контакта компонента.
                /// </summary>
                [XmlAttribute("pinNum", DataType = "int")]
                public int _pinNum;

                /// <summary>
                /// Имя объекта или ссылка на именованный объект.
                /// </summary>
                [XmlAttribute("name")]
                public string _name;

                /// <summary>
                /// Схемотехническое имя контакта компонента.
                /// </summary>
                [XmlAttribute("pinSymName")]
                public string _pinSymName;

                /// <summary>
                /// Параметр контакта компонента: эквивалентность.
                /// </summary>
                [XmlAttribute("pinEqual", DataType = "int")]
                public int _pinEqual;

                /// <summary>
                /// Параметр контакта (вывода) компонента: номер вентиля контакта.
                /// </summary>
                [XmlAttribute("gate", DataType = "int")]
                public int _gate;

                /// <summary>
                /// Параметр контакта (вывода) компонента: эквивалентность вентиля контакта.
                /// </summary>
                [XmlAttribute("gateEqual", DataType = "int")]
                public int _gateEqual;
            }

            /// <summary>
            /// Описание атрибута схемного компонента.
            /// </summary>
            public class Attribute_Component
            {
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
            }

            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Контакты схемного компонента.
            /// </summary>
            [XmlArray("Pins")]
            [XmlArrayItem("Pin")]
            public Pin_Component[] _Pins;

            /// <summary>
            /// Атрибуты компонента.
            /// </summary>
            [XmlArray("Attributes")]
            [XmlArrayItem("Attribute")]
            public Attribute_Component[] _Attributes;
        }

        /// <summary>
        /// Описание упаковки (соответствие контактов компонента и выводов посадочного места).
        /// </summary>
        public class Package
        {
            /// <summary>
            /// Соответствие контакта схемного компонента и вывода посадочного места.
            /// </summary>
            public class Pinpack
            {
                /// <summary>
                /// Номер контакта компонента.
                /// </summary>
                [XmlAttribute("pinNum", DataType = "int")]
                public int _pinNum;

                /// <summary>
                /// Номер контактной площадки (вывода) посадочного места.
                /// </summary>
                [XmlAttribute("padNum", DataType = "int")]
                public int _padNum;

                /// <summary>
                /// Параметр правил выравнивания задержек: тип значений констант и допусков.
                /// </summary>
                [XmlAttribute("valueType")]
                public valueType _valueType;

                /// <summary>
                /// Параметр контакта компонента в посадочном месте: задержка сигнала в посадочном месте.
                /// </summary>
                [XmlAttribute("delay", DataType = "float")]
                public float _delay;
            }

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
            /// Соответствие контакта схемного компонента и вывода посадочного места.
            /// </summary>
            [XmlElement("Pinpack")]
            public Pinpack[] _Pinpacks;
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Стеки контактных площадок.
        /// </summary>
        [XmlArray("Padstacks")]
        [XmlArrayItem("Padstack")]
        public Padstack[] _Padstacks;

        /// <summary>
        /// Типы (стеки) переходных отверстий.
        /// </summary>
        [XmlArray("Viastacks")]
        [XmlArrayItem("Viastack")]
        public Viastack[] _Viastacks;

        /// <summary>
        /// Посадочные места.
        /// </summary>
        [XmlArray("Footprints")]
        [XmlArrayItem("Footprint")]
        public Footprint[] _Footprints;

        /// <summary>
        /// Схемные компоненты.
        /// </summary>
        [XmlArray("Components")]
        [XmlArrayItem("Component")]
        public Component[] _Components;

        /// <summary>
        /// Упаковки.
        /// </summary>
        [XmlArray("Packages")]
        [XmlArrayItem("Package")]
        public Package[] _Packages;
    }
}
