/*! \file OtherShapeFeatureDefinitionType.cs
	\brief Defines the other shape feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The OtherShapeFeatureDefinitionType defines the other shape
    /// feature nominal information that can be common to one or more other shape features.</remarks>
    [System.SerializableAttribute()]
    public partial class OtherShapeFeatureDefinitionType : ShapeFeatureDefinitionBaseType
    {
        /// <remarks> The Description element describes the other shape feature in natural language.</remarks>
        public string Description { get; set; }
    }
}
