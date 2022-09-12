/*! \file ArrayNumbersAttrBase.cs
	\brief Generic class for sequence of numbers 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Helpers;

namespace X3DCad.Model.Types
{
    /// <summary>
    /// Generic class for sequence of numbers - fixed size
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ArrayNumbersAttrBase<T> where T : struct
    {
        private T[] valueField;

        public ArrayNumbersAttrBase(uint size)
        {
            valueField = new T[size];
        }

        [XmlIgnore]
        public T[] Value { get => valueField; set => valueField = value; }

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
                    cnt = Math.Min(cnt, (uint)Value.Length);
                    for (int i = 0, idx = 0; i < parts.Length && idx < cnt; ++i)
                    {
                        if (!string.IsNullOrEmpty(parts[i]))
                        {
                            Value[idx] = Converter.FromStringToNonNullable<T>(value);
                            ++idx;
                        }
                    }
                }
            }
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
    /// Generic class for sequence of numbers [0...*]
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ListNumbersBase<T> where T : struct
    {
        private List<T> itemsField = new List<T>();

        [XmlIgnore]
        public List<T> Items { get => itemsField; set => itemsField = value; }

        public override string? ToString()
        {
            if (itemsField != null)
            {
                string value = string.Join(" ", itemsField);
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
                    itemsField.Clear();
                    for (int i = 0, idx = 0; i < parts.Length && idx < cnt; ++i)
                    {
                        if (!string.IsNullOrEmpty(parts[i]))
                        {
                            itemsField.Add(Converter.FromStringToNonNullable<T>(value));
                            ++idx;
                        }
                    }
                }
            }
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
