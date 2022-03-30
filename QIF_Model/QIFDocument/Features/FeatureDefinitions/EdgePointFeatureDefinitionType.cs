/*! \file EdgePointFeatureDefinitionType.cs
    \brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
public partial class EdgePointFeatureDefinitionType
{

	private EdgePointFeatureDefinitionAttributes attributesField;

	private string internalExternalField;

	private byte idField;

	/// <remarks/>
	public EdgePointFeatureDefinitionAttributes Attributes
	{
		get
		{
			return this.attributesField;
		}
		set
		{
			this.attributesField = value;
		}
	}

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
public partial class EdgePointFeatureDefinitionAttributes
{

	private EdgePointFeatureDefinitionAttributesAttributeBool attributeBoolField;

	private EdgePointFeatureDefinitionAttributesAttributeStr attributeStrField;

	private EdgePointFeatureDefinitionAttributesAttributeTime attributeTimeField;

	private byte nField;

	/// <remarks/>
	public EdgePointFeatureDefinitionAttributesAttributeBool AttributeBool
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
	public EdgePointFeatureDefinitionAttributesAttributeStr AttributeStr
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
	public EdgePointFeatureDefinitionAttributesAttributeTime AttributeTime
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
public partial class EdgePointFeatureDefinitionAttributesAttributeBool
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
public partial class EdgePointFeatureDefinitionAttributesAttributeStr
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
public partial class EdgePointFeatureDefinitionAttributesAttributeTime
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

