/*! \file LinearCharacteristicDefinitionBaseType.cs
    \brief The LinearCharacteristicDefinitionBaseType is the abstract base type that defines a linear characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The LinearCharacteristicDefinitionBaseType is the abstract base type that defines a linear characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class LinearCharacteristicDefinitionBaseType : DimensionalCharacteristicDefinitionBaseType
    {
        /// <remarks> This compositor provides a choice between a toleranced
        /// characteristic and a non-toleranced characteristic that still needs to be tracked and/or reported.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("NonTolerance", typeof(IntermediatesPMI.NonToleranceEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("Tolerance", typeof(IntermediatesPMI.LinearToleranceType))]
        public object? Item { get; set; }
    }

    /// <summary>
    /// The DistanceBetweenCharacteristicDefinitionType defines information
    /// that can be common to more than one distance-between
    /// characteristic.The DistanceBetweenCharacteristicDefinitionType is used to tolerance between two features.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DistanceBetweenCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The DistanceFromCharacteristicDefinitionType defines information
    /// that can be common to more than one distance-from characteristic.
    /// The DistanceFromCharacteristicItemType is used to tolerance a
    /// feature with respect to an origin reference feature.
    /// </summary>
    public class DistanceFromCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The ChordCharacteristicDefinitionType defines information that can be common to more than one chord characteristic.
    /// </summary>
    public class ChordCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The ConicalTaperCharacteristicDefinitionType defines information
    /// that can be common to more than one conical taper characteristic.
    /// </summary>
    public class ConicalTaperCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The FlatTaperCharacteristicDefinitionType defines information that can be common to more than one flat taper characteristic.
    /// </summary>
    public class FlatTaperCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The SphericalRadiusCharacteristicDefinitionType defines information that can be common to more than one spherical radius characteristic.
    /// </summary>
    public class SphericalRadiusCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The RadiusCharacteristicDefinitionType defines information that can be common to more than one radius characteristic.
    /// </summary>
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class RadiusCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
        /// <remarks> The optional ControlledRadius element indicates whether the
        /// characteristic is a controlled radius.The element
        /// is set to "true" for controlled, and is set to "false" or is not present for not controlled.</remarks>
        public bool ControlledRadius { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ControlledRadiusSpecified { get; set; }
    }

    /// <summary>
    /// The SquareCharacteristicDefinitionType defines information that can
    /// be common to more than one square characteristic.This is the length of a side of a square.
    /// ASME Y14.5 - 2009 Section 3.3.16
    /// </summary>
    public class SquareCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The ThicknessCharacteristicDefinitionType defines information that can be common to more than one thickness characteristic.
    /// </summary>
    public class ThicknessCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The DepthCharacteristicDefinitionType defines information that can be common to more than one depth characteristic.
    /// </summary>
    public class DepthCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The HeightCharacteristicDefinitionType defines information that can be common to more than one height characteristic.
    /// </summary>
    public class HeightCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The WidthCharacteristicDefinitionType defines information that can be common to more than one width characteristic.
    /// </summary>
    public class WidthCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The LengthCharacteristicDefinitionType defines information that can be common to more than one length characteristic.
    /// </summary>
    public class LengthCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The SphericalDiameterCharacteristicDefinitionType defines
    /// information that can be common to more than one spherical diameter characteristic.
    /// </summary>
    public class SphericalDiameterCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The CurveLengthCharacteristicDefinitionType defines information that can be common to more than one curve length characteristic.
    /// </summary>
    public class CurveLengthCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }
}
