/*! \file SFRotation.cs
	\brief SFRotation is an axis-angle 4-tuple, indicating X-Y-Z direction axis plus angle orientation about that axis.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace X3DCad.Model.Types
{
    /// <summary>
    /// SFRotation is an axis-angle 4-tuple, indicating X-Y-Z direction axis plus angle orientation about that axis.
    /// The first three values specify a normalized axis vector about which the rotation takes place, so the first three values shall be within the range[-1..+1] in order to represent a normalized unit vector.
    /// The fourth value specifies the amount of right-handed rotation about that axis in radians.
    /// Warning: comma characters within singleton values do not pass strict XML validation.
    /// </summary>
    public class SFRotation : X3DVecField<SFFloat>
    {
        public SFRotation() : base(4) 
        {   // Identity
            base.Items[0] = 0;
            base.Items[1] = 0;
            base.Items[2] = 1;
            base.Items[3] = 0;
        }

        public static SFRotation? CreateFromString(string? value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }
            SFRotation res = new SFRotation();
            res.FromString(value);
            return res;
        }
    }
}
