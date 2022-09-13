﻿/*! \file X3DPrimitiveField.cs
	\brief X3DPrimitiveField is the abstract generic field type from which all primitive field types are derived.

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
    /// X3DPrimitiveField is the abstract non-generic field type inherited by
    /// generic version of this class. This is needed to group all the instantiated
    /// classes such as <see cref="SFBool" />, <see cref="SFDouble" />,
    /// <see cref="SFFloat" /> and <see cref="SFInt32" /> are primitive data
    /// field types.
    /// </summary>
    public abstract class X3DPrimitiveField : X3DField
    {
        public X3DPrimitiveField() { }
    }

    /// <summary>
    /// X3DPrimitiveField is the abstract generic field type from which all primitive
    /// field types are derived. <see cref="SFBool" />, <see cref="SFDouble" />,
    /// <see cref="SFFloat" />, <see cref="SFInt32" /> and <see cref="SFTime" />
    /// are primitive data field types.
    /// </summary>
    /// <typeparam name="TPrimitive">.NET Framework equivalent primitive data type</typeparam>
    public abstract class X3DPrimitiveField<TPrimitive> : X3DPrimitiveField
        where TPrimitive : struct
    {
        protected TPrimitive Primitive { get; set; }
        public X3DPrimitiveField()
        {
            Primitive = default(TPrimitive);
        }

        #region Object Equality

        public override int GetHashCode()
        {
            return this.Primitive.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is X3DPrimitiveField<TPrimitive>)
            {
                return this.Primitive.Equals(((X3DPrimitiveField<TPrimitive>)obj).Primitive);
            }
            else if (obj is TPrimitive)
            {
                return this.Primitive.Equals((TPrimitive)obj);
            }
            else
            {
                return false;
            }
        }

        #endregion Object Equality

        #region String Compatibility

        public override string? ToString()
        {
            return this.Primitive.ToString();
        }

        #endregion String Compatibility
    }
}
