/*! \file CharacteristicBaseType.cs
    \brief The CharacteristicBaseType is the abstract base type that defines information common to all characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <summary>
    /// The CharacteristicBaseType is the abstract base type that defines information common to all characteristics.
    /// </summary>
    public abstract class CharacteristicBaseType
    {
        /// <remarks> The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).</remarks>
        public Primitives.AttributesType Attributes { get; set; }

        /// <remarks> The optional Description element is a description of the characteristic.</remarks>
        public string Description { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks> The CharacteristicDesignatorType defines a designator, a UUID and a criticality level for a characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CharacteristicDesignatorType
    {
        /// <remarks> The Designator element is the identifier of a characteristic. A 
        /// characteristic designator is often identified by a
        /// number(or a number and a letter) in a balloon on a drawing or in a digital model.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Designator { get; set; }

        /// <remarks> The optional UUID element is a persistent identifier for
        /// the characteristic designator.If used, it should be generated
        /// using a widely accepted UUID generator.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public Primitives.QPIdType UUID { get; set; }

        /// <remarks> The optional Criticality element is the criticality level of the characteristic.</remarks>
        public CriticalityType Criticality { get; set; }

        /// <remarks> The optional Balloon element defines the characteristics of a
        /// characteristic identifier balloon from a printed drawing or
        /// from an external digital drawing or model.QIF model based
        /// definitions describe characteristic balloons explicitly
        /// internally as visualization CAD data.</remarks>
        public CharacteristicBalloonType Balloon { get; set; }
    }

    /// <remarks> The CriticalityType defines a criticality level for a characteristic and optionally defines a criticality area.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CriticalityType
    {
        /// <remarks> This compositor provides a choice between the criticality level
        /// as an enumeration of a common type and a user defined string
        /// that describes the criticality.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("LevelEnum", typeof(CriticalityLevelEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherLevel", typeof(string))]
        public object Level { get; set; }

        /// <remarks> This optional compositor refines the meaning of the
        /// criticality level by defining the area to which it applies.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AreaEnum", typeof(CriticalityAreaEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherArea", typeof(string))]
        public object Area { get; set; }
    }

    /// <remarks> The CriticalityLevelEnumType enumerates values that describe characteristic criticality levels.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CriticalityLevelEnumType
    {
        MINOR,
        MAJOR,
        CRITICAL,
        KEY,
        UNDEFINED,
    }

    /// <remarks> The CriticalityAreaEnumType enumerates values that describe characteristic criticality areas.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CriticalityAreaEnumType
    {
        SAFETY,
        MISSION,
        FIT,
        FUNCTION,
        APPEARANCE,
        UNDEFINED,
    }

    /// <remarks> 
    /// The CharacteristicBalloonType defines a characteristic
    /// identifier balloon, i.e.a visual representation of the identifier
    /// on a print or drawing.This type provides a mechanism for
    /// describing characteristic balloons from printed drawings or
    /// from external digital drawings or models.QIF model based
    /// definitions describe characteristic balloons explicitly internally
    /// as visualization CAD data.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CharacteristicBalloonType
    {
        /// <remarks> The BalloonLocation element is the location of a characteristic
        /// designator balloon with respect to the characteristic to which it applies.</remarks>
        public CharacteristicBalloonLocationEnumType BalloonLocation { get; set; }

        /// <remarks> The BalloonStyle element is the style of a characteristic designator balloon.</remarks>
        public CharacteristicBalloonStyleEnumType BalloonStyle { get; set; }
    }

    /// <remarks> The CharacteristicBalloonLocationEnumType enumerates values that
    /// describe the location of a characteristic identifier balloon
    /// with respect to the print, drawing or model characteristic it describes.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CharacteristicBalloonLocationEnumType
    {
        ABOVE,
        BELOW,
        LEFT,
        RIGHT,
        DEFAULT,
        UNDEFINED,
    }

    /// <remarks> The CharacteristicBalloonStyleEnumType enumerates values that
    /// describe characteristic identifier balloon styles.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CharacteristicBalloonStyleEnumType
    {
        OPEN_CIRCLE,
        BARRED_CIRCLE,
        ELONGATED_CIRCLE,
        SPLIT_CIRCLE,
        PENTAGON,
        HEXAGON,
        OCTAGON,
        RECTANGLE,
        ROUNDED_RECTANGLE,
        ELONGATED_HEXAGON,
        FORWARD_CHEVRON,
        BACKWARD_CHEVRON,
        DEFAULT,
        UNDEFINED,
    }
}
