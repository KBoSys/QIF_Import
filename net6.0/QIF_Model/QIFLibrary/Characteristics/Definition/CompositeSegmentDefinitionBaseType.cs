/*! \file CompositeSegmentDefinitionBaseType.cs
    \brief 
        The CompositeSegmentDefinitionBaseType is the abstract base type
        that defines information that can be common to more than one
        composite segment characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The CompositeSegmentDefinitionBaseType is the abstract base type
    /// that defines information that can be common to more than one
    /// composite segment characteristics.
    /// ASME Y14.5 - 2009 Section 7.5
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class CompositeSegmentDefinitionBaseType
    {
        /// <remarks> The optional DatumReferenceFrameId element is the QIF id of the datum reference frame for a composite tolerance segment.</remarks>
        public Primitives.QIFReferenceFullType? DatumReferenceFrameId { get; set; }

        /// <remarks> The ToleranceValue element is the tolerance value for the segment.</remarks>
        public Units.LinearValueType? ToleranceValue { get; set; }

        /// <remarks> The optional ToleranceDualValue element is the dual tolerance  value for the segment.</remarks>
        public Units.LinearDualValueType? ToleranceDualValue { get; set; }

        /// <remarks> The optional CharacteristicDesignator element is the designator
        /// of this individual composite segment of a characteristic
        /// together with an optional level of criticality and optional UUID.</remarks>
        public CharacteristicDesignatorType? CharacteristicDesignator { get; set; }
    }
}
