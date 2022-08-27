/*! \file PointFeatureNominalType.cs
    \brief The PointFeatureNominalType defines the point feature nominal information for an individual point feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.Construction;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The PointFeatureNominalType defines the point feature nominal information for an individual point feature.</remarks>
    public class PointFeatureNominalType : PointFeatureNominalBaseType
    {
        /// <remarks> The Location element is the nominal location of the point.</remarks>
        [XmlElement]
        public Primitives.PointType Location { get; set; }

        /// <remarks> The optional Normal element is the nominal unit normal vector at the point of a surface on which the point lies.</remarks>
        [XmlElement()]
        public Primitives.UnitVectorType Normal { get; set; }

        /// <remarks> The optional Constructed element signifies that the point is constructed and provides details of the construction method.</remarks>
        [XmlElement()]
        public PointConstructionMethodType Constructed { get; set; }
    }

    /// <remarks> The PointConstructionMethodType defines the method for constructing a unique nominal or measured point feature.</remarks>
    public class PointConstructionMethodType
    {
        #region Choice
        /// <remarks> This optional compositor provides a choice of the construction method for the point feature.</remarks>
        [XmlChoiceIdentifier("Type")]
        [XmlElement(ElementName = "Intersection", Type = typeof(PointFeatureIntersectionType))]
        [XmlElement(ElementName = "Projection", Type = typeof(PointFeatureProjectionType))]
        [XmlElement(ElementName = "Copy", Type = typeof(PointFeatureCopyType))]
        [XmlElement(ElementName = "Cast", Type = typeof(PointFeatureCastType))]
        [XmlElement(ElementName = "Transform", Type = typeof(PointFeatureTransformType))]
        [XmlElement(ElementName = "FromCone", Type = typeof(PointFeatureFromConeType))]
        [XmlElement(ElementName = "FromScan", Type = typeof(PointFeatureFromScanType))]
        [XmlElement(ElementName = "CenterOfGravity", Type = typeof(PointFeatureCenterOfGravityType))]
        [XmlElement(ElementName = "Pierce", Type = typeof(PointFeaturePierceType))]
        [XmlElement(ElementName = "MidPoint", Type = typeof(PointFeatureMidPointType))]
        [XmlElement(ElementName = "MovePoint", Type = typeof(PointFeatureMovePointType))]
        [XmlElement(ElementName = "MovePointVector", Type = typeof(PointFeatureMovePointVectorType))]
        [XmlElement(ElementName = "MovePointAxis", Type = typeof(PointFeatureMovePointAxisType))]
        [XmlElement(ElementName = "Extreme", Type = typeof(PointFeatureExtremeType))]
        public ConstructionMethodBaseType Method { get; set; }

        [XmlIgnore]
        public PointConstructionMethodChoiceType Type { get; set; }
        #endregion
    }

    [XmlType(IncludeInSchema = false)]
    public enum PointConstructionMethodChoiceType
    {
        None,
        Intersection,
        Projection,
        Copy,
        Cast,
        Transform,
        FromCone,
        FromScan,
        CenterOfGravity,
        Pierce,
        MidPoint,
        MovePoint,
        MovePointVector,
        MovePointAxis,
        Extreme,
    }
}
