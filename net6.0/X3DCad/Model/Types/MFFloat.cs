/*! \file MFFloat.cs
	\brief MFFloat is an array of SFFloat values

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
    /// MFFloat is an array of SFFloat values, meaning a single-precision floating-point array type.  
    /// Array values are optionally separated by commas in XML syntax.
    /// </summary>
    public class MFFloat : ListNumbersBase<float>
    {
    }
}
