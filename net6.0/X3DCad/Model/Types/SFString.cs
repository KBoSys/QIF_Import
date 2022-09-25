/*! \file SFString.cs
	\brief The SFString field contain strings encoded with the UTF-8 universal character set. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X3DCad.Model.Types
{
    /// <summary>
    /// The SFString field contain strings encoded with the UTF-8 universal
    /// character set. Any characters (including linefeeds and '#') may appear
    /// within the string. The default value of an uninitialized SFString
    /// outputOnly field is the empty string.
    /// </summary>
    public class SFString : X3DField
    {
        #region Constructors
        private string Data { get; set; }

        public SFString()
        {
            this.Data = string.Empty;
        }

        public SFString(string data)
        {
            this.Data = data;
        }

        public SFString(SFString obj)
        {
            this.Data = obj.Data;
        }

        #endregion Constructors

        #region Object Equality

        public override int GetHashCode()
        {
            return this.Data.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if ((obj as SFString) != null)
            {
                return this.Data.Equals(((SFString)obj).Data);
            }

            return (obj as string) != null && this.Data.Equals(obj);
        }

        #endregion Object Equality

        #region String Compatibility

        public override string ToString()
        {
            return this.Data;
        }

        public override void FromString(string? str)
        {
            this.Data = str ?? string.Empty;
        }

        public override bool FromStringTokens(string[] tokens, ref int firstIdx)
        {
            if (firstIdx < tokens.Length)
            {
                this.Data = tokens[firstIdx];
                ++firstIdx;
                return true;
            }
            return false;
        }

        public static implicit operator SFString?(string? obj)
        {
            return obj == null ? null : new SFString(obj);
        }

        public static implicit operator string? (SFString obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return obj.Data;
            }
        }
        #endregion String Compatibility
    }
}
