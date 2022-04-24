/*! \file Attributes.cs
    \brief Attributes Definitions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Primitives
{
    /// <summary>
    /// The AttributeBaseType is the abstract base type for all entity
    /// attributes present in the CAD scene.
    /// </summary>
    public abstract class AttributeBaseType
	{
        /// <summary>
        /// The required name attribute is the name of the entity attribute.
        /// This name is a unique identifier of an attribute within the entity.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }
	}

    /// <summary>
    /// The AttributeBoolType defines an entity attribute of Boolean type.
    /// </summary>
    public class AttributeBoolType : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the Boolean value of
        /// this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public bool Value { get; set; }
	}

    /// <summary>
    /// The AttributeStrType defines an entity attribute of string type.
    /// </summary>
    public class AttributeStrType : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the string value of
        /// this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }

    /// <summary>
    /// The AttributeTimeType defines an entity attribute of date-time type.
    /// </summary>
    public class AttributeTimeType : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the date-time value of
        /// this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public DateTime Value { get; set; }
    }

    /// <summary>
    /// The AttributeQPIdType defines an entity attribute of QPId type.
    /// </summary>
    public class AttributeQPIdType : AttributeBaseType
    {
        /// <summary>
        /// The Value element specifies the QPId value of this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public QPIdType Value { get; set; }
    }

    /// <summary>
    /// The AttributeI1Type defines an entity attribute of integer type.
    /// </summary>
    public class AttributeI1Type : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the integer value of this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The AttributeI2Type defines an entity attribute of 'pair of integers' type.
    /// </summary>
    public class AttributeI2Type : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the integer pair value of this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public I2Type Value { get; set; }
    }

    /// <summary>
    /// The AttributeI3Type defines an entity attribute of 'pair of integers' type.
    /// </summary>
    public class AttributeI3Type : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the integer triple value of this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public I3Type Value { get; set; }
    }

    /// <summary>
    /// The AttributeD1Type defines an entity attribute of double type.
    /// </summary>
    public class AttributeD1Type : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the double value of this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public double Value { get; set; }
    }

    /// <summary>
    /// The AttributeD2Type defines an entity attribute of 'two doubles' type.
    /// </summary>
    public class AttributeD2Type : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the double pair value of this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public D2Type Value { get; set; }
    }

    /// <summary>
    /// The AttributeD3Type defines an entity attribute of 'three doubles' type.
    /// </summary>
    public class AttributeD3Type : AttributeBaseType
    {
        /// <summary>
        /// The required value attribute specifies the double triple value of this entity attribute.
        /// </summary>
        [XmlElement("value")]
        public D3Type Value { get; set; }
    }

    /// <summary>
    /// The AttributeUserType defines a user-defined entity attribute which
    /// contains a binary array or any user-defined structured XML data.
    /// </summary>
    public class AttributeUserType : AttributeBaseType
    {
        /// <summary>
        /// This compositor selects the representation method for data
        /// of the user-defined entity attribute.
        /// </summary>
        struct UserData
		{
            public UserDataXMLType userDataXML;
            public BinaryDataType userDataBinary;
        }
        private UserData userData;

        /// <summary>
        /// The UserDataXML element is the user-defined data represented as an XML structure.
        /// </summary>
        [XmlElement]
        public UserDataXMLType UserDataXML 
        { 
            get => userData.userDataXML;
            set => userData.userDataXML = value;
        }

        /// <summary>
        /// The UserDataBinary element is a binary block of user data.
        /// </summary>
        [XmlElement]
        public BinaryDataType UserDataBinary 
        {
            get => userData.userDataBinary;
            set => userData.userDataBinary = value;
        }

        /// <summary>
        /// The required nameUserAttribute attribute is the name of
        /// user-defined attribute type.The structure of the
        /// user-defined attribute can be identified by this name.
        /// </summary>
        [XmlElement("nameUserAttribute")]
        public string NameUserAttribute { get; set; }
    }

    /// <summary>
    /// The UserDataXMLType defines a user-defined XML structure from any
    /// namespace that is not the target namespace.The XML processor will
    /// validate elements if the corresponding schema will be presented.If
    /// the schema cannot be obtained, no errors will occur.
    /// </summary>
    public class UserDataXMLType
	{
        /// <summary>
        /// This 'any' specifier specifies that the content must be from
        /// another namespace and lax verification should be applied to
        /// that content.
        /// </summary>
        [XmlAnyElement]
        public XmlElement[] AllElements;
    }
  
	/// <remarks The AttributesType defines a list of entity attributes./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class AttributesType
	{
		private List<AttributeBaseType> items = new List<AttributeBaseType>();

		/// <summary>
		/// FeatureDefinition substitutionGroup
		/// </summary>
		[XmlElement(ElementName = "AttributeBool", Type = typeof(AttributeBoolType))]
		[XmlElement(ElementName = "AttributeStr", Type = typeof(AttributeStrType))]
		[XmlElement(ElementName = "AttributeTime", Type = typeof(AttributeTimeType))]

		/// <remarks The required n attribute is the number of entity attributes in this list./>
		[XmlAttribute("n")]
		public int Count { get => items.Count; }
	}

    public abstract class AttributesTypeHolder
	{
        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement]
        Primitives.AttributesType Attributes { get; set; }
    }
}
