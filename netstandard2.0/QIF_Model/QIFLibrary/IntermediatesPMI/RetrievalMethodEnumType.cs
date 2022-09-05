/*! \file RetrievalMethodEnumType.cs
 	\brief The RetrievalMethodEnumType enumerates values that describe methods
        of retrieving a single point from a set of points in a cylindrical acceptance window.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The RetrievalMethodEnumType enumerates values that describe methods
    /// of retrieving a single point from a set of points in a cylindrical acceptance window.</remarks>
    public enum RetrievalMethodEnumType
    {
        AVERAGE,	//</remarks> will average all points within the window.
		MAXEXTREME, //</remarks> will retrieve the single point furthest in the direction of the cylinder's axis.
		MINEXTREME, //</remarks> will retrieve the single point furthest against the direction of the cylinder's axis,
		CLOSEST1D,	//</remarks> will retrieve the single point closest to the cylinder center point along the cylinder's axis without regard to the perpendicular distance from the cylinder's axis.
		CLOSEST2D,	//</remarks> will retrieve the single point closest to the cylinder's axis without regard to the distance up or down the axis from the cylinder center point.
		CLOSEST3D,	//</remarks> will retrieve the single point closest to the cylinder's center point in three dimensions.
	}
}
