/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Раздел «Настройки дизайна».
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Настройки автоматической трассировки.
        /// </summary>
        public class Autoroute
        {
            /// <summary>
            /// Настройка автоматической трассировки: режим трассировки.
            /// </summary>
            [XmlAttribute("mode")]
            public mode_Autoroute _mode;

            /// <summary>
            /// Параметр автоматической трассировки: использование функциональной эквивалентности.
            /// </summary>
            [XmlAttribute("autoEqu")]
            public autoEqu _autoEqu;

            /// <summary>
            /// Параметр автоматической трассировки: форма проводников.
            /// </summary>
            [XmlAttribute("wireShape")]
            public wireShape _wireShape;

            /// <summary>
            /// Параметр автоматической трассировки: создавать «капельки».
            /// </summary>
            [XmlAttribute("teardrops")]
            public Bool _teardrops;
            [XmlIgnore]
            public bool _teardropsSpecified { get { return _teardrops != Bool.off; } }

            /// <summary>
            /// Параметр автоматической трассировки: ослабленный контроль зазоров.
            /// </summary>
            [XmlAttribute("weakCheck")]
            public Bool _weakCheck;
            [XmlIgnore]
            public bool _weakCheckSpecified { get { return _weakCheck != Bool.off; } }

            /// <summary>
            /// Параметр автоматической трассировки: использовать имеющуюся разводку в качестве начального варианта.
            /// </summary>
            [XmlAttribute("takeCurLayout")]
            public Bool _takeCurLayout;
            [XmlIgnore]
            public bool _takeCurLayoutSpecified { get { return _takeCurLayout != Bool.off; } }

            /// <summary>
            /// Настройка автоматической трассировки: соединять планарные контакты напрямую.
            /// </summary>
            [XmlAttribute("directConnectSMD")]
            public Bool _directConnectSMD;
            [XmlIgnore]
            public bool _directConnectSMDSpecified { get { return _directConnectSMD != Bool.off; } }

            /// <summary>
            /// Настройка автоматической трассировки: не дотягивать проводник до точки привязки полигонального контакта.
            /// </summary>
            [XmlAttribute("dontStretchWireToPolypin")]
            public Bool _dontStretchWireToPolypin;
            [XmlIgnore]
            public bool _dontStretchWireToPolypinSpecified { get { return _dontStretchWireToPolypin != Bool.off; } }
        }

        /// <summary>
        /// Настройки автоматических процедур.
        /// </summary>
        public class Autoproc
        {
            /// <summary>
            /// Настройка автоматической перекладки проводников.
            /// </summary>
            [XmlAttribute("refine")]
            public refine _refine;

            /// <summary>
            /// Настройка автоматической подвижки.
            /// </summary>
            [XmlAttribute("automove")]
            public automove _automove;
        }

        /// <summary>
        /// Настройки автоматического размещения компонентов.
        /// </summary>
        public class Placement
        {
            /// <summary>
            /// Настройки автоматического размещения компонентов: область размещения. Область прямоугольная, задаётся двумя вершинами(верхняя левая и правая нижняя).
            /// </summary>
            public class PlacementArea
            {
                /// <summary>
                /// Координаты точек, вершин
                /// </summary>
                [XmlElement("Dot")]
                public Dot _Dots;
            }

            /// <summary>
            /// Настройки автоматического размещения компонентов: область размещения. Область прямоугольная, задаётся двумя вершинами(верхняя левая и правая нижняя).
            /// </summary>
            [XmlElement("PlacementArea")]
            public PlacementArea _PlacementArea;
        }

        /// <summary>
        /// Настройки ориентации ярлыков.
        /// </summary>
        public class Labels_Settings
        {
            /// <summary>
            /// Настройка ориентации ярлыков: вращать ярлык при вращении компонента.
            /// </summary>
            [XmlAttribute("rotateWithComp")]
            public Bool _rotateWithComp;
            [XmlIgnore]
            public bool _rotateWithCompSpecified { get { return _rotateWithComp != Bool.off; } }

            /// <summary>
            /// Настройка редактирования ярлыков: использовать правила ориентации.
            /// </summary>
            [XmlAttribute("useOrientRules")]
            public Bool _useOrientRules;
            [XmlIgnore]
            public bool _useOrientRulesSpecified { get { return _useOrientRules != Bool.off; } }

            /// <summary>
            /// Настройка ориентации ярлыков: поворот для ярлыков горизонтальной ориентации на верхней стороне.
            /// </summary>
            [XmlAttribute("topHorzRotate")]
            public Bool _topHorzRotate;
            [XmlIgnore]
            public bool _topHorzRotateSpecified { get { return _topHorzRotate != Bool.off; } }

            /// <summary>
            /// Настройка ориентации ярлыков: поворот для ярлыков вертикальной ориентации на верхней стороне.
            /// </summary>
            [XmlAttribute("topVertRotate")]
            public Bool _topVertRotate;
            [XmlIgnore]
            public bool _topVertRotateSpecified { get { return _topVertRotate != Bool.off; } }

            /// <summary>
            /// Настройка ориентации ярлыков: поворот для ярлыков горизонтальной ориентации на нижней стороне.
            /// </summary>
            [XmlAttribute("bottomHorzRotate")]
            public Bool _bottomHorzRotate;
            [XmlIgnore]
            public bool _bottomHorzRotateSpecified { get { return _bottomHorzRotate != Bool.off; } }

            /// <summary>
            /// Настройка ориентации ярлыков: поворот для ярлыков вертикальной ориентации на нижней стороне.
            /// </summary>
            [XmlAttribute("bottomVertRotate")]
            public Bool _bottomVertRotate;
            [XmlIgnore]
            public bool _bottomVertRotateSpecified { get { return _bottomVertRotate != Bool.off; } }
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Настройки автоматической трассировки.
        /// </summary>
        [XmlElement("Autoroute")]
        public Autoroute _Autoroute;

        /// <summary>
        /// Настройки автоматических процедур.
        /// </summary>
        [XmlElement("Autoproc")]
        public Autoproc _Autoproc;

        /// <summary>
        /// Настройки автоматического размещения компонентов.
        /// </summary>
        [XmlElement("Placement")]
        public Placement _Placement;

        /// <summary>
        /// Настройки ориентации ярлыков.
        /// </summary>
        [XmlElement("Labels")]
        public Labels_Settings _Labels;
    }
}
