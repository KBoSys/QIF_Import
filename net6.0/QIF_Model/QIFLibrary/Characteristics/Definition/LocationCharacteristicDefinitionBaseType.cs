/*! \file LocationCharacteristicDefinitionBaseType.cs
    \brief Defines location characteristics

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The LocationCharacteristicDefinitionBaseType is the abstract base
    /// type that defines information that can be common to more than one location characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class LocationCharacteristicDefinitionBaseType : GeometricCharacteristicDefinitionBaseType
    {
        /// <remarks> The ToleranceValue element is the tolerance of the location characteristic.</remarks>
        public Units.LinearValueType? ToleranceValue { get; set; }

        /// <remarks> The optional ToleranceDualValue element is the dual tolerance value of the location characteristic.</remarks>
        public Units.LinearDualValueType? ToleranceDualValue { get; set; }

        /// <remarks> The optional DatumReferenceFrameId element is the QIF id of the datum reference frame for the location characteristic.</remarks>
        public Primitives.QIFReferenceFullType? DatumReferenceFrameId { get; set; }
    }

    /// <summary>
    /// The CoaxialityCharacteristicDefinitionType defines information that can be common to more than one coaxiality characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoaxialityCharacteristicDefinitionType : LocationCharacteristicDefinitionBaseType
    {
        /// <remarks> The ZoneShape element describes the shape of the tolerance zone.</remarks>
        public CoaxialityZoneShapeType? ZoneShape { get; set; }
    }

    /// <remarks> The CoaxialityZoneShapeType defines the shape of the tolerance zone for a coaxiality characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoaxialityZoneShapeType
    {
        /// <remarks>
        /// This compositor provides a choice of the zone shape for a
        /// coaxiality characteristic.The zone shape is indicated by any
        /// symbols preceding the tolerance value in the tolerance indicator.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DiametricalZone", typeof(CoaxialityDiametricalZoneType))]
        [System.Xml.Serialization.XmlElementAttribute("NonDiametricalZone", typeof(CoaxialityNonDiametricalZoneType))]
        public object? Item { get; set; }
    }

    /// <remarks> The CoaxialityDiametricalZoneType defines the shape of a
    /// tolerance zone as diametrical(a diameter symbol precedes the tolerance value in the tolerance indicator).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoaxialityDiametricalZoneType
    {
    }

    /// <remarks> The CoaxialityNonDiametricalZoneType defines the shape of a
    /// tolerance zone as not diametrical(no symbol precedes the
    /// tolerance value in the tolerance indicator).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoaxialityNonDiametricalZoneType
    {
    }

}
