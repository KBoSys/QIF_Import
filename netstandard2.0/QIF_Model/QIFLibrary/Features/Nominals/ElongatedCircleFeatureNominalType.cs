/*! \file ElongatedCircleFeatureNominalType.cs
    \brief Defines the elongated circle feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The ElongatedCircleFeatureNominalType defines the elongated
    /// circle feature nominal information for an individual elongated circle feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCircleFeatureNominalType : CurveFeatureNominalBaseType
    {
        /// <remarks> The CenterLine element is the nominal location point and a
        /// unit vector direction of the centerline of the elongated
        /// circle feature.The location point is both midway between
        /// the sides and between the ends.Or in other words, the
        /// sides are located half the diameter away from the location
        /// point in directions perpendicular to both the centerline
        /// vector and the normal vector.The ends are located half the
        /// length away from the location point in directions along and
        /// against the centerline vector.</remarks>
        public PointAndVectorType CenterLine { get; set; }

        /// <remarks> The Normal element is the nominal unit normal vector of the
        /// plane in which the elongated circle feature lies.The
        /// Normal must be perpendicular to the center line.</remarks>
        public UnitVectorType Normal { get; set; }

        /// <remarks> The optional Constructed element signifies that the
        /// elongated circle is constructed and provides details of the construction method.</remarks>
        public ElongatedCircleConstructionMethodType Constructed { get; set; }
    }
}
