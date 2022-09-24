/*! \file X3DVecField.cs
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
    public abstract class X3DVecField<T> : X3DField 
        where T : X3DPrimitiveField, new()
    {
        #region Constructors
        private T[] valueField;

        protected X3DVecField(uint size)
        {
            valueField = new T[size];
            for (int i = 0; i < size; ++i)
                valueField[i] = new T();
        }
        #endregion

        #region Vector Element Accessors
        [XmlIgnore]
        public T[] Items { get => valueField; set => valueField = value; }
        #endregion

        #region Object Equality
        public override int GetHashCode()
        {
            int hash = 17;
            foreach (var item in Items)
                hash = hash * 23 + item.GetHashCode();

            return hash;
        }

        public override bool Equals(object? obj)
        {
            if (obj is X3DVecField<T>)
            {
                var casted = obj as X3DVecField<T>;
                if (casted != null && Items.Length == casted.Items.Length)
                {
                    for (int i = 0; i < Items.Length; i++)
                    {
                        if (!Items[i].Equals(casted.Items[i]))
                            return false;
                    }
                    return true;
                }
            }

            return false;
        }

        #endregion Object Equality

        #region String Compatibility
        public override string? ToString()
        {
            if (Items != null)
            {
                string value = string.Join(" ", Items.AsEnumerable());
                return value;
            }
            return null;
        }

        public override void FromString(string? value)
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
                    cnt = Math.Min(cnt, (uint)Items.Length);
                    for (int i = 0, idx = 0; i < parts.Length && idx < cnt; ++i)
                    {
                        if (!string.IsNullOrEmpty(parts[i]))
                        {
                            Items[idx].FromString(parts[i]);
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
        #endregion
    }

    public class X3DPoint2D<T> : X3DVecField<T> where T : X3DPrimitiveField, new()
    {
        public X3DPoint2D() : base(2) { }

        #region Vector Element Accessors
        public T X { get => base.Items[0]; set => base.Items[0] = value; }
        public T Y { get => base.Items[1]; set => base.Items[1] = value; }
        #endregion
    }

    public class X3DPoint3D<T> : X3DVecField<T> where T : X3DPrimitiveField, new()
    {
        public X3DPoint3D() : base(3) { }
        public X3DPoint3D(T x, T y, T z) : base(3) 
        {
            base.Items[0] = x;
            base.Items[1] = y;
            base.Items[2] = z;
        }

        #region Vector Element Accessors
        public T Z { get => base.Items[2]; set => base.Items[2] = value; }
        #endregion
    }
}
