/*! \file ListDoubleType.cs
    \brief Defines an array of double values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System.Text.RegularExpressions;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// ListDoubleTypeBase is an array of double values.
    /// </summary>
    public abstract class ListDoubleTypeBase
    {
        private double[]? valueField;

        public ListDoubleTypeBase()
        {
        }
        public ListDoubleTypeBase(uint size)
        {
            Value = new double[size];
        }
        protected ListDoubleTypeBase(double[]? value)
        {
            Value = value;
        }
        /// Implicit conversion to a double[].
        public static implicit operator double[]? (ListDoubleTypeBase alias)
        {
            return alias.Value;
        }

        [System.Xml.Serialization.XmlIgnore]
        public double[]? Value { get => valueField; set => valueField = value; }

        public override string? ToString()
        {
            if (Value != null)
            {
                string value = string.Join(" ", Value);
                return value;
            }
            return null;
        }

        public void FromString(string? value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var parts = Regex.Split(value, @"\s+");
                uint cnt = 0;
                foreach (var part in parts)
                {
                    if (!string.IsNullOrEmpty(part))
                    {
                        ++cnt;
                    }
                }
                if (cnt > 0)
                {
                    Value = new System.Double[cnt];
                    for (int i = 0, idx = 0; i < parts.Length && idx < cnt; ++i)
                    {
                        if (!string.IsNullOrEmpty(parts[i]))
                        {
                            Value[idx] = 0.0;
                            double.TryParse(parts[i], out Value[idx]);
                            ++idx;
                        }
                    }
                }
            }
        }
    }

    public class ListDoubleNoCountType : ListDoubleTypeBase
    {
        public ListDoubleNoCountType() { }
        public ListDoubleNoCountType(uint size) : base(size) { }

        protected ListDoubleNoCountType(double[] value) : base(value) { }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string? Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }
    }

    public class ListDoubleType : ListDoubleNoCountType
    {
        public ListDoubleType() { }
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
            get => base.Value != null ? (uint)base.Value.Length : 0;
            set { }
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
        public D2Type(double[]? value) : base(value) { }

        /// Implicit conversion from double[] to D2Type
        public static implicit operator D2Type(double[]? value)
        {
            return new D2Type(value);
        }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string? Text
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
        public D3Type(double[]? value) : base(value) { }

        /// Implicit conversion from double[] to D3Type
        public static implicit operator D3Type(double[] value)
        {
            return new D3Type(value);
        }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string? Text
        {
            get => base.ToString();
            set => base.FromString(value);
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

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string? Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }
    }

    /// <remarks> The ArrayDoubleType is an array of double values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayDoubleType : ListDoubleType
    {
    }
}
