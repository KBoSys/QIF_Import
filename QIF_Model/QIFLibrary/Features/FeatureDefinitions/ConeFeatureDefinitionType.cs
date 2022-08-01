/*! \file ConeFeatureDefinitionType.cs
	\brief
	The ConeFeatureDefinitionType defines the cone feature nominal
    information that can be common to one or more cone features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    [XmlType(IncludeInSchema = false)]
    public enum ConeAngleTypeEnum
    {
        None,
        HalfAngle,
        FullAngle
    }

    /// <remarks The ConeFeatureDefinitionType defines the cone feature nominal	information that can be common to one or more cone features./>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ConeFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        #region Properties
        /// <remarks The InternalExternal element indicates whether the feature is internal or external./>
        [XmlElement]
        public QIFLibrary.PrimitivesPMI.InternalExternalEnumType InternalExternal { get; set; }

        /// <summary>
        /// The Diameter element is the nominal diameter of the cone at
        /// the locating point.If the locating point is defined at the
        /// cone vertex then this value will be zero.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType Diameter { get; set; }

        #region Angle Choice
        /// <remarks This compositor defines the angle of the cone./>
        /// <summary>
        /// The HalfAngle element the nominal angle between the side
        /// of the cone and its axis(this is half of the included
        /// angle of the cone). This angle will be greater than zero
        /// and less than 90 degrees.
        ///
        /// The FullAngle element is the nominal angle between the
        /// sides of the cone in a plane including the cone's axis
        /// (this is the included angle of the cone). This angle will
        /// be greater than zero and less than 180 degrees.
        /// </summary>
        [XmlChoiceIdentifier("AngleType")]
        [XmlElement(ElementName = "HalfAngle", Type = typeof(AngularValueType))]
        [XmlElement(ElementName = "FullAngle", Type = typeof(AngularValueType))]
        public AngularValueType Angle { get; set; }

        [XmlIgnore]
        public ConeAngleTypeEnum AngleType { get; set; }
        #endregion

        /// <remarks The LargeEndDistance element is the nominal distance from
        /// the locating point to the large end of a truncated cone along the axis vector./>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType LargeEndDistance { get; set; }

        /// <remarks The optional SmallEndDistance element is the nominal
        /// distance from the locating point to the small end of a
        /// truncated cone along the axis vector.If this element is missing, the cone has a pointed end./>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType SmallEndDistance { get; set; }

        #endregion
    }
}
