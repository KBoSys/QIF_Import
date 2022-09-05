/*! \file CircleFeatures.cs
    \brief defines circle constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks> The CircleFromScanType defines a circle construction by the retrieval of a circle from a scanned surface feature(point cloud).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleFromScanType : ConstructionMethodBaseType
    {
        /// <remarks> The SurfaceFeature element identifies the scanned surface feature from which the circle is retrieved.</remarks>
        public BaseFeatureType? SurfaceFeature { get; set; }

        /// <remarks> The SearchRadius element is the radius around the nominal
        /// feature, wherein the measured feature can be expected.The
        /// SearchRadius is the radius added to and subtracted from the
        /// nominal feature radius to define a cylindrical shell.All
        /// scanned points within this cylindrical shell are used for
        /// the retrieval of the feature.The cylindrical shell's axis
        /// is defined by the feature's direction and the cylindrical
        /// shell's axis passes through the feature's center point.</remarks>
        public LinearValueType? SearchRadius { get; set; }

        /// <remarks> The Depth element is the measuring depth down the circle nominal axis vector at which the circle is to be retrieved.</remarks>
        public LinearValueType? Depth { get; set; }
    }

    /// <remarks> The CircleFromConeType defines the construction of a circle from a cone.
    /// The circle will be located either at a specified diameter on the cone or at a specified distance from the vertex of the cone.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleFromConeType : ConstructionMethodBaseType
    {
        /// <remarks>
        /// The Diameter element is the cone diameter at which the circle will be constructed.
        /// The Distance element is the distance from the cone vertex at which the circle will be constructed. </remarks>
        [System.Xml.Serialization.XmlElementAttribute("Diameter", typeof(LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("Distance", typeof(LinearValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public LinearValueType? Item { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public DiameterOrDistanceChoiceType ItemElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum DiameterOrDistanceChoiceType
    {
        /// <remarks></remarks>
        Diameter,

        /// <remarks></remarks>
        Distance,
    }

    /// <remarks> The CircleTransformType defines a circle construction by the
    /// transformation of a circle through the specified nominal or actual coordinate system.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleTransformType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseCircle element identifies the circle to be transformed.</remarks>
        public BaseFeatureType? BaseCircle { get; set; }

        /// <remarks> The Transformation element identifies the coordinate system to be used to transform the base circle.</remarks>
        public TransformationReferenceType? Transformation { get; set; }
    }

    /// <remarks> The CircleTangentThroughType defines the construction of a circle
    /// with a nominal diameter through a point and tangent to a base
    /// feature.The point and base feature are both coplanar with the circle.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleTangentThroughType : ConstructionMethodBaseType
    {
        /// <remarks> The TangentFeature element identifies the base feature to which the constructed circle is tangent.</remarks>
        public BaseFeatureType? TangentFeature { get; set; }

        /// <remarks> The PointFeature element identifies the point feature through which the constructed circle passes.</remarks>
        public BaseFeatureType? PointFeature { get; set; }
    }

    /// <remarks> The CircleTangentType defines the construction of a circle with a
    /// nominal diameter tangent to two base features coplanar with the circle.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleTangentType : ConstructionMethodBaseType
    {
        /// <remarks> Each TangentFeature element identifies a base feature for the tangent circle construction.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("TangentFeature")]
        public SequencedBaseFeatureType[] TangentFeature { get; set; }
    }

    /// <remarks> The CircleCastType defines a circle construction by the casting of
    /// another feature type to a circle.The location, vector and size are
    /// copied from the base feature.Any information not available on the
    /// base feature will remain at nominal.For example, a cast sphere
    /// will create a circle with center and diameter taken from the sphere
    /// but it will retain its nominal normal vector.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleCastType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseFeature element identifies the feature to be cast to a circle.</remarks>
        public BaseFeatureType? BaseFeature { get; set; }
    }

    /// <remarks> The CircleCopyType defines a copied circle construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleCopyType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseCircle element identifies the circle to be copied.</remarks>
        public BaseFeatureType? BaseCircle { get; set; }
    }

    /// <remarks> The CircleProjectionType defines a projected circle construction with the circle to be projected and the projection plane.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleProjectionType : ConstructionMethodBaseType
    {
        /// <remarks> The ProjectionCircle element identifies the circle to be projected.</remarks>
        public BaseFeatureType? ProjectionCircle { get; set; }

        /// <remarks> The ProjectionPlane element identifies the plane onto which the base circle is to be projected.</remarks>
        public BaseFeatureType? ProjectionPlane { get; set; }
    }

    /// <remarks> The CircleIntersectionType defines the construction of a circle by
    /// the intersection of two features, e.g.a cylinder, cone or surface
    /// of revolution with a plane, two cones of differing angles, or a cone with a cylinder.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleIntersectionType : ConstructionMethodBaseType
    {
        /// <remarks> Each IntersectionFeature element identifies a feature to be used to construct the circle of intersection.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("IntersectionFeature")]
        public SequencedBaseFeatureType[] IntersectionFeature { get; set; }
    }

    /// <remarks> The CircleRecompType defines a list of base feature points for
    /// construction of a re-compensated-for-probe-size best-fit circle
    /// through the measurement points of base features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleRecompType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseFeaturePointList element gives a list of sets of
        /// points for construction of a re-compensated-for-probe-size
        /// best-fit circle.The total number of points in the
        /// BaseFeaturePointSets in the list must be 3 or greater.</remarks>
        public BaseFeaturePointListType? BaseFeaturePointList { get; set; }
    }

    /// <remarks> The CircleBestFitType defines the information for a best-fit circle
    /// which includes a list of point-reducible base features; the points
    /// to which those features reduce are used in the best-fit
    /// construction of the circle.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleBestFitType : ConstructionMethodBaseType
    {
        /// <remarks> Each BaseFeature element identifies a base feature to be
        /// used for the construction of a circle.The number of base features must be 3 or greater.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
        public SequencedBaseFeatureType[]? Items { get; set; }

        /// <remarks> The required n attribute is the number of base features used in the construction.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => this.Items != null ? (uint)this.Items.Length : 0;
            set { }
        }
    }
}
