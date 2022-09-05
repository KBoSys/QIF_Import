/*! \file EdgePointFeatureDefinitionType.cs

    The InternalExternalEnumType enumerates values that describe
    whether a feature is inside or outside of material.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    public enum InternalExternalEnumType
    {
        INTERNAL,       //</remarks> feature is inside of material, e.g., surface of a cylindrical hole
        EXTERNAL,       //</remarks> feature is outside of material, e.g., surface of a cylindrical peg
        NOT_APPLICABLE  //</remarks> the concept of internal or external does not apply, e.g., a plane
    }
}
