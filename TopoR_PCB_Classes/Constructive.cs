/* Мною, Константином aka KilkennyCat, 05 июля 2020 года создано сиё 
 * на основе "Описание формата TopoR PCB версия 1.2.0 Апрель 2017 г.".
 * k@kilkenny.pro
 * http://kilkennycat.ru  http://kilkenny.pro
 */

using System;
using System.Xml.Serialization;

namespace TopoR_PCB_Classes
{
    /// <summary>
    /// Описание конструктива платы.
    /// </summary>
    public class Constructive
    {
        /// <summary>
        /// Описание контура платы и вырезов в плате.
        /// </summary>
        public class BoardOutline
        {
            public class Shape_Contour
            {

                /// <summary>
                /// Толщина линии.
                /// </summary>
                [XmlAttribute("lineWidth", DataType = "float")]
                public float _lineWidth;

                /// <summary>
                /// Незалитая фигура.
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
                public object _NonfilledFigure;
                
                public void Shift(float x, float y)
                {
                    switch (_NonfilledFigure?.GetType().Name)
                    {
                        case "ArcCCW":
                            ((ArcCCW)_NonfilledFigure).Shift(x, y);
                            break;
                        case "ArcCW":
                            ((ArcCW)_NonfilledFigure).Shift(x, y);
                            break;
                        case "ArcByAngle":
                            ((ArcByAngle)_NonfilledFigure).Shift(x, y);
                            break;
                        case "ArcByMiddle":
                            ((ArcByMiddle)_NonfilledFigure).Shift(x, y);
                            break;
                        case "Circle":
                            ((Circle)_NonfilledFigure).Shift(x, y);
                            break;
                        case "Line":
                            ((Line)_NonfilledFigure).Shift(x, y);
                            break;
                        case "Polyline":
                            ((Polyline)_NonfilledFigure).Shift(x, y);
                            break;
                        case "Rect":
                            ((Rect)_NonfilledFigure).Shift(x, y);
                            break;
                        case "Contour":
                            ((Contour)_NonfilledFigure).Shift(x, y);
                            break;
                    }
                }
                public void UnitsConvert(dist in_units, dist out_units)
                {
                    _lineWidth = Ut.UnitsConvert(_lineWidth, in_units, out_units);

                    switch (_NonfilledFigure?.GetType().Name)
                    {
                        case "ArcCCW":
                            ((ArcCCW)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "ArcCW":
                            ((ArcCW)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "ArcByAngle":
                            ((ArcByAngle)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "ArcByMiddle":
                            ((ArcByMiddle)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "Circle":
                            ((Circle)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "Line":
                            ((Line)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "Polyline":
                            ((Polyline)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "Rect":
                            ((Rect)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "Contour":
                            ((Contour)_NonfilledFigure).UnitsConvert(in_units, out_units);
                            break;
                    }
                }
            }

            public class Shape_Voids
            {

                /// <summary>
                /// Толщина линии.
                /// </summary>
                [XmlAttribute("lineWidth", DataType = "float")]
                public float _lineWidth;

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

                public void Shift(float x, float y)
                {
                    switch (_FilledFigure?.GetType().Name)
                    {
                        case "FilledCircle":
                            ((FilledCircle)_FilledFigure).Shift(x, y);
                            break;
                        case "FilledRect":
                            ((FilledRect)_FilledFigure).Shift(x, y);
                            break;
                        case "Polygon":
                            ((Polygon)_FilledFigure).Shift(x, y);
                            break;
                        case "FilledContour":
                            ((FilledContour)_FilledFigure).Shift(x, y);
                            break;
                    }
                }

                public void UnitsConvert(dist in_units, dist out_units)
                {
                    _lineWidth = Ut.UnitsConvert(_lineWidth, in_units, out_units);

                    switch (_FilledFigure?.GetType().Name)
                    {
                        case "FilledCircle":
                            ((FilledCircle)_FilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "FilledRect":
                            ((FilledRect)_FilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "Polygon":
                            ((Polygon)_FilledFigure).UnitsConvert(in_units, out_units);
                            break;
                        case "FilledContour":
                            ((FilledContour)_FilledFigure).UnitsConvert(in_units, out_units);
                            break;
                    }
                }
            }

            /// <summary>
            /// Описание контура платы.
            /// </summary>
            [XmlArray("Contour")]
            [XmlArrayItem("Shape")]
            public Shape_Contour[] _Contours;

            /// <summary>
            /// Вырезы в плате.
            /// </summary>
            [XmlArray("Voids")]
            [XmlArrayItem("Shape")]
            public Shape_Voids[] _Voids;
        }

        /// <summary>
        /// Описание монтажного отверстия на плате.
        /// </summary>
        public class MntholeInstance
        {
            /// <summary>
            /// Задаёт угол в градусах c точностью до тысячных долей.
            /// </summary>
            [XmlAttribute("angle", DataType = "float")]
            public float _angle;

            /// <summary>
            /// Признак фиксации.
            /// </summary>
            [XmlAttribute("fixed")]
            public Bool _fixed;
            [XmlIgnore]
            public bool _fixedSpecified { get { return _fixed != Bool.off; } }

            /// <summary>
            /// Ссылка на стек контактных площадок.
            /// </summary>
            [XmlElement("PadstackRef")]
            public PadstackRef _PadstackRef;

            /// <summary>
            /// ссылка на цепь.
            /// </summary>
            [XmlElement("NetRef")]
            public NetRef _NetRef;

            /// <summary>
            /// Точка привязки объекта.
            /// </summary>
            [XmlElement("Org")]
            public Org _Org;

            public void Shift(float x, float y)
            {
                _Org?.Shift(x, y);
            }

            public void UnitsConvert(dist in_units, dist out_units)
            {
                _Org?.UnitsConvert(in_units, out_units);
            }
        }
        /// <summary>
        /// Описание запрета.
        /// </summary>
        public class Keepout_Сonstructive
        {
            /// <summary>
            /// Тип запрета.
            /// </summary>
            public class Role
            {
                // <summary>
                /// Тип запрета: запрет трассировки.
                /// </summary>
                public class Trace
                {
                    /// <summary>
                    /// Тип запрета трассировки.
                    /// </summary>
                    [XmlAttribute("role")]
                    public role _role;

                    /// <summary>
                    /// Ссылка на слои.
                    /// </summary>
                    [
                         XmlElement("AllLayers", typeof(AllLayers)),
                         XmlElement("AllLayersInner", typeof(AllLayersInner)),
                         XmlElement("AllLayersInnerSignal", typeof(AllLayersInnerSignal)),
                         XmlElement("AllLayersSignal", typeof(AllLayersSignal)),
                         XmlElement("AllLayersOuter", typeof(AllLayersOuter)),
                         XmlElement("LayerGroupRef", typeof(LayerGroupRef)),
                         XmlElement("LayerRef", typeof(LayerRef)) //Внимание! тут может быть массив
                     ]
                    public object _LayersRef;
                }

                /// <summary>
                /// Тип запрета: запрет размещения.
                /// </summary>
                public class Place
                {
                    /// <summary>
                    /// Сторона объекта.
                    /// </summary>
                    [XmlAttribute("side")]
                    public side _side;
                }
                /// <summary>
                /// Тип запрета: запрет трассировки.
                /// </summary>
                [XmlElement("Trace", typeof(Trace))]
                public Trace _Trace;
                [XmlElement("Place", typeof(Place))]
                public Place _Place;
            }

            [XmlElement("Role", typeof(Role))]
            public Role _Role;

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

                XmlElement("Contour", typeof(Contour)),
                XmlElement("FilledContour", typeof(FilledContour)),

                XmlElement("Polyline", typeof(Polyline))
            ]
            public object _FigureContPolyline;

            public void Shift(float x, float y)
            {
                switch (_FigureContPolyline?.GetType().Name)
                {
                    case "ArcCCW":
                        ((ArcCCW)_FigureContPolyline).Shift(x, y);
                        break;
                    case "ArcCW":
                        ((ArcCW)_FigureContPolyline).Shift(x, y);
                        break;
                    case "ArcByAngle":
                        ((ArcByAngle)_FigureContPolyline).Shift(x, y);
                        break;
                    case "ArcByMiddle":
                        ((ArcByMiddle)_FigureContPolyline).Shift(x, y);
                        break;
                    case "Circle":
                        ((Circle)_FigureContPolyline).Shift(x, y);
                        break;
                    case "Line":
                        ((Line)_FigureContPolyline).Shift(x, y);
                        break;
                    case "FilledCircle":
                        ((FilledCircle)_FigureContPolyline).Shift(x, y);
                        break;
                    case "Rect":
                        ((Rect)_FigureContPolyline).Shift(x, y);
                        break;
                    case "FilledRect":
                        ((FilledRect)_FigureContPolyline).Shift(x, y);
                        break;
                    case "Polygon":
                        ((Polygon)_FigureContPolyline).Shift(x, y);
                        break;
                    case "FilledContour":
                        ((FilledContour)_FigureContPolyline).Shift(x, y);
                        break;
                    case "Polyline":
                        ((Polyline)_FigureContPolyline).Shift(x, y);
                        break;
                    case "Contour":
                        ((Contour)_FigureContPolyline).Shift(x, y);
                        break;
                }
            }
            public void UnitsConvert(dist in_units, dist out_units)
            {
                switch (_FigureContPolyline?.GetType().Name)
                {
                    case "ArcCCW":
                        ((ArcCCW)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "ArcCW":
                        ((ArcCW)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "ArcByAngle":
                        ((ArcByAngle)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "ArcByMiddle":
                        ((ArcByMiddle)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "Circle":
                        ((Circle)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "Line":
                        ((Line)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "FilledCircle":
                        ((FilledCircle)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "Rect":
                        ((Rect)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "FilledRect":
                        ((FilledRect)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "Polygon":
                        ((Polygon)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "FilledContour":
                        ((FilledContour)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "Polyline":
                        ((Polyline)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                    case "Contour":
                        ((Contour)_FigureContPolyline).UnitsConvert(in_units, out_units);
                        break;
                }
            }
        }

        /// <summary>
        /// Версия раздела.
        /// </summary>
        [XmlAttribute("version")]
        public string _version;

        /// <summary>
        /// Контур платы и вырезы в плате.
        /// </summary>
        [XmlElement("BoardOutline")]
        public BoardOutline _BoardOutline;

        /// <summary>
        /// Монтажные отверстия на плате.
        /// </summary>
        [XmlArray("Mntholes")]
        [XmlArrayItem("MntholeInstance")]
        public MntholeInstance[] _Mntholes;

        /// <summary>
        /// Детали на механических слоях.
        /// </summary>
        [XmlArray("MechLayerObjects")]
        [XmlArrayItem("Detail")]
        public Detail[] _MechLayerObjects;

        /// <summary>
        /// Описание надписей.
        /// </summary>
        [XmlArray("Texts")]
        [XmlArrayItem("Text")]
        public Text[] _Texts;

        /// <summary>
        /// Описание запретов.
        /// </summary>
        [XmlArray("Keepouts")]
        [XmlArrayItem("Keepout")]
        public Keepout_Сonstructive[] _Keepouts;

        public void Shift(float x, float y)
        {
            if (_BoardOutline != null)
            {
                if (_BoardOutline?._Contours.Length > 0)
                    for (int i = 0; i < _BoardOutline._Contours.Length; i++)
                        _BoardOutline._Contours[i].Shift(x, y);
                if (_BoardOutline?._Voids.Length > 0)
                    for (int i = 0; i < _BoardOutline._Voids.Length; i++)
                        _BoardOutline._Voids[i].Shift(x, y);
            }

            if (_Mntholes?.Length > 0)
                for (int i = 0; i < _Mntholes.Length; i++)
                    _Mntholes[i].Shift(x, y);

            if (_MechLayerObjects?.Length > 0)
                for (int i = 0; i < _MechLayerObjects.Length; i++)
                    _MechLayerObjects[i].Shift(x, y);

            if (_Texts?.Length > 0)
                for (int i = 0; i < _Texts.Length; i++)
                    _Texts[i].Shift(x, y);

            if (_Keepouts?.Length > 0)
                for (int i = 0; i < _Keepouts.Length; i++)
                    _Keepouts[i].Shift(x, y);
        }

        public void UnitsConvert(dist in_units, dist out_units)
        {
            if (_BoardOutline?._Contours?.Length > 0)
                for (int i = 0; i < _BoardOutline._Contours.Length; i++)
                    _BoardOutline._Contours[i].UnitsConvert(in_units, out_units);
            if (_BoardOutline?._Voids?.Length > 0)
                for (int i = 0; i < _BoardOutline._Voids.Length; i++)
                    _BoardOutline._Voids[i].UnitsConvert(in_units, out_units);


            if (_Mntholes?.Length > 0)
                for (int i = 0; i < _Mntholes.Length; i++)
                    _Mntholes[i].UnitsConvert(in_units, out_units);

            if (_MechLayerObjects?.Length > 0)
                for (int i = 0; i < _MechLayerObjects.Length; i++)
                    _MechLayerObjects[i].UnitsConvert(in_units, out_units);

            if (_Texts?.Length > 0)
                for (int i = 0; i < _Texts.Length; i++)
                    _Texts[i].UnitsConvert(in_units, out_units);

            if (_Keepouts?.Length > 0)
                for (int i = 0; i < _Keepouts.Length; i++)
                    _Keepouts[i].UnitsConvert(in_units, out_units);
        }

        public void Add(Constructive a, bool boardOutline, bool mntholeInstances, bool details, bool texts, bool keepouts)
        {
            int l;
            if (boardOutline)
            {
                if (a?._BoardOutline?._Contours?.Length > 0)
                {
                    if (_BoardOutline == null)
                        _BoardOutline = new BoardOutline();

                    if (_BoardOutline._Contours == null)
                        _BoardOutline._Contours = (BoardOutline.Shape_Contour[])a._BoardOutline._Contours.Clone();
                    else
                    {
                        l = _BoardOutline._Contours.Length;
                        Array.Resize(ref _BoardOutline._Contours, l + a._BoardOutline._Contours.Length);
                        a._BoardOutline._Contours.CopyTo(_BoardOutline._Contours, l);
                    }
                }

                if (a?._BoardOutline?._Voids?.Length > 0)
                {
                    if (_BoardOutline == null)
                        _BoardOutline = new BoardOutline();

                    if (_BoardOutline._Voids == null)
                        _BoardOutline._Voids = (BoardOutline.Shape_Voids[])a._BoardOutline._Voids.Clone();
                    else
                    {
                        l = _BoardOutline._Voids.Length;
                        Array.Resize(ref _BoardOutline._Voids, l + a._BoardOutline._Voids.Length);
                        a._BoardOutline._Voids.CopyTo(_BoardOutline._Voids, l);
                    }
                }
            }

            if (mntholeInstances)
            {
                if (a?._Mntholes?.Length > 0)
                {
                    if (_Mntholes == null)
                        _Mntholes = (MntholeInstance[])a._Mntholes.Clone();
                    else
                    {
                        l = _Mntholes.Length;
                        Array.Resize(ref _Mntholes, l + a._Mntholes.Length);
                        a._Mntholes.CopyTo(_Mntholes, l);
                    }
                }
            }

            if (details)
            {
                if (a?._MechLayerObjects?.Length > 0)
                {
                    if (_MechLayerObjects == null)
                        _MechLayerObjects = (Detail[])a._MechLayerObjects.Clone();
                    else
                    {
                        l = _MechLayerObjects.Length;
                        Array.Resize(ref _MechLayerObjects, l + a._MechLayerObjects.Length);
                        a._MechLayerObjects.CopyTo(_MechLayerObjects, l);
                    }
                }
            }

            if (texts)
            {
                if (a?._Texts?.Length > 0)
                {
                    if (_Texts == null)
                        _Texts = (Text[])a._Texts.Clone();
                    else
                    {
                        l = _Texts.Length;
                        Array.Resize(ref _Texts, l + a._Texts.Length);
                        a._Texts.CopyTo(_Texts, l);
                    }
                }
            }

            if (keepouts)
            {
                if (a?._Keepouts?.Length > 0)
                {
                    if (_Keepouts == null)
                        _Keepouts = (Keepout_Сonstructive[])a._Keepouts.Clone();
                    else
                    {
                        l = _Keepouts.Length;
                        Array.Resize(ref _Keepouts, l + a._Keepouts.Length);
                        a._Keepouts.CopyTo(_Keepouts, l);
                    }
                }
            }
        }
    }
}