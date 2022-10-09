/*! \file SFVec3f.cs
	\brief SFVec3f is a 3-tuple triplet of SFFloat values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Types
{
    public class SFVec2f : X3DPoint2D<SFFloat>
    {
        public SFVec2f() { }
        public SFVec2f(SFFloat x, SFFloat y) : base(x, y) { }

    }

    /// <summary>
    /// SFVec3f is a 3-tuple triplet of SFFloat values.
    /// </summary>
    public class SFVec3f : X3DPoint3D<SFFloat>
    {
        public SFVec3f() { }
        public SFVec3f(SFFloat x, SFFloat y, SFFloat z) : base(x, y, z) { }

        public static SFVec3f? CreateFromString(string? value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }
            SFVec3f res = new SFVec3f();
            res.FromString(value);
            return res;
        }
    }

    /// <summary>
    /// bboxSizeType dimensions are non-negative values, default value (-1 -1 -1) indicates that no bounding box size has been computed.
    /// </summary>
    public class bboxSizeType : SFVec3f
    {
        public bboxSizeType() : base(-1, -1, -1) { }

        public static new bboxSizeType? CreateFromString(string? value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }
            bboxSizeType res = new bboxSizeType();
            res.FromString(value);
            return res;
        }
    }

    public class MFVec3f : X3DArrayField<SFVec3f>
    {
        #region String Compatibility
        public static implicit operator MFVec3f(string str)
        {
            var obj = new MFVec3f();

            obj.FromString(str);
            return obj;
        }

        public static implicit operator string? (MFVec3f obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    public class MFVec2f : X3DArrayField<SFVec2f>
    {
        #region String Compatibility
        public static implicit operator MFVec2f(string str)
        {
            var obj = new MFVec2f();

            obj.FromString(str);
            return obj;
        }

        public static implicit operator string?(MFVec2f obj)
        {
            return obj.ToString();
        }

        #endregion
    }
}
