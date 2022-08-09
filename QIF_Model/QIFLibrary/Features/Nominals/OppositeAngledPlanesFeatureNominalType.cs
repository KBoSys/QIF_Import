/*! \file OppositeAngledPlanesFeatureNominalType.cs
    \brief Defines the opposite angled planes feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The OppositeAngledPlanesFeatureNominalType defines the opposite
    /// angled planes feature nominal information for an individual
    /// opposite angled planes feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The CenterPlane element is the nominal location point and a
        /// unit vector normal of the center plane of the opposite
        /// angled planes feature.The location point is both midway
        /// between the sides and between the ends(real or
        /// virtual). Or in other words, the sides are located half the
        /// width away from the location point in directions along and
        /// against the center plane normal.The ends are located half
        /// the length away from the location point in directions along
        /// and against the length vector./>
        public PlaneType CenterPlane { get; set; }

        /// <remarks The optional LengthVector element is the nominal unit
        /// vector of the long axis of the feature./>
        public UnitVectorType LengthVector { get; set; }

        /// <remarks The optional DepthVector element is the nominal unit vector
        /// pointing out of the feature(away from the bottom if there
        /// is one) and is perpendicular to both the LengthVector and
        /// the normal to the center plane./>
        public UnitVectorType DepthVector { get; set; }

        /// <remarks The optional DraftVector element is the nominal unit vector
        /// defining the direction in which the draft angle is applied
        /// when it is different than the depth vector and like the
        /// depth vector generally points out of the feature.It is not
        /// necessarily perpendicular to either the LengthVector or the
        /// normal to the center plane./>
        public UnitVectorType DraftVector { get; set; }

        /// <remarks The optional Constructed element signifies that the opposite
        /// angled planes feature is constructed and provides details of
        /// the construction method./>
        public OppositeAngledPlanesConstructionMethodType Constructed { get; set; }
    }
}
