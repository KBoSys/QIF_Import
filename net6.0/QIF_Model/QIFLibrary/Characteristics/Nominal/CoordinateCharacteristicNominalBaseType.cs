/*! \file CoordinateCharacteristicNominalBaseType.cs
    \brief defines a unique coordinate characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <summary>
    /// The CoordinateCharacteristicNominalBaseType is the abstract base type that defines a unique coordinate characteristic nominal.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class CoordinateCharacteristicNominalBaseType : DimensionalCharacteristicNominalBaseType
    {
    }

    /// <remarks> The AngularCoordinateCharacteristicNominalType defines a unique angular coordinate characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AngularCoordinateCharacteristicNominalType : CoordinateCharacteristicNominalBaseType
    {
        /// <remarks> The optional TargetValue element is the nominal value for the angular coordinate characteristic.</remarks>
        public Units.AngularValueType? TargetValue { get; set; }

        /// <remarks> The Direction element is the coordinate axis for the characteristic.</remarks>
        public IntermediatesPMI.AngularCoordinateDirectionEnumType Direction { get; set; }

        /// <remarks> The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which this characteristic is evaluated.</remarks>
        public Primitives.QIFReferenceFullType? CoordinateSystemId { get; set; }
    }

    /// <remarks> The LinearCoordinateCharacteristicNominalType defines a unique linear coordinate characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class LinearCoordinateCharacteristicNominalType : CoordinateCharacteristicNominalBaseType
    {
        /// <remarks> The optional TargetValue element is the nominal value.</remarks>
        public Units.LinearValueType? TargetValue { get; set; }

        /// <remarks> The Direction element is the coordinate axis for the characteristic.</remarks>
        public IntermediatesPMI.LinearCoordinateDirectionEnumType Direction { get; set; }

        /// <remarks> The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which this characteristic is evaluated.</remarks>
        public Primitives.QIFReferenceFullType? CoordinateSystemId { get; set; }
    }
}
