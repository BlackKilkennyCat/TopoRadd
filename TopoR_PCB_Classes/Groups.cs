/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Группировка объектов».
    /// </summary>
    public class Groups
    {
        /// <summary>
        /// Описание групп слоёв.
        /// </summary>
        public class LayerGroup
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Ссылка на слой или ссылка на группу слоёв.
            /// </summary>
            [
                XmlElement("LayerRef", typeof(LayerRef)),
                XmlElement("LayerGroupRef", typeof(LayerGroupRef))
            ]
            public object[] _LayerRefs;
        }

        /// <summary>
        /// Описание группы цепей.
        /// </summary>
        public class NetGroup
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Ссылка на цепь или ссылка на группу цепей.
            /// </summary>
            [
                XmlElement("NetRef", typeof(NetRef)),
                XmlElement("NetGroupRef", typeof(NetGroupRef))
            ]
            public object[] _NetRefs;
        }

        /// <summary>
        /// Описание группы компонентов.
        /// </summary>
        public class CompGroup
        {
            /// <summary>
            /// Имя объекта или ссылка на именованный объект.
            /// </summary>
            [XmlAttribute("name")]
            public string _name;

            /// <summary>
            /// Ссылка на компонент на плате или ссылка на группу компонентов.
            /// </summary>
            [
                XmlElement("CompInstanceRef", typeof(CompInstanceRef)),
                XmlElement("CompGroupRef", typeof(CompGroupRef))
            ]
            public object[] _CompRefs;
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Группы слоёв.
        /// </summary>
        [XmlArray("LayerGroups")]
        [XmlArrayItem("LayerGroup")]
        public LayerGroup[] _LayerGroups;

        /// <summary>
        /// Группы цепей.
        /// </summary>
        [XmlArray("NetGroups")]
        [XmlArrayItem("NetGroup")]
        public NetGroup[] _NetGroups;

        /// <summary>
        /// Группы компонентов.
        /// </summary>
        [XmlArray("CompGroups")]
        [XmlArrayItem("CompGroup")]
        public CompGroup[] _CompGroups;
    }
}
