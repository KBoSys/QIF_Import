/*! \file Features.cs
    \brief defines types that describe dimensional metrology features

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using QIF_Model.QIFLibrary.Features.FeatureDefinitions;

namespace QIF_Model.QIFLibrary.Features
{
	/// <remarks Metrology Features/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
	public partial class Features
	{
		#region Private Fields
		private FeatureDefinitionsType featureDefinitionsField;
		private Nominals featureNominalsField;
		private Items featureItemsField;
		private NominalPointSets nominalPointSetsField;
		#endregion

		#region Properties
		/// <remarks Feature Definitions (optional)/>
		[XmlElement("FeatureDefinitions")]
		public FeatureDefinitionsType FeatureDefinitions
		{
			get => this.featureDefinitionsField;
			set => this.featureDefinitionsField = value;
		}

		/// <remarks Nominals (optional)/>
		public Nominals FeatureNominals
		{
			get => this.featureNominalsField;
			set => this.featureNominalsField = value;
		}

		/// <remarks Items (optionsL/>
		public Items FeatureItems
		{
			get => this.featureItemsField;
			set => this.featureItemsField = value;
		}

		/// <remarks Point Sets (optional)/>
		public NominalPointSets NominalPointSets
		{
			get => this.nominalPointSetsField;
			set => this.nominalPointSetsField = value;
		}
		#endregion
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributes
	{

		private FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeBool attributeBoolField;

		private FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeStr attributeStrField;

		private FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeTime attributeTimeField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeBool AttributeBool
		{
			get
			{
				return this.attributeBoolField;
			}
			set
			{
				this.attributeBoolField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeStr AttributeStr
		{
			get
			{
				return this.attributeStrField;
			}
			set
			{
				this.attributeStrField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeTime AttributeTime
		{
			get
			{
				return this.attributeTimeField;
			}
			set
			{
				this.attributeTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeBool
	{

		private bool valueField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool value
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeStr
	{

		private string valueField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string value
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributesAttributeTime
	{

		private System.DateTime valueField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public System.DateTime value
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureDefinitionsCircleFeatureDefinitionDiameter
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private byte valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		public byte Value
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
	public partial class FeaturesFeatureDefinitionsCircularArcFeatureDefinitionRadius
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private byte valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		public byte Value
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
	public partial class FeaturesFeatureDefinitionsConeFeatureDefinition
	{

		private string internalExternalField;

		private FeaturesFeatureDefinitionsConeFeatureDefinitionDiameter diameterField;

		private FeaturesFeatureDefinitionsConeFeatureDefinitionHalfAngle halfAngleField;

		private FeaturesFeatureDefinitionsConeFeatureDefinitionLargeEndDistance largeEndDistanceField;

		private FeaturesFeatureDefinitionsConeFeatureDefinitionSmallEndDistance smallEndDistanceField;

		private byte idField;

		/// <remarks/>
		public string InternalExternal
		{
			get
			{
				return this.internalExternalField;
			}
			set
			{
				this.internalExternalField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsConeFeatureDefinitionDiameter Diameter
		{
			get
			{
				return this.diameterField;
			}
			set
			{
				this.diameterField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsConeFeatureDefinitionHalfAngle HalfAngle
		{
			get
			{
				return this.halfAngleField;
			}
			set
			{
				this.halfAngleField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsConeFeatureDefinitionLargeEndDistance LargeEndDistance
		{
			get
			{
				return this.largeEndDistanceField;
			}
			set
			{
				this.largeEndDistanceField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsConeFeatureDefinitionSmallEndDistance SmallEndDistance
		{
			get
			{
				return this.smallEndDistanceField;
			}
			set
			{
				this.smallEndDistanceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureDefinitionsConeFeatureDefinitionDiameter
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private byte valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		public byte Value
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
	public partial class FeaturesFeatureDefinitionsConeFeatureDefinitionHalfAngle
	{

		private string angularUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private byte valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string angularUnit
		{
			get
			{
				return this.angularUnitField;
			}
			set
			{
				this.angularUnitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		public byte Value
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
	public partial class FeaturesFeatureDefinitionsConeFeatureDefinitionLargeEndDistance
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private byte valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		public byte Value
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
	public partial class FeaturesFeatureDefinitionsConeFeatureDefinitionSmallEndDistance
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private byte valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		public byte Value
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominal
	{

		private string nameField;

		private string uUIDField;

		private FeaturesFeatureNominalsCircleFeatureNominalFeatureDefinitionId featureDefinitionIdField;

		private FeaturesFeatureNominalsCircleFeatureNominalParentFeatureNominalId parentFeatureNominalIdField;

		private FeaturesFeatureNominalsCircleFeatureNominalEntityInternalIds entityInternalIdsField;

		private FeaturesFeatureNominalsCircleFeatureNominalEntityExternalIds entityExternalIdsField;

		private FeaturesFeatureNominalsCircleFeatureNominalPointList pointListField;

		private FeaturesFeatureNominalsCircleFeatureNominalSubstituteFeatureAlgorithm substituteFeatureAlgorithmField;

		private FeaturesFeatureNominalsCircleFeatureNominalSurfaceFeatureNominalId surfaceFeatureNominalIdField;

		private FeaturesFeatureNominalsCircleFeatureNominalLocation locationField;

		private FeaturesFeatureNominalsCircleFeatureNominalNormal normalField;

		private FeaturesFeatureNominalsCircleFeatureNominalSweep sweepField;

		private FeaturesFeatureNominalsCircleFeatureNominalConstructed constructedField;

		private byte idField;

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
		public string UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalFeatureDefinitionId FeatureDefinitionId
		{
			get
			{
				return this.featureDefinitionIdField;
			}
			set
			{
				this.featureDefinitionIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalParentFeatureNominalId ParentFeatureNominalId
		{
			get
			{
				return this.parentFeatureNominalIdField;
			}
			set
			{
				this.parentFeatureNominalIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalEntityInternalIds EntityInternalIds
		{
			get
			{
				return this.entityInternalIdsField;
			}
			set
			{
				this.entityInternalIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalEntityExternalIds EntityExternalIds
		{
			get
			{
				return this.entityExternalIdsField;
			}
			set
			{
				this.entityExternalIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalSubstituteFeatureAlgorithm SubstituteFeatureAlgorithm
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
		public FeaturesFeatureNominalsCircleFeatureNominalSurfaceFeatureNominalId SurfaceFeatureNominalId
		{
			get
			{
				return this.surfaceFeatureNominalIdField;
			}
			set
			{
				this.surfaceFeatureNominalIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalLocation Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalNormal Normal
		{
			get
			{
				return this.normalField;
			}
			set
			{
				this.normalField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalSweep Sweep
		{
			get
			{
				return this.sweepField;
			}
			set
			{
				this.sweepField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalConstructed Constructed
		{
			get
			{
				return this.constructedField;
			}
			set
			{
				this.constructedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalFeatureDefinitionId
	{

		private byte xIdField;

		private byte valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
		public byte Value
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalParentFeatureNominalId
	{

		private byte xIdField;

		private byte valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
		public byte Value
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalEntityInternalIds
	{

		private FeaturesFeatureNominalsCircleFeatureNominalEntityInternalIdsID[] idField;

		private byte nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureNominalsCircleFeatureNominalEntityInternalIdsID[] Id
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalEntityInternalIdsID
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalEntityExternalIds
	{

		private FeaturesFeatureNominalsCircleFeatureNominalEntityExternalIdsID[] idField;

		private byte nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureNominalsCircleFeatureNominalEntityExternalIdsID[] Id
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalEntityExternalIdsID
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalPointList
	{

		private FeaturesFeatureNominalsCircleFeatureNominalPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureNominalsCircleFeatureNominalPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureNominalsCircleFeatureNominalPointListSinglePointSetId singlePointSetIdField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalPointListWholePointSetId
	{

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalPointListRangePointSetId
	{

		private string rangeField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalPointListSinglePointSetId
	{

		private byte indexField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalSubstituteFeatureAlgorithm
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalSurfaceFeatureNominalId
	{

		private byte asmPathIdField;

		private byte asmPathXIdField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte asmPathId
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
		public byte asmPathXId
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
		public byte xId
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalLocation
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private string validityField;

		private byte xDecimalPlacesField;

		private byte xSignificantFiguresField;

		private string xValidityField;

		private byte yDecimalPlacesField;

		private byte ySignificantFiguresField;

		private string yValidityField;

		private byte zDecimalPlacesField;

		private byte zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalNormal
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private string validityField;

		private byte xDecimalPlacesField;

		private byte xSignificantFiguresField;

		private string xValidityField;

		private byte yDecimalPlacesField;

		private byte ySignificantFiguresField;

		private string yValidityField;

		private byte zDecimalPlacesField;

		private byte zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalSweep
	{

		private FeaturesFeatureNominalsCircleFeatureNominalSweepDirBeg dirBegField;

		private FeaturesFeatureNominalsCircleFeatureNominalSweepDomainAngle domainAngleField;

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalSweepDirBeg DirBeg
		{
			get
			{
				return this.dirBegField;
			}
			set
			{
				this.dirBegField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalSweepDomainAngle DomainAngle
		{
			get
			{
				return this.domainAngleField;
			}
			set
			{
				this.domainAngleField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsCircleFeatureNominalSweepDirBeg
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private string validityField;

		private byte xDecimalPlacesField;

		private byte xSignificantFiguresField;

		private string xValidityField;

		private byte yDecimalPlacesField;

		private byte ySignificantFiguresField;

		private string yValidityField;

		private byte zDecimalPlacesField;

		private byte zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalSweepDomainAngle
	{

		private string angularUnitField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string angularUnit
		{
			get
			{
				return this.angularUnitField;
			}
			set
			{
				this.angularUnitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalConstructed
	{

		private FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFit bestFitField;

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFit BestFit
		{
			get
			{
				return this.bestFitField;
			}
			set
			{
				this.bestFitField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFit
	{

		private bool nominalsCalculatedField;

		private FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFitBaseFeature[] baseFeatureField;

		private byte nField;

		/// <remarks/>
		public bool NominalsCalculated
		{
			get
			{
				return this.nominalsCalculatedField;
			}
			set
			{
				this.nominalsCalculatedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
		public FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFitBaseFeature[] BaseFeature
		{
			get
			{
				return this.baseFeatureField;
			}
			set
			{
				this.baseFeatureField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFitBaseFeature
	{

		private string referencedComponentField;

		private FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFitBaseFeatureFeatureId featureIdField;

		private uint sequenceNumberField;

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
		public FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFitBaseFeatureFeatureId FeatureId
		{
			get
			{
				return this.featureIdField;
			}
			set
			{
				this.featureIdField = value;
			}
		}

		/// <remarks/>
		public uint SequenceNumber
		{
			get
			{
				return this.sequenceNumberField;
			}
			set
			{
				this.sequenceNumberField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsCircleFeatureNominalConstructedBestFitBaseFeatureFeatureId
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominal
	{

		private string nameField;

		private string uUIDField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalFeatureDefinitionId featureDefinitionIdField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalParentFeatureNominalId parentFeatureNominalIdField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalEntityInternalIds entityInternalIdsField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalEntityExternalIds entityExternalIdsField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalPointList pointListField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalSubstituteFeatureAlgorithm substituteFeatureAlgorithmField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalSurfaceFeatureNominalId surfaceFeatureNominalIdField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalLocation locationField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalSweep sweepField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalNormal normalField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalConstructed constructedField;

		private byte idField;

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
		public string UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalFeatureDefinitionId FeatureDefinitionId
		{
			get
			{
				return this.featureDefinitionIdField;
			}
			set
			{
				this.featureDefinitionIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalParentFeatureNominalId ParentFeatureNominalId
		{
			get
			{
				return this.parentFeatureNominalIdField;
			}
			set
			{
				this.parentFeatureNominalIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalEntityInternalIds EntityInternalIds
		{
			get
			{
				return this.entityInternalIdsField;
			}
			set
			{
				this.entityInternalIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalEntityExternalIds EntityExternalIds
		{
			get
			{
				return this.entityExternalIdsField;
			}
			set
			{
				this.entityExternalIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalSubstituteFeatureAlgorithm SubstituteFeatureAlgorithm
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
		public FeaturesFeatureNominalsCircularArcFeatureNominalSurfaceFeatureNominalId SurfaceFeatureNominalId
		{
			get
			{
				return this.surfaceFeatureNominalIdField;
			}
			set
			{
				this.surfaceFeatureNominalIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalLocation Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalSweep Sweep
		{
			get
			{
				return this.sweepField;
			}
			set
			{
				this.sweepField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalNormal Normal
		{
			get
			{
				return this.normalField;
			}
			set
			{
				this.normalField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalConstructed Constructed
		{
			get
			{
				return this.constructedField;
			}
			set
			{
				this.constructedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalFeatureDefinitionId
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalParentFeatureNominalId
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalEntityInternalIds
	{

		private FeaturesFeatureNominalsCircularArcFeatureNominalEntityInternalIdsID[] idField;

		private uint nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureNominalsCircularArcFeatureNominalEntityInternalIdsID[] Id
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalEntityInternalIdsID
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalEntityExternalIds
	{

		private FeaturesFeatureNominalsCircularArcFeatureNominalEntityExternalIdsID[] idField;

		private uint nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureNominalsCircularArcFeatureNominalEntityExternalIdsID[] Id
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalEntityExternalIdsID
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalPointList
	{

		private FeaturesFeatureNominalsCircularArcFeatureNominalPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalPointListSinglePointSetId singlePointSetIdField;

		private uint nField;

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalPointListWholePointSetId
	{

		private uint xIdField;

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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalPointListRangePointSetId
	{

		private string rangeField;

		private uint xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalPointListSinglePointSetId
	{

		private uint indexField;

		private uint xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public uint index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalSubstituteFeatureAlgorithm
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalSurfaceFeatureNominalId
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalLocation
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private string validityField;

		private byte xDecimalPlacesField;

		private byte xSignificantFiguresField;

		private string xValidityField;

		private byte yDecimalPlacesField;

		private byte ySignificantFiguresField;

		private string yValidityField;

		private byte zDecimalPlacesField;

		private byte zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalSweep
	{

		private FeaturesFeatureNominalsCircularArcFeatureNominalSweepDirBeg dirBegField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalSweepDomainAngle domainAngleField;

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalSweepDirBeg DirBeg
		{
			get
			{
				return this.dirBegField;
			}
			set
			{
				this.dirBegField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalSweepDomainAngle DomainAngle
		{
			get
			{
				return this.domainAngleField;
			}
			set
			{
				this.domainAngleField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalSweepDirBeg
	{

		private string linearUnitField;

		private string decimalPlacesField;

		private string significantFiguresField;

		private string validityField;

		private string xDecimalPlacesField;

		private string xSignificantFiguresField;

		private string xValidityField;

		private string yDecimalPlacesField;

		private string ySignificantFiguresField;

		private string yValidityField;

		private string zDecimalPlacesField;

		private string zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalSweepDomainAngle
	{

		private string angularUnitField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string angularUnit
		{
			get
			{
				return this.angularUnitField;
			}
			set
			{
				this.angularUnitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalNormal
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private string validityField;

		private byte xDecimalPlacesField;

		private byte xSignificantFiguresField;

		private string xValidityField;

		private byte yDecimalPlacesField;

		private byte ySignificantFiguresField;

		private string yValidityField;

		private byte zDecimalPlacesField;

		private byte zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalConstructed
	{

		private FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFit bestFitField;

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFit BestFit
		{
			get
			{
				return this.bestFitField;
			}
			set
			{
				this.bestFitField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFit
	{

		private bool nominalsCalculatedField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFitBaseFeature[] baseFeatureField;

		private byte nField;

		/// <remarks/>
		public bool NominalsCalculated
		{
			get
			{
				return this.nominalsCalculatedField;
			}
			set
			{
				this.nominalsCalculatedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
		public FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFitBaseFeature[] BaseFeature
		{
			get
			{
				return this.baseFeatureField;
			}
			set
			{
				this.baseFeatureField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFitBaseFeature
	{

		private string referencedComponentField;

		private FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFitBaseFeatureFeatureId featureIdField;

		private uint sequenceNumberField;

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
		public FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFitBaseFeatureFeatureId FeatureId
		{
			get
			{
				return this.featureIdField;
			}
			set
			{
				this.featureIdField = value;
			}
		}

		/// <remarks/>
		public uint SequenceNumber
		{
			get
			{
				return this.sequenceNumberField;
			}
			set
			{
				this.sequenceNumberField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsCircularArcFeatureNominalConstructedBestFitBaseFeatureFeatureId
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
	public partial class FeaturesFeatureNominalsConeFeatureNominal
	{

		private string nameField;

		private string uUIDField;

		private FeaturesFeatureNominalsConeFeatureNominalFeatureDefinitionId featureDefinitionIdField;

		private FeaturesFeatureNominalsConeFeatureNominalParentFeatureNominalId parentFeatureNominalIdField;

		private FeaturesFeatureNominalsConeFeatureNominalEntityInternalIds entityInternalIdsField;

		private FeaturesFeatureNominalsConeFeatureNominalEntityExternalIds entityExternalIdsField;

		private FeaturesFeatureNominalsConeFeatureNominalPointList pointListField;

		private FeaturesFeatureNominalsConeFeatureNominalSubstituteFeatureAlgorithm substituteFeatureAlgorithmField;

		private FeaturesFeatureNominalsConeFeatureNominalAxis axisField;

		private FeaturesFeatureNominalsConeFeatureNominalSweep sweepField;

		private FeaturesFeatureNominalsConeFeatureNominalConstructed constructedField;

		private byte idField;

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
		public string UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalFeatureDefinitionId FeatureDefinitionId
		{
			get
			{
				return this.featureDefinitionIdField;
			}
			set
			{
				this.featureDefinitionIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalParentFeatureNominalId ParentFeatureNominalId
		{
			get
			{
				return this.parentFeatureNominalIdField;
			}
			set
			{
				this.parentFeatureNominalIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalEntityInternalIds EntityInternalIds
		{
			get
			{
				return this.entityInternalIdsField;
			}
			set
			{
				this.entityInternalIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalEntityExternalIds EntityExternalIds
		{
			get
			{
				return this.entityExternalIdsField;
			}
			set
			{
				this.entityExternalIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalSubstituteFeatureAlgorithm SubstituteFeatureAlgorithm
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
		public FeaturesFeatureNominalsConeFeatureNominalAxis Axis
		{
			get
			{
				return this.axisField;
			}
			set
			{
				this.axisField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalSweep Sweep
		{
			get
			{
				return this.sweepField;
			}
			set
			{
				this.sweepField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalConstructed Constructed
		{
			get
			{
				return this.constructedField;
			}
			set
			{
				this.constructedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalFeatureDefinitionId
	{

		private byte xIdField;

		private byte valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
		public byte Value
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalParentFeatureNominalId
	{

		private byte xIdField;

		private byte valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
		public byte Value
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalEntityInternalIds
	{

		private FeaturesFeatureNominalsConeFeatureNominalEntityInternalIdsID[] idField;

		private byte nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureNominalsConeFeatureNominalEntityInternalIdsID[] Id
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalEntityInternalIdsID
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalEntityExternalIds
	{

		private FeaturesFeatureNominalsConeFeatureNominalEntityExternalIdsID[] idField;

		private byte nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureNominalsConeFeatureNominalEntityExternalIdsID[] Id
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalEntityExternalIdsID
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalPointList
	{

		private FeaturesFeatureNominalsConeFeatureNominalPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureNominalsConeFeatureNominalPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureNominalsConeFeatureNominalPointListSinglePointSetId singlePointSetIdField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalPointListWholePointSetId
	{

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalPointListRangePointSetId
	{

		private string rangeField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalPointListSinglePointSetId
	{

		private byte indexField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalSubstituteFeatureAlgorithm
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalAxis
	{

		private FeaturesFeatureNominalsConeFeatureNominalAxisAxisPoint axisPointField;

		private FeaturesFeatureNominalsConeFeatureNominalAxisDirection directionField;

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalAxisAxisPoint AxisPoint
		{
			get
			{
				return this.axisPointField;
			}
			set
			{
				this.axisPointField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalAxisDirection Direction
		{
			get
			{
				return this.directionField;
			}
			set
			{
				this.directionField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsConeFeatureNominalAxisAxisPoint
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private string validityField;

		private byte xDecimalPlacesField;

		private byte xSignificantFiguresField;

		private string xValidityField;

		private byte yDecimalPlacesField;

		private byte ySignificantFiguresField;

		private string yValidityField;

		private byte zDecimalPlacesField;

		private byte zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalAxisDirection
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private string validityField;

		private byte xDecimalPlacesField;

		private byte xSignificantFiguresField;

		private string xValidityField;

		private byte yDecimalPlacesField;

		private byte ySignificantFiguresField;

		private string yValidityField;

		private byte zDecimalPlacesField;

		private byte zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalSweep
	{

		private FeaturesFeatureNominalsConeFeatureNominalSweepDirBeg dirBegField;

		private FeaturesFeatureNominalsConeFeatureNominalSweepDomainAngle domainAngleField;

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalSweepDirBeg DirBeg
		{
			get
			{
				return this.dirBegField;
			}
			set
			{
				this.dirBegField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalSweepDomainAngle DomainAngle
		{
			get
			{
				return this.domainAngleField;
			}
			set
			{
				this.domainAngleField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsConeFeatureNominalSweepDirBeg
	{

		private string linearUnitField;

		private byte decimalPlacesField;

		private byte significantFiguresField;

		private string validityField;

		private byte xDecimalPlacesField;

		private byte xSignificantFiguresField;

		private string xValidityField;

		private byte yDecimalPlacesField;

		private byte ySignificantFiguresField;

		private string yValidityField;

		private byte zDecimalPlacesField;

		private byte zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte decimalPlaces
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte significantFigures
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalSweepDomainAngle
	{

		private string angularUnitField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string angularUnit
		{
			get
			{
				return this.angularUnitField;
			}
			set
			{
				this.angularUnitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalConstructed
	{

		private FeaturesFeatureNominalsConeFeatureNominalConstructedBestFit bestFitField;

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominalConstructedBestFit BestFit
		{
			get
			{
				return this.bestFitField;
			}
			set
			{
				this.bestFitField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsConeFeatureNominalConstructedBestFit
	{

		private bool nominalsCalculatedField;

		private FeaturesFeatureNominalsConeFeatureNominalConstructedBestFitBaseFeature[] baseFeatureField;

		private byte nField;

		/// <remarks/>
		public bool NominalsCalculated
		{
			get
			{
				return this.nominalsCalculatedField;
			}
			set
			{
				this.nominalsCalculatedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
		public FeaturesFeatureNominalsConeFeatureNominalConstructedBestFitBaseFeature[] BaseFeature
		{
			get
			{
				return this.baseFeatureField;
			}
			set
			{
				this.baseFeatureField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureNominalsConeFeatureNominalConstructedBestFitBaseFeature
	{

		private string referencedComponentField;

		private FeaturesFeatureNominalsConeFeatureNominalConstructedBestFitBaseFeatureFeatureId featureIdField;

		private uint sequenceNumberField;

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
		public FeaturesFeatureNominalsConeFeatureNominalConstructedBestFitBaseFeatureFeatureId FeatureId
		{
			get
			{
				return this.featureIdField;
			}
			set
			{
				this.featureIdField = value;
			}
		}

		/// <remarks/>
		public uint SequenceNumber
		{
			get
			{
				return this.sequenceNumberField;
			}
			set
			{
				this.sequenceNumberField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureNominalsConeFeatureNominalConstructedBestFitBaseFeatureFeatureId
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
	public partial class FeaturesFeatureItemsCircleFeatureItem
	{

		private FeaturesFeatureItemsCircleFeatureItemFeatureNominalId featureNominalIdField;

		private FeaturesFeatureItemsCircleFeatureItemParentFeatureItemId parentFeatureItemIdField;

		private string featureNameField;

		private string uUIDField;

		private FeaturesFeatureItemsCircleFeatureItemNotableEventIds notableEventIdsField;

		private FeaturesFeatureItemsCircleFeatureItemCoordinateSystemId coordinateSystemIdField;

		private FeaturesFeatureItemsCircleFeatureItemPointList pointListField;

		private FeaturesFeatureItemsCircleFeatureItemSubstituteFeatureAlgorithm substituteFeatureAlgorithmField;

		private FeaturesFeatureItemsCircleFeatureItemVirtualMeasurement virtualMeasurementField;

		private FeaturesFeatureItemsCircleFeatureItemDeterminationMode determinationModeField;

		private byte idField;

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemFeatureNominalId FeatureNominalId
		{
			get
			{
				return this.featureNominalIdField;
			}
			set
			{
				this.featureNominalIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemParentFeatureItemId ParentFeatureItemId
		{
			get
			{
				return this.parentFeatureItemIdField;
			}
			set
			{
				this.parentFeatureItemIdField = value;
			}
		}

		/// <remarks/>
		public string FeatureName
		{
			get
			{
				return this.featureNameField;
			}
			set
			{
				this.featureNameField = value;
			}
		}

		/// <remarks/>
		public string UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemNotableEventIds NotableEventIds
		{
			get
			{
				return this.notableEventIdsField;
			}
			set
			{
				this.notableEventIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemCoordinateSystemId CoordinateSystemId
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
		public FeaturesFeatureItemsCircleFeatureItemPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemSubstituteFeatureAlgorithm SubstituteFeatureAlgorithm
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
		public FeaturesFeatureItemsCircleFeatureItemVirtualMeasurement VirtualMeasurement
		{
			get
			{
				return this.virtualMeasurementField;
			}
			set
			{
				this.virtualMeasurementField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemDeterminationMode DeterminationMode
		{
			get
			{
				return this.determinationModeField;
			}
			set
			{
				this.determinationModeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureItemsCircleFeatureItemFeatureNominalId
	{

		private byte asmPathIdField;

		private byte asmPathXIdField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte asmPathId
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
		public byte asmPathXId
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
		public byte xId
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
	public partial class FeaturesFeatureItemsCircleFeatureItemParentFeatureItemId
	{

		private byte xIdField;

		private byte valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
		public byte Value
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
	public partial class FeaturesFeatureItemsCircleFeatureItemNotableEventIds
	{

		private FeaturesFeatureItemsCircleFeatureItemNotableEventIdsID[] idField;

		private byte nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureItemsCircleFeatureItemNotableEventIdsID[] Id
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureItemsCircleFeatureItemNotableEventIdsID
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
	public partial class FeaturesFeatureItemsCircleFeatureItemCoordinateSystemId
	{

		private byte asmPathIdField;

		private byte asmPathXIdField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte asmPathId
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
		public byte asmPathXId
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
		public byte xId
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
	public partial class FeaturesFeatureItemsCircleFeatureItemPointList
	{

		private FeaturesFeatureItemsCircleFeatureItemPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureItemsCircleFeatureItemPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureItemsCircleFeatureItemPointListSinglePointSetId singlePointSetIdField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureItemsCircleFeatureItemPointListWholePointSetId
	{

		private uint xIdField;

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
	public partial class FeaturesFeatureItemsCircleFeatureItemPointListRangePointSetId
	{

		private string rangeField;

		private uint xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
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
	public partial class FeaturesFeatureItemsCircleFeatureItemPointListSinglePointSetId
	{

		private uint indexField;

		private uint xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public uint index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
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
	public partial class FeaturesFeatureItemsCircleFeatureItemSubstituteFeatureAlgorithm
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
	public partial class FeaturesFeatureItemsCircleFeatureItemVirtualMeasurement
	{

		private byte idField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureItemsCircleFeatureItemDeterminationMode
	{

		private FeaturesFeatureItemsCircleFeatureItemDeterminationModeChecked checkedField;

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemDeterminationModeChecked Checked
		{
			get
			{
				return this.checkedField;
			}
			set
			{
				this.checkedField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsCircleFeatureItemDeterminationModeChecked
	{

		private FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetails checkDetailsField;

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetails CheckDetails
		{
			get
			{
				return this.checkDetailsField;
			}
			set
			{
				this.checkDetailsField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetails
	{

		private FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasured measuredField;

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasured Measured
		{
			get
			{
				return this.measuredField;
			}
			set
			{
				this.measuredField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasured
	{

		private FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList pointListField;

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList
	{

		private FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId singlePointSetIdField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId
	{

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId
	{

		private string rangeField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureItemsCircleFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId
	{

		private byte indexField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItem
	{

		private FeaturesFeatureItemsCircularArcFeatureItemFeatureNominalId featureNominalIdField;

		private FeaturesFeatureItemsCircularArcFeatureItemParentFeatureItemId parentFeatureItemIdField;

		private string featureNameField;

		private string uUIDField;

		private FeaturesFeatureItemsCircularArcFeatureItemNotableEventIds notableEventIdsField;

		private FeaturesFeatureItemsCircularArcFeatureItemCoordinateSystemId coordinateSystemIdField;

		private FeaturesFeatureItemsCircularArcFeatureItemPointList pointListField;

		private FeaturesFeatureItemsCircularArcFeatureItemSubstituteFeatureAlgorithm substituteFeatureAlgorithmField;

		private FeaturesFeatureItemsCircularArcFeatureItemVirtualMeasurement virtualMeasurementField;

		private FeaturesFeatureItemsCircularArcFeatureItemDeterminationMode determinationModeField;

		private byte idField;

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemFeatureNominalId FeatureNominalId
		{
			get
			{
				return this.featureNominalIdField;
			}
			set
			{
				this.featureNominalIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemParentFeatureItemId ParentFeatureItemId
		{
			get
			{
				return this.parentFeatureItemIdField;
			}
			set
			{
				this.parentFeatureItemIdField = value;
			}
		}

		/// <remarks/>
		public string FeatureName
		{
			get
			{
				return this.featureNameField;
			}
			set
			{
				this.featureNameField = value;
			}
		}

		/// <remarks/>
		public string UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemNotableEventIds NotableEventIds
		{
			get
			{
				return this.notableEventIdsField;
			}
			set
			{
				this.notableEventIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemCoordinateSystemId CoordinateSystemId
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
		public FeaturesFeatureItemsCircularArcFeatureItemPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemSubstituteFeatureAlgorithm SubstituteFeatureAlgorithm
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
		public FeaturesFeatureItemsCircularArcFeatureItemVirtualMeasurement VirtualMeasurement
		{
			get
			{
				return this.virtualMeasurementField;
			}
			set
			{
				this.virtualMeasurementField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemDeterminationMode DeterminationMode
		{
			get
			{
				return this.determinationModeField;
			}
			set
			{
				this.determinationModeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemFeatureNominalId
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemParentFeatureItemId
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemNotableEventIds
	{

		private FeaturesFeatureItemsCircularArcFeatureItemNotableEventIdsID[] idField;

		private uint nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureItemsCircularArcFeatureItemNotableEventIdsID[] Id
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemNotableEventIdsID
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemCoordinateSystemId
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemPointList
	{

		private FeaturesFeatureItemsCircularArcFeatureItemPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureItemsCircularArcFeatureItemPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureItemsCircularArcFeatureItemPointListSinglePointSetId singlePointSetIdField;

		private uint nField;

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemPointListWholePointSetId
	{

		private uint xIdField;

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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemPointListRangePointSetId
	{

		private string rangeField;

		private uint xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemPointListSinglePointSetId
	{

		private uint indexField;

		private uint xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public uint index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemSubstituteFeatureAlgorithm
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemVirtualMeasurement
	{

		private uint idField;

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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemDeterminationMode
	{

		private FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeChecked checkedField;

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeChecked Checked
		{
			get
			{
				return this.checkedField;
			}
			set
			{
				this.checkedField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeChecked
	{

		private FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetails checkDetailsField;

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetails CheckDetails
		{
			get
			{
				return this.checkDetailsField;
			}
			set
			{
				this.checkDetailsField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetails
	{

		private FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasured measuredField;

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasured Measured
		{
			get
			{
				return this.measuredField;
			}
			set
			{
				this.measuredField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasured
	{

		private FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList pointListField;

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList
	{

		private FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId singlePointSetIdField;

		private uint nField;

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId
	{

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId
	{

		private string rangeField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureItemsCircularArcFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId
	{

		private byte indexField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureItemsConeFeatureItem
	{

		private FeaturesFeatureItemsConeFeatureItemFeatureNominalId featureNominalIdField;

		private FeaturesFeatureItemsConeFeatureItemParentFeatureItemId parentFeatureItemIdField;

		private string featureNameField;

		private string uUIDField;

		private FeaturesFeatureItemsConeFeatureItemNotableEventIds notableEventIdsField;

		private FeaturesFeatureItemsConeFeatureItemCoordinateSystemId coordinateSystemIdField;

		private FeaturesFeatureItemsConeFeatureItemPointList pointListField;

		private FeaturesFeatureItemsConeFeatureItemSubstituteFeatureAlgorithm substituteFeatureAlgorithmField;

		private FeaturesFeatureItemsConeFeatureItemVirtualMeasurement virtualMeasurementField;

		private FeaturesFeatureItemsConeFeatureItemDeterminationMode determinationModeField;

		private byte idField;

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemFeatureNominalId FeatureNominalId
		{
			get
			{
				return this.featureNominalIdField;
			}
			set
			{
				this.featureNominalIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemParentFeatureItemId ParentFeatureItemId
		{
			get
			{
				return this.parentFeatureItemIdField;
			}
			set
			{
				this.parentFeatureItemIdField = value;
			}
		}

		/// <remarks/>
		public string FeatureName
		{
			get
			{
				return this.featureNameField;
			}
			set
			{
				this.featureNameField = value;
			}
		}

		/// <remarks/>
		public string UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemNotableEventIds NotableEventIds
		{
			get
			{
				return this.notableEventIdsField;
			}
			set
			{
				this.notableEventIdsField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemCoordinateSystemId CoordinateSystemId
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
		public FeaturesFeatureItemsConeFeatureItemPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemSubstituteFeatureAlgorithm SubstituteFeatureAlgorithm
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
		public FeaturesFeatureItemsConeFeatureItemVirtualMeasurement VirtualMeasurement
		{
			get
			{
				return this.virtualMeasurementField;
			}
			set
			{
				this.virtualMeasurementField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemDeterminationMode DeterminationMode
		{
			get
			{
				return this.determinationModeField;
			}
			set
			{
				this.determinationModeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureItemsConeFeatureItemFeatureNominalId
	{

		private byte asmPathIdField;

		private byte asmPathXIdField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte asmPathId
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
		public byte asmPathXId
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
		public byte xId
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
	public partial class FeaturesFeatureItemsConeFeatureItemParentFeatureItemId
	{

		private byte xIdField;

		private byte valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
		public byte Value
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
	public partial class FeaturesFeatureItemsConeFeatureItemNotableEventIds
	{

		private FeaturesFeatureItemsConeFeatureItemNotableEventIdsID[] idField;

		private byte nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Id")]
		public FeaturesFeatureItemsConeFeatureItemNotableEventIdsID[] Id
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureItemsConeFeatureItemNotableEventIdsID
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
	public partial class FeaturesFeatureItemsConeFeatureItemCoordinateSystemId
	{

		private byte asmPathIdField;

		private byte asmPathXIdField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte asmPathId
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
		public byte asmPathXId
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
		public byte xId
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
	public partial class FeaturesFeatureItemsConeFeatureItemPointList
	{

		private FeaturesFeatureItemsConeFeatureItemPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureItemsConeFeatureItemPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureItemsConeFeatureItemPointListSinglePointSetId singlePointSetIdField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureItemsConeFeatureItemPointListWholePointSetId
	{

		private uint xIdField;

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
	public partial class FeaturesFeatureItemsConeFeatureItemPointListRangePointSetId
	{

		private string rangeField;

		private uint xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
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
	public partial class FeaturesFeatureItemsConeFeatureItemPointListSinglePointSetId
	{

		private uint indexField;

		private uint xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public uint index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
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
	public partial class FeaturesFeatureItemsConeFeatureItemSubstituteFeatureAlgorithm
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
	public partial class FeaturesFeatureItemsConeFeatureItemVirtualMeasurement
	{

		private byte idField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte id
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
	public partial class FeaturesFeatureItemsConeFeatureItemDeterminationMode
	{

		private FeaturesFeatureItemsConeFeatureItemDeterminationModeChecked checkedField;

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemDeterminationModeChecked Checked
		{
			get
			{
				return this.checkedField;
			}
			set
			{
				this.checkedField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsConeFeatureItemDeterminationModeChecked
	{

		private FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetails checkDetailsField;

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetails CheckDetails
		{
			get
			{
				return this.checkDetailsField;
			}
			set
			{
				this.checkDetailsField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetails
	{

		private FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasured measuredField;

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasured Measured
		{
			get
			{
				return this.measuredField;
			}
			set
			{
				this.measuredField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasured
	{

		private FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList pointListField;

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList PointList
		{
			get
			{
				return this.pointListField;
			}
			set
			{
				this.pointListField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointList
	{

		private FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId wholePointSetIdField;

		private FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId rangePointSetIdField;

		private FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId singlePointSetIdField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId WholePointSetId
		{
			get
			{
				return this.wholePointSetIdField;
			}
			set
			{
				this.wholePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId RangePointSetId
		{
			get
			{
				return this.rangePointSetIdField;
			}
			set
			{
				this.rangePointSetIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId SinglePointSetId
		{
			get
			{
				return this.singlePointSetIdField;
			}
			set
			{
				this.singlePointSetIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
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
	public partial class FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListWholePointSetId
	{

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListRangePointSetId
	{

		private string rangeField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string range
		{
			get
			{
				return this.rangeField;
			}
			set
			{
				this.rangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesFeatureItemsConeFeatureItemDeterminationModeCheckedCheckDetailsMeasuredPointListSinglePointSetId
	{

		private byte indexField;

		private byte xIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte xId
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
	public partial class FeaturesNominalPointSetsNominalPointSet
	{

		private FeaturesNominalPointSetsNominalPointSetMeasurePoint[] measurePointField;

		private string linearUnitField;

		private string decimalPlacesField;

		private string significantFiguresField;

		private string validityField;

		private string xDecimalPlacesField;

		private string xSignificantFiguresField;

		private string xValidityField;

		private string yDecimalPlacesField;

		private string ySignificantFiguresField;

		private string yValidityField;

		private string zDecimalPlacesField;

		private string zSignificantFiguresField;

		private string zValidityField;

		private uint nField;

		private uint idField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MeasurePoint")]
		public FeaturesNominalPointSetsNominalPointSetMeasurePoint[] MeasurePoint
		{
			get
			{
				return this.measurePointField;
			}
			set
			{
				this.measurePointField = value;
			}
		}

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
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
	public partial class FeaturesNominalPointSetsNominalPointSetMeasurePoint
	{

		private FeaturesNominalPointSetsNominalPointSetMeasurePointPoint pointField;

		private FeaturesNominalPointSetsNominalPointSetMeasurePointNormal normalField;

		private FeaturesNominalPointSetsNominalPointSetMeasurePointMeasurementDeviceId measurementDeviceIdField;

		private FeaturesNominalPointSetsNominalPointSetMeasurePointSensorId sensorIdField;

		private FeaturesNominalPointSetsNominalPointSetMeasurePointTipId tipIdField;

		private uint idField;

		/// <remarks/>
		public FeaturesNominalPointSetsNominalPointSetMeasurePointPoint Point
		{
			get
			{
				return this.pointField;
			}
			set
			{
				this.pointField = value;
			}
		}

		/// <remarks/>
		public FeaturesNominalPointSetsNominalPointSetMeasurePointNormal Normal
		{
			get
			{
				return this.normalField;
			}
			set
			{
				this.normalField = value;
			}
		}

		/// <remarks/>
		public FeaturesNominalPointSetsNominalPointSetMeasurePointMeasurementDeviceId MeasurementDeviceId
		{
			get
			{
				return this.measurementDeviceIdField;
			}
			set
			{
				this.measurementDeviceIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesNominalPointSetsNominalPointSetMeasurePointSensorId SensorId
		{
			get
			{
				return this.sensorIdField;
			}
			set
			{
				this.sensorIdField = value;
			}
		}

		/// <remarks/>
		public FeaturesNominalPointSetsNominalPointSetMeasurePointTipId TipId
		{
			get
			{
				return this.tipIdField;
			}
			set
			{
				this.tipIdField = value;
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
	public partial class FeaturesNominalPointSetsNominalPointSetMeasurePointPoint
	{

		private string linearUnitField;

		private string decimalPlacesField;

		private string significantFiguresField;

		private string validityField;

		private string xDecimalPlacesField;

		private string xSignificantFiguresField;

		private string xValidityField;

		private string yDecimalPlacesField;

		private string ySignificantFiguresField;

		private string yValidityField;

		private string zDecimalPlacesField;

		private string zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesNominalPointSetsNominalPointSetMeasurePointNormal
	{

		private string linearUnitField;

		private string decimalPlacesField;

		private string significantFiguresField;

		private string validityField;

		private string xDecimalPlacesField;

		private string xSignificantFiguresField;

		private string xValidityField;

		private string yDecimalPlacesField;

		private string ySignificantFiguresField;

		private string yValidityField;

		private string zDecimalPlacesField;

		private string zSignificantFiguresField;

		private string zValidityField;

		private string valueField;

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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string validity
		{
			get
			{
				return this.validityField;
			}
			set
			{
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string xDecimalPlaces
		{
			get
			{
				return this.xDecimalPlacesField;
			}
			set
			{
				this.xDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string xSignificantFigures
		{
			get
			{
				return this.xSignificantFiguresField;
			}
			set
			{
				this.xSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string xValidity
		{
			get
			{
				return this.xValidityField;
			}
			set
			{
				this.xValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string yDecimalPlaces
		{
			get
			{
				return this.yDecimalPlacesField;
			}
			set
			{
				this.yDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string ySignificantFigures
		{
			get
			{
				return this.ySignificantFiguresField;
			}
			set
			{
				this.ySignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string yValidity
		{
			get
			{
				return this.yValidityField;
			}
			set
			{
				this.yValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string zDecimalPlaces
		{
			get
			{
				return this.zDecimalPlacesField;
			}
			set
			{
				this.zDecimalPlacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string zSignificantFigures
		{
			get
			{
				return this.zSignificantFiguresField;
			}
			set
			{
				this.zSignificantFiguresField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string zValidity
		{
			get
			{
				return this.zValidityField;
			}
			set
			{
				this.zValidityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
	public partial class FeaturesNominalPointSetsNominalPointSetMeasurePointMeasurementDeviceId
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
	public partial class FeaturesNominalPointSetsNominalPointSetMeasurePointSensorId
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
	public partial class FeaturesNominalPointSetsNominalPointSetMeasurePointTipId
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
}
