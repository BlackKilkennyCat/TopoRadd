/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{

    #region Enumerations //Все enum в алфавитном порядке

    /// <summary>
    /// Параметр надписей (ярлыков): способ выравнивания текста. Значение по умолчанию – CM.
    /// </summary>
    public enum align
    {
        /// <summary>
        /// по центру
        /// </summary>
        [XmlEnum("CM")]
        CM,
        /// <summary>
        /// по левому верхнему углу
        /// </summary>
        [XmlEnum("LT")]
        LT,
        /// <summary>
        /// по верхнему краю
        /// </summary>
        [XmlEnum("CT")]
        CT,
        /// <summary>
        /// по правому верхнему углу
        /// </summary>
        [XmlEnum("RT")]
        RT,
        /// <summary>
        /// по левому краю
        /// </summary>
        [XmlEnum("LM")]
        LM,
        /// <summary>
        /// по правому краю
        /// </summary>
        [XmlEnum("RM")]
        RM,
        /// <summary>
        /// по левому нижнему углу
        /// </summary>
        [XmlEnum("LB")]
        LB,
        /// <summary>
        /// по нижнему краю
        /// </summary>
        [XmlEnum("CB")]
        CB,
        /// <summary>
        /// по правому нижнему углу
        /// </summary>
        [XmlEnum("RB")]
        RB
    }

    /// <summary>
    /// Параметр автоматической трассировки: использование функциональной эквивалентности. Значение по умолчанию – None.
    /// </summary>
    public enum autoEqu
    {
        /// <summary>
        /// не использовать функциональную эквивалентность
        /// </summary>
        [XmlEnum("None")]
        None,
        /// <summary>
        /// переназначать выводы компонента
        /// </summary>
        [XmlEnum("Pins")]
        Pins,
        /// <summary>
        /// переназначать вентили компонентов (не поддерживается)
        /// </summary>
        [XmlEnum("Gates")]
        Gates,
        /// <summary>
        /// разрешить все переназначения (не поддерживается)
        /// </summary>
        [XmlEnum("Full")]
        Full
    }

    /// <summary>
    /// Настройка автоматической подвижки. Значение по умолчанию – MoveVias.
    /// </summary>
    public enum automove
    {
        /// <summary>
        /// двигаются только переходы
        /// </summary>
        [XmlEnum("MoveVias")]
        MoveVias,
        /// <summary>
        /// двигаются только переходы; в процессе движения выполняется перекладка проводников
        /// </summary>
        [XmlEnum("MoveViasWithRefine")]
        MoveViasWithRefine,
        /// <summary>
        /// двигаются компоненты и переходы; в процессе движения выполняется перекладка проводников
        /// </summary>
        [XmlEnum("MoveCompsWithRefine")]
        MoveCompsWithRefine
    }

    /// <summary>
    /// Флаг, значение по умолчанию – off.
    /// </summary>
    public enum Bool
    {
        [XmlEnum("off")]
        off,
        [XmlEnum("on")]
        on
    }

    /// <summary>
    /// Параметр области металлизации (полигона) стека: подключение контактных площадок. Значение по умолчанию – Direct.
    /// </summary>
    public enum connectPad
    {
        /// <summary>
        /// прямое подключение
        /// </summary>
        [XmlEnum("Direct")]
        Direct,
        /// <summary>
        /// подключение с помощью термобарьера
        /// </summary>
        [XmlEnum("Thermal")]
        Thermal
    }

    /// <summary>
    /// Параметр области металлизации (полигона): подключение площадок переходных отверстий. Значение по умолчанию – Direct.
    /// </summary>
    public enum connectVia
    {
        /// <summary>
        /// прямое подключение
        /// </summary>
        [XmlEnum("Direct")]
        Direct,
        /// <summary>
        /// подключение с помощью термобарьера
        /// </summary>
        [XmlEnum("Thermal")]
        Thermal
    }

    /// <summary>
    /// Единицы измерения длины для всего файла. Значение по умолчанию – mm (миллиметр).
    /// </summary>
    public enum dist
    {
        /// <summary>
        /// миллиметр
        /// </summary>
        [XmlEnum("mm")]
        mm,
        /// <summary>
        /// микрометр
        /// </summary>
        [XmlEnum("mkm")]
        mkm,
        /// <summary>
        /// сантиметр
        /// </summary>
        [XmlEnum("cm")]
        cm,
        /// <summary>
        /// дециметр
        /// </summary>
        [XmlEnum("dm")]
        dm,
        /// <summary>
        /// метр
        /// </summary>
        [XmlEnum("m")]
        m,
        /// <summary>
        /// мил(тысячная дюйма)
        /// </summary>
        [XmlEnum("mil")]
        mil,
        /// <summary>
        /// дюйм
        /// </summary>
        [XmlEnum("inch")]
        inch
    }

    /// <summary>
    /// Параметр области металлизации (полигона): тип заливки. Значение по умолчанию – Solid.
    /// </summary>
    public enum fillType
    {
        /// <summary>
        /// сплошная заливка
        /// </summary>
        [XmlEnum("Solid")]
        Solid,
        /// <summary>
        /// штриховка сеткой
        /// </summary>
        [XmlEnum("Hatched")]
        Hatched,
        /// <summary>
        /// диагональная штриховка сеткой
        /// </summary>
        [XmlEnum("CRHatched")]
        CRHatched
    }

    /// <summary>
    /// Настройка отображения сетки: тип сетки.
    /// </summary>
    public enum gridKind
    {
        [XmlEnum("Dots")]
        Dots,
        [XmlEnum("Lines")]
        Lines
    }

    /// <summary>
    /// Тип слоя. Значение по умолчанию – Signal.
    /// </summary>
    public enum layer_type
    {
        /// <summary>
        /// сигнальный слой
        /// </summary>
        [XmlEnum("Signal")]
        Signal,
        /// <summary>
        /// сборочный слой (слой очертаний компонентов)
        /// </summary>
        [XmlEnum("Assy")]
        Assy,
        /// <summary>
        /// слой паяльной пасты 
        /// </summary>
        [XmlEnum("Paste")]
        Paste,
        /// <summary>
        /// слой шелкографии
        /// </summary>
        [XmlEnum("Silk")]
        Silk,
        /// <summary>
        /// слой маски
        /// </summary>
        [XmlEnum("Mask")]
        Mask,
        /// <summary>
        /// опорный слой
        /// </summary>
        [XmlEnum("Plane")]
        Plane,
        /// <summary>
        /// механический слой
        /// </summary>
        [XmlEnum("Mechanical")]
        Mechanical,
        /// <summary>
        /// документирующий слой
        /// </summary>
        [XmlEnum("Doc")]
        Doc,
        /// <summary>
        /// диэлектрический слой
        /// </summary>
        [XmlEnum("Dielectric")]
        Dielectric
    }

    /// <summary>
    /// Настройка автоматической трассировки: режим трассировки. Значение по умолчанию – Multilayer.
    /// </summary>
    public enum mode_Autoroute
    {
        /// <summary>
        /// многослойная трассировка
        /// </summary>
        [XmlEnum("Multilayer")]
        Multilayer,
        /// <summary>
        /// однослойная трассировка на верхнем слое
        /// </summary>
        [XmlEnum("SinglelayerTop")]
        SinglelayerTop,
        /// <summary>
        /// однослойная трассировка на нижнем слое
        /// </summary>
        [XmlEnum("SinglelayerBottom")]
        SinglelayerBottom
    }

    /// <summary>
    /// Настройка подключения к углам прямоугольных контактных площадок: режим подключения.
    /// </summary>
    public enum mode_PadConnectSettings
    {
        /// <summary>
        /// возможность подключения к углам КП определяется автоматически.
        /// </summary>
        [XmlEnum("AutoConnect")]
        AutoConnect,
        /// <summary>
        /// разрешено подключаться к углам всех КП
        /// </summary>
        [XmlEnum("AllPads")]
        AllPads
    }

    /// <summary>
    /// Параметр области металлизации (полигона): точность аппроксимации контура. Значение по умолчанию – Med.
    /// </summary>
    public enum precision
    {
        /// <summary>
        /// средняя точность
        /// </summary>
        [XmlEnum("Med")]
        Med,
        /// <summary>
        /// низкая точность
        /// </summary>
        [XmlEnum("Low")]
        Low,
        /// <summary>
        /// высокая точность
        /// </summary>
        [XmlEnum("High")]
        High
    }

    /// <summary>
    /// Настройка отображения: единицы измерения. Значение по умолчанию – Metric.
    /// </summary>
    public enum preference
    {
        /// <summary>
        /// метрические (конкретные единицы выбираются в зависимости от параметра)
        /// </summary>
        [XmlEnum("Metric")]
        Metric,
        /// <summary>
        /// микрометр
        /// </summary>
        [XmlEnum("mkm")]
        mkm,
        /// <summary>
        /// миллиметр
        /// </summary>
        [XmlEnum("mm")]
        mm,
        /// <summary>
        /// сантиметр
        /// </summary>
        [XmlEnum("cm")]
        cm,
        /// <summary>
        /// дециметр
        /// </summary>
        [XmlEnum("dm")]
        dm,
        /// <summary>
        /// метр
        /// </summary>
        [XmlEnum("m")]
        m,
        /// <summary>
        /// английские (конкретные единицы выбираются в зависимости от параметра)
        /// </summary>
        [XmlEnum("Imperial")]
        Imperial,
        /// <summary>
        /// мил(тысячная дюйма)
        /// </summary>
        [XmlEnum("mil")]
        mil,
        /// <summary>
        /// дюйм
        /// </summary>
        [XmlEnum("inch")]
        inch
    }

    /// <summary>
    /// Настройка автоматической перекладки проводников. Значение по умолчанию – ChangeLayer.
    /// </summary>
    public enum refine
    {
        /// <summary>
        /// разрешён перенос проводников на другой слой.
        /// </summary>
        [XmlEnum("ChangeLayer")]
        ChangeLayer,
        /// <summary>
        /// без переноса проводников на другой слой.
        /// </summary>
        [XmlEnum("NoChangeLayer")]
        NoChangeLayer
    }

    /// <summary>
    /// Тип запрета трассировки. Значение по умолчанию – Wires
    /// </summary>
    public enum role
    {
        /// <summary>
        /// запрет проводников
        /// </summary>
        [XmlEnum("Wires")]
        Wires,
        /// <summary>
        /// запрет переходных отверстий
        /// </summary>
        [XmlEnum("Vias")]
        Vias,
        /// <summary>
        /// запрет проводников и переходных отверстий
        /// </summary>
        [XmlEnum("Wires and Vias")]
        WiresАndVias
    }

    /// <summary>
    /// Настройка фильтра сообщений: режим показа предупреждений. Значение по умолчанию – ShowChecked.
    /// </summary>
    public enum showWarnings
    {
        /// <summary>
        /// показывать только отмеченные предупреждения
        /// </summary>
        [XmlEnum("ShowChecked")]
        ShowChecked,
        /// <summary>
        /// показывать все предупреждения
        /// </summary>
        [XmlEnum("ShowAll")]
        ShowAll,
        /// <summary>
        /// ничего не показывать
        /// </summary>
        [XmlEnum("ShowNothing")]
        ShowNothing
    }

    /// <summary>
    /// Сторона объекта.
    /// </summary>
    /// <remarks>! Значение Both возможно только при описании запретов размещения.</remarks>
    public enum side
    {
        /// <summary>
        /// верх
        /// </summary>
        [XmlEnum("Top")]
        Top,
        /// <summary>
        /// низ
        /// </summary>
        [XmlEnum("Bottom")]
        Bottom,
        /// <summary>
        /// обе стороны
        /// </summary>
        [XmlEnum("Both")]
        Both
    }

    /// <summary>
    /// Параметр области металлизации (полигона): состояние. Значение по умолчанию – Unpoured.
    /// </summary>
    public enum state
    {
        /// <summary>
        /// незалитая
        /// </summary>
        [XmlEnum("Unpoured")]
        Unpoured,
        /// <summary>
        /// залитая
        /// </summary>
        [XmlEnum("Poured")]
        Poured,
        /// <summary>
        /// залитая и зафиксированная
        /// </summary>
        [XmlEnum("Locked")]
        Locked
    }

    /// <summary>
    /// Единица измерения времени для всего файла. Значение по умолчанию – ps (пикосекунда).
    /// </summary>
    public enum time
    {
        /// <summary>
        /// пикосекунда
        /// </summary>
        [XmlEnum("ps")]
        ps,
        /// <summary>
        /// фемтосекунда
        /// </summary>
        [XmlEnum("fs")]
        fs,
        /// <summary>
        /// наносекунда
        /// </summary>
        [XmlEnum("ns")]
        ns,
        /// <summary>
        /// микросекунда
        /// </summary>
        [XmlEnum("us")]
        us
    }

    /// <summary>
    /// Тип предопределённого атрибута компонента. Значение по умолчанию - RefDes
    /// </summary>
    public enum type
    {
        /// <summary>
        /// позиционное обозначение
        /// </summary>
        [XmlEnum("RefDes")]
        RefDes,
        /// <summary>
        /// PartName
        /// </summary>
        [XmlEnum("PartName")]
        PartName
    }

    /// <summary>
    /// Параметр стека контактной площадки: подключение к области металлизации (полигону). Значение по умолчанию – NoneConnect.
    /// </summary>
    public enum type_connectToCopper
    {
        /// <summary>
        /// тип подключения не задан(используются настройки полигона)
        /// </summary>
        [XmlEnum("NoneConnect")]
        NoneConnect,
        /// <summary>
        /// прямое подключение 
        /// </summary>
        [XmlEnum("Direct")]
        Direct,
        /// <summary>
        /// подключение с помощью термобарьера
        /// </summary>
        [XmlEnum("Thermal")]
        Thermal
    }

    /// <summary>
    /// Тип обработки углов прямоугольной контактной площадки.
    /// </summary>
    public enum type_handling
    {
        /// <summary>
        /// без обработки
        /// </summary>
        [XmlEnum("None")]
        None,
        /// <summary>
        /// скругление
        /// </summary>
        [XmlEnum("Rounding")]
        Rounding,
        /// <summary>
        /// срез
        /// </summary>
        [XmlEnum("Chamfer")]
        Chamfer
    }

    /// <summary>
    /// Тип стека контактных площадок. Значение по умолчанию – Through.
    /// </summary>
    public enum type_padstack
    {
        /// <summary>
        /// сквозной
        /// </summary>
        [XmlEnum("Through")]
        Through,
        /// <summary>
        /// планарный
        /// </summary>
        [XmlEnum("SMD")]
        SMD,
        /// <summary>
        /// монтажное отверстие
        /// </summary>
        [XmlEnum("MountHole")]
        MountHole
    }

    /// <summary>
    /// Настройка вывода файлов Gerber, DXF, Drill: единицы измерения. Значение по умолчанию – mm.
    /// </summary>
    public enum units
    {
        /// <summary>
        /// миллиметр
        /// </summary>
        [XmlEnum("mm")]
        mm,
        /// <summary>
        /// мил (тысячная дюйма)
        /// </summary>
        [XmlEnum("mil")]
        mil
    }

    /// <summary>
    /// Параметр правил выравнивания задержек: тип значений констант и допусков. Значение по умолчанию: Dist
    /// </summary>
    public enum valueType
    {
        /// <summary>
        /// длина
        /// </summary>
        [XmlEnum("Dist")]
        Dist,
        /// <summary>
        /// время
        /// </summary>
        [XmlEnum("Time")]
        Time
    }

    /// <summary>
    /// Параметр автоматической трассировки: форма проводников. 
    /// </summary>
    public enum wireShape
    {
        /// <summary>
        /// Polyline
        /// </summary>
        [XmlEnum("Polyline")]
        Polyline,
        /// <summary>
        /// Arcs
        /// </summary>
        [XmlEnum("Arcs")]
        Arcs
    }

    #endregion Enumerations

    #region Reference Types 
    /// <summary>
    /// базовый класс ссылок.
    /// </summary>
    public class BaseRef
    {
        /// <summary>
        /// Имя объекта или ссылка на именованный объект.
        /// </summary>
        [XmlAttribute("name")]
        public string _ReferenceName;
    }

    /// <summary>
    /// Ссылка на атрибут.
    /// </summary>
    public class AttributeRef : BaseRef { }

    /// <summary>
    /// Ссылка на тип слоя.
    /// </summary>
    public class LayerTypeRef
    {
        /// <summary>
        /// Тип слоя.
        /// </summary>
        [XmlAttribute("type")]
        public layer_type _type;
    }

    /// <summary>
    /// Ссылка на группу слоёв.
    /// </summary>
    public class LayerGroupRef : BaseRef { }

    /// <summary>
    /// Ссылка на слой.
    /// </summary>
    /// <remarks>! Если в дизайне определён только один слой с заданным именем, то тип слоя не указывается.</remarks>
    public class LayerRef : BaseRef
    {
        /// <summary>
        /// Тип слоя или ссылка на именованный cлой
        /// </summary>
        /// <remarks>В документации сказано ещё и про возможность установки типа, если имя слоя неуникально, в данный момент это отключено</remarks>
        // TODO:
        //   XmlAttribute("type", typeof(type_layer)),
    }

    /// <summary>
    /// Ссылка на тип переходного отверстия.
    /// </summary>
    public class ViastackRef : BaseRef { }

    /// <summary>
    /// Ссылка на стек контактных площадок.
    /// </summary>
    public class NetRef : BaseRef { }

    /// <summary>
    /// Ссылка на группу компонентов.
    /// </summary>
    public class CompGroupRef : BaseRef { }

    /// <summary>
    /// Ссылка на компонент на плате.
    /// </summary>
    public class CompInstanceRef : BaseRef { }

    /// <summary>
    /// Ссылка на группу цепей.
    /// </summary>
    public class NetGroupRef : BaseRef { }

    /// <summary>
    /// Ссылка на волновое сопротивление.
    /// </summary>
    public class ImpedanceRef : BaseRef { }

    /// <summary>
    /// Ссылка на сигнал.
    /// </summary>
    public class SignalRef : BaseRef { }

    /// <summary>
    /// Ссылка на группу сигналов..
    /// </summary>
    public class SignalGroupRef : BaseRef { }

    /// <summary>
    /// Ссылка на дифференциальный сигнал.
    /// </summary>
    public class DiffSignalRef : BaseRef { }

    /// <summary>
    /// Ссылка на контакт.
    /// </summary>
    public class PinRef
    {
        /// <summary>
        /// Имя компонента, используется для ссылки на компонент.
        /// </summary>
        [XmlAttribute("compName")]
        public string _compName;

        /// <summary>
        /// Имя контакта компонента, используется для ссылки.
        /// </summary>
        [XmlAttribute("pinName")]
        public string _pinName;
    }

    /// <summary>
    /// Ссылка на контакт источника сигнала.
    /// </summary>
    public class SourcePinRef : PinRef { }

    /// <summary>
    /// Ссылка на контакт приёмника сигнала.
    /// </summary>
    public class ReceiverPinRef : PinRef { }

    /// <summary>
    /// Ссылка на стек контактных площадок.
    /// </summary>
    public class PadstackRef : BaseRef { }

    /// <summary>
    /// Ссылка на стиль надписей.
    /// </summary>
    public class TextStyleRef : BaseRef { }

    /// <summary>
    /// Ссылка на схемный компонент.
    /// </summary>
    public class ComponentRef : BaseRef { }

    /// <summary>
    /// Ссылка на посадочное место.
    /// </summary>
    public class FootprintRef : BaseRef { }

    /// <summary>
    /// Ссылка на вывод посадочного места.
    /// </summary>
    public class PadRef
    {
        /// <summary>
        /// Ссылка на вывод посадочного места..
        /// </summary>
        [XmlAttribute("compName")]
        public string _compName;

        /// <summary>
        /// Номер контактной площадки (вывода) посадочного места.
        /// </summary>
        [XmlAttribute("padNum", DataType = "int")]
        public int _padNum;
    }
    #endregion Reference Type

    #region Coordinates

    public class base_coordinat
    {
        [XmlAttribute("x", DataType = "float")]
        public float _x;
        [XmlAttribute("y", DataType = "float")]
        public float _y;

        public void Shift(float x, float y)
        {
            _x += x;
            _y += y;
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _x = Ut.UnitsConvert(_x, in_units, out_units);
            _y = Ut.UnitsConvert(_y, in_units, out_units);
        }
    }

    /// <summary>
    /// координаты точки, вершины.
    /// </summary>
    public class Dot : base_coordinat { }

    /// <summary>
    /// Центр круга (окружности), овала.
    /// </summary>
    public class Center : base_coordinat { }

    /// <summary>
    /// Начальная точка линии, дуги.
    /// </summary>
    public class Start : base_coordinat { }

    /// <summary>
    /// Средняя точка дуги.
    /// </summary>
    public class Middle : base_coordinat { }

    /// <summary>
    /// Конечная точка линии, дуги.
    /// </summary>
    public class End : base_coordinat { }

    /// <summary>
    /// Точка привязки объекта.
    /// </summary>
    public class Org : base_coordinat { }

    /// <summary>
    /// Cмещение точки привязки или объекта по осям x и y.
    /// </summary>
    public class Shift : base_coordinat { }

    /// <summary>
    /// Вытягивание по осям x и y.
    /// </summary>
    public class Stretch : base_coordinat { }

    #endregion Coordinates

    #region Segments
    /// <summary>
    /// Описание прямолинейного сегмента контура.
    /// </summary>
    public class SegmentLine
    {
        /// <summary>
        /// Конечная точка линии, дуги.
        /// </summary>
        [XmlElement("End")]
        public End _End;

        public void Shift(float x, float y)
        {
            _End?.Shift(x, y);
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _End?.UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Описание дугообразного сегмента контура.
    /// Дуга, задаётся центром. Обход против часовой стрелки.
    /// </summary>
    public class SegmentArcCCW : SegmentLine
    {
        /// <summary>
        /// Центр круга (окружности), овала.
        /// </summary>
        [XmlElement("Center")]
        public Center _Center;

        public new void Shift(float x, float y)
        {
            _Center?.Shift(x, y);
            _End?.Shift(x, y);
        }

        public new void UnitsConvert(dist in_units, dist out_units)
        {
            _Center?.UnitsConvert(in_units, out_units);
            _End?.UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Описание дугообразного сегмента контура.
    /// Дуга, задаётся центром. Обход по часовой стрелки.
    /// </summary>
    public class SegmentArcCW : SegmentArcCCW { }

    /// <summary>
    /// Описание дугообразного сегмента контура. 
    /// Дуга, задаётся углом. Отрицательный угол означает обход по часовой стрелке.
    /// </summary>
    public class SegmentArcByAngle : SegmentLine
    {
        /// <summary>
        /// Задаёт угол в градусах c точностью до тысячных долей.
        /// </summary>
        [XmlAttribute("angle", DataType = "float")]
        public float _angle;
    }

    /// <summary>
    /// Описание дугообразного сегмента контура.
    /// Дуга, задаётся тремя точками: начало, середина и конец.
    /// </summary>
    public class SegmentArcByMiddle : SegmentLine
    {
        /// <summary>
        /// Конечная точка линии, дуги.
        /// </summary>
        [XmlElement("Middle")]
        public Middle _Middle;

        public new void Shift(float x, float y)
        {
            _Middle?.Shift(x, y);
            _End?.Shift(x, y);
        }

        public new void UnitsConvert(dist in_units, dist out_units)
        {
            _Middle?.UnitsConvert(in_units, out_units);
            _End?.UnitsConvert(in_units, out_units);
        }
    }
    #endregion Segments

    #region Figures

    /// <summary>
    /// Дуга, заданная центром. Обход против часовой стрелки.
    /// </summary>
    public class ArcCCW
    {
        /// <summary>
        /// Центр круга (окружности), овала.
        /// </summary>
        [XmlElement("Center")]
        public Center _Center;

        /// <summary>
        /// Начальная точка линии, дуги.
        /// </summary>
        [XmlElement("Start")]
        public Start _Start;

        /// <summary>
        /// Конечная точка линии, дуги.
        /// </summary>
        [XmlElement("End")]
        public End _End;

        public void Shift(float x, float y)
        {
            _Start?.Shift(x, y);
            _Center?.Shift(x, y);
            _End?.Shift(x, y);
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _Start?.UnitsConvert(in_units, out_units);
            _Center?.UnitsConvert(in_units, out_units);
            _End?.UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Дуга, заданная центром. Обход по часовой стрелке.
    /// </summary>
    public class ArcCW : ArcCCW { }

    /// <summary>
    /// Дуга, заданная углом. Отрицательный угол означает обход по часовой стрелке.
    /// </summary>
    public class ArcByAngle
    {
        /// <summary>
        /// Задаёт угол в градусах c точностью до тысячных долей.
        /// </summary>
        [XmlAttribute("angle", DataType = "float")]
        public float _angle;

        /// <summary>
        /// Начальная точка линии, дуги.
        /// </summary>
        [XmlElement("Start")]
        public Start _Start;

        /// <summary>
        /// Конечная точка линии, дуги.
        /// </summary>
        [XmlElement("End")]
        public End _End;

        public void Shift(float x, float y)
        {
            _Start?.Shift(x, y);
            _End?.Shift(x, y);
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _Start?.UnitsConvert(in_units, out_units);
            _End?.UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Дуга, заданная тремя точками: начало, середина и конец.
    /// </summary>
    public class ArcByMiddle
    {
        /// <summary>
        /// Начальная точка линии, дуги.
        /// </summary>
        [XmlElement("Start")]
        public Start _Start;

        /// <summary>
        /// Конечная точка линии, дуги.
        /// </summary>
        [XmlElement("Middle")]
        public Middle _Middle;

        /// <summary>
        /// Конечная точка линии, дуги.
        /// </summary>
        [XmlElement("End")]
        public End _End;

        public void Shift(float x, float y)
        {
            _Start?.Shift(x, y);
            _Middle?.Shift(x, y);
            _End?.Shift(x, y);
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _Start?.UnitsConvert(in_units, out_units);
            _Middle?.UnitsConvert(in_units, out_units);
            _End?.UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Описание окружности (незалитого круга).
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// Диаметр окружности, круга, овала.
        /// </summary>
        [XmlAttribute("diameter", DataType = "float")]
        public float _diameter;

        /// <summary>
        /// Центр круга (окружности), овала.
        /// </summary>
        [XmlElement("Center")]
        public Center _Center;

        public void Shift(float x, float y)
        {
            _Center?.Shift(x, y);
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _diameter = Ut.UnitsConvert(_diameter, in_units, out_units);
            _Center?.UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Описание линии.
    /// </summary>
    public class Line
    {
        /// <summary>
        /// Массив координат точек, вершин.
        /// </summary>
        [XmlElement("Dot")]
        public Dot[] _Dots;

        public void Shift(float x, float y)
        {
            if (_Dots?.Length > 0)
                for (int i = 0; i < _Dots.Length; i++)
                    _Dots[i].Shift(x, y);
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            if (_Dots?.Length > 0)
                for (int i = 0; i < _Dots.Length; i++)
                    _Dots[i].UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Описание полилинии.
    /// </summary>
    public class Polyline
    {
        /// <summary>
        /// Начальная точка линии, дуги.
        /// </summary>
        [XmlElement("Start")]
        public Start _Start;

        /// <summary>
        /// Сегменты.
        /// </summary>
        [
            XmlElement("SegmentLine", typeof(SegmentLine)),
            XmlElement("SegmentArcByAngle", typeof(SegmentArcByAngle)),
            XmlElement("SegmentArcCCW", typeof(SegmentArcCCW)),
            XmlElement("SegmentArcCW", typeof(SegmentArcCW)),
            XmlElement("SegmentArcByMiddle", typeof(SegmentArcByMiddle))
        ]
        public object[] _Segments;

        public void Shift(float x, float y)
        {
            _Start?.Shift(x, y);

            if (_Segments?.Length > 0)
                for (int i = 0; i < _Segments.Length; i++)
                    switch (_Segments[i].GetType().Name)
                    {
                        case "SegmentLine":
                            ((SegmentLine)_Segments[i]).Shift(x, y);
                            break;
                        case "SegmentArcByAngle":
                            ((SegmentArcByAngle)_Segments[i]).Shift(x, y);
                            break;
                        case "SegmentArcCCW":
                            ((SegmentArcCCW)_Segments[i]).Shift(x, y);
                            break;
                        case "SegmentArcCW":
                            ((SegmentArcCW)_Segments[i]).Shift(x, y);
                            break;
                        case "SegmentArcByMiddle":
                            ((SegmentArcByMiddle)_Segments[i]).Shift(x, y);
                            break;
                    }
        }
        public void UnitsConvert(dist in_units, dist out_units)
        {
            _Start?.UnitsConvert(in_units, out_units);

            if (_Segments?.Length > 0)
                for (int i = 0; i < _Segments.Length; i++)
                    switch (_Segments[i].GetType().Name)
                    {
                        case "SegmentLine":
                            ((SegmentLine)_Segments[i]).UnitsConvert(in_units, out_units);
                            break;
                        case "SegmentArcByAngle":
                            ((SegmentArcByAngle)_Segments[i]).UnitsConvert(in_units, out_units);
                            break;
                        case "SegmentArcCCW":
                            ((SegmentArcCCW)_Segments[i]).UnitsConvert(in_units, out_units);
                            break;
                        case "SegmentArcCW":
                            ((SegmentArcCW)_Segments[i]).UnitsConvert(in_units, out_units);
                            break;
                        case "SegmentArcByMiddle":
                            ((SegmentArcByMiddle)_Segments[i]).UnitsConvert(in_units, out_units);
                            break;
                    }
        }
    }

    /// <summary>
    /// Описание незалитого контура.
    /// Если конечная точка последнего сегмента не совпадает с начальной точкой контура, контур замыкается линейным сегментом.
    /// </summary>
    public class Contour : Polyline { }

    /// <summary>
    /// Описание незалитого прямоугольника. Указываются верхняя левая и правая нижняя вершины
    /// </summary>
    public class Rect : Line { }

    /// <summary>
    /// Описание залитого контура.
    /// Если конечная точка последнего сегмента не совпадает с начальной точкой контура, контур замыкается линейным сегментом.
    /// </summary>
    public class FilledContour : Polyline { }///TODO: требует уточнения

    /// <summary>
    /// Описание круга.
    /// </summary>
    public class FilledCircle : Circle { }

    /// <summary>
    /// Описание залитого прямоугольника.
    /// </summary>
    public class FilledRect : Rect { }

    /// <summary>
    /// Описание многоугольника.
    /// Тег поддерживается, но является устаревшим.Следует использовать тег FilledContour.
    /// </summary>
    public class Polygon : Line { }

    /// <summary>
    /// Описание дугообразного сегмента проводника (дуга по часовой стрелке).
    /// </summary>
    /// <remarks>Начальная точка сегмента определяется по предыдущему сегменту или по тегу Start, заданному в SubWire. ! Если сегмент принадлежит змейке, указывается ссылка на змейку serpRef.</remarks>
    public class TrackArcCW
    {
        /// <summary>
        /// Центр круга (окружности), овала.
        /// </summary>
        [XmlElement("Center")]
        public Center _Center;

        /// <summary>
        /// Конечная точка линии, дуги.
        /// </summary>
        [XmlElement("End")]
        public End _End;

        /// <summary>
        /// Ссылка на змейку. Строка должна содержать идентификатор описанной змейки Serpent.
        /// </summary>
        [XmlAttribute("serpRef")]
        public string _serpRef;

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _Center?.UnitsConvert(in_units, out_units);
            _End?.UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Описание дугообразного сегмента проводника (дуга против часовой стрелки).
    /// </summary>
    /// <remarks>Начальная точка сегмента определяется по предыдущему сегменту или по тегу Start, заданному в SubWire. ! Если сегмент принадлежит змейке, указывается ссылка на змейку serpRef.</remarks>
    public class TrackArc : TrackArcCW { }

    /// <summary>
    /// Описание прямолинейного сегмента проводника.
    /// </summary>
    /// <remarks>Начальная точка сегмента определяется по предыдущему сегменту или по тегу Start, заданному в SubWire. ! Если сегмент принадлежит змейке, указывается ссылка на змейку serpRef.</remarks>
    public class TrackLine
    {
        /// <summary>
        /// Конечная точка линии, дуги.
        /// </summary>
        [XmlElement("End")]
        public End _End;

        /// <summary>
        /// Ссылка на змейку. Строка должна содержать идентификатор описанной змейки Serpent.
        /// </summary>
        [XmlAttribute("serpRef")]
        public string _serpRef;

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _End?.UnitsConvert(in_units, out_units);
        }
    }

    #endregion Figures 

    #region Rules area
    /// <summary>
    /// Устанавливает область действия правила: все слои.
    /// </summary>
    public class AllLayers
    {
        [XmlElement("AllLayers")]
        public string _AllLayers;
    }

    /// <summary>
    /// Устанавливает область действия правила: все компоненты.
    /// </summary>
    public class AllComps
    {
        [XmlElement("AllComps")]
        public string _AllComps;
    }

    /// <summary>
    /// Устанавливает область действия правила: все цепи.
    /// </summary>
    public class AllNets
    {
        [XmlElement("AllNets")]
        public string _AllNets;
    }
    /// <summary>
    /// Устанавливает область действия правила: все внутренние слои.
    /// </summary>
    public class AllLayersInner
    {
        [XmlElement("AllLayersInner")]
        public string _AllLayersInner;
    }

    /// <summary>
    /// Устанавливает область действия правила: все внутренние сигнальные слои.
    /// </summary>
    public class AllLayersInnerSignal
    {
        [XmlElement("AllLayersInnerSignal")]
        public string _AllLayersInnerSignal;
    }

    /// <summary>
    /// Устанавливает область действия правила: все сигнальные слои.
    /// </summary>
    public class AllLayersSignal
    {
        [XmlElement("AllLayersSignal")]
        public string _AllLayersSignal;
    }

    /// <summary>
    /// Устанавливает область действия правила: все внешние слои.
    /// </summary>
    public class AllLayersOuter
    {
        [XmlElement("AllLayersOuter")]
        public string _AllLayersOuter;
    }

    /// <summary>
    /// Устанавливает доступные типы переходных отверстий для правила: все типы.
    /// </summary>
    public class AllViastacks
    {
        [XmlElement("AllViastacks")]
        public string _AllViastacks;
    }

    /// <summary>
    /// Устанавливает доступные типы переходных отверстий для правила: все сквозные типы.
    /// </summary>
    public class AllViastacksThrough
    {
        [XmlElement("AllViastacksThrough")]
        public string _AllViastacksThrough;
    }

    /// <summary>
    /// Устанавливает доступные типы переходных отверстий для правила: все несквозные типы.
    /// </summary>
    public class AllViastacksNotThrough
    {
        [XmlElement("AllViastacksNotThrough")]
        public string _AllViastacksNotThrough;
    }
    #endregion Rules area

    #region Thermal Detail Text ObjectSignal

    /// <summary>
    /// Описание термобарьера.
    /// </summary>
    public class Thermal
    {
        /// <summary>
        /// Параметр термобарьера: число спиц.! В TopoR поддерживается только одно значение – 4.
        /// </summary>
        [XmlAttribute("spokeNum", DataType = "int")]
        public int _spokeNum;

        /// <summary>
        /// Параметр термобарьера: минимальное число спиц.
        /// </summary>
        [XmlAttribute("minSpokeNum", DataType = "int")]
        public int _minSpokeNum;

        /// <summary>
        /// Задаёт угол в градусах c точностью до тысячных долей.
        /// </summary>
        [XmlAttribute("angle", DataType = "float")]
        public float _angle;

        /// <summary>
        /// Параметр термобарьера: ширина спицы.
        /// </summary>
        [XmlAttribute("spokeWidth", DataType = "float")]
        public float _spokeWidth;

        /// <summary>
        /// Параметр термобарьера: зазор между контактной площадкой и областью металлизации.
        /// </summary>
        [XmlAttribute("backoff", DataType = "float")]
        public float _backoff;

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _spokeWidth = Ut.UnitsConvert(_spokeWidth, in_units, out_units);
        }
    }

    /// <summary>
    /// Описание детали.
    /// </summary>
    public class Detail
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

        public void Shift(float x, float y)
        {
            switch (_Figure?.GetType().Name)
            {
                case "ArcCCW":
                    ((ArcCCW)_Figure).Shift(x, y);
                    break;
                case "ArcCW":
                    ((ArcCW)_Figure).Shift(x, y);
                    break;
                case "ArcByAngle":
                    ((ArcByAngle)_Figure).Shift(x, y);
                    break;
                case "ArcByMiddle":
                    ((ArcByMiddle)_Figure).Shift(x, y);
                    break;
                case "Circle":
                    ((Circle)_Figure).Shift(x, y);
                    break;
                case "Line":
                    ((Line)_Figure).Shift(x, y);
                    break;
                case "FilledCircle":
                    ((FilledCircle)_Figure).Shift(x, y);
                    break;
                case "Rect":
                    ((Rect)_Figure).Shift(x, y);
                    break;
                case "FilledRect":
                    ((FilledRect)_Figure).Shift(x, y);
                    break;
                case "Polygon":
                    ((Polygon)_Figure).Shift(x, y);
                    break;
                case "FilledContour":
                    ((FilledContour)_Figure).Shift(x, y);
                    break;
            }
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            _lineWidth = Ut.UnitsConvert(_lineWidth, in_units, out_units);
            switch (_Figure?.GetType().Name)
            {
                case "ArcCCW":
                    ((ArcCCW)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "ArcCW":
                    ((ArcCW)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "ArcByAngle":
                    ((ArcByAngle)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "ArcByMiddle":
                    ((ArcByMiddle)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "Circle":
                    ((Circle)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "Line":
                    ((Line)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "FilledCircle":
                    ((FilledCircle)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "Rect":
                    ((Rect)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "FilledRect":
                    ((FilledRect)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "Polygon":
                    ((Polygon)_Figure).UnitsConvert(in_units, out_units);
                    break;
                case "FilledContour":
                    ((FilledContour)_Figure).UnitsConvert(in_units, out_units);
                    break;
            }
        }
    }

    /// <summary>
    /// Описание надписи.
    /// </summary>
    public class Text
    {
        /// <summary>
        /// Параметр надписи: текст надписи.
        /// </summary>
        [XmlAttribute("text")]
        public string _text;

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

        public void Shift(float x, float y)
        {
            _Org?.Shift(x, y);
        }
        /// <summary>
        /// TODO: конвертировать текстовые стили по ссылке
        /// </summary>
        /// <param name="in_units"></param>
        /// <param name="out_units"></param>
        public void UnitsConvert(dist in_units, dist out_units)
        {
            _Org?.UnitsConvert(in_units, out_units);
        }
    }

    /// <summary>
    /// Сигналы воздействия правила
    /// </summary>
    public class ObjectSignal
    {
        [
            XmlElement("SignalRef", typeof(SignalRef)),
            XmlElement("DiffSignalRef", typeof(DiffSignalRef)),
            XmlElement("SignalGroupRef", typeof(SignalGroupRef)),
        ]
        public object _Refs;
    }
    #endregion

    /// <summary>
    /// Различные сервисные функции
    /// </summary>
    public static class Ut
    {
        public static float UnitsConvert(float value, dist in_units, dist out_units)
        {
            double k;
            switch (in_units)
            {
                case dist.mkm:
                    k = 0.001;
                    break;
                case dist.cm:
                    k = 10;
                    break;
                case dist.dm:
                    k = 100;
                    break;
                case dist.m:
                    k = 1000;
                    break;
                case dist.mil:
                    k = 0.0254000000000000002032;
                    break;
                case dist.inch:
                    k = 25.4000000000000002032;
                    break;
                case dist.mm:
                default:
                    k = 1;
                    break;
            }
            switch (out_units)
            {
                case dist.mkm:
                    return (float)(value * k * 1000);
                case dist.cm:
                    return (float)(value * k * 0.1);
                case dist.dm:
                    return (float)(value * k * 0.01);
                case dist.m:
                    return (float)(value * k * 0.001);
                case dist.mil:
                    return (float)(value * k * 39.37007874015748);
                case dist.inch:
                    return (float)(value * k * 0.03937007874015748);
                case dist.mm:
                    return (float)(value * k);
                default:
                    return value;
            }
        }
    }
}
