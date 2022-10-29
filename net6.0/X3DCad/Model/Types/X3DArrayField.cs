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
    public interface IX3DArray
    {
        public string? ToString();
        public void FromString(string? value);
    }

    /// <summary>
    /// Generic class for sequence of numbers [0...*]
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class X3DArrayField<SingleField> : List<SingleField>, IX3DArray
        where SingleField : X3DField, new()
    {
        #region String Compatibility
        public override string? ToString()
        {
            return string.Join(" ", this);
        }

        public virtual void FromString(string? value)
        {
            Clear();
            if (!string.IsNullOrEmpty(value))
            {
                var parts = Regex.Split(value, @"\s+");
                this.FromStringTokens(parts);
            }
        }

        protected virtual void FromStringTokens(string[] tokens)
        {
            for (int tokenIdx = 0; tokenIdx < tokens.Length; )
            {
                var obj = new SingleField();
                obj.FromStringTokens(tokens, ref tokenIdx);
                Add(obj);
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
