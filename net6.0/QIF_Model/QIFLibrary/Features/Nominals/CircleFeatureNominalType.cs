/*! \file CircleFeatureNominalType.cs
    \brief The CircleFeatureNominalType defines nominal information for an individual circle feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.Construction;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The CircleFeatureNominalType defines nominal information for an individual circle feature.</remarks>
    public class CircleFeatureNominalType : CurveFeatureNominalBaseType
    {
        /// <remarks> The Location element is the nominal center point of the circle.</remarks>
        [XmlElement]
        public Primitives.PointType? Location { get; set; }

        /// <remarks> The Normal element is the nominal unit normal vector of the plane of the circle.</remarks>
        [XmlElement]
        public Primitives.UnitVectorType? Normal { get; set; }

        /// <remarks> The optional Sweep element gives the nominal start direction and the swept angle for a partial circle.
        /// The StartVector of the Sweep must lie in the plane of the circle.</remarks>
        [XmlElement]
        public Primitives.SweepType Sweep { get; set; }

        /// <remarks> The optional Constructed element signifies that the circle is constructed and provides details of the construction method.</remarks>
        [XmlElement]
        public CircleConstructionMethodType Constructed { get; set; }
    }

    /// <remarks> The CircleConstructionMethodType defines the method for constructing a unique nominal or measured circle feature. </remarks>
    public class CircleConstructionMethodType
    {
        #region Choice
        /// <remarks> This optional compositor provides a choice of the construction method for the circle.</remarks>
        [XmlChoiceIdentifier("Type")]
        [XmlElement(ElementName = "BestFit", Type = typeof(CircleBestFitType))]
        [XmlElement(ElementName = "Recompensated", Type = typeof(CircleRecompType))]
        [XmlElement(ElementName = "Intersection", Type = typeof(CircleIntersectionType))]
        [XmlElement(ElementName = "Projection", Type = typeof(CircleProjectionType))]
        [XmlElement(ElementName = "Copy", Type = typeof(CircleCopyType))]
        [XmlElement(ElementName = "Cast", Type = typeof(CircleCastType))]
        [XmlElement(ElementName = "Tangent", Type = typeof(CircleTangentType))]
        [XmlElement(ElementName = "TangentThrough", Type = typeof(CircleTangentThroughType))]
        [XmlElement(ElementName = "Transform", Type = typeof(CircleTransformType))]
        [XmlElement(ElementName = "FromCone", Type = typeof(CircleFromConeType))]
        [XmlElement(ElementName = "FromScan", Type = typeof(CircleFromScanType))]
        public ConstructionMethodBaseType? Method { get; set; }

        [XmlType(IncludeInSchema = false)]
        public enum CircleConstructionMethodChoiceType
        {
            None,
            BestFit,
            Recompensated,
            Intersection,
            Projection,
            Copy,
            Cast,
            Tangent,
            TangentThrough,
            Transform,
            FromCone,
            FromScan,
        }

        [XmlIgnore]
        public CircleConstructionMethodChoiceType Type { get; set; }
        #endregion
    }
}
