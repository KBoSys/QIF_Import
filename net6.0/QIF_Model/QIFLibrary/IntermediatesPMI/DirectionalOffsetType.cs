/*! \file DirectionalOffsetType.cs
    \brief The DirectionalOffsetType defines an offset or displacement in a specified direction.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The DirectionalOffsetType defines an offset or displacement in a specified direction.</remarks>
    public class DirectionalOffsetType
    {
        /// <remarks> The Offset element is offset in the specified direction, a
        /// positive value will offset in the specified direction and a
        /// negative value will offset opposite the specified direction.</remarks>
        [XmlElement]
        public Units.LinearValueType? Offset { get; set; }

        #region Choice
        [XmlChoiceIdentifier("DirectionType")]
        [XmlElement("NominalDirection", typeof(Primitives.UnitVectorType))]
        [XmlElement("FeatureDirection", typeof(BaseFeatureType))]
        public object? Direction;

        // Don't serialize this field. The EnumType field
        // contains the enumeration value that corresponds
        // to the MyChoice field value.
        [XmlIgnore]
        public OffsetDirectionChoiceType DirectionType;

        #endregion
    }
    [XmlType(IncludeInSchema = false)]
    public enum OffsetDirectionChoiceType
    {
        None,
        NominalDirection,
        FeatureDirection,
    }

    /// <remarks> (ISO specific) The ModifyingPlaneEnumType enumerates values that describe the modifying plane.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ModifyingPlaneEnumType
    {
        PARALLEL,
        PERPENDICULAR,
        INCLINED,
    }

    /// <remarks> (ISO specific) The DirectionFeatureType defines a direction-feature feature control frame modifier.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DirectionFeatureType
    {
        /// <remarks> The DirectionFeatureEnum element specifies how the direction is derived from the datum.</remarks>
        public ModifyingPlaneEnumType DirectionFeatureEnum { get; set; }

        /// <remarks> The DatumDefinitionId element identifies the datum from which the direction feature is derived.</remarks>
        public Primitives.QIFReferenceFullType? DatumDefinitionId { get; set; }
    }
}
