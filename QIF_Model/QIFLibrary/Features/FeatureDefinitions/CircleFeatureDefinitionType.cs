/*! \file CircleFeatureDefinitionType.cs
	\brief
	The CircleFeatureDefinition defines circle feature nominal
    information that can be common to one or more circle features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks The CircleFeatureDefinition defines circle feature nominal	information that can be common to one or more circle features./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CircleFeatureDefinitionType : CurveFeatureDefinitionBaseType
    {
        private QIFLibrary.PrimitivesPMI.InternalExternalEnumType internalExternalField;

        public CircleFeatureDefinitionType()
        {
            internalExternalField = QIFLibrary.PrimitivesPMI.InternalExternalEnumType.INTERNAL;
        }

        /// <remarks The InternalExternal element indicates whether the feature is internal or external./>
        [XmlElement]
        public QIFLibrary.PrimitivesPMI.InternalExternalEnumType InternalExternal
        {
            get => internalExternalField;
            set => internalExternalField = value;
        }

        /// <remarks The Diameter element is the nominal diameter of the circle feature./>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType Diameter { get; set; }
    }
}
