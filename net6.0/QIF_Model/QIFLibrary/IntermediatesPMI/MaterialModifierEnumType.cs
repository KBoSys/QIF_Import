/*! \file MaterialModifierEnumType.cs
	\brief Defines Material Modifier 

	The MaterialModifierEnumType enumerates values that describe a
	material condition or material boundary modifier for a tolerance
    zone or a datum reference.

	ASME Y14.5 - 2009 Sections 1.3.38, 1.3.39, 1.3.48

	ISO 2692 specific: LEAST_RPR and MAXIMUM_RPR represent the least
    and maximum material symbols respectively when appended with the
	reciprocity requirement symbol, i.e., (L)(R) and (M)(R).

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> 
    /// The MaterialModifierEnumType enumerates values that describe a
    /// material condition or material boundary modifier for a tolerance zone or a datum reference.
    /// </remarks>
    public enum MaterialModifierEnumType
    {
        REGARDLESS,
        LEAST,
        MAXIMUM,
        LEAST_RPR,
        MAXIMUM_RPR,
        NONE,
    }
}
