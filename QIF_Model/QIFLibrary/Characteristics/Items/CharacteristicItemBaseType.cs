/*! \file CharacteristicItemBaseType.cs
    \brief abstract base type that defines information common to all characteristic items.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <summary>
    /// The CharacteristicItemBaseType is the abstract base type that defines information common to all characteristic items.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CharacteristicItemBaseType : CharacteristicBaseType
    {
        /// <remarks The optional Name element is the name of the characteristic./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Name { get; set; }

        /// <remarks
        /// The optional CharacteristicDesignator element is the
        /// designator of a characteristic together with an optional
        /// level of criticality and optional UUID.The designator
        /// element of the CharacteristicDesignator will typically be
        /// at the most general level when used in this
        /// CharacteristicDefinitionBaseType.For example, an instance
        /// of CharacteristicDefinitionBaseType might have a
        /// CharacteristicDesignator element with the Designator K.
        /// Then there might be three instances of
        /// CharacteristicItemBaseType referencing the
        /// CharacteristicDefinitionBaseType instance and having
        /// CharacteristicDesignator elements using Designators K-1, K-2, and K-3./>
        public CharacteristicDesignatorType CharacteristicDesignator { get; set; }

        /// <remarks The optional FeatureItemIds element is a list of the QIF
        /// ids of the instances of FeatureItemType to which the CharacteristicItem applies./>
        public Primitives.ArrayReferenceType FeatureItemIds { get; set; }

        /// <remarks The optional SubstituteFeatureAlgorithm element is the
        /// substitute feature data fitting algorithm for the feature or
        /// features.This setting overrides any substitute feature
        /// algorithm defined on the feature nominal or feature item for
        /// the purpose of evaluating this characteristic.This setting
        /// overrides the optional substitute feature algorithm on the characteristic nominal./>
        public IntermediatesPMI.SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }

        /// <remarks The optional NotableEventIds element is a list of QIF ids
        /// of notable events associated with the measurement of the characteristic./>
        public Primitives.ArrayReferenceType NotableEventIds { get; set; }

        /// <remarks The optional MeasurementDeviceIds element is a list of
        /// references to the measurement devices that may be used in the inspection of the characteristic./>
        public Primitives.ArrayReferenceType MeasurementDeviceIds { get; set; }

        /// <remarks The CharacteristicNominalId element is the QIF id of the nominal characteristic./>
        public Primitives.QIFReferenceFullType CharacteristicNominalId { get; set; }

        /// <remarks The optional LocationOnDrawing element gives information
        /// about the location of the characteristic callout on a printed drawing or in a digital model./>
        public LocationOnDrawingType LocationOnDrawing { get; set; }

        /// <remarks The optional VirtualMeasurement element represents a
        /// virtual measurement of the characteristic item.Knowing the
        /// id of the VirtualMeasurement enables finding the
        /// characteristic item with which the VirtualMeasurement is associated./>
        public IntermediatesPMI.VirtualMeasurementType VirtualMeasurement { get; set; }
    }

    /// <remarks The LocationOnDrawingType defines the drawing location of a characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LocationOnDrawingType
    {
        /// <remarks This compositor provides a choice among locations on printed or
        /// digital drawings, external digital models, and internal CAD representations./>
        [System.Xml.Serialization.XmlElementAttribute("DrawingId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("DrawingZone", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ModelId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("SheetNumber", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("View", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ViewId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public LocationOnDrawingChoiceType[] ItemsElementName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum LocationOnDrawingChoiceType
    {
        DrawingId,
        DrawingZone,
        ModelId,
        SheetNumber,
        View,
        ViewId,
    }


    /// <remarks TODO/>
    public class SurfaceTextureCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class ThreadCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedAttributeCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedAreaCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedForceCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedMassCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedPressureCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedSpeedCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedTemperatureCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedTimeCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedUnitCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldFilletCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldPlugCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldSlotCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldSpotCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldStudCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldSeamCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldSurfacingCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldEdgeCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldSquareCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldBevelCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldVCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldUCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldJCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldFlareVCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldFlareBevelCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldScarfCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class WeldCompoundCharacteristicItemType : CharacteristicItemBaseType
    {

    }
}
