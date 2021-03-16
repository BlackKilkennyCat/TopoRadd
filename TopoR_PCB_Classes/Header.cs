/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Заголовок файла».
    /// </summary>
    public class Header
    {
        /// <summary>
        /// Единицы измерений для всего файла.
        /// </summary>
        public class Units_Header
        {
            /// <summary>
            /// Единицы измерения длины для всего файла. Значение по умолчанию – mm (миллиметр).
            /// </summary>
            [XmlAttribute("dist")]
            public dist _dist;

            /// <summary>
            /// Единицы измерения времени для всего файла. Значение по умолчанию – ps (пикосекунда).
            /// </summary>
            [XmlAttribute("time")]
            public time _time;
        }
        /// <summary>
        /// Название формата файла.
        /// </summary>
       
        [XmlElement("Format")]
        public string _Format;

        /// <summary>
        /// Версия формата.
        /// </summary>
        [XmlElement("Version")]
        public string _Version;

        /// <summary>
        /// Название программы, создавшей файл.
        /// </summary>
        [XmlElement("Program")]
        public string _Program;

        /// <summary>
        /// Дата и время создания файла (в произвольной форме).
        /// </summary>
        [XmlElement("Date")]
        public string _Date;

        /// <summary>
        /// Формат импортированного файла, из которого был получен дизайн.
        /// </summary>
        [XmlElement("OriginalFormat")]
        public string _OriginalFormat;

        /// <summary>
        /// Импортированный файл. Путь к файлу задаётся относительно каталога содержащего файл проекта.
        /// </summary>
        [XmlElement("OriginalFile")]
        public string _OriginalFile;

        /// <summary>
        /// Единицы измерения для всего файла.
        /// </summary>
        [XmlElement("Units")]
        public Units_Header _Units;
    }
}
