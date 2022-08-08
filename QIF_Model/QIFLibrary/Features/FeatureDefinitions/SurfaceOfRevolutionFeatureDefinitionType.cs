/*! \file SurfaceOfRevolutionFeatureDefinitionType.cs
	\brief Defines the surface of revolution feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks The SurfaceOfRevolutionFeatureDefinitionType defines the surface of
    /// revolution feature nominal information that can be common to one or
    /// more surface of revolution features./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks The InternalExternal element indicates whether the feature is internal or external./>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks The optional Length element is the nominal length of the
        /// surface of revolution from the starting point in the
        /// direction of the axis of the surface of revolution./>
        public LinearValueType Length { get; set; }
    }
}
