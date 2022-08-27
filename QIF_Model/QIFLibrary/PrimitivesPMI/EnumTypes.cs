/*! \file EnumTypes.cs
    \brief enumerations

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The ShapeClassEnumType enumerates values that describe the shape
    /// class of a part.FREEFORM includes curved shapes such as turbine
    /// blades. PRISMATIC parts are non-rotational.THINWALLED is also known as sheet metal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ShapeClassEnumType
    {
        /// <remarks></remarks>
        GEAR,

        /// <remarks></remarks>
        FREEFORM,

        /// <remarks></remarks>
        PRISMATIC,

        /// <remarks></remarks>
        ROTATIONAL,

        /// <remarks></remarks>
        THINWALLED,
    }
}
