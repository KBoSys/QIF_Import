/*! \file ProfileCharacteristicDefinitionBaseType.cs
    \brief The ProfileCharacteristicDefinitionBaseType is the abstract base type that defines a profile characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The ProfileCharacteristicDefinitionBaseType is the abstract base type that defines a profile characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class ProfileCharacteristicDefinitionBaseType : GeometricCharacteristicDefinitionBaseType
    {
        /// <remarks The ToleranceValue element is the tolerance of the profile characteristic./>
        public Units.LinearValueType ToleranceValue { get; set; }

        /// <remarks The optional ToleranceDualValue element is the dual tolerance value of the profile characteristic./>
        public Units.LinearDualValueType ToleranceDualValue { get; set; }

        /// <remarks This optional compositor provides a choice between the ASME
        /// Y14.5 and ISO 1101 implementations of unequal, unilateral or offset profile tolerance zones./>
        /// 
        /// The optional OuterDisposition element is the outer
        /// disposition of the profile characteristic's tolerance
        /// zone when the tolerance zone is not symmetric about or is
        /// offset from the nominal surface or curve.The value
        /// represents the upper tolerance limit when the tolerance
        /// zone is expressed as a bi-directional tolerance.For
        /// asymmetrically disposed tolerance zones it can range in
        /// value from zero when the tolerance zone is completely
        /// inside the part material, to the whole tolerance value
        /// when the tolerance zone is completely outside the part
        /// material.For offset tolerance zones it will have a
        /// negative value for a tolerance zone offset inside the
        /// part material, or a positive value greater than the
        /// tolerance value for a tolerance zone offset outside the part material.
        /// 
        /// (ISO specific UZ) The optional UnequallyDisposedZone
        /// element is the center of the profile characteristic's
        /// tolerance zone when the tolerance zone is not symmetric
        /// about or is offset from the nominal surface or curve.For
        /// asymmetrically disposed tolerance zones it has a positive
        /// value when the center of the tolerance zone is outside
        /// the part material, and a negative value when the center
        /// of the tolerance zone is inside the part material.
        [System.Xml.Serialization.XmlElementAttribute("OuterDisposition", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("UnequallyDisposedZone", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ZoneTypeChoice")]
        public Units.LinearValueType ZoneType { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ZoneTypeChoiceType ZoneTypeChoice { get; set; }

        /// <remarks (ISO specific OZ) The optional OffsetZone element when
        /// present and set to true indicates that the profile tolerance zone can be offset by any unspecified amount./>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool OffsetZone { get; set; }

        /// <remarks (ISO specific VA) The optional VariableAngle element when
        /// present and set to true indicates that the profile
        /// tolerance zone can be offset by an unspecified angular amount./>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool VariableAngle { get; set; }

        /// <remarks The optional SecondCompositeSegmentProfileDefinition
        /// gives information about the second segment of a composite frame profile characteristic./>
        public CompositeSegmentProfileDefinitionType SecondCompositeSegmentProfileDefinition { get; set; }

        /// <remarks The optional ThirdCompositeSegmentProfileDefinition
        /// gives information about the third segment of a
        /// composite frame profile characteristic.This element may be used only if the
        /// SecondCompositeSegmentProfileDefinition element is used./>
        public CompositeSegmentProfileDefinitionType ThirdCompositeSegmentProfileDefinition { get; set; }

        /// <remarks The optional FourthCompositeSegmentProfileDefinition
        /// gives information about the fourth segment of a
        /// composite frame profile characteristic. This element may be used only if the
        /// ThirdCompositeSegmentProfileDefinition element is used./>
        public CompositeSegmentProfileDefinitionType FourthCompositeSegmentProfileDefinition { get; set; }

        /// <remarks The optional DatumReferenceFrameId element is the QIF id of
        /// the datum reference frame for the profile characteristic./>
        public Primitives.QIFReferenceFullType DatumReferenceFrameId { get; set; }

        /// <remarks (ISO specific greaterthan/lessthan) The optional
        /// OrientationOnly element when present and set to true
        /// signifies that the DRF associated with this profile
        /// characteristic controls only orientation degrees of freedom./>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool OrientationOnly { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ZoneTypeChoiceType
    {
        OuterDisposition,
        UnequallyDisposedZone,
    }

    /// <remarks The CompositeSegmentProfileDefinitionType defines information that
    /// can be common to more than one composite segment profile characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CompositeSegmentProfileDefinitionType : CompositeSegmentDefinitionBaseType
    {
        /// <remarks
        /// The optional OuterDisposition element is the outer
        /// disposition of the composite segment's tolerance zone when
        /// the tolerance zone is not symmetric about or is offset from
        /// the nominal surface or curve.The value represents the
        /// upper tolerance limit when the tolerance zone is expressed
        /// as a bi-directional tolerance.For asymmetrically disposed
        /// tolerance zones it can range in value from zero when the
        /// tolerance zone is completely inside the part material, to
        /// the whole tolerance value when the tolerance zone is
        /// completely outside the part material.For offset tolerance
        /// zones it will have a negative value for a tolerance zone
        /// offset inside the part material, or a positive value
        /// greater than the tolerance value for a tolerance zone
        /// offset outside the part material./>
        public Units.LinearValueType OuterDisposition { get; set; }
    }

    /// <summary>
    /// The global PointProfileCharacteristicDefinition element gives information about a point profile characteristic definition.
    /// </summary>
    public class PointProfileCharacteristicDefinitionType : ProfileCharacteristicDefinitionBaseType
	{
	}
}
