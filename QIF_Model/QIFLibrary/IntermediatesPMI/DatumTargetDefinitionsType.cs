/*! \file DatumTargetDefinitionsType.cs
	\brief The DatumTargetDefinitionsType defines a list of datum target definitions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The MovableDatumTargetDirectionType defines the direction in which a datum target can move./>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class MovableDatumTargetDirectionType
	{
        public MovableDatumTargetDirectionType() { }

        /// <summary>
        /// The DatumTargetTranslationDirection element is the vector
        /// direction in which the datum target can translate when a datum
        /// target is allowed to move in order to stabilize a datum reference frame.
        /// </summary>
        [XmlElement()]
        public Primitives.UnitVectorType DatumTargetTranslationDirection { get; set; }
    }

    /// <remarks The DatumTargetType defines a datum target definition./>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumTargetType : QIFIdTypeBase
    {
        public DatumTargetType() { }

        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement()]
        public Primitives.AttributesType Attributes { get; set; }

        /// <summary>
        /// The DatumTargetLabel element is the label for the datum target
        /// which includes both the datum name and the target number, for example 'A1'.
        /// </summary>
        [XmlElement]
        public string DatumTargetLabel { get; set; }

        /// <summary>
        /// The optional FeatureNominalId element is the QIF id of the
        /// feature nominal on which the datum target lies.
        /// </summary>
        [XmlElement()]
        public Primitives.QIFReferenceFullType FeatureNominalId { get; set; }

        /// <summary>
        /// The optional TargetZoneId element is the QIF id of the feature zone.
        /// </summary>
        [XmlElement()]
        public Primitives.QIFReferenceFullType TargetZoneId { get; set; }

        /// <summary>
        /// The optional MovableDatumTarget element identifies the datum
        /// target as a movable datum target and specifies the allowed direction of movement.
        /// </summary>
        [XmlElement()]
        public MovableDatumTargetDirectionType MovableDatumTarget { get; set; }
    }

    /// <remarks The DatumTargetDefinitionsType defines a list of datum target definitions./>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumTargetDefinitionsType
    {
        public DatumTargetDefinitionsType() { }

        /// <remarks Each DatumDefinition element gives information about a datum./>
        [XmlElement("DatumTarget", Type = typeof(DatumTargetType))]
        public List<DatumTargetType> DatumTargets { get; set; }

        /// <remarks The required n attribute is the number of datum target definitions in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.DatumTargets.Count;
            set { }
        }
    }
}
