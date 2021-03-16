/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Стили надписей».
    /// </summary>
    public class TextStyles
    {
        /// <summary>
        /// Описание стиля надписей.
        /// </summary>
        public class TextStyle
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Параметр стиля надписей: название шрифта.
            /// </summary>
            [XmlAttribute("fontName")]
            public string _fontName;

            /// <summary>
            /// Параметр стиля надписей: высота символов в текущих единицах.
            /// </summary>
            [XmlAttribute("height", DataType = "float")]
            public float _height;

            /// <summary>
            /// Параметр стиля надписей: жирность шрифта.
            /// </summary>
            [XmlAttribute("bold")]
            public Bool _bold;
            [XmlIgnore]
            public bool _boldSpecified { get { return _bold != Bool.off; } }

            /// <summary>
            /// Параметр стиля надписей: курсив.
            /// </summary>
            [XmlAttribute("italic")]
            public Bool _italic;
            [XmlIgnore]
            public bool _italicSpecified { get { return _italic != Bool.off; } }
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Стили надписей.
        /// </summary>
        [XmlElement("TextStyle")]
        public TextStyle[] _TextStyles;
    }
}
