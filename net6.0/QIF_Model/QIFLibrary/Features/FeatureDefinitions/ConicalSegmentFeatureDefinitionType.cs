/*! \file ConicalSegmentFeatureDefinitionType.cs
	\brief defines conical segment

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The ConicalSegmentFeatureDefinitionType defines the conical segment
    /// feature nominal information that can be common to one or more conical segment features.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ConicalSegmentFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        [XmlElement]
        public PrimitivesPMI.InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The Diameter element is the nominal diameter of the conical
        /// segment at the locating point.If the locating point is defined at the conical segment's vertex then this value will be zero.
        /// </remarks>
        [XmlElement]
        public Units.LinearValueType? Diameter { get; set; }

        #region Choice
        /// <remarks> This compositor defines the angle of the cone.</remarks>
        /// <summary>
        /// The HalfAngle element is the nominal angle between the
        /// side of the conical segment and its axis(this is half of
        /// the included angle of the conical segment). This angle will be greater than zero and less than 90 degrees.
        ///
        /// The FullAngle element is the nominal angle between the
        /// sides of the conical segment in a plane including the
        /// conical segment's axis (this is the included angle of the
        /// conical segment). This angle will be greater than zero and less than 180 degrees.
        /// </summary>
        [XmlChoiceIdentifier("AngleType")]
        [XmlElement(ElementName = "HalfAngle", Type = typeof(Units.AngularValueType))]
        [XmlElement(ElementName = "FullAngle", Type = typeof(Units.AngularValueType))]
        public Units.AngularValueType? Angle { get; set; }

        [XmlType(IncludeInSchema = false)]
        public enum ConicalAngleTypeEnum
        {
            None,
            HalfAngle,
            FullAngle
        }

        [XmlIgnore]
        public ConicalAngleTypeEnum AngleType { get; set; }
        #endregion

        /// <remarks> This optional compositor defines the extents of the conical
        /// segment with respect to the locating point. The distance to
        /// an end is positive if it is in the direction of the axis
        /// vector and negative if it is in a direction opposite the axis vector. 
        /// </remarks>
        #region Choice
        /// <remarks> The LargeEndDistance element is the nominal distance
        /// from the locating point to the large end of the conical segment along the axis vector.</remarks>
        [XmlElement]
        public Units.LinearValueType? LargeEndDistance { get; set; }

        /// <remarks> The optional SmallEndDistance element is the nominal
        /// distance from the locating point to the small end of the
        /// conical segment along the axis vector.If this element is missing, the conical segment has a pointed end.</remarks>
        [XmlElement]
        public Units.LinearValueType? SmallEndDistance { get; set; }
        #endregion
    }
}
