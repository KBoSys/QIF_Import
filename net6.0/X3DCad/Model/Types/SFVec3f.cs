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
    }
}
