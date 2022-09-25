/*! \file SFFloat.cs
	\brief Specifies one single-precision floating point number.

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
    /// The SFFloat field specifies one single-precision floating point number.
    /// Implementation of these fields is targeted at the single precision
    /// floating point capabilities of processors. However, it is allowable to
    /// implement this field using fixed point numbering provided at least six
    /// decimal digits of precision are maintained and that exponents have
    /// range of at least [-12, 12] for both positive and negative numbers.
    /// The default value of an uninitialized SFFloat field is 0.0.
    /// </summary>
    public class SFFloat : X3DPrimitiveField<float>
    {
        #region Constructors

        public SFFloat()
        {
            Primitive = 0.0f;
        }

        public SFFloat(float value)
        {
            Primitive = value;
        }

        public SFFloat(SFFloat obj)
        {
            Primitive = obj.Primitive;
        }

        #endregion Constructors

        #region float Compatibility

        public static implicit operator SFFloat(float value)
        {
            return new SFFloat { Primitive = value };
        }

        public static implicit operator float(SFFloat obj)
        {
            return obj.Primitive;
        }

        #endregion float Compatibility

        #region String Compatibility

        public override string ToString()
        {
            return Primitive.ToString("0.000000").TrimEnd('0').TrimEnd('.');
        }
        #endregion String Compatibility
    }

    /// <summary>
    /// unitIntervalType value is an SFFloat ranging [0..1]
    /// </summary>
    public class unitIntervalType : SFFloat
    {
        public unitIntervalType() : base(0.5f)
        {
        }
        public unitIntervalType(float val) : base(val)
        {
        }

        public static implicit operator float (unitIntervalType d) => d.Primitive;
        public static implicit operator unitIntervalType (float value) => new unitIntervalType(value);
    }
}
