/*! \file ShapeClassType.cs
	\brief defines the shape class of a part.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The ShapeClassType defines the shape class of a part.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ShapeClassType
    {
        /// <remarks>
        /// The ShapeClassEnum element describes an often-used shape class.
        /// The OtherShapeClass element describes a shape class in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("OtherShapeClass", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ShapeClassEnum", typeof(ShapeClassEnumType))]
        public object? Item { get; set; }
    }
}
