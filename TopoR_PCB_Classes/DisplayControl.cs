/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Настройки отображения».
    /// </summary>
    public class DisplayControl
    {
        /// <summary>
        /// Настройка отображения: параметры текущего вида.
        /// </summary>
        public class View
        {
            /// <summary>
            /// Параметр текущего вида: масштаб.
            /// </summary>
            [XmlAttribute("scale", DataType = "float")]
            public float _scale;

            /// <summary>
            /// Параметр текущего вида: прокрутка по горизонтали.
            /// </summary>
            [XmlAttribute("scrollHorz", DataType = "float")]
            public float _scrollHorz;

            /// <summary>
            /// Параметр текущего вида: прокрутка по вертикали.
            /// </summary>
            [XmlAttribute("scrollVert", DataType = "float")]
            public float _scrollVert;
        }

        /// <summary>
        /// Устанавливает активный слой.
        /// </summary>
        public class ActiveLayer
        {
            /// <summary>
            /// Тип слоя.
            /// </summary>
            [XmlAttribute("type")]
            public layer_type _type;

            /// <summary>
            /// Наименование слоя.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;
        }

        /// <summary>
        /// Настройка отображения: единицы измерения.
        /// </summary>
        public class Units_DisplayControl
        {
            /// <summary>
            /// Настройка отображения: единицы измерения.
            /// </summary>
            [XmlAttribute("preference")]
            public preference _preference;
        }

        /// <summary>
        /// Настройка отображения: общие цветовые настройки.
        /// </summary>
        public class Colors_DisplayControl
        {
            /// <summary>
            /// Настройка отображения: текущая цветовая схема.
            /// </summary>
            [XmlAttribute("colorScheme")]
            public string _colorScheme;

            /// <summary>
            /// Настройка отображения: яркость выделенных объектов.
            /// </summary>
            [XmlAttribute("hilightRate", DataType = "int")]
            public int _hilightRate;

            /// <summary>
            /// Настройка отображения: степень затемнения невыделенных объектов.
            /// </summary>
            [XmlAttribute("darkRate", DataType = "int")]
            public int _darkRate;

            /// <summary>
            /// Настройка отображения: цвет фона.
            /// </summary>
            [XmlAttribute("background")]
            public string _background;

            /// <summary>
            /// Настройка отображения: цвет контура платы.
            /// </summary>
            [XmlAttribute("board")]
            public string _board;

            /// <summary>
            /// Настройка отображения: цвет линий связей.
            /// </summary>
            [XmlAttribute("netLines")]
            public string _netLines;

            /// <summary>
            /// Настройка отображения: цвет запрета размещения на обеих сторонах платы.
            /// </summary>
            [XmlAttribute("keepoutPlaceBoth")]
            public string _keepoutPlaceBoth;

            /// <summary>
            /// Настройка отображения: цвет запрета трассировки на всех слоях.
            /// </summary>
            [XmlAttribute("keepoutWireAll")]
            public string _keepoutWireAll;

            /// <summary>
            /// Настройка отображения: цвет запрета размещения на верхней стороне платы.
            /// </summary>
            [XmlAttribute("keepoutPlaceTop")]
            public string _keepoutPlaceTop;

            /// <summary>
            /// Настройка отображения: цвет запрета размещения на нижней стороне платы.
            /// </summary>
            [XmlAttribute("keepoutPlaceBot")]
            public string _keepoutPlaceBot;

            /// <summary>
            /// Настройка отображения: цвет габаритов компонентов.
            /// </summary>
            [XmlAttribute("compsBound")]
            public string _compsBound;

            /// <summary>
            /// Настройка отображения: цвет позиционных обозначений компонентов.
            /// </summary>
            [XmlAttribute("compsName")]
            public string _compsName;

            /// <summary>
            /// Настройка отображения: цвет имён контактов.
            /// </summary>
            [XmlAttribute("pinsName")]
            public string _pinsName;

            /// <summary>
            /// Настройка отображения: цвет имён цепей контактов.
            /// </summary>
            [XmlAttribute("pinsNet")]
            public string _pinsNet;

            /// <summary>
            /// Настройка отображения: цвет сквозных контактных площадок.
            /// </summary>
            [XmlAttribute("clrThroughPads")]
            public string _clrThroughPads;

            /// <summary>
            /// Настройка отображения: цвет сквозных переходных отверстий.
            /// </summary>
            [XmlAttribute("clrThroughVias")]
            public string _clrThroughVias;

            /// <summary>
            /// Настройка отображения: цвет скрытых переходных отверстий.
            /// </summary>
            [XmlAttribute("clrBurriedVias")]
            public string _clrBurriedVias;

            /// <summary>
            /// Настройка отображения: цвет глухих переходных отверстий.
            /// </summary>
            [XmlAttribute("clrBlindVias")]
            public string _clrBlindVias;

            /// <summary>
            /// Настройка отображения: цвет зафиксированных переходных отверстий.
            /// </summary>
            [XmlAttribute("clrFixedVias")]
            public string _clrFixedVias;

            /// <summary>
            /// Настройка отображения: цвет нарушений DRC.
            /// </summary>
            [XmlAttribute("drcViolation")]
            public string _drcViolation;

            /// <summary>
            /// Настройка отображения: цвет индикации уменьшения номинального зазора.
            /// </summary>
            [XmlAttribute("narrow")]
            public string _narrow;

            /// <summary>
            /// Настройка отображения: цвет индикации уменьшения ширины проводника.
            /// </summary>
            [XmlAttribute("trimmed")]
            public string _trimmed;
        }

        /// <summary>
        /// Настройка отображения: настройки видимости объектов.
        /// </summary>
        public class Show_DisplayControl
        {
            /// <summary>
            /// Настройка отображения: текущая схема отображения.
            /// </summary>
            [XmlAttribute("displayScheme")]
            public string _displayScheme;

            /// <summary>
            /// Настройка отображения: показывать контур платы.
            /// </summary>
            [XmlAttribute("showBoardOutline")]
            public Bool _showBoardOutline;
            [XmlIgnore]
            public bool _showBoardOutlineSpecified { get { return _showBoardOutline != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать проводники.
            /// </summary>
            [XmlAttribute("showWires")]
            public Bool _showWires;
            [XmlIgnore]
            public bool _showWiresSpecified { get { return _showWires != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать области металлизации (полигоны).
            /// </summary>
            [XmlAttribute("showCoppers")]
            public Bool _showCoppers;
            [XmlIgnore]
            public bool _showCoppersSpecified { get { return _showCoppers != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать ярлыки (надписи).
            /// </summary>
            [XmlAttribute("showTexts")]
            public Bool _showTexts;
            [XmlIgnore]
            public bool _showTextsSpecified { get { return _showTexts != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать сквозные контактные площадки специальным цветом.
            /// </summary>
            [XmlAttribute("throughPad")]
            public Bool _throughPad;
            [XmlIgnore]
            public bool _throughPadSpecified { get { return _throughPad != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать сквозные переходные отверстия специальным цветом.
            /// </summary>
            [XmlAttribute("throughVia")]
            public Bool _throughVia;
            [XmlIgnore]
            public bool _throughViaSpecified { get { return _throughVia != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать скрытые переходные отверстия специальным цветом
            /// </summary>
            [XmlAttribute("burriedVia")]
            public Bool _burriedVia;
            [XmlIgnore]
            public bool _burriedViaSpecified { get { return _burriedVia != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать глухие переходные отверстия специальным цветом.
            /// </summary>
            [XmlAttribute("blindVia")]
            public Bool _blindVia;
            [XmlIgnore]
            public bool _blindViaSpecified { get { return _blindVia != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать фиксированные переходные отверстия специальным цветом.
            /// </summary>
            [XmlAttribute("fixedVia")]
            public Bool _fixedVia;
            [XmlIgnore]
            public bool _fixedViaSpecified { get { return _fixedVia != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать переходы.
            /// </summary>
            [XmlAttribute("showVias")]
            public Bool _showVias;
            [XmlIgnore]
            public bool _showViasSpecified { get { return _showVias != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать металлические слои.
            /// </summary>
            [XmlAttribute("showSignalLayers")]
            public Bool _showSignalLayers;
            [XmlIgnore]
            public bool _showSignalLayersSpecified { get { return _showSignalLayers != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать верхние механические слои.
            /// </summary>
            [XmlAttribute("showTopMechLayers")]
            public Bool _showTopMechLayers;
            [XmlIgnore]
            public bool _showTopMechLayersSpecified { get { return _showTopMechLayers != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать нижние механические слои.
            /// </summary>
            [XmlAttribute("showBotMechLayers")]
            public Bool _showBotMechLayers;
            [XmlIgnore]
            public bool _showBotMechLayersSpecified { get { return _showBotMechLayers != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать документирующие слои.
            /// </summary>
            [XmlAttribute("showDocLayers")]
            public Bool _showDocLayers;
            [XmlIgnore]
            public bool _showDocLayersSpecified { get { return _showDocLayers != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать детали на верхних металлических слоях.
            /// </summary>
            [XmlAttribute("showTopMechDetails")]
            public Bool _showTopMechDetails;
            [XmlIgnore]
            public bool _showTopMechDetailsSpecified { get { return _showTopMechDetails != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать детали на нижних металлических слоях.
            /// </summary>
            [XmlAttribute("showBotMechDetails")]
            public Bool _showBotMechDetails;
            [XmlIgnore]
            public bool _showBotMechDetailsSpecified { get { return _showBotMechDetails != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать контактные площадки на металлических слоях.
            /// </summary>
            [XmlAttribute("showMetalPads")]
            public Bool _showMetalPads;
            [XmlIgnore]
            public bool _showMetalPadsSpecified { get { return _showMetalPads != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать КП на верхних металлических слоях.
            /// </summary>
            [XmlAttribute("showTopMechPads")]
            public Bool _showTopMechPads;
            [XmlIgnore]
            public bool _showTopMechPadsSpecified { get { return _showTopMechPads != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать контактные площадки на нижних металлических слоях.
            /// </summary>
            [XmlAttribute("showBotMechPads")]
            public Bool _showBotMechPads;
            [XmlIgnore]
            public bool _showBotMechPadsSpecified { get { return _showBotMechPads != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать связи.
            /// </summary>
            [XmlAttribute("showNetLines")]
            public Bool _showNetLines;
            [XmlIgnore]
            public bool _showNetLinesSpecified { get { return _showNetLines != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать монтажные отверстия.
            /// </summary>
            [XmlAttribute("showMountingHoles")]
            public Bool _showMountingHoles;
            [XmlIgnore]
            public bool _showMountingHolesSpecified { get { return _showMountingHoles != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать проводники тонкими линиями.
            /// </summary>
            [XmlAttribute("showThinWires")]
            public Bool _showThinWires;
            [XmlIgnore]
            public bool _showThinWiresSpecified { get { return _showThinWires != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать компоненты.
            /// </summary>
            [XmlAttribute("showComponents")]
            public Bool _showComponents;
            [XmlIgnore]
            public bool _showComponentsSpecified { get { return _showComponents != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать компоненты на верхней стороне.
            /// </summary>
            [XmlAttribute("showCompTop")]
            public Bool _showCompTop;
            [XmlIgnore]
            public bool _showCompTopSpecified { get { return _showCompTop != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать компоненты на нижней стороне.
            /// </summary>
            [XmlAttribute("showCompBot")]
            public Bool _showCompBot;
            [XmlIgnore]
            public bool _showCompBotSpecified { get { return _showCompBot != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать позиционные обозначения компонентов.
            /// </summary>
            [XmlAttribute("showCompsDes")]
            public Bool _showCompsDes;
            [XmlIgnore]
            public bool _showCompsDesSpecified { get { return _showCompsDes != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать имена контактов.
            /// </summary>
            [XmlAttribute("showPinsName")]
            public Bool _showPinsName;
            [XmlIgnore]
            public bool _showPinsNameSpecified { get { return _showPinsName != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать имена цепей контактов.
            /// </summary>
            [XmlAttribute("showPinsNet")]
            public Bool _showPinsNet;
            [XmlIgnore]
            public bool _showPinsNetSpecified { get { return _showPinsNet != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать габариты компонентов.
            /// </summary>
            [XmlAttribute("showCompsBound")]
            public Bool _showCompsBound;
            [XmlIgnore]
            public bool _showCompsBoundSpecified { get { return _showCompsBound != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать ярлыки атрибута RefDes.
            /// </summary>
            [XmlAttribute("showLabelRefDes")]
            public Bool _showLabelRefDes;
            [XmlIgnore]
            public bool _showLabelRefDesSpecified { get { return _showLabelRefDes != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать ярлыки атрибута PartName.
            /// </summary>
            [XmlAttribute("showLabelPartName")]
            public Bool _showLabelPartName;
            [XmlIgnore]
            public bool _showLabelPartNameSpecified { get { return _showLabelPartName != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать ярлыки пользовательских атрибутов.
            /// </summary>
            [XmlAttribute("showLabelOther")]
            public Bool _showLabelOther;
            [XmlIgnore]
            public bool _showLabelOtherSpecified { get { return _showLabelOther != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать нарушения.
            /// </summary>
            [XmlAttribute("showViolations")]
            public Bool _showViolations;
            [XmlIgnore]
            public bool _showViolationsSpecified { get { return _showViolations != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать уменьшение номинального зазора.
            /// </summary>
            [XmlAttribute("showNarrow")]
            public Bool _showNarrow;
            [XmlIgnore]
            public bool _showNarrowSpecified { get { return _showNarrow != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать уменьшение ширины проводника.
            /// </summary>
            [XmlAttribute("showTrimmed")]
            public Bool _showTrimmed;
            [XmlIgnore]
            public bool _showTrimmedSpecified { get { return _showTrimmed != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать нарушение DRC.
            /// </summary>
            [XmlAttribute("showDRCViolations")]
            public Bool _showDRCViolations;
            [XmlIgnore]
            public bool _showDRCViolationsSpecified { get { return _showDRCViolations != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать запреты.
            /// </summary>
            [XmlAttribute("showKeepouts")]
            public Bool _showKeepouts;
            [XmlIgnore]
            public bool _showKeepoutsSpecified { get { return _showKeepouts != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать запреты трассировки.
            /// </summary>
            [XmlAttribute("showRouteKeepouts")]
            public Bool _showRouteKeepouts;
            [XmlIgnore]
            public bool _showRouteKeepoutsSpecified { get { return _showRouteKeepouts != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать запреты размещения.
            /// </summary>
            [XmlAttribute("showPlaceKeepouts")]
            public Bool _showPlaceKeepouts;
            [XmlIgnore]
            public bool _showPlaceKeepoutsSpecified { get { return _showPlaceKeepouts != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать только активный слой.
            /// </summary>
            [XmlAttribute("showActiveLayerOnly")]
            public Bool _showActiveLayerOnly;
            [XmlIgnore]
            public bool _showActiveLayerOnlySpecified { get { return _showActiveLayerOnly != Bool.off; } }

            /// <summary>
            /// Настройка отображения: показывать области змеек.
            /// </summary>
            [XmlAttribute("showSerpentArea")]
            public Bool _showSerpentArea;
            [XmlIgnore]
            public bool _showSerpentAreaSpecified { get { return _showSerpentArea != Bool.off; } }
        }

        /// <summary>
        /// Настройки сетки.
        /// </summary>
        public class Grid
        {
            /// <summary>
            /// Настройка отображения сетки: шаг сетки.
            /// </summary>
            public class GridSpace
            {
                /// <summary>
                /// шаг сетки по горизонтали.
                /// </summary>
                [XmlAttribute("x", DataType = "float")]
                public float _x;

                /// <summary>
                /// шаг сетки по вертикали.
                /// </summary>
                [XmlAttribute("y", DataType = "float")]
                public float _y;
            }

            /// <summary>
            /// Настройка отображения сетки: цвет сетки.
            /// </summary>
            [XmlAttribute("gridColor")]
            public string _gridColor;

            /// <summary>
            /// Настройка отображения сетки: тип сетки.
            /// </summary>
            [XmlAttribute("gridKind")]
            public gridKind _gridKind;

            /// <summary>
            /// Настройка отображения сетки: показывать сетку.
            /// </summary>
            [XmlAttribute("gridShow")]
            public Bool _gridShow;
            [XmlIgnore]
            public bool _gridShowSpecified { get { return _gridShow != Bool.off; } }

            /// <summary>
            /// Настройка ручного редактора: выравнивание на сетку.
            /// </summary>
            [XmlAttribute("alignToGrid")]
            public Bool _alignToGrid;
            [XmlIgnore]
            public bool _alignToGridSpecified { get { return _alignToGrid != Bool.off; } }

            /// <summary>
            /// Настройка ручного редактирования: привязка к углу кратному 45˚.
            /// </summary>
            [XmlAttribute("snapToAngle")]
            public Bool _snapToAngle;
            [XmlIgnore]
            public bool _snapToAngleSpecified { get { return _snapToAngle != Bool.off; } }

            /// <summary>
            /// Настройка отображения сетки: шаг сетки.
            /// </summary>
            [XmlElement("GridSpace")]
            public GridSpace _GridSpace;
        }

        /// <summary>
        /// Настройка отображения: настройки видимости слоя.
        /// </summary>
        public class LayerOptions
        {
            /// <summary>
            /// Настройка отображения: цветовые настройки слоя.
            /// </summary>
            public class Colors_LayerOptions
            {
                /// <summary>
                /// Настройка отображения слоя: цвет деталей, проводников (основной цвет слоя).
                /// </summary>
                [XmlAttribute("details")]
                public string _details;

                /// <summary>
                /// Настройка отображения слоя: цвет контактных площадок.
                /// </summary>
                [XmlAttribute("pads")]
                public string _pads;

                /// <summary>
                /// Настройка отображения слоя: цвет зафиксированных объектов.
                /// </summary>
                [XmlAttribute("fix")]
                public string _fix;
            }

            /// <summary>
            /// Настройка отображения слоя: настройки видимости.
            /// </summary>
            public class Show_LayerOptions
            {
                /// <summary>
                /// Флаг видимости.
                /// </summary>
                [XmlAttribute("visible")]
                public Bool _visible;
                [XmlIgnore]
                public bool _visibleSpecified { get { return _visible != Bool.off; } }

                /// <summary>
                /// Настройка отображения слоя: видимость деталей.
                /// </summary>
                [XmlAttribute("details")]
                public Bool _details;
                [XmlIgnore]
                public bool _detailsSpecified { get { return _details != Bool.off; } }

                /// <summary>
                /// Настройка отображения слоя: видимость контактных площадок.
                /// </summary>
                [XmlAttribute("pads")]
                public Bool _pads;
                [XmlIgnore]
                public bool _padsSpecified { get { return _pads != Bool.off; } }
            }

            /// <summary>
            /// Ссылка на слой.
            /// </summary>
            [XmlElement("LayerRef")]
            public LayerRef _LayerRef;

            /// <summary>
            /// Настройка отображения: цветовые настройки слоя.
            /// </summary>
            [XmlElement("Colors")]
            public Colors_LayerOptions _Colors;

            /// <summary>
            /// Настройка отображения слоя: настройки видимости.
            /// </summary>
            [XmlElement("Show")]
            public Show_LayerOptions _Show;
        }

        /// <summary>
        /// Отображение цепей особым цветом.
        /// </summary>
        public class ColorNets
        {
            /// <summary>
            /// Отображение цепей особым цветом: установить цвет для цепи / сигнала / группы цепей / группы сигналов.
            /// </summary>
            public class SetColor
            {
                /// <summary>
                /// Отображение цепей особым цветом: задание цвета.
                /// </summary>
                [XmlAttribute("color")]
                public string _color;

                /// <summary>
                /// Ссылка на цепь или сигнал
                /// </summary>
                [
                    XmlElement("NetRef", typeof(NetRef)),
                    XmlElement("NetGroupRef", typeof(NetGroupRef)),
                    XmlElement("AllNets", typeof(AllNets)),
                    XmlElement("SignalRef", typeof(SignalRef)),
                    XmlElement("DiffSignalRef", typeof(DiffSignalRef)),
                    XmlElement("SignalGroupRef", typeof(SignalGroupRef)),
                ]
                public object _Refs;
            }

            /// <summary>
            /// Флаг применения правила.
            /// </summary>
            [XmlAttribute("enabled")]
            public Bool _enabled;
            [XmlIgnore]
            public bool _enabledSpecified { get { return _enabled != Bool.off; } }

            /// <summary>
            /// Отображение цепей особым цветом: применять для проводников.
            /// </summary>
            [XmlAttribute("colorizeWire")]
            public Bool _colorizeWire;
            [XmlIgnore]
            public bool _colorizeWireSpecified { get { return _colorizeWire != Bool.off; } }

            /// <summary>
            /// Отображение цепей особым цветом: применять для контактных площадок.
            /// </summary>
            [XmlAttribute("colorizePad")]
            public Bool _colorizePad;
            [XmlIgnore]
            public bool _colorizePadSpecified { get { return _colorizePad != Bool.off; } }

            /// <summary>
            /// Отображение цепей особым цветом: применять для областей металлизации.
            /// </summary>
            [XmlAttribute("colorizeCopper")]
            public Bool _colorizeCopper;
            [XmlIgnore]
            public bool _colorizeCopperSpecified { get { return _colorizeCopper != Bool.off; } }

            /// <summary>
            /// Отображение цепей особым цветом: применять для переходов.
            /// </summary>
            [XmlAttribute("colorizeVia")]
            public Bool _colorizeVia;
            [XmlIgnore]
            public bool _colorizeViaSpecified { get { return _colorizeVia != Bool.off; } }

            /// <summary>
            /// Отображение цепей особым цветом: применять для связей.
            /// </summary>
            [XmlAttribute("colorizeNetline")]
            public Bool _colorizeNetline;
            [XmlIgnore]
            public bool _colorizeNetlineSpecified { get { return _colorizeNetline != Bool.off; } }

            /// <summary>
            /// Отображение цепей особым цветом: установить цвет для цепи / сигнала / группы цепей / группы сигналов.
            /// </summary>
            [XmlElement("SetColor")]
            public SetColor[] _SetColors;
        }

        /// <summary>
        /// Фильтр отображения связей.
        /// </summary>
        public class FilterNetlines
        {
            /// <summary>
            /// Флаг применения правила.
            /// </summary>
            [XmlAttribute("enabled")]
            public Bool _enabled;
            [XmlIgnore]
            public bool _enabledSpecified { get { return _enabled != Bool.off; } }

            /// <summary>
            /// Ссылки на цепь или сигнал
            /// </summary>
            [
                XmlElement("NetRef", typeof(NetRef)),
                XmlElement("NetGroupRef", typeof(NetGroupRef)),
                XmlElement("AllNets", typeof(AllNets)),
                XmlElement("SignalRef", typeof(SignalRef)),
                XmlElement("DiffSignalRef", typeof(DiffSignalRef)),
                XmlElement("SignalGroupRef", typeof(SignalGroupRef)),
            ]
            public object[] _Refs;
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Настройка отображения: параметры текущего вида.
        /// </summary>
        [XmlElement("View")]
        public View _View;

        /// <summary>
        /// Устанавливает активный слой.
        /// </summary>
        [XmlElement("ActiveLayer")]
        public ActiveLayer _ActiveLayer;

        /// <summary>
        /// Настройка отображения: единицы измерения.
        /// </summary>
        [XmlElement("Units")]
        public Units_DisplayControl _Units;

        /// <summary>
        /// Настройка отображения: общие цветовые настройки.
        /// </summary>
        [XmlElement("Colors")]
        public Colors_DisplayControl _Colors;

        /// <summary>
        ///  Настройка отображения: настройки видимости объектов.
        /// </summary>
        [XmlElement("Show")]
        public Show_DisplayControl _Show;

        /// <summary>
        ///  Настройки сетки.
        /// </summary>
        [XmlElement("Grid")]
        public Grid _Grid;

        /// <summary>
        /// Настройка отображения: настройки видимости слоёв.
        /// </summary>
        [XmlArray("LayersVisualOptions")]
        [XmlArrayItem("LayerOptions")]
        public LayerOptions[] _LayersVisualOptions;

        /// <summary>
        /// Отображение цепей особым цветом.
        /// </summary>
        [XmlElement("ColorNets")]
        public ColorNets _ColorNets;
        
        /// <summary>
        /// Фильтр отображения связей.
        /// </summary>
        [XmlElement("FilterNetlines")]
        public FilterNetlines _FilterNetlines;
    }
}
