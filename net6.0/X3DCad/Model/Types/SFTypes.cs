/*! \file SFTypes.cs
	\brief simple types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X3DCad.Model.Types
{
    public class SFInt32 : X3DPrimitiveField<Int32>
    {
        #region Integer Compatibility
        public static implicit operator SFInt32(Int32 value)
        {
            return new SFInt32 { Primitive = value };
        }

        public static implicit operator Int32(SFInt32 obj)
        {
            return obj.Primitive;
        }
        #endregion

        #region String Compatibility

        public override string ToString()
        {
            return Primitive.ToString();
        }

        public override void FromString(string? str)
        {
            this.Primitive = str != null ? Int32.Parse(str) : 0;
        }
        #endregion String Compatibility
    }

    /// <summary>
    /// MFInt32 is an array of SFInt32 values
    /// Array values are optionally separated by commas in XML syntax.
    /// </summary>
    public class MFInt32 : X3DArrayField<SFInt32>
    {
    }
}
