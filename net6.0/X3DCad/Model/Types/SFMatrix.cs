/*! \file SFMatrix.cs
	\brief Matrices

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Types
{
    /// <summary>
    /// SFMatrix3d specifies a 3x3 matrix of double-precision floating point numbers, organized in row-major fashion.
    /// Warning: comma characters within singleton values do not pass strict XML validation.
    /// </summary>
    public class SFMatrix3d : X3DVecField<SFFloat>
    {
        public SFMatrix3d() : base(9) 
        {
            // Identity
            base.Items[0] = 1;
            base.Items[1] = 0;
            base.Items[2] = 0;
            base.Items[3] = 0;
            base.Items[4] = 1;
            base.Items[5] = 0;
            base.Items[6] = 0;
            base.Items[7] = 0;
            base.Items[8] = 1;
        }

        [XmlAttribute("defaultValue")]
        [System.ComponentModel.DefaultValueAttribute("1 0 0 0 1 0 0 0 1")]
        public string? ValueAsText 
        { 
            get => ToString(); 
            set => FromString(value); 
        }

        public static SFMatrix3d? CreateFromString(string? value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }
            SFMatrix3d res = new SFMatrix3d();
            res.FromString(value);
            return res;
        }
    }

    public class MFMatrix3d : X3DArrayField<SFMatrix3d>
    {
        #region String Compatibility
        public static implicit operator MFMatrix3d(string str)
        {
            var obj = new MFMatrix3d();

            obj.FromString(str);
            return obj;
        }

        public static implicit operator string?(MFMatrix3d obj)
        {
            return obj.ToString();
        }
        #endregion
    }

    /// <summary>
    /// SFMatrix4f specifies a 4x4 matrix of single-precision floating point numbers, organized in row-major fashion.
    /// Warning: comma characters within singleton values do not pass strict XML validation.
    /// </summary>
    public class SFMatrix4d : X3DVecField<SFFloat>
    {
        public SFMatrix4d() : base(16)
        {
            // Identity
            base.Items[0] = 1;
            base.Items[1] = 0;
            base.Items[2] = 0;
            base.Items[3] = 0;

            base.Items[4] = 0;
            base.Items[5] = 1;
            base.Items[6] = 0;
            base.Items[7] = 0;

            base.Items[8] = 0;
            base.Items[9] = 0;
            base.Items[10] = 1;
            base.Items[11] = 0;

            base.Items[12] = 0;
            base.Items[13] = 0;
            base.Items[14] = 0;
            base.Items[15] = 1;
        }

        [XmlAttribute("defaultValue")]
        [System.ComponentModel.DefaultValueAttribute("1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1")]
        public string? ValueAsText
        {
            get => ToString();
            set => FromString(value);
        }

        public static SFMatrix4d? CreateFromString(string? value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }
            SFMatrix4d res = new SFMatrix4d();
            res.FromString(value);
            return res;
        }
    }

    public class MFMatrix4d : X3DArrayField<SFMatrix4d>
    {
        #region String Compatibility
        public static implicit operator MFMatrix4d(string str)
        {
            var obj = new MFMatrix4d();

            obj.FromString(str);
            return obj;
        }

        public static implicit operator string?(MFMatrix4d obj)
        {
            return obj.ToString();
        }
        #endregion
    }
}
