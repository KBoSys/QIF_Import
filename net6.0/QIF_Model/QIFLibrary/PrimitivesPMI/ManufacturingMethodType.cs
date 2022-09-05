/*! \file ManufacturingMethodType.cs
	\brief defines a manufacturing method for a part.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The ManufacturingMethodType defines a manufacturing method for a part.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ManufacturingMethodType
    {
        /// <remarks>
        /// The ManufacturingMethodEnum element describes an often-used manufacturing method.
        /// The OtherManufacturingMethod element describes a manufacturing method in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturingMethodEnum", typeof(ManufacturingMethodEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherManufacturingMethod", typeof(string))]
        public object? Item { get; set; }
    }

    /// <remarks> The ManufacturingMethodEnumType enumerates values that describe the methods of manufacturing a part. </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ManufacturingMethodEnumType
    {
        /// <remarks> additive manufacturing</remarks>
        ADDITIVE,

        /// <remarks></remarks>
        CASTING,

        /// <remarks> manufacturing includes lay-up and filament winding</remarks>
        COMPOSITE,

        /// <remarks> fabricates existing components</remarks>
        FABRICATION,

        /// <remarks> includes forging, rolling, extrusion, pressing, bending, and shearing</remarks>
        FORMING,

        /// <remarks> includes welding, brazing, sintering, bonding, fastening, and press fitting.</remarks>
        JOINING,

        /// <remarks> includes all operations that may be done on a machining center or other machine that
        /// subtracts material such as milling, turning, drilling, reaming, boring, sawing, hobbing, and electron beam machining. </remarks>
        MACHINING,

        /// <remarks> includes injection molding.</remarks>
        MOLDING,
    }
}
