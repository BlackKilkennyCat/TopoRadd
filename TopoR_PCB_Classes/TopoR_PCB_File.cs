/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */


using System.Xml.Serialization;
using TopoR_PCB_Classes;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Корневой тег. Включает все разделы файла.
    /// </summary>
    [XmlRoot("TopoR_PCB_File")]
    public class TopoR_PCB_File
    {
        /// <summary>
        /// Раздел «Заголовок файла».
        /// </summary>
        [XmlElement("Header")]
        public Header _Header;

        /// <summary>
        /// Раздел «Слои». (Обязательный раздел)
        /// </summary>
        [XmlElement("Layers")]
        public Layers _Layers;

        /// <summary>
        /// Раздел «Стили надписей».
        /// </summary>
        [XmlElement("TextStyles")]
        public TextStyles _TextStyles;

        /// <summary>
        /// Раздел «Библиотечные элементы». (Обязательный раздел)
        /// </summary>
        [XmlElement("LocalLibrary")]
        public LocalLibrary _LocalLibrary;

        /// <summary>
        /// Раздел «Конструктив платы».
        /// </summary>
        [XmlElement("Constructive")]
        public Constructive _Constructive;

        /// <summary>
        /// Раздел «Компоненты на плате». (Обязательный раздел).
        /// </summary>
        [XmlElement("ComponentsOnBoard")]
        public ComponentsOnBoard _ComponentsOnBoard;

        /// <summary>
        /// Раздел «Текущий список соединений».
        /// </summary>
        [XmlElement("NetList")]
        public NetList _NetList;

        /// <summary>
        /// Раздел «Группировка объектов».
        /// </summary>
        [XmlElement("Groups")]
        public Groups _Groups;

        /// <summary>
        /// Раздел «Правила для высокоскоростных устройств».
        /// </summary>
        [XmlElement("HiSpeedRules")]
        public HiSpeedRules _HiSpeedRules;

        /// <summary>
        /// Раздел «Правила».
        /// </summary>
        /// <remarks>! Порядок следования правил в каждой секции определяет приоритет правил. Чем выше приоритет у правила, тем ниже оно описано.</remarks>
        [XmlElement("Rules")]
        public Rules _Rules;

        /// <summary>
        /// Раздел «Соединения на плате».
        /// </summary>
        /// <remarks>В этом разделе описывается конкретная реализация соединений: печатные проводники, межслойные переходы и области металлизации.</remarks>
        [XmlElement("Connectivity")]
        public Connectivity _Connectivity;

        /// <summary>
        /// Раздел «Настройки дизайна».
        /// </summary>
        [XmlElement("Settings")]
        public Settings _Settings;

        /// <summary>
        /// Раздел «Настройки отображения».
        /// </summary>

        [XmlElement("DisplayControl")]
        public DisplayControl _DisplayControl;

        /// <summary>
        /// Раздел «Настройки диалогов».
        /// </summary>
        [XmlElement("DialogSettings")]
        public DialogSettings _DialogSettings;
    }
}
