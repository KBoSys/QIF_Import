/*! \file EdgePointFeatureDefinitionType.cs

    The InternalExternalEnumType enumerates values that describe
    whether a feature is inside or outside of material.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFDocument.PrimitivesPMI
{
	public enum InternalExternalEnumType
	{
        INTERNAL,       ///> feature is inside of material, e.g., surface of a cylindrical hole
        EXTERNAL,       ///> feature is outside of material, e.g., surface of a cylindrical peg
        NOT_APPLICABLE  ///> the concept of internal or external does not apply, e.g., a plane
    }
}
