/*! \file FeatureZoneListType.cs
    \brief Defines a list of feature zones.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Features
{
    /// <remarks> The FeatureZonesType defines a list of feature zones.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneListType
    {
        /// <remarks> Each FeatureZone element gives information about the zone of
        /// the feature used to define characteristic tolerance zones or
        /// datum target areas or to specify the meaning of a characteristic.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FeatureZonePoint", typeof(FeatureZonePointType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneCurveLine", typeof(FeatureZoneCurveLineType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneCurveCircular", typeof(FeatureZoneCurveCircularType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneCurveIrregular", typeof(FeatureZoneCurveIrregularType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneAreaCircular", typeof(FeatureZoneAreaCircularType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneAreaRectangular", typeof(FeatureZoneAreaRectangularType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneAreaIrregular", typeof(FeatureZoneAreaIrregularType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneAreaCylindrical", typeof(FeatureZoneAreaCylindricalType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneAreaSpherical", typeof(FeatureZoneAreaSphericalType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureZoneAreaBetween", typeof(FeatureZoneAreaBetweenType))]
        public FeatureZoneBaseType[] FeatureZones { get; set; }

        /// <remarks> The required n attribute is the number of feature zones in the list.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count 
        {
            get => (uint)this.FeatureZones.Length;
            set { }
        }
    }

    /// <remarks> The FeatureZoneBaseType is the abstract base type that defines the
    /// zone of the feature used to define characteristic tolerance zones
    /// or datum target areas or to specify the meaning of a characteristic.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaSphericalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaBetweenType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaCylindricalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaIrregularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaRectangularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaCircularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneCurveBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneCurveIrregularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneCurveCircularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneCurveLineType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZonePointType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FeatureZoneBaseType
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }

        /// <remarks> The Label element is the label applied to the feature zone.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Label { get; set; }

        /// <remarks> The optional SurfaceFeatureNominalId element is the QIF id of the nominal surface feature the zone lies on.</remarks>
        public QIFReferenceFullType SurfaceFeatureNominalId { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks> The FeatureZoneAreaBaseType is the abstract base type that defines a basic parameter for area feature zone types.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaSphericalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaBetweenType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaCylindricalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaIrregularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaRectangularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneAreaCircularType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FeatureZoneAreaBaseType : FeatureZoneBaseType
    {
        /// <remarks>
        /// The FaceIds element is a list of QIF ids of faces. This element is in an optional choice.
        /// The EdgeIds element is a list of QIF ids of edges. This element is in an optional choice.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("EdgeIds", typeof(ArrayReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("FaceIds", typeof(ArrayReferenceFullType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ArrayReferenceFullType Item { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public EdgeFaceItemChoice ItemElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum EdgeFaceItemChoice
    {
        /// <remarks></remarks>
        EdgeIds,

        /// <remarks></remarks>
        FaceIds,
    }

    /// <remarks> The FeatureZoneAreaSphericalType defines a feature zone as a sphere.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneAreaSphericalType : FeatureZoneAreaBaseType
    {
        /// <remarks> The Sphere element is the sphere that defines the basic
        /// size and location of a tooling ball used for the datum target point simulator.</remarks>
        public SphereType Sphere { get; set; }
    }

    /// <remarks> The FeatureZoneAreaBetweenType defines a feature zone as the area between two other feature zones.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneAreaBetweenType : FeatureZoneAreaBaseType
    {
        /// <remarks>
        /// The FromPointZone element is the QIF id of a point that represents the first boundary of the between zone.
        /// The FromCurveZone element is the QIF id of a curve that represents the first boundary of the between zone.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FromCurveZoneId", typeof(QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("FromPointZoneId", typeof(QIFReferenceFullType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public QIFReferenceFullType Item1 { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public FromZoneChoiceType Item1ElementName { get; set; }

        /// <remarks>
        /// The ToPointZone element is the QIF id of a point that represents the second boundary of the between zone.</remarks>
        /// The ToCurveZone element is the QIF id of a curve that represents the second boundary of the between zone.
        [System.Xml.Serialization.XmlElementAttribute("ToCurveZoneId", typeof(QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("ToPointZoneId", typeof(QIFReferenceFullType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item2ElementName")]
        public QIFReferenceFullType Item2 { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ToZoneChoiceType Item2ElementName { get; set; }

        /// <remarks></remarks>
        public UnitVectorType StartDirection { get; set; }

        /// <remarks></remarks>
        public UnitVectorType PlaneNormal { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum FromZoneChoiceType
    {
        /// <remarks></remarks>
        FromCurveZoneId,

        /// <remarks></remarks>
        FromPointZoneId,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ToZoneChoiceType
    {
        /// <remarks></remarks>
        ToCurveZoneId,

        /// <remarks></remarks>
        ToPointZoneId,
    }

    /// <remarks> The FeatureZoneAreaCylindricalType defines a feature zone as a cylinder area.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneAreaCylindricalType : FeatureZoneAreaBaseType
    {
        /// <remarks> The Cylinder element is the cylinder that defines the basic size and location of a cylindrical area.</remarks>
        public CylinderType Cylinder { get; set; }
    }

    /// <remarks> The FeatureZoneAreaIrregularType defines a feature zone as an irregular area defined by a poly-line boundary.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneAreaIrregularType : FeatureZoneAreaBaseType
    {
    }

    /// <remarks> The FeatureZoneAreaRectangularType defines a feature zone as a rectangular area.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneAreaRectangularType : FeatureZoneAreaBaseType
    {
        /// <remarks> The Rectangle element is the rectangle that defines the basic size and location of a rectangle.</remarks>
        public RectangleType Rectangle { get; set; }
    }

    /// <remarks> The FeatureZoneAreaCircularType defines a feature zone as circular area.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneAreaCircularType : FeatureZoneAreaBaseType
    {
        /// <remarks> The Circle element is the circle that defines the basic size and location of a circular area.</remarks>
        public CircleType Circle { get; set; }
    }

    /// <remarks> The FeatureZoneCurveBaseType is the abstract base type that defines a basic parameter for curve feature zone types.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneCurveIrregularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneCurveCircularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureZoneCurveLineType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FeatureZoneCurveBaseType : FeatureZoneBaseType
    {
        /// <remarks>
        /// The optional EdgeIds element is a list of QIF ids of edges.
        /// The optional CurveIds element is a list of QIF ids of curves (not curve features).</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CurveIds", typeof(ArrayReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("EdgeIds", typeof(ArrayReferenceFullType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ArrayReferenceFullType Item { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CurveEdgeChoiceType ItemElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum CurveEdgeChoiceType
    {
        /// <remarks></remarks>
        CurveIds,

        /// <remarks></remarks>
        EdgeIds,
    }

    /// <remarks> The FeatureZoneCurveIrregularType defines a feature zone as a curve</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneCurveIrregularType : FeatureZoneCurveBaseType
    {
        /// <remarks></remarks>
        public PolyLineType CurvePoints { get; set; }
    }

    /// <remarks> The FeatureZoneCurveCircularType defines a feature zone as a circle or an arc.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneCurveCircularType : FeatureZoneCurveBaseType
    {
        /// <remarks></remarks>
        public CircleType Circle { get; set; }
    }

    /// <remarks> The FeatureZoneCurveLineType defines a feature zone as a line.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZoneCurveLineType : FeatureZoneCurveBaseType
    {
        /// <remarks> The Line element is the line that defines the basic location and direction of the line.</remarks>
        public LineSegmentType Line { get; set; }
    }

    /// <remarks> The FeatureZonePointType defines a feature zone as a point.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureZonePointType : FeatureZoneBaseType
    {
        /// <remarks>
        /// The optional VertexID element is a QIF id of a vertex.
        /// The optional PointID element is the QIF id of a nominal point feature.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("PointId", typeof(QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("VertexId", typeof(QIFReferenceFullType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public QIFReferenceFullType Item { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public PointVertexChoiceType ItemElementName { get; set; }

        /// <remarks> The Point element is the location of the point.</remarks>
        public PointType Point { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum PointVertexChoiceType
    {
        /// <remarks></remarks>
        PointId,

        /// <remarks></remarks>
        VertexId,
    }
}
