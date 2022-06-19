/*! \file ArrayAsAttributeBase.cs
    \brief generic base class for arrays as attribute

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks generic base class for arrays as attribute/>
    public abstract class ArrayAsAttributeBase<T> 
    {
        private T[] items;
        private uint numEntries;

        protected ArrayAsAttributeBase()
        {
            numEntries = 1;
        }
        protected ArrayAsAttributeBase(uint entries)
        {
            numEntries = entries > 0 ? entries : 1;
        }
        protected ArrayAsAttributeBase(T[] _items) { items = _items; }

        /// Implicit conversion to a T[].
        public static implicit operator T[](ArrayAsAttributeBase<T> alias)
        {
            return alias.Items;
        }

        #region Serialization
        [XmlIgnore]
        T[] Items { get => this.items; set => this.items = value; }

        /// <remarks The required count attribute gives the number of entries represented by the array. 
        /// The number of entries in the array must be numEntries * count./>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public uint Count
        {
            get => (uint)this.Items.Length / numEntries;
            set { }
        }

        [XmlTextAttribute]
        public string Value { get => ToString(); set => FromString(value); }
        #endregion

        public override string ToString()
        {
            string value = string.Join(" ", Items);
            return value;
        }

        public void FromString(string input)
        {
            string[] parts = input.Split(' ');

            if (parts.Length > 0)
            {
                Items = new T[parts.Length];
                for (int i = 0; i < parts.Length; ++i)
                {
                    Items[i] = default(T);
                    try
                    {
                        var converter = TypeDescriptor.GetConverter(typeof(T));
                        if (converter != null)
                        {
                            Items[i] = (T)converter.ConvertFromString(parts[i]);
                        }
                    }
                    finally
                    {
                    }
                }
            }
        }
    }

    /// <summary>
    /// Generic base class for Arrays with 'n' attribute
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ArrayBaseType<T>
    {
        protected T[] itemsField;

        [XmlIgnore]
        public virtual T[] Items { get => itemsField; set => itemsField = value; }

        /// <remarks The required count attribute gives the number of entries represented by the array./>
        [XmlAttribute("n")]
        public uint Count
        {
            get => (uint)this.itemsField.Length;
            set { }
        }
    }
}
