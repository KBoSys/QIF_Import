/*! \file ListDoubleType.cs
    \brief Defines an array of double values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System.Text.RegularExpressions;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// ListDoubleTypeBase is a list of double values.
    /// </summary>
    public abstract class ListDoubleTypeBase
    {
        private List<double> valueField;

        #region Constructors
        public ListDoubleTypeBase()
        {
            valueField = new List<double>();
        }

        protected ListDoubleTypeBase(double[] value)
        {
            valueField = new List<double>(value);
        }
        #endregion Constructors

        /// Implicit conversion to a double[].
        public static implicit operator double[] (ListDoubleTypeBase alias)
        {
            return alias.Value;
        }

        [System.Xml.Serialization.XmlIgnore]
        public List<double> Items { get => valueField; set => valueField = value; }

        [System.Xml.Serialization.XmlIgnore]
        public double[] Value { get => valueField.ToArray(); set => valueField = new List<double>(value); }

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
                int cnt = 0;
                foreach (var part in parts)
                {
                    if (!string.IsNullOrEmpty(part))
                    {
                        ++cnt;
                    }
                }
                if (cnt > 0)
                {
                    valueField = new List<double>(cnt);
                    for (int i = 0, idx = 0; i < parts.Length && idx < cnt; ++i)
                    {
                        if (!string.IsNullOrEmpty(parts[i]))
                        {
                            double val = 0;
                            double.TryParse(parts[i], out val);
                            valueField.Add(val);
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
    /// ArrayDoubleTypeBase is an array of double values.
    /// </summary>
    public abstract class ArrayDoubleTypeBase
    {
        private double[] valueField;

        #region Constructors
        public ArrayDoubleTypeBase(uint size)
        {
            valueField = new double[size];
        }
        #endregion Constructors

        /// Implicit conversion to a double[].
        public static implicit operator double[](ArrayDoubleTypeBase alias)
        {
            return alias.Value;
        }

        [System.Xml.Serialization.XmlIgnore]
        public double[] Value { get => valueField; set => valueField = value; }

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
                int cnt = 0;
                foreach (var part in parts)
                {
                    if (!string.IsNullOrEmpty(part))
                    {
                        ++cnt;
                    }
                }
                if (cnt > 0)
                {
                    valueField = new double[cnt];
                    for (int i = 0, idx = 0; i < parts.Length && idx < cnt; ++i)
                    {
                        if (!string.IsNullOrEmpty(parts[i]))
                        {
                            double val = 0;
                            double.TryParse(parts[i], out val);
                            valueField[idx++] = val;
                        }
                    }
                }
            }
        }
    }

    public class ArrayDoubleNoCountType : ArrayDoubleTypeBase
    {
        public ArrayDoubleNoCountType(uint cnt) : base(cnt) { }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string? Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }
    }

    public class ArrayDoubleType : ArrayDoubleNoCountType
    {
        public ArrayDoubleType(uint size) : base(size) { }

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
    public class D2Type : ArrayDoubleTypeBase
    {
        public D2Type() : base(2)
        {
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
    public class D3Type : ArrayDoubleTypeBase
    {
        public D3Type() : base(3)
        {
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
    public class D4Type : ArrayDoubleTypeBase
    {
        public D4Type() : base(4)
        {
        }
        /// <remarks></remarks>

        [System.Xml.Serialization.XmlTextAttribute()]
        public string? Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }
    }
}
