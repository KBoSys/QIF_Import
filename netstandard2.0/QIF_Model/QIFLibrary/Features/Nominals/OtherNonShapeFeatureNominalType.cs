/*! \file OtherNonShapeFeatureNominalType.cs
    \brief Defines the nominal values of an other non-shape feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The OtherNonShapeFeatureNominalType defines the nominal values of an other non-shape feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherNonShapeFeatureNominalType : NonShapeFeatureNominalBaseType
    {
        /// <remarks> The ReferenceFeatureNominalIds element is a list of the QIF ids of associated nominal features.</remarks>
        public ArrayReferenceFullType ReferenceFeatureNominalIds { get; set; }
    }
}
