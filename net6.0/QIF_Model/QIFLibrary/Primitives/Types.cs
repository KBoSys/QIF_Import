﻿/*! \file Types.cs
    \brief Defines different types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using QIF_Model.QIFLibrary.Statistics;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// The BinaryDataType represents a Base64-encoded arbitrary binary
    /// data block.For base64Binary data the entire binary stream is
    /// encoded using the Base64 Alphabet in RFC 2045.
    /// </summary>
    public class BinaryDataType : TypeAliasNullable<System.Byte[]>
    {
        public BinaryDataType()
        {
        }
        private BinaryDataType(System.Byte[] value)
        {
            base._value = value;
        }
        /// Implicit conversion from System.Byte[] to BinaryDataType 
        public static implicit operator BinaryDataType(System.Byte[] value)
        {
            return new BinaryDataType(value);
        }
        /// Implicit conversion to a System.Byte[].
        public static implicit operator System.Byte[](BinaryDataType alias)
        {
            return alias;
        }

        /// <summary>
        /// The required count attribute is the number of bytes in the binary block.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public uint Count 
        {
            get => Value != null ? (uint)Value.Length : 0;  
            set { }
        }
    }

    /// <summary>
    /// The ListIntType is a list of integer numbers.
    /// </summary>
    public class ListIntType : TypeAliasNullable<int[]>
    {
        public ListIntType() { }
        public ListIntType(uint size)
        {
            Value = new int[size];
        }
        protected ListIntType(int[]? value)
        {
            base._value = value;
        }
        /// Implicit conversion from System.Int32[] to ListIntType 
        public static implicit operator ListIntType(System.Int32[] value)
        {
            return new ListIntType(value);
        }
        /// Implicit conversion to a System.Int32[].
        public static implicit operator int[]? (ListIntType alias)
        {
            return alias.Value;
        }
    }

    /// <summary>
    /// The ListUnsignedByteType is an array of unsigned byte values.
    /// </summary>
    public class ListUnsignedByteType : TypeAliasNullable<uint[]>
    {
        public ListUnsignedByteType() { }
        public ListUnsignedByteType(uint size)
        {
            Value = new uint[size];
        }
        protected ListUnsignedByteType(uint[] value)
        {
            base._value = value;
        }
        /// Implicit conversion from uint[] to ListUnsignedByteType
        public static implicit operator ListUnsignedByteType(uint[] value)
        {
            return new ListUnsignedByteType(value);
        }
        /// Implicit conversion to uint[].
        public static implicit operator uint[](ListUnsignedByteType alias)
        {
            return alias;
        }
    }

    /// <remarks> The ArrayUnsignedByteType is an array of unsigned byte values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayUnsignedByteType : ListUnsignedByteType
    {
        /// <remarks> The required count attribute is the number of integer numbers in this array.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public uint Count
        {
            get => base.Value != null ? (uint)base.Value.Length : 0;
            set { }
        }
    }

    /// <summary>
    /// The I2Type is an array of two integer values.
    /// </summary>
    public class I2Type : ListIntType
    {
        public I2Type() : base(2)
        {
        }
        public I2Type(int[]? value) : base(value) { }

        /// Implicit conversion from System.Int32[] to ListIntType 
        public static implicit operator I2Type(int[] value)
        {
            return new I2Type(value);
        }
    }

    /// <remarks> The ArrayIntType is an array of integer numbers.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayIntType : ArrayAsAttributeBase<int>
    {
    }

    /// <remarks> The ArrayI2Type is an array of integer numbers representing a
    /// specific number of ordered pairs of integers.Each successive group
    /// of two entries in the array represents the first and second
    /// components of a pair.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot()]
    public partial class ArrayI2Type : ArrayAsAttributeBase<int>
    {
        public ArrayI2Type() : base(2) { }
    }

    /// <summary>
    /// The I3Type is an array of three integer values.
    /// </summary>
    public class I3Type : ListIntType
    {
        public I3Type() : base(3)
        {
        }
        public I3Type(int[]? value) : base(value) { }

        /// Implicit conversion from System.Int32[] to ListIntType 
        public static implicit operator I3Type(int[]? value)
        {
            return new I3Type(value);
        }
    }

    /// <remarks> The ArrayI3Type is an array of integer numbers representing a
    /// specific number of ordered triplets of integers.Each successive
    /// group of three entries in the array represents the first, second
    /// and third components of a triplet.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot()]
    public partial class ArrayI3Type : ArrayAsAttributeBase<int>
    {
        public ArrayI3Type() : base(3) { }
    }

    /// <summary>
    /// The ListBooleanType is an array of Boolean values.
    /// </summary>
    public class ListBooleanType : List<System.Boolean>
    {
        public ListBooleanType()
        {
        }
    }

    /// <summary>
    /// The ListDateTimeType is an array of date-time values.
    /// </summary>
    public class ListDateTimeType : List<System.DateTime>
    {
        public ListDateTimeType()
        {
        }
    }

    /// <summary>
    /// The ListTokenType is a list of string tokens.
    /// </summary>
    public class ListTokenType : List<System.String>
    {
        public ListTokenType()
        {
        }
    }
    public class DoublePositiveType : TypeAlias<System.Double>
    {
        public DoublePositiveType()
        {
        }
        private DoublePositiveType(System.Double value)
        {
            base._value = Math.Abs(value);
        }
        public static implicit operator DoublePositiveType(System.Double value)
        {
            return new DoublePositiveType(value);
        }
        public static implicit operator System.Double(DoublePositiveType value)
        {
            return value.Value;
        }
    }

    /// <summary>
    /// The QPIdType(QIF Persistent Identifier Type) is the text
    /// representation of the universally unique identifier described in
    /// the standard ISO/IEC 9834-8. As a number, it has 128 bits.As a
    /// text string it is represented by 32 hexadecimal digits displayed in
    /// five groups separated by hyphens in the form 8-4-4-4-12, for a
    /// total of 36 characters.example:
    /// fd43400a-29bf-4ec6-b96c-e2f846eb6ff6
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class QPIdType
    {
        [XmlText]
        public string? Value { get; set; }

        //
        //<xs:restriction base="xs:token">
        //<xs:pattern value = "[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}" </remarks>
        //</ xs:restriction>
    }

    /// <summary>
    /// The QPIdReferenceType defines the text representation of the
    /// universally unique identifier described in the standard ISO/IEC
    /// 9834-8. As a number, it has 128 bits.As a text string it is
    /// represented by 32 hexadecimal digits displayed in five groups
    /// separated by hyphens in the form 8-4-4-4-12, for a total of 36
    /// characters.example: fd43400a-29bf-4ec6-b96c-e2f846eb6ff6
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class QPIdReferenceType
    {
        [XmlText]
        public string? Value { get; set; }

        //
        //<xs:restriction base="xs:token">
        //<xs:pattern value = "[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}" </remarks>
        //</ xs:restriction>
    }

    /// <summary>
    /// The FractionType is a fraction value. 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class FractionType
    {
        /// <remarks> The Numerator element is the numerator of the fraction.</remarks>
        [XmlElement]
        public uint NumeratorValue { get; set; }

        /// <remarks> The Denominator element is the denominator of the fraction.</remarks>
        [XmlElement]
        public uint Denominator { get; set; }
    }

    /// <summary>
    /// The ListNaturalType is an array of natural numbers.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ListNaturalType : List<uint>
    {
    }

    /// <summary>
    /// The Natural2Type is an array of two Natural values.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class Natural2Type : ListNaturalType
    {
        public Natural2Type() { }
    }

    /// <summary>
    /// The SweepType defines a partial feature using a vector and an angle.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SweepType
    {
        /// <remarks> The DirBeg element is a unit vector representing the beginning extent of the feature.</remarks>
        [XmlElement]
        public UnitVectorType? DirBeg { get; set; }

        /// <remarks> The DomainAngle element is the angle limits in angular units from the start vector to the start extent of the feature.</remarks>
        [XmlElement]
        public AngleRangeType? DomainAngle { get; set; }
    }

    /// <summary>
    /// The AngleRangeType defines an angle range.
    /// </summary>
    public class AngleRangeType : D2Type
    {
        /// <remarks> The DirBeg element is a unit vector representing the beginning extent of the feature.</remarks>
        [XmlAttribute("angularUnit")]
        public string? UnitName { get; set; }
    }

    /// <remarks> The QIFFeaturePairType defines a pair of feature references and
    /// optionally defines feature zones for either or both features.This
    /// type is used to define the two features participating in a distance	between or angle between characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFFeaturePairType
    {
        /// <remarks> The FirstFeature element is a reference to a QIF feature id that may include an AsmPath.</remarks>
        public QIFReferenceFullType? FirstFeature { get; set; }

        /// <remarks> The SecondFeature element is a reference to a QIF feature id that may include an AsmPath.</remarks>
        public QIFReferenceFullType? SecondFeature { get; set; }

        /// <remarks> The optional FirstFeatureZone element is a reference to a QIF
        /// zone feature id that may include an AsmPath.This feature zone is applied to the first feature.</remarks>
        public QIFReferenceFullType? FirstFeatureZone { get; set; }

        /// <remarks> The optional SecondFeatureZone element is a reference to a QIF
        /// zone feature id that may include an AsmPath.This feature zone is applied to the second feature.</remarks>
        public QIFReferenceFullType? SecondFeatureZone { get; set; }
    }

    /// <remarks> The ArrayReferenceFullType is an array of references to object IDs.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayPairReferenceFullType : ArrayBaseType<QIFFeaturePairType>
    {
        /// <remarks> The Id element is reference to a QIF id that may include an AsmPath.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FeaturePair")]
        public QIFFeaturePairType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The ArrayNaturalType is an array of natural numbers.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayNaturalType : ListNaturalType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public uint count
        {
            get => (uint)base.Count;
            set { }
        }
    }
}