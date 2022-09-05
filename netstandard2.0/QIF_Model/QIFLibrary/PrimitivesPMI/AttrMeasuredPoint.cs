/*! \file AttrMeasuredPoint.cs
    \brief Provides attributes for the combined uncertainty and mean error of measured 3D points and vectors.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <summary>
    /// The AttrMeasuredPoint attributeGroup provides attributes for the
    /// combined uncertainty and mean error of measured 3D points and
    /// vectors. Uncertainty and/or error may be specified that applies to
    /// all three values(X, Y and Z) and/or uncertainty and/or error may
    /// be specified individually for X, Y, and Z.If both types of
    /// accuracy are given, the individual values should be used, not the group value.
    /// </summary>
    public class AttrMeasuredPoint
    {
        /// <remarks></remarks>
        public decimal CombinedUncertainty { get; set; }

        /// <remarks></remarks>
        public decimal MeanError { get; set; }

        /// <remarks></remarks>
        public decimal XCombinedUncertainty { get; set; }

        /// <remarks></remarks>
        public decimal XMeanError { get; set; }

        /// <remarks></remarks>
        public decimal YCombinedUncertainty { get; set; }

        /// <remarks></remarks>
        public decimal YMeanError { get; set; }

        /// <remarks></remarks>
        public decimal ZCombinedUncertainty { get; set; }

        /// <remarks></remarks>
        public decimal ZMeanError { get; set; }
    }
}
