﻿/*! \file QIFTypes.cs
    \brief Declaration of QIF Types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications
{
    /// <summary>
    /// Defines an alias type for the sealed base types
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TypeAlias<T> : IXmlSerializable where T : struct
    {
        protected T _value;
        protected TypeAlias()
        {
        }

        protected TypeAlias(T value)
        {
            this._value = value;
        }

        [XmlTextAttribute]
        public T Value { get => _value; set => _value = value; }

        #region Xml Serialization Infrastructure
        public override string? ToString()
        {
            return Value.ToString();
        }

        public virtual void WriteXml(XmlWriter writer)
        {
            writer.WriteString(ToString());
        }

        public virtual void ReadXml(XmlReader reader)
        {
            Value = (T)reader.ReadElementContentAs(typeof(T), new XmlNamespaceManager(new NameTable()));
        }

        public virtual System.Xml.Schema.XmlSchema? GetSchema()
        {
            return null;
        }
        #endregion
    }

    /// <summary>
    /// Defines an alias type for the sealed base types
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TypeAliasNullable<T> : IXmlSerializable
    {
        protected T? _value;
        protected TypeAliasNullable()
        {
        }
        protected TypeAliasNullable(T value)
        {
            this._value = value;
        }

        [XmlTextAttribute]
        public T? Value { get => _value; set => _value = value; }

        #region Xml Serialization Infrastructure
        public override string? ToString()
        {
            return Value?.ToString();
        }

        public virtual void WriteXml(XmlWriter writer)
        {
            writer.WriteString(ToString());
        }

        public virtual void ReadXml(XmlReader reader)
        {
            Value = (T)reader.ReadElementContentAs(typeof(T), new XmlNamespaceManager(new NameTable()));
        }

        public virtual System.Xml.Schema.XmlSchema? GetSchema()
        {
            return null;
        }
        #endregion
    }

    /// <summary>
    /// Alias type for System.UInt32
    /// </summary>
    public class UInt32Type : TypeAlias<System.UInt32>
    {
        public UInt32Type()
        {
        }
        /// As we are using implicit conversions we can keep the constructor private
        public UInt32Type(System.UInt32 value)
        {
            base._value = value;
        }
        /// Implicit conversion from System.UInt32 to UInt32Type 
        public static implicit operator UInt32Type(System.UInt32 value)
        {
            return new UInt32Type(value);
        }
        /// Implicit conversion to a System.UInt32.
        public static implicit operator System.UInt32(UInt32Type alias)
        {
            return alias.Value;
        }
    }

    /// <summary>
    /// The NaturalType is the natural number type (integer > 0).
    /// </summary>
    public class NaturalType : TypeAlias<uint>
    {
        public NaturalType()
        {
        }
        /// As we are using implicit conversions we can keep the constructor private
        public NaturalType(uint value)
        {
            base._value = value;
        }
        /// Implicit conversion from System.UInt32 to NaturalType
        public static implicit operator NaturalType(System.UInt32 value)
        {
            return new NaturalType(value);
        }
        /// Implicit conversion to a System.UInt32.
        public static implicit operator System.UInt32(NaturalType alias)
        {
            return alias.Value;
        }
    }

    /// <summary>
    /// Alias type for System.Decimal
    /// </summary>
    public class DecimalType
    {
        private decimal valueField;
        public DecimalType()
        {
        }
        protected DecimalType(System.Decimal value)
        {
            valueField = value;
        }
        /// Implicit conversion from System.Decimal to DecimalType 
        public static implicit operator DecimalType(decimal value)
        {
            return new DecimalType(value);
        }
        /// Implicit conversion to a System.Decimal.
        public static implicit operator decimal(DecimalType alias)
        {
            return alias.Value;
        }

        [XmlText]
        public string? Text
        {
            get => ToString();
            set => FromString(value);
        }

        [XmlIgnore]
        public decimal Value { get => valueField; set => valueField = value; }

        public override string ToString()
        {
            return $"{valueField}";
        }
        protected virtual bool FromString(string? text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return decimal.TryParse(text, out valueField);
            }
            return false;
        }
    }

    /// <summary>
    /// Alias type for System.Decimal
    /// </summary>
    public class DoubleType : TypeAlias<double>
    {
        private DoubleType(double value)
        {
            base._value = value;
        }
        /// Implicit conversion from System.Decimal to DecimalType 
        public static implicit operator DoubleType(double value)
        {
            return new DoubleType(value);
        }
        /// Implicit conversion to a System.Decimal.
        public static implicit operator double(DoubleType alias)
        {
            return alias;
        }
    }

    /// <summary>
    /// All local (i.e. not significant outside the instance file) identifiers in the QIF schemas are of type QIFIdType.
    /// </summary>
    [System.SerializableAttribute()]
    public class QIFIdType : UInt32Type
    {
        public QIFIdType() { }
        public QIFIdType(System.UInt32 value) : base(value) { }

        /// Implicit conversion from System.UInt32 to QIFIdType
        public static implicit operator QIFIdType(System.UInt32 value)
        {
            return new QIFIdType(value);
        }
    }

    //! Base class for all classes that have QIFIdType as an attribute
    [System.SerializableAttribute()]
    public abstract class QIFIdTypeBase
    {
        public QIFIdTypeBase() { }

        /// <summary>
        /// The id attribute is the QIF id of the feature, used for referencing.
        /// </summary>
        [XmlIgnore]
        public QIFIdType QIFID { get; set; } = new QIFIdType();

        /// <summary>
        /// The id attribute is the QIF id of the feature, used for referencing.
        /// </summary>
        [XmlAttribute]
        public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
    }
}
