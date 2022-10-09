/*! \file SFColor.cs
	\brief Specifies one RGB (red-green-blue) color triple.

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
    /// The SFColor field specifies one RGB (red-green-blue) color triple.
    /// Each color is written to the X3D file as an RGB triple of floating
    /// point numbers in the range 0.0 to 1.0. The default value of an
    /// uninitialized SFColor field is (0 0 0).
    /// </summary>
    public class SFColor : X3DVecField<SFFloat>
    {
        public SFColor()
            : base(3)
        {
        }

        public SFColor(SFFloat red, SFFloat green, SFFloat blue)
            : base(3)
        {
            Red = ValidateValueRange(red);
            Green = ValidateValueRange(green);
            Blue = ValidateValueRange(blue);
        }

        #region Color Component Properties

        public SFFloat Red
        {
            get => base.Items[0];
            set => base.Items[0] = ValidateValueRange(value);
        }

        public SFFloat Green
        {
            get => base.Items[1];
            set => base.Items[1] = ValidateValueRange(value);
        }

        public SFFloat Blue
        {
            get => base.Items[2];
            set => base.Items[2] = ValidateValueRange(value);
        }

        protected float ValidateValueRange(float value)
        {
            if (value < 0.0f || value > 1.0f)
            {
                throw new ArgumentOutOfRangeException(string.Format("SFColor component value range is from 0.0 to 1.0. Given value = {0}", value));
            }

            return value;
        }
        #endregion Color Component Properties
    }

    public class SFColorRGBA : SFColor
    {
        public SFColorRGBA() 
        {
            Items = new SFFloat[4] { 0, 0, 0, 0 };
        }
        public SFColorRGBA(SFFloat red, SFFloat green, SFFloat blue, SFFloat alpha)
        {
            Items = new SFFloat[4] { red, green, blue, alpha };
        }
        public SFFloat Alpha
        {
            get => base.Items[3];
            set => base.Items[3] = ValidateValueRange(value);
        }
    }

    /// <summary>
    /// MFColor specifies zero or more SFColor RGB triples, where
    /// each color value is an RGB triple of floating point numbers in range[0, 1].
    /// The default value of an uninitialized MFColor field is the empty list.
    /// Individual SFColor array values are optionally separated by commas in XML syntax.
    /// </summary>
    public class MFColor : X3DArrayField<SFColor>
    {
    }

    /// <summary>
    /// MFColorRGBA specifies zero or more SFColorRGBA 4-tuples, where
    /// each color value is an RGBA 4-tuple of floating point numbers in range[0, 1].
    /// Alpha(opacity) values = (1 - transparency).
    /// The default value of an uninitialized MFColor field is the empty list.
    /// Individual SFColorRGBA array values are optionally separated by commas in XML syntax.
    /// </summary>
    public class MFColorRGBA : X3DArrayField<SFColorRGBA>
    {

    }
}
