/*! \file X3DField.cs
	\brief X3DField is the abstract field type from which all single values field types are derived.

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
    /// X3DField is the abstract field type from which all single values field types are derived.
    /// </summary>
    public abstract class X3DField
    {
        public X3DField() { }

        #region String Compatibility
        public abstract void FromString(string? str);
        #endregion String Compatibility
    }
}
