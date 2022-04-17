/*! \file DatumReferenceFramesType.cs
	\brief Defines a list of datum reference frames.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
    /// <remarks 
    /// The DatumReferenceFrameType defines the datum reference component
    /// of a feature control frame.If no datums are referenced by a
    /// feature control frame(such as in a 'to itself' profile or position
    /// characteristic or in the lowermost segment of a composite profile
    /// or position) then a datum reference frame can still be needed but
    /// it contains no datums.Such a datum reference frame indicates that
    /// all 6 degrees of freedom are available unconstrained by datum features. 
    /// />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumReferenceFrameType : QIFIdTypeBase
    {
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        [XmlElement(IsNullable = true)]
        public AttributesType Attributes { get; set; }

        /// <remarks 
        /// The optional Datums element is a list of datums (simple,
        /// compound, or datum feature) with an assigned precedence (order). />
        [XmlElement(IsNullable = true)]
        public DatumsType Datums { get; set; }

        /// <remarks 
        /// The optional Name element is the name of the datum reference frame, e.g.ABC, STARTUP, AD(m)E(m). />
        [XmlElement(IsNullable = true)]
        public string Name { get; set; }

        /// <remarks 
        /// The optional Description element is a description of the datum reference frame. />
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }

        /// <remarks 
        /// The optional CoordinateSystemId element is the QIF id of the coordinate system in which the characteristic is evaluated. />
        [XmlElement(IsNullable = true)]
        public Primitives.QIFReferenceFullType CoordinateSystemId { get; set; }
    }

    /// <remarks The DatumReferenceFramesType defines a list of datum reference frames./>
    [System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumReferenceFramesType
    {
        /// <remarks Each DatumReferenceFrame element gives information about a datum reference frame./>
		[XmlElement(ElementName = "DatumReferenceFrame", Type = typeof(DatumReferenceFrameType))]
        public DatumReferenceFrameType[] DatumReferenceFrames { get; set; }

		/// <remarks The required n attribute is the number of datum reference frames in the list./>
		[XmlAttribute("n")]
        public int Count
        {
            get => this.DatumReferenceFrames.Length;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrame
    {

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatums datumsField;

        private string nameField;

        private string descriptionField;

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameCoordinateSystemId coordinateSystemIdField;

        private uint idField;

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatums Datums
        {
            get
            {
                return this.datumsField;
            }
            set
            {
                this.datumsField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameCoordinateSystemId CoordinateSystemId
        {
            get
            {
                return this.coordinateSystemIdField;
            }
            set
            {
                this.coordinateSystemIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatums
    {

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatum[] datumField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Datum")]
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatum[] Datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatum
    {

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatum simpleDatumField;

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumPrecedence precedenceField;

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatum SimpleDatum
        {
            get
            {
                return this.simpleDatumField;
            }
            set
            {
                this.simpleDatumField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumPrecedence Precedence
        {
            get
            {
                return this.precedenceField;
            }
            set
            {
                this.precedenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatum
    {

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumDefinitionId datumDefinitionIdField;

        private string materialModifierField;

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumSizeCharacteristicDefinitionId sizeCharacteristicDefinitionIdField;

        private string referencedComponentField;

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumSubstituteFeatureAlgorithm substituteFeatureAlgorithmField;

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumFeatureSimulatorModifier datumFeatureSimulatorModifierField;

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumTranslation datumTranslationField;

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDegreesOfFreedom degreesOfFreedomField;

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumProjectedDatum projectedDatumField;

        private string diameterModifierField;

        private string sectionModifierField;

        private bool contactingFeatureField;

        private bool distanceVariableField;

        private bool datumFixedField;

        private string reducedDatumField;

        private bool constrainOrientationField;

        private bool constrainSubsequentField;

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumDefinitionId DatumDefinitionId
        {
            get
            {
                return this.datumDefinitionIdField;
            }
            set
            {
                this.datumDefinitionIdField = value;
            }
        }

        /// <remarks/>
        public string MaterialModifier
        {
            get
            {
                return this.materialModifierField;
            }
            set
            {
                this.materialModifierField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumSizeCharacteristicDefinitionId SizeCharacteristicDefinitionId
        {
            get
            {
                return this.sizeCharacteristicDefinitionIdField;
            }
            set
            {
                this.sizeCharacteristicDefinitionIdField = value;
            }
        }

        /// <remarks/>
        public string ReferencedComponent
        {
            get
            {
                return this.referencedComponentField;
            }
            set
            {
                this.referencedComponentField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumSubstituteFeatureAlgorithm SubstituteFeatureAlgorithm
        {
            get
            {
                return this.substituteFeatureAlgorithmField;
            }
            set
            {
                this.substituteFeatureAlgorithmField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumFeatureSimulatorModifier DatumFeatureSimulatorModifier
        {
            get
            {
                return this.datumFeatureSimulatorModifierField;
            }
            set
            {
                this.datumFeatureSimulatorModifierField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumTranslation DatumTranslation
        {
            get
            {
                return this.datumTranslationField;
            }
            set
            {
                this.datumTranslationField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDegreesOfFreedom DegreesOfFreedom
        {
            get
            {
                return this.degreesOfFreedomField;
            }
            set
            {
                this.degreesOfFreedomField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumProjectedDatum ProjectedDatum
        {
            get
            {
                return this.projectedDatumField;
            }
            set
            {
                this.projectedDatumField = value;
            }
        }

        /// <remarks/>
        public string DiameterModifier
        {
            get
            {
                return this.diameterModifierField;
            }
            set
            {
                this.diameterModifierField = value;
            }
        }

        /// <remarks/>
        public string SectionModifier
        {
            get
            {
                return this.sectionModifierField;
            }
            set
            {
                this.sectionModifierField = value;
            }
        }

        /// <remarks/>
        public bool ContactingFeature
        {
            get
            {
                return this.contactingFeatureField;
            }
            set
            {
                this.contactingFeatureField = value;
            }
        }

        /// <remarks/>
        public bool DistanceVariable
        {
            get
            {
                return this.distanceVariableField;
            }
            set
            {
                this.distanceVariableField = value;
            }
        }

        /// <remarks/>
        public bool DatumFixed
        {
            get
            {
                return this.datumFixedField;
            }
            set
            {
                this.datumFixedField = value;
            }
        }

        /// <remarks/>
        public string ReducedDatum
        {
            get
            {
                return this.reducedDatumField;
            }
            set
            {
                this.reducedDatumField = value;
            }
        }

        /// <remarks/>
        public bool ConstrainOrientation
        {
            get
            {
                return this.constrainOrientationField;
            }
            set
            {
                this.constrainOrientationField = value;
            }
        }

        /// <remarks/>
        public bool ConstrainSubsequent
        {
            get
            {
                return this.constrainSubsequentField;
            }
            set
            {
                this.constrainSubsequentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumDefinitionId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumSizeCharacteristicDefinitionId
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumSubstituteFeatureAlgorithm
    {

        private string substituteFeatureAlgorithmEnumField;

        /// <remarks/>
        public string SubstituteFeatureAlgorithmEnum
        {
            get
            {
                return this.substituteFeatureAlgorithmEnumField;
            }
            set
            {
                this.substituteFeatureAlgorithmEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumFeatureSimulatorModifier
    {

        private QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumFeatureSimulatorModifierLinearSize linearSizeField;

        /// <remarks/>
        public QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumFeatureSimulatorModifierLinearSize LinearSize
        {
            get
            {
                return this.linearSizeField;
            }
            set
            {
                this.linearSizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumFeatureSimulatorModifierLinearSize
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDatumTranslation
    {

        private bool datumTranslationAllowedField;

        /// <remarks/>
        public bool DatumTranslationAllowed
        {
            get
            {
                return this.datumTranslationAllowedField;
            }
            set
            {
                this.datumTranslationAllowedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumDegreesOfFreedom
    {

        private string[] degreeOfFreedomField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DegreeOfFreedom")]
        public string[] DegreeOfFreedom
        {
            get
            {
                return this.degreeOfFreedomField;
            }
            set
            {
                this.degreeOfFreedomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumSimpleDatumProjectedDatum
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameDatumsDatumPrecedence
    {

        private string precedenceEnumField;

        /// <remarks/>
        public string PrecedenceEnum
        {
            get
            {
                return this.precedenceEnumField;
            }
            set
            {
                this.precedenceEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumReferenceFramesDatumReferenceFrameCoordinateSystemId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }
}
