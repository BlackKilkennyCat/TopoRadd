/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Соединения на плате».
    /// </summary>
    /// <remarks>В этом разделе описывается конкретная реализация соединений: печатные проводники, межслойные переходы и области металлизации.</remarks>
    public class Connectivity
    {
        /// <summary>
        /// Переходное отверстие на плате.
        /// </summary>
        public class Via
        {
            /// <summary>
            /// Признак фиксации.
            /// </summary>
            [XmlAttribute("fixed")]
            public Bool _fixed;
            [XmlIgnore]
            public bool _fixedSpecified { get { return _fixed != Bool.off; } }

            /// <summary>
            /// Ссылка на тип переходного отверстия.
            /// </summary>
            [XmlElement("ViastackRef")]
            public ViastackRef _ViastackRef;

            /// <summary>
            /// Ссылка на цепь.
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
        /// Описание змейки.
        /// </summary>
        /// <remarks>! Проводники, реализующие змейку, описываются в секции Wires (см. описание раздела Connectivity)</remarks>
        public class Serpent
        {
            /// <summary>
            /// Идентификатор неименованных объектов.
            /// </summary>
            [XmlAttribute("id")]
            public string _id;

            /// <summary>
            /// Параметр змейки: требуемая длина.
            /// </summary>
            [XmlAttribute("length", DataType ="float")]
            public float _length;

            /// <summary>
            /// Параметр змейки: зазор между соседними изломами.
            /// </summary>
            [XmlAttribute("gap", DataType = "float")]
            public float _gap;

            /// <summary>
            /// Параметр змейки: высота h1 (см. описание змейки Serpent).
            /// </summary>
            [XmlAttribute("h1", DataType = "float")]
            public float _h1;

            /// <summary>
            /// Параметр змейки: высота h2 (см. описание змейки Serpent).
            /// </summary>
            [XmlAttribute("h2", DataType = "float")]
            public float _h2;

            /// <summary>
            /// Параметр змейки: высота h3 (см. описание змейки Serpent).
            /// </summary>
            [XmlAttribute("h3", DataType = "float")]
            public float _h3;

            /// <summary>
            /// Параметр змейки: высота h4 (см. описание змейки Serpent).
            /// </summary>
            [XmlAttribute("h4", DataType = "float")]
            public float _h4;

        }

        /// <summary>
        /// Описание застёгнутой пары проводников.
        /// </summary>
        /// <remarks>! Сегменты(Track) описывают осевую линию пары.Форма проводников пары рассчитывается автоматически.</remarks> 
        public class ZippedWire
        {
            /// <summary>
            /// Идентификатор неименованных объектов.
            /// </summary>
            [XmlAttribute("id")]
            public string _id;

            /// <summary>
            /// Признак фиксации.
            /// </summary>
            [XmlAttribute("fixed")]
            public Bool _fixed;
            [XmlIgnore]
            public bool _fixedSpecified { get { return _fixed != Bool.off; } }

            /// <summary>
            /// Ссылка на слой.
            /// </summary>
            [XmlElement("LayerRef")]
            public LayerRef _LayerRef;

            /// <summary>
            /// Ссылка на дифференциальный сигнал.
            /// </summary>
            [XmlElement("DiffSignalRef")]
            public DiffSignalRef _DiffSignalRef;

            /// <summary>
            /// Начальная точка линии, дуги.
            /// </summary>
            [XmlElement("Start")]
            public Start _Start;

            /// <summary>
            /// Описание(я) сегмента проводника.
            /// </summary>
            [
                XmlElement("TrackLine", typeof(TrackLine)), 
                XmlElement("TrackArc", typeof(TrackArc)), 
                XmlElement("TrackArcCW", typeof(TrackArcCW))
            ]
            public object[] _Tracks;
        }

        /// <summary>
        /// Описание проводника.
        /// </summary>
        public class Wire
        {
            /// <summary>
            /// Описание части проводника (последовательность сегментов с одной шириной и одинаковым признаком фиксации).
            /// </summary>
            /// <remarks>! Атрибут zipwireRef (ссылка на застёгнутую пару проводников) используется, если описываемая часть проводника входит в застёгнутую пару проводников ZippedWire (см. пример описания проводника дифференциальной пары).</remarks>
            public class Subwire
            {
                /// <summary>
                /// Описание «капельки» четырёхугольником. Первая вершина соответствует точке привязки контакта (переходного отверстия). Остальные вершины описывают контур четырёхугольника против часовой стрелки.
                /// </summary>
                /// <remarks> ! TopoR при импорте игнорирует информацию о капельках.</remarks>
                public class Teardrop
                {
                    /// <summary>
                    /// координаты точки, вершины.
                    /// </summary>
                    [XmlElement("Dot")]
                    public Dot[] _Dots;
                }
                
                /// <summary>
                /// Признак фиксации.
                /// </summary>
                [XmlAttribute("fixed")]
                public Bool _fixed;
                [XmlIgnore]
                public bool _fixedSpecified { get { return _fixed != Bool.off; } }

                /// <summary>
                /// Ширина проводника.
                /// </summary>
                [XmlAttribute("width", DataType = "float")]
                public float _width;

                /// <summary>
                /// Ссылка на застёгнутую пару проводников. Строка должна содержать идентификатор описанной застёгнутой пары проводников ZippedWire.
                /// </summary>
                [XmlAttribute("zipwireRef")]
                public string _zipwireRef;

                /// <summary>
                /// Описание «капелек» для Subwire.
                /// </summary>
                /// <remarks>От KilkennyCat: сделал как массив, в спецификации не так, но так удобней</remarks>
                [XmlArray("Teardrops")]
                [XmlArrayItem("Teardrop")]
                public Teardrop[] _Teardrops;

                /// <summary>
                /// Начальная точка линии, дуги.
                /// </summary>
                [XmlElement("Start")]
                public Start _Start;

                /// <summary>
                /// Описание(я) сегмента проводника.
                /// </summary>
                [
                    XmlElement("TrackLine", typeof(TrackLine)),
                    XmlElement("TrackArc", typeof(TrackArc)),
                    XmlElement("TrackArcCW", typeof(TrackArcCW))
                ]
                public object[] _Tracks;
            }

            /// <summary>
            /// Ссылка на слой.
            /// </summary>
            [XmlElement("LayerRef")]
            public LayerRef _LayerRef;

            /// <summary>
            /// Ссылка на цепь.
            /// </summary>
            [XmlElement("NetRef")]
            public NetRef _NetRef;

            /// <summary>
            /// Части проводника (последовательность сегментов с одной шириной и одинаковым признаком фиксации).
            /// </summary>
            [XmlElement("Subwire")]
            public Subwire[] _Subwires;
        }

        /// <summary>
        /// Описание заливаемой области металлизации (полигона).
        /// </summary>
        /// <remarks>! Заливка полигона линиями (Fill) записывается только для других САПР. TopoR при импорте её игнорирует. Сплошная заливка (fillType = Solid) не записывается.</remarks>
        public class Copper_Connectivity
        {
            /// <summary>
            /// Описание термобарьера для подключения контактных площадок к области металлизации.
            /// </summary>
            public class ThermalPad
            {
                /// <summary>
                /// Описание термобарьера.
                /// </summary>
                [XmlElement("Thermal")]
                public Thermal _Thermal;
            }

            /// <summary>
            /// Описание термобарьера для подключения площадок переходных отверстий к области металлизации.
            /// </summary>
            public class ThermalVia
            {
                /// <summary>
                /// Описание термобарьера.
                /// </summary>
                [XmlElement("Thermal")]
                public Thermal _Thermal;
            }

            /// <summary>
            /// Описание контура заливаемой области металлизации.
            /// </summary>
            public class Shape_Copper
            {
                /// <summary>
                /// Описание залитой фигуры.
                /// </summary>
                [
                    XmlElement("FilledCircle", typeof(FilledCircle)),
                    XmlElement("FilledRect", typeof(FilledRect)),
                    XmlElement("Polygon", typeof(Polygon)),
                    XmlElement("FilledContour", typeof(FilledContour))
                ]
                public object _FilledFigure;
            }

            /// <summary>
            /// Описание островка области металлизации.
            /// </summary>
            public class Island
            {
                /// <summary>
                /// Описание спицы термобарьера, присутствующего на плате
                /// </summary>
                public class ThermalSpoke
                {
                    /// <summary>
                    /// Толщина линии.
                    /// </summary>
                    [XmlAttribute("lineWidth", DataType = "float")]
                    public float _lineWidth;

                    /// <summary>
                    /// Описания координат точек, вершин.
                    /// </summary>
                    [XmlElement("Dot")]
                    public Dot[] _Dots;
                }

                /// <summary>
                /// Описание многоугольника.
                /// </summary>
                [
                    XmlElement("Polygon", typeof(Polygon)),
                    XmlElement("FilledContour", typeof(FilledContour))
                ]
                public object _Polygon;

                /// <summary>
                /// Вырезы в островке области металлизации.
                /// </summary>
                [XmlArray("Voids")]
                [
                    XmlArrayItem("Polygon", typeof(Polygon)),
                    XmlArrayItem("FilledContour", typeof(FilledContour))
                ]
                public object[] _Voids;

                /// <summary>
                /// Описание спиц термобарьеров, присутствующих на плате
                /// </summary>
                [XmlElement("ThermalSpoke")]
                public ThermalSpoke[] _ThermalSpokes;
            }

            /// <summary>
            /// Параметр области металлизации (полигона): приоритет заливки.
            /// </summary>
            [XmlAttribute("priority", DataType ="int")]
            public int _priority;

            /// <summary>
            /// Параметр области металлизации (полигона): использовать указанный зазор.
            /// </summary>
            [XmlAttribute("useBackoff")]
            public Bool _useBackoff;
            [XmlIgnore]
            public bool _useBackoffSpecified { get { return _useBackoff != Bool.off; } }

            /// <summary>
            /// Параметр области металлизации (полигона): зазор до области металлизации.
            /// </summary>
            [XmlAttribute("backoff", DataType ="float")]
            public float _backoff;

            /// <summary>
            /// Параметр области металлизации (полигона) стека: подключение контактных площадок.
            /// </summary>
            [XmlAttribute("connectPad")]
            public connectPad _connectPad;

            /// <summary>
            /// Параметр области металлизации (полигона): подключение площадок переходных отверстий.
            /// </summary>
            [XmlAttribute("connectVia")]
            public connectVia _connectVia;

            /// <summary>
            /// Толщина линии.
            /// </summary>
            [XmlAttribute("lineWidth", DataType = "float")]
            public float _lineWidth;

            /// <summary>
            /// Параметр области металлизации (полигона): зазор между линиями штриховки.
            /// </summary>
            [XmlAttribute("lineClr", DataType = "float")]
            public float _lineClr;

            /// <summary>
            /// Параметр области металлизации (полигона): минимальная площадь островка.
            /// </summary>
            [XmlAttribute("minSquare", DataType = "float")]
            public float _minSquare;

            /// <summary>
            /// Параметр области металлизации (полигона): точность аппроксимации контура.
            /// </summary>
            [XmlAttribute("precision")]
            public precision _precision;

            /// <summary>
            /// Параметр области металлизации (полигона): удалять неподключенные островки.
            /// </summary>
            [XmlAttribute("deleteUnconnected")]
            public Bool _deleteUnconnected;
            [XmlIgnore]
            public bool _deleteUnconnectedSpecified { get { return _deleteUnconnected != Bool.off; } }

            /// <summary>
            /// Параметр области металлизации (полигона): состояние.
            /// </summary>
            [XmlAttribute("state")]
            public state _state;

            /// <summary>
            /// Параметр области металлизации (полигона): тип заливки.
            /// </summary>
            [XmlAttribute("fillType")]
            public fillType _fillType;

            /// <summary>
            /// Ссылка на слой.
            /// </summary>
            [XmlElement("LayerRef")]
            public LayerRef _LayerRef;

            /// <summary>
            /// Ссылка на цепь.
            /// </summary>
            [XmlElement("NetRef")]
            public NetRef _NetRef;

            /// <summary>
            /// Описание термобарьера для подключения контактных площадок к области металлизации.
            /// </summary>
            [XmlElement("ThermalPad")]
            public ThermalPad _ThermalPad;

            /// <summary>
            /// Описание термобарьера для подключения площадок переходных отверстий к области металлизации.
            /// </summary>
            [XmlElement("ThermalVia")]
            public ThermalVia _ThermalVia;

            /// <summary>
            /// Описание контура заливаемой области металлизации..
            /// </summary>
            [XmlElement("Shape")]
            public Shape_Copper _Shape;

            /// <summary>
            /// Вырезы в областях металлизации (полигонах) заданные пользователем.
            /// </summary>
            [XmlArray("Voids")]
            [
                XmlArrayItem("FilledCircle", typeof(FilledCircle)),
                XmlArrayItem("FilledRect", typeof(FilledRect)),
                XmlArrayItem("Polygon", typeof(Polygon)),
                XmlArrayItem("FilledContour", typeof(FilledContour))
            ]
            public object[] _Voids;

            /// <summary>
            /// Островки области металлизации.
            /// </summary>
            [XmlArray("Islands")]
            [XmlArrayItem("Island")]
            public Island[] _Islands;

            /// <summary>
            /// Заливка областей металлизации (полигонов) линиями.
            /// </summary>
            /// <remarks>! TopoR при импорте игнорирует эту информацию и строит заливку заново.</remarks>
            [XmlArray("Fill")]
            [XmlArrayItem("Line")]
            public Line[] _Fill_lines;
        }

        /// <summary>
        /// Описание незаливаемой области металлизации.
        /// </summary>
        public class NonfilledCopper
        {
            /// <summary>
            /// Описание контура незаливаемой области металлизации.
            /// </summary>
            public class Shape_NonfilledCopper
            {
                /// <summary>
                /// Описание фигуры.
                /// </summary>
                [
                    XmlElement("ArcCCW", typeof(ArcCCW)),
                    XmlElement("ArcCW", typeof(ArcCW)),
                    XmlElement("ArcByAngle", typeof(ArcByAngle)),
                    XmlElement("ArcByMiddle", typeof(ArcByMiddle)),
                    XmlElement("Circle", typeof(Circle)),
                    XmlElement("Line", typeof(Line)),
                    XmlElement("Polyline", typeof(Polyline)),
                    XmlElement("Rect", typeof(Rect)),
                    XmlElement("Contour", typeof(Contour))
                    
                ]
                public object _FigureContPoliline;
            }

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
            /// Ссылка на цепь.
            /// </summary>
            [XmlElement("NetRef")]
            public NetRef _NetRef;

            /// <summary>
            /// Описание контура незаливаемой области металлизации.
            /// </summary>
            [XmlElement("Shape")]
            public Shape_NonfilledCopper _Shape;
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Переходные отверстия на плате.
        /// </summary>
        [XmlArray("Vias")]
        [XmlArrayItem("Via")]
        public Via[] _Vias;

        /// <summary>
        /// Змейки
        /// </summary>
        [XmlArray("Serpents")]
        [XmlArrayItem("Serpent")]
        public Serpent[] _Serpents;

        /// <summary>
        /// Застёгнутые пары проводников.
        /// </summary>
        [XmlArray("ZippedWires")]
        [XmlArrayItem("ZippedWire")]
        public ZippedWire[] _ZippedWires;

        /// <summary>
        /// Проводники.
        /// </summary>
        [XmlArray("Wires")]
        [XmlArrayItem("Wire")]
        public Wire[] _Wires;

        /// <summary>
        /// Oбласти металлизации (полигонов).
        /// </summary>
        [XmlArray("Coppers")]
        [XmlArrayItem("Copper")]
        public Copper_Connectivity[] _Coppers;

        /// <summary>
        /// Незаливаемые области металлизации.
        /// </summary>
        [XmlArray("NonfilledCoppers")]
        [XmlArrayItem("NonfilledCopper")]
        public NonfilledCopper[] _NonfilledCoppers;
    }
}
