/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Настройки диалогов».
    /// </summary>
    public class DialogSettings
    {
        /// <summary>
        /// Настройки DRC.
        /// </summary>
        public class DRCSettings
        {
            /// <summary>
            /// Настройка DRC: выводить отчёт в указанный файл.
            /// </summary
            [XmlAttribute("createLog")]
            public Bool _createLog;
            [XmlIgnore]
            public bool _createLogSpecified { get { return _createLog != Bool.off; } }

            /// <summary>
            /// Настройка DRC: файл для вывода отчета.
            /// </summary
            [XmlAttribute("logFileName")]
            public string _logFileName;

            /// <summary>
            /// Настройка DRC: максимальное количество сообщений.
            /// </summary
            [XmlAttribute("messageLimit", DataType = "int")]
            public int _messageLimit;

            /// <summary>
            /// Настройка DRC: допуск.
            /// </summary
            [XmlAttribute("tolerance", DataType = "float")]
            public float _tolerance;

            /// <summary>
            /// Настройка DRC: проверка целостности цепей.
            /// </summary
            [XmlAttribute("checkNetIntegrity")]
            public Bool _checkNetIntegrity;
            [XmlIgnore]
            public bool _checkNetIntegritySpecified { get { return _checkNetIntegrity != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверка ширины проводников.
            /// </summary
            [XmlAttribute("checkNetWidth")]
            public Bool _checkNetWidth;
            [XmlIgnore]
            public bool _checkNetWidthSpecified { get { return _checkNetWidth != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверка зазоров.
            /// </summary
            [XmlAttribute("checkClearances")]
            public Bool _checkClearances;
            [XmlIgnore]
            public bool _checkClearancesSpecified { get { return _checkClearances != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между надписями и областями металлизации (полигонами).
            /// </summary
            [XmlAttribute("textToCopper")]
            public Bool _textToCopper;
            [XmlIgnore]
            public bool _textToCopperSpecified { get { return _textToCopper != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между надписями и запретами.
            /// </summary
            [XmlAttribute("textToKeepout")]
            public Bool _textToKeepout;
            [XmlIgnore]
            public bool _textToKeepoutSpecified { get { return _textToKeepout != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между надписями и переходными отверстиями.
            /// </summary
            [XmlAttribute("textToVia")]
            public Bool _textToVia;
            [XmlIgnore]
            public bool _textToViaSpecified { get { return _textToVia != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между надписями и проводниками.
            /// </summary
            [XmlAttribute("textToWire")]
            public Bool _textToWire;
            [XmlIgnore]
            public bool _textToWireSpecified { get { return _textToWire != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между надписями и контактными площадками.
            /// </summary
            [XmlAttribute("textToPad")]
            public Bool _textToPad;
            [XmlIgnore]
            public bool _textToPadSpecified { get { return _textToPad != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры от надписей до края платы.
            /// </summary
            [XmlAttribute("textToBoard")]
            public Bool _textToBoard;
            [XmlIgnore]
            public bool _textToBoardSpecified { get { return _textToBoard != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазор между полигонами.
            /// </summary
            [XmlAttribute("copperToCopper")]
            public Bool _copperToCopper;
            [XmlIgnore]
            public bool _copperToCopperSpecified { get { return _copperToCopper != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазор между полигонами и запретами.
            /// </summary
            [XmlAttribute("copperToKeepout")]
            public Bool _copperToKeepout;
            [XmlIgnore]
            public bool _copperToKeepoutSpecified { get { return _copperToKeepout != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазор между полигонами и проводниками.
            /// </summary
            [XmlAttribute("copperToWire")]
            public Bool _copperToWire;
            [XmlIgnore]
            public bool _copperToWireSpecified { get { return _copperToWire != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазор между полигонами и переходными отверстиями.
            /// </summary
            [XmlAttribute("copperToVia")]
            public Bool _copperToVia;
            [XmlIgnore]
            public bool _copperToViaSpecified { get { return _copperToVia != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазор между полигонами и контактными площадками.
            /// </summary
            [XmlAttribute("copperToPad")]
            public Bool _copperToPad;
            [XmlIgnore]
            public bool _copperToPadSpecified { get { return _copperToPad != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазор между полигонами и краем платы.
            /// </summary
            [XmlAttribute("copperToBoard")]
            public Bool _copperToBoard;
            [XmlIgnore]
            public bool _copperToBoardSpecified { get { return _copperToBoard != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между проводниками и запретами.
            /// </summary
            [XmlAttribute("wireToKeepout")]
            public Bool _wireToKeepout;
            [XmlIgnore]
            public bool _wireToKeepoutSpecified { get { return _wireToKeepout != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между переходными отверстиями и запретами.
            /// </summary
            [XmlAttribute("viaToKeepout")]
            public Bool _viaToKeepout;
            [XmlIgnore]
            public bool _viaToKeepoutSpecified { get { return _viaToKeepout != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверка зазоров между контактными площадками и запретами.
            /// </summary
            [XmlAttribute("padToKeepout")]
            public Bool _padToKeepout;
            [XmlIgnore]
            public bool _padToKeepoutSpecified { get { return _padToKeepout != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между проводниками.
            /// </summary
            [XmlAttribute("wireToWire")]
            public Bool _wireToWire;
            [XmlIgnore]
            public bool _wireToWireSpecified { get { return _wireToWire != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между проводниками и переходными отверстиями.
            /// </summary
            [XmlAttribute("wireToVia")]
            public Bool _wireToVia;
            [XmlIgnore]
            public bool _wireToViaSpecified { get { return _wireToVia != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между проводниками и контактными площадками.
            /// </summary
            [XmlAttribute("wireToPad")]
            public Bool _wireToPad;
            [XmlIgnore]
            public bool _wireToPadSpecified { get { return _wireToPad != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры от проводников до края платы.
            /// </summary
            [XmlAttribute("wireToBoard")]
            public Bool _wireToBoard;
            [XmlIgnore]
            public bool _wireToBoardSpecified { get { return _wireToBoard != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между переходными отверстиями.
            /// </summary
            [XmlAttribute("viaToVia")]
            public Bool _viaToVia;
            [XmlIgnore]
            public bool _viaToViaSpecified { get { return _viaToVia != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры между переходными отверстиями и контактными площадками.
            /// </summary
            [XmlAttribute("viaToPad")]
            public Bool _viaToPad;
            [XmlIgnore]
            public bool _viaToPadSpecified { get { return _viaToPad != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверять зазоры от переходных отверстий до края платы.
            /// </summary
            [XmlAttribute("viaToBoard")]
            public Bool _viaToBoard;
            [XmlIgnore]
            public bool _viaToBoardSpecified { get { return _viaToBoard != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверка зазоров между контактными площадками.
            /// </summary
            [XmlAttribute("padToPad")]
            public Bool _padToPad;
            [XmlIgnore]
            public bool _padToPadSpecified { get { return _padToPad != Bool.off; } }

            /// <summary>
            /// Настройка DRC: проверка зазоров между контактными площадками и краем платы.
            /// </summary
            [XmlAttribute("padToBoard")]
            public Bool _padToBoard;
            [XmlIgnore]
            public bool _padToBoardSpecified { get { return _padToBoard != Bool.off; } }
        }

        /// <summary>
        /// Настройки вывода файлов Gerber.
        /// </summary>
        public class GerberSettings
        {
            /// <summary>
            /// Настройки вывода файла Gerber.
            /// </summary>
            public class ExportFile_GerberSettings
            {
                /// <summary>
                /// Настройка экспорта Gerber файлов: список экспортируемых объектов для слоя.
                /// </summary>
                public class ExportObjects_ExportFile
                {
                    /// <summary>
                    /// Настройка вывода файла Gerber: выводить контур платы.
                    /// </summary
                    [XmlAttribute("board")]
                    public Bool _board;

                    /// <summary>
                    /// Настройка вывода файлов Geber, DXF: выводить проводники.
                    /// </summary
                    [XmlAttribute("wires")]
                    public Bool _wires;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить области металлизации (полигоны).
                    /// </summary
                    [XmlAttribute("coppers")]
                    public Bool _coppers;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить контактные площадки.
                    /// </summary
                    [XmlAttribute("padstacks")]
                    public Bool _padstacks;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить переходные отверстия.
                    /// </summary
                    [XmlAttribute("vias")]
                    public Bool _vias;

                    /// <summary>
                    /// Настройка вывода файлов Gerber и DXF: выводить надписи.
                    /// </summary
                    [XmlAttribute("texts")]
                    public Bool _texts;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить ярлыки.
                    /// </summary
                    [XmlAttribute("labels")]
                    public Bool _labels;

                    /// <summary>
                    /// Настройка вывода файлов Gerber: выводить детали на механических слоях.
                    /// </summary
                    [XmlAttribute("details")]
                    public Bool _details;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить реперные знаки.
                    /// </summary
                    /// <remarks>! В TopoR реперные знаки не поддерживаются.</remarks>
                    [XmlAttribute("fiducials")]
                    public Bool _fiducials;
                }

                /// <summary>
                /// Имя экспортируемого файла Gerber, Drill.
                /// </summary
                /// <remarks>! Имя не должно содержать путь к файлу.</remarks>
                [XmlAttribute("fileName")]
                public string _fileName;

                /// <summary>
                /// Настройка вывода файла Gerber: выводить файл.
                /// </summary
                [XmlAttribute("output")]
                public Bool _output;

                /// <summary>
                /// Настройка вывода файла Gerber: вывод слоя в зеркальном отображении.
                /// </summary
                [XmlAttribute("mirror")]
                public Bool _mirror;

                /// <summary>
                /// Настройка вывода файлов Gerber: инверсный вывод слоя.
                /// </summary
                [XmlAttribute("negative")]
                public Bool _negative;

                /// <summary>
                /// Ссылка на слой.
                /// </summary>
                [XmlElement("LayerRef")]
                public LayerRef _LayerRef;

                /// <summary>
                /// Настройка экспорта Gerber файлов: список экспортируемых объектов для слоя.
                /// </summary>
                [XmlElement("ExportObjects")]
                public ExportObjects_ExportFile _ExportObjects;

                /// <summary>
                /// Настройка вывода файла Gerber: смещение объектов по осям x и y.
                /// </summary>
                [XmlElement("Shift")]
                public Shift _Shift;
            }

            /// <summary>
            /// Каталог для выходных файлов (Gerber, Drill).
            /// </summary
            [XmlAttribute("outPath")]
            public string _outPath;

            /// <summary>
            /// Настройка вывода файлов Gerber, DXF, Drill: единицы измерения.
            /// </summary
            [XmlAttribute("units")]
            public units _units;

            /// <summary>
            /// Настройка вывода чисел в файлы Gerber, Drill: количество цифр перед запятой.
            /// </summary
            [XmlAttribute("intNums", DataType = "int")]
            public int _intNums;

            /// <summary>
            /// Настройка вывода чисел в файлы Gerber, Drill: количество цифр после запятой.
            /// </summary
            [XmlAttribute("fractNums", DataType = "int")]
            public int _fractNums;

            /// <summary>
            /// Настройки вывода файлов Gerber.
            /// </summary>
            [XmlElement("ExportFile")]
            public ExportFile_GerberSettings[] _ExportFiles;
        }

        /// <summary>
        /// Настройки вывода файла DXF.
        /// </summary>
        public class DXFSettings
        {
            /// <summary>
            /// Настройки вывода слоя в файл DXF.
            /// </summary> 
            public class ExportLayer
            {
                /// <summary>
                /// Настройка экспорта слоя в файл DXF: список экспортируемых объектов для слоя.
                /// </summary>
                public class ExportObjects_ExportLayer
                {

                    /// <summary>
                    /// Настройка вывода файлов Geber, DXF: выводить проводники.
                    /// </summary
                    [XmlAttribute("wires")]
                    public Bool _wires;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить области металлизации (полигоны).
                    /// </summary
                    [XmlAttribute("coppers")]
                    public Bool _coppers;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить контактные площадки.
                    /// </summary
                    [XmlAttribute("padstacks")]
                    public Bool _padstacks;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить переходные отверстия.
                    /// </summary
                    [XmlAttribute("vias")]
                    public Bool _vias;

                    /// <summary>
                    /// Настройка вывода файлов Gerber и DXF: выводить надписи.
                    /// </summary
                    [XmlAttribute("texts")]
                    public Bool _texts;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить ярлыки.
                    /// </summary
                    [XmlAttribute("labels")]
                    public Bool _labels;

                    /// <summary>
                    /// Настройка вывода файлов Gerber: выводить детали на механических слоях.
                    /// </summary
                    [XmlAttribute("details")]
                    public Bool _details;

                    /// <summary>
                    /// Настройка вывода слоя в файл DXF: выводить очертания компонентов.
                    /// </summary
                    [XmlAttribute("compsOutline")]
                    public Bool _compsOutline;

                    /// <summary>
                    /// Настройка вывода файлов Gerber, DXF: выводить реперные знаки.
                    /// </summary
                    /// <remarks>! В TopoR реперные знаки не поддерживаются.</remarks>
                    [XmlAttribute("fiducials")]
                    public Bool _fiducials;
                }

                /// <summary>
                /// Настройка вывода слоя в файл DXF: выводить слой.
                /// </summary>
                [XmlAttribute("output")]
                public Bool _output;

                /// <summary>
                /// Ссылка на слой.
                /// </summary>
                [XmlElement("LayerRef")]
                public LayerRef _LayerRef;

                /// <summary>
                /// Настройка экспорта слоя в файл DXF: список экспортируемых объектов для слоя.
                /// </summary>
                [XmlElement("ExportObjects")]
                public ExportObjects_ExportLayer _ExportObjects;

            }

            /// <summary>
            /// Имя выходного файла (ВОМ, DXF).
            /// </summary>
            [XmlAttribute("outFile")]
            public string _outFile;

            /// <summary>
            /// Настройка вывода файлов Gerber, DXF, Drill: единицы измерения.
            /// </summary>
            [XmlAttribute("units")]
            public units _units;

            /// <summary>
            /// Настройка вывода файла DXF: выводить слой с контуром платы.
            /// </summary>
            [XmlAttribute("outputBoardLayer")]
            public Bool _outputBoardLayer;
            [XmlIgnore]
            public bool _outputBoardLayerSpecified { get { return _outputBoardLayer != Bool.off; } }

            /// <summary>
            /// Настройка вывода файла DXF: выводить слой отверстий.
            /// </summary>
            [XmlAttribute("outputDrillLayer")]
            public Bool _outputDrillLayer;
            [XmlIgnore]
            public bool _outputDrillLayerSpecified { get { return _outputDrillLayer != Bool.off; } }

            /// <summary>
            /// Настройки вывода слоя в файл DXF.
            /// </summary>
            [XmlElement("ExportLayer")]
            public ExportLayer[] _ExportLayers;
        }

        /// <summary>
        /// Настройки вывода файлов Drill.
        /// </summary>
        public class DrillSettings
        {
            /// <summary>
            /// Настройки вывода файла Gerber.
            /// </summary>
            public class ExportFile_DrillSettings
            {               
                /// <summary>
                /// Имя экспортируемого файла Gerber, Drill.
                /// </summary
                /// <remarks>! Имя не должно содержать путь к файлу.</remarks>
                [XmlAttribute("fileName")]
                public string _fileName;
            }

            /// <summary>
            /// Каталог для выходных файлов (Gerber, Drill).
            /// </summary
            [XmlAttribute("outPath")]
            public string _outPath;

            /// <summary>
            /// Настройка вывода файлов Gerber, DXF, Drill: единицы измерения.
            /// </summary
            [XmlAttribute("units")]
            public units _units;

            /// <summary>
            /// Настройка вывода чисел в файлы Gerber, Drill: количество цифр перед запятой.
            /// </summary
            [XmlAttribute("intNums", DataType = "int")]
            public int _intNums;

            /// <summary>
            /// Настройка вывода чисел в файлы Gerber, Drill: количество цифр после запятой.
            /// </summary
            [XmlAttribute("fractNums", DataType = "int")]
            public int _fractNums;

            /// <summary>
            /// Настройки вывода файлов Gerber.
            /// </summary>
            [XmlElement("ExportFile")]
            public ExportFile_DrillSettings[] _ExportFiles;
        }

        /// <summary>
        /// Настройки вывода BOM файла.
        /// </summary>
        public class BOMSettings
        {
            /// <summary>
            /// Имя выходного файла (ВОМ, DXF).
            /// </summary>
            [XmlAttribute("outFile")]
            public string _outFile;

            /// <summary>
            /// Настройка диалога вывода BOM файла: выводить количество компонентов.
            /// </summary>
            [XmlAttribute("count")]
            public Bool _count;
            [XmlIgnore]
            public bool _countSpecified { get { return _count != Bool.off; } }

            /// <summary>
            /// Настройка вывода BOM файла: выводить наименование компонентов.
            /// </summary>
            [XmlAttribute("partName")]
            public Bool _partName;
            [XmlIgnore]
            public bool _partNameSpecified { get { return _partName != Bool.off; } }

            /// <summary>
            /// Настройка вывода BOM файла: выводить наименование посадочных мест.
            /// </summary>
            [XmlAttribute("footprint")]
            public Bool _footprint;
            [XmlIgnore]
            public bool _footprintSpecified { get { return _footprint != Bool.off; } }

            /// <summary>
            /// Настройка вывода BOM файла: выводить позиционные обозначения компонентов.
            /// </summary>
            [XmlAttribute("refDes")]
            public Bool _refDes;
            [XmlIgnore]
            public bool _refDesSpecified { get { return _refDes != Bool.off; } }

            /// <summary>
            /// Ссылка на атрибут.
            /// </summary>
            [XmlElement("AttributeRef")]
            public AttributeRef[] _AttributeRefs;

        }

        /// <summary>
        /// Настройка фильтра сообщений.
        /// </summary>
        public class MessagesFilter
        {
            /// <summary>
            /// Настройка фильтра сообщений: режим показа предупреждений.
            /// </summary>
            [XmlAttribute("showWarnings")]
            public showWarnings _showWarnings;

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5003.
            /// </summary>
            [XmlAttribute("W5003")]
            public Bool _W5003;
            [XmlIgnore]
            public bool _W5003Specified { get { return _W5003 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5012.
            /// </summary>
            [XmlAttribute("W5012")]
            public Bool _W5012;
            [XmlIgnore]
            public bool _W5012Specified { get { return _W5012 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5013.
            /// </summary>
            [XmlAttribute("W5013")]
            public Bool _W5013;
            [XmlIgnore]
            public bool _W5013Specified { get { return _W5013 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5014.
            /// </summary>
            [XmlAttribute("W5014")]
            public Bool _W5014;
            [XmlIgnore]
            public bool _W5014Specified { get { return _W5014 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5015.
            /// </summary>
            [XmlAttribute("W5015")]
            public Bool _W5015;
            [XmlIgnore]
            public bool _W5015Specified { get { return _W5015 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5016.
            /// </summary>
            [XmlAttribute("W5016")]
            public Bool _W5016;
            [XmlIgnore]
            public bool _W5016Specified { get { return _W5016 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5017.
            /// </summary>
            [XmlAttribute("W5017")]
            public Bool _W5017;
            [XmlIgnore]
            public bool _W5017Specified { get { return _W5017 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5018.
            /// </summary>
            [XmlAttribute("W5018")]
            public Bool _W5018;
            [XmlIgnore]
            public bool _W5018Specified { get { return _W5018 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5023.
            /// </summary>
            [XmlAttribute("W5023")]
            public Bool _W5023;
            [XmlIgnore]
            public bool _W5023Specified { get { return _W5023 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5024.
            /// </summary>
            [XmlAttribute("W5024")]
            public Bool _W5024;
            [XmlIgnore]
            public bool _W5024Specified { get { return _W5024 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5026.
            /// </summary>
            [XmlAttribute("W5026")]
            public Bool _W5026;
            [XmlIgnore]
            public bool _W5026Specified { get { return _W5026 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5034.
            /// </summary>
            [XmlAttribute("W5034")]
            public Bool _W5034;
            [XmlIgnore]
            public bool _W5034Specified { get { return _W5034 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5036.
            /// </summary>
            [XmlAttribute("W5036")]
            public Bool _W5036;
            [XmlIgnore]
            public bool _W5036Specified { get { return _W5036 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: выводить сообщение 5037.
            /// </summary>
            [XmlAttribute("W5037")]
            public Bool _W5037;
            [XmlIgnore]
            public bool _W5037Specified { get { return _W5037 != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: быстрая проверка зазоров между компонентами.
            /// </summary>
            [XmlAttribute("WClrnBtwComps")]
            public Bool _WClrnBtwComps;
            [XmlIgnore]
            public bool _WClrnBtwCompsSpecified { get { return _WClrnBtwComps != Bool.off; } }

            /// <summary>
            /// Настройка фильтра сообщений: быстрая проверка зазоров между объектами одной цепи.
            /// </summary>
            [XmlAttribute("WClrnBtwObjSameNet")]
            public Bool _WClrnBtwObjSameNet;
            [XmlIgnore]
            public bool _WClrnBtwObjSameNetSpecified { get { return _WClrnBtwObjSameNet != Bool.off; } }
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Настройки DRC.
        /// </summary>
        [XmlElement("DRCSettings")]
        public DRCSettings _DRCSettings;

        /// <summary>
        /// Настройки вывода файлов Gerber.
        /// </summary>
        [XmlElement("GerberSettings")]
        public GerberSettings _GerberSettings;

        /// <summary>
        /// Настройки вывода файла DXF.
        /// </summary>
        [XmlElement("DXFSettings")]
        public DXFSettings _DXFSettings;

        /// <summary>
        /// Настройки вывода файлов Drill.
        /// </summary>
        [XmlElement("DrillSettings")]
        public DrillSettings _DrillSettings;

        /// <summary>
        /// Настройки вывода BOM файла.
        /// </summary>
        [XmlElement("BOMSettings")]
        public BOMSettings _BOMSettings;

        /// <summary>
        /// Настройка фильтра сообщений.
        /// </summary>
        [XmlElement("MessagesFilter")]
        public MessagesFilter _MessagesFilter;
    }
}
