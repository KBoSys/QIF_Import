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

    /// <summary>
    /// The SFColor field specifies one RGB (red-green-blue) color triple.
    /// Each color is written to the X3D file as an RGB triple of floating
    /// point numbers in the range 0.0 to 1.0. The default value of an
    /// uninitialized SFColor field is (0 0 0).
    /// </summary>
    public class SFColor : SFVec3f
    {
        public SFColor()
            : base(0.0f, 0.0f, 0.0f)
        {
        }

        public SFColor(SFFloat red, SFFloat green, SFFloat blue)
            : base(ValidateValueRange(red), ValidateValueRange(green), ValidateValueRange(blue))
        {
        }

        #region Color Component Properties

        public SFFloat Red
        {
            get => base.X;
            set => base.X = ValidateValueRange(value);
        }

        public SFFloat Green
        {
            get => base.Y;
            set => base.Y = ValidateValueRange(value);
        }

        public SFFloat Blue
        {
            get => base.Z;
            set => base.Z = ValidateValueRange(value);
        }

        private static float ValidateValueRange(float value)
        {
            if (value < 0.0f || value > 1.0f)
            {
                throw new ArgumentOutOfRangeException(string.Format("SFColor Red component value range is from 0.0 to 1.0. Given value = {0}", value));
            }

            return value;
        }

        #endregion Color Component Properties
    }
}
