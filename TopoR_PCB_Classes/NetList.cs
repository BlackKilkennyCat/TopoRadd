/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Текущий список соединений».
    /// </summary>
    public class NetList
    {
        /// <summary>
        /// Раздел «Текущий список соединени
        /// </summary>
        public class Net
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Ссылка на контакт или вывод посадочного места (объект класса PinRef или PadRef).
            /// </summary>
            [
                XmlElement("PinRef", typeof(PinRef)),
                XmlElement("PadRef", typeof(PadRef))
            ]
            public object[] _refs;
        }
        
        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Описания цепей.
        /// </summary>
        [XmlElement("Net")]
        public Net[] _Nets;

    }
}
