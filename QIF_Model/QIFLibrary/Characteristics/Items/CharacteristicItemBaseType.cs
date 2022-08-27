/*! \file CharacteristicItemBaseType.cs
    \brief abstract base type that defines information common to all characteristic items.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

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
        /// <remarks> The optional Name element is the name of the characteristic.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Name { get; set; }

        /// <remarks>
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
        /// CharacteristicDesignator elements using Designators K-1, K-2, and K-3.</remarks>
        public CharacteristicDesignatorType CharacteristicDesignator { get; set; }

        /// <remarks> The optional FeatureItemIds element is a list of the QIF
        /// ids of the instances of FeatureItemType to which the CharacteristicItem applies.</remarks>
        public Primitives.ArrayReferenceType FeatureItemIds { get; set; }

        /// <remarks> The optional SubstituteFeatureAlgorithm element is the
        /// substitute feature data fitting algorithm for the feature or
        /// features.This setting overrides any substitute feature
        /// algorithm defined on the feature nominal or feature item for
        /// the purpose of evaluating this characteristic.This setting
        /// overrides the optional substitute feature algorithm on the characteristic nominal.</remarks>
        public IntermediatesPMI.SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }

        /// <remarks> The optional NotableEventIds element is a list of QIF ids
        /// of notable events associated with the measurement of the characteristic.</remarks>
        public Primitives.ArrayReferenceType NotableEventIds { get; set; }

        /// <remarks> The optional MeasurementDeviceIds element is a list of
        /// references to the measurement devices that may be used in the inspection of the characteristic.</remarks>
        public Primitives.ArrayReferenceType MeasurementDeviceIds { get; set; }

        /// <remarks> The CharacteristicNominalId element is the QIF id of the nominal characteristic.</remarks>
        public Primitives.QIFReferenceFullType CharacteristicNominalId { get; set; }

        /// <remarks> The optional LocationOnDrawing element gives information
        /// about the location of the characteristic callout on a printed drawing or in a digital model.</remarks>
        public LocationOnDrawingType LocationOnDrawing { get; set; }

        /// <remarks> The optional VirtualMeasurement element represents a
        /// virtual measurement of the characteristic item.Knowing the
        /// id of the VirtualMeasurement enables finding the
        /// characteristic item with which the VirtualMeasurement is associated.</remarks>
        public IntermediatesPMI.VirtualMeasurementType VirtualMeasurement { get; set; }
    }

    /// <remarks> The LocationOnDrawingType defines the drawing location of a characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LocationOnDrawingType
    {
        /// <remarks> This compositor provides a choice among locations on printed or
        /// digital drawings, external digital models, and internal CAD representations.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DrawingId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("DrawingZone", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ModelId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("SheetNumber", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("View", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ViewId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks></remarks>
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


    /// <remarks> The SurfaceTextureCharacteristicItemType defines a surface texture characteristic item.</remarks>
    public class SurfaceTextureCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks> The ThreadCharacteristicItemType defines a thread characteristic item.</remarks>
    public class ThreadCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks> The UserDefinedAttributeCharacteristicItemType defines a user-defined attribute characteristic item.</remarks>
    public class UserDefinedAttributeCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks> The AreaCharacteristicItemBaseType is the abstract base type that defines an area characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedAreaCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class AreaCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }

    /// <remarks> The UserDefinedAreaCharacteristicItemType is
    /// a characteristic item specified by the user that is
    /// measured in area units.</remarks>
    public class UserDefinedAreaCharacteristicItemType : AreaCharacteristicItemBaseType
    {

    }

    /// <remarks> The ForceCharacteristicItemBaseType is the abstract base type that defines a force characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedForceCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ForceCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }

    /// <remarks> The UserDefinedForceCharacteristicItemType is
    /// a characteristic item specified by the user that is measured in force units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedForceCharacteristicItemType : ForceCharacteristicItemBaseType
    {
    }

    /// <remarks> The MassCharacteristicItemBaseType is the abstract base type that defines a mass characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedMassCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class MassCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }

    /// <remarks> The UserDefinedMassCharacteristicItemType is
    /// a characteristic item specified by the user that is measured in mass units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedMassCharacteristicItemType : MassCharacteristicItemBaseType
    {
    }

    /// <remarks> The PressureCharacteristicItemBaseType is the abstract base type that defines a pressure characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedPressureCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PressureCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }

    /// <remarks> The UserDefinedPressureCharacteristicItemType is
    /// a characteristic item specified by the user that is measured in pressure units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedPressureCharacteristicItemType : PressureCharacteristicItemBaseType
    {
    }

    /// <remarks> The SpeedCharacteristicItemBaseType is the abstract base type that defines a speed characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedSpeedCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class SpeedCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }

    /// <remarks> The UserDefinedSpeedCharacteristicItemType is
    /// a characteristic item specified by the user that is measured in speed units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedSpeedCharacteristicItemType : SpeedCharacteristicItemBaseType
    {
    }

    /// <remarks> The TemperatureCharacteristicItemBaseType is the abstract base type that defines a temperature characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedTemperatureCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class TemperatureCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }

    /// <remarks> The UserDefinedTemperatureCharacteristicItemType is
    /// a characteristic item specified by the user that is measured in temperature units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedTemperatureCharacteristicItemType : TemperatureCharacteristicItemBaseType
    {
    }

    /// <remarks> The TimeCharacteristicItemBaseType is the abstract base type that defines a time characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedTimeCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class TimeCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }

    /// <remarks> The UserDefinedTimeCharacteristicItemType is
    /// a characteristic item specified by the user that is measured in time units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedTimeCharacteristicItemType : TimeCharacteristicItemBaseType
    {
    }

    /// <remarks> The UserDefinedUnitCharacteristicItemType defines a user-defined
    /// numerical characteristic item that is specific to an application
    /// and has numerical values and units that are not available in
    /// another user-defined characteristic type.In particular this type
    /// is not to be used to define characteristics with linear units,
    /// angular units, or units of temperature, area, force, mass,
    /// pressure, speed, or time.</remarks>
    public class UserDefinedUnitCharacteristicItemType : CharacteristicItemBaseType
    {

    }

    /// <remarks> The WeldCharacteristicItemBaseType is the abstract base type that defines a weld characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldCompoundCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldScarfCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareBevelCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareVCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldJCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldUCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldVCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldBevelCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSquareCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldEdgeCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSurfacingCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSeamCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldStudCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSpotCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSlotCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldPlugCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFilletCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class WeldCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }

    /// <remarks> The WeldCompoundCharacteristicItemType defines a compound weld characteristic item.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldCompoundCharacteristicItemType : WeldCharacteristicItemBaseType
    {
        /// <remarks> The WeldCharacteristicItemIds element is a list of the QIF ids of the weld characteristic items.</remarks>
        public ArrayReferenceType WeldCharacteristicItemIds { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldScarfCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFlareBevelCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFlareVCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldJCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldUCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldVCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldBevelCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSquareCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldEdgeCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSurfacingCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSeamCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldStudCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSpotCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSlotCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldPlugCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFilletCharacteristicItemType : WeldCharacteristicItemBaseType
    {
    }
}
