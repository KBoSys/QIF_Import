/*! \file MarkingFeatureNominalType.cs
    \brief Defines the nominal values of a marking feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The MarkingFeatureNominalType defines the nominal values of a marking feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MarkingFeatureNominalType : NonShapeFeatureNominalBaseType
    {
        /// <remarks> The Location element defines a rectangle within which the
        /// marking should be made.</remarks>
        public RectangleType? Location { get; set; }
    }
}
