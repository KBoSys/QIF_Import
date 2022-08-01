/*! \file ListDoubleType.cs
    \brief Defines an array of double values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// ListDoubleTypeBase is an array of double values.
    /// </summary>
    public abstract class ListDoubleTypeBase
    {
        private double[] valueField;

        public ListDoubleTypeBase()
        {
        }
        public ListDoubleTypeBase(uint size)
        {
            Value = new double[size];
        }
        protected ListDoubleTypeBase(double[] value)
        {
            Value = value;
        }
        /// Implicit conversion to a double[].
        public static implicit operator double[](ListDoubleTypeBase alias)
        {
            return alias.Value;
        }

        [System.Xml.Serialization.XmlIgnore]
        public double[] Value { get => valueField; set => valueField = value; }

        public override string ToString()
        {
            string value = string.Join(" ", Value);
            return value;
        }

        public void FromString(string value)
        {
            string[] parts = value.Split(' ');

            if (parts.Length > 0)
            {
                Value = new System.Double[parts.Length];
                for (int i = 0; i < parts.Length; ++i)
                {
                    Value[i] = 0.0;
                    double.TryParse(parts[i], out Value[i]);
                }
            }
        }
    }

    public class ListDoubleType : ListDoubleTypeBase
    {
        public ListDoubleType()
        {
        }
        public ListDoubleType(uint size) : base(size) { }

        protected ListDoubleType(double[] value) : base(value) { }

        /// Implicit conversion from double[] to ListDoubleType
        public static implicit operator ListDoubleType(double[] value)
        {
            return new ListDoubleType(value);
        }

        /// <summary>
        /// The required count attribute gives the number of items in the list. 
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public virtual uint Count
        {
            get => (uint)Value.Length;
            set { }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }
    }

    /// <summary>
    /// The D2Type is an array of two double values.
    /// </summary>
    public class D2Type : ListDoubleTypeBase
    {
        public D2Type() : base(2)
        {
        }
        protected D2Type(double[] value) : base(value) { }

        /// Implicit conversion from double[] to D2Type
        public static implicit operator D2Type(double[] value)
        {
            return new D2Type(value);
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }
    }

    /// <summary>
    /// The D3Type is an array of three double values.
    /// </summary>
    public class D3Type : ListDoubleTypeBase
    {
        public D3Type() : base(3)
        {
        }
        protected D3Type(double[] value) : base(value) { }

        /// Implicit conversion from double[] to D3Type
        public static implicit operator D3Type(double[] value)
        {
            return new D3Type(value);
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }
    }

    /// <summary>
    /// The D4Type is an array of four double values.
    /// </summary>
    public class D4Type : ListDoubleTypeBase
    {
        public D4Type() : base(4)
        {
        }
        private D4Type(double[] value) : base(value) { }

        /// Implicit conversion from double[] to D4Type
        public static implicit operator D4Type(double[] value)
        {
            return new D4Type(value);
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }
    }

    /// <remarks The ArrayDoubleType is an array of double values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayDoubleType : ListDoubleType
    {
    }
}
