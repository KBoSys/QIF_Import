/*! \file RunoutCharacteristicDefinitionBaseType.cs
    \brief defines a runout characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The RunoutCharacteristicDefinitionBaseType is the abstract base type that defines a runout characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class RunoutCharacteristicDefinitionBaseType : GeometricCharacteristicDefinitionBaseType
    {
        /// <remarks> The ToleranceValue element is the tolerance of the runout characteristic.</remarks>
        public Units.LinearValueType? ToleranceValue { get; set; }

        /// <remarks> The optional ToleranceDualValue element is the dual tolerance value of the runout characteristic.</remarks>
        public Units.LinearDualValueType? ToleranceDualValue { get; set; }

        /// <remarks> The optional DatumReferenceFrameId element is the QIF id of the datum reference frame of the runout characteristic.</remarks>
        public Primitives.QIFReferenceFullType? DatumReferenceFrameId { get; set; }
    }

    /// <summary>
    /// The CircularRunoutCharacteristicDefinitionType defines information that can be common to more than one circular runout characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CircularRunoutCharacteristicDefinitionType : RunoutCharacteristicDefinitionBaseType
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class TotalRunoutCharacteristicDefinitionType : RunoutCharacteristicDefinitionBaseType
    {
    }
}
