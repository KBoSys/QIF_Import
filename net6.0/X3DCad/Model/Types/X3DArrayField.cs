/*! \file X3DVecField.cs
	\brief Generic class for sequence of numbers 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Helpers;

namespace X3DCad.Model.Types
{
    /// <summary>
    /// Generic class for sequence of numbers [0...*]
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class X3DArrayField<SingleField> where SingleField : X3DField, new()
    {
        private List<SingleField> itemsField = new List<SingleField>();

        public void Add(SingleField field)
        {
            itemsField.Add(field);
        }

        [XmlIgnore]
        public List<SingleField> Items { get => itemsField; set => itemsField = value; }

        #region String Compatibility
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
                this.FromStringTokens(parts);
            }
        }

        protected void FromStringTokens(string[] tokens)
        {
            itemsField.Clear();
            for (int tokenIdx = 0; tokenIdx < tokens.Length; )
            {
                var obj = new SingleField();
                obj.FromStringTokens(tokens, ref tokenIdx);
                itemsField.Add(obj);
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

    /// <summary>
    /// MFFloat is an array of SFFloat values, meaning a single-precision floating-point array type.  
    /// Array values are optionally separated by commas in XML syntax.
    /// </summary>
    public class MFFloat : X3DArrayField<SFFloat>
    {
    }
}
