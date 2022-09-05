/*! \file ElongatedCylinderFeatureNominalType.cs
    \brief Defines the elongated cylinder feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The ElongatedCylinderFeatureNominalType defines the elongated
    /// cylinder feature nominal information for an individual elongated cylinder feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCylinderFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks> The CenterPlane element gives the nominal location point
        /// and unit vector normal of the center plane of the elongated
        /// cylinder feature.The location point of the center plane is
        /// also the nominal location point of the elongated cylinder
        /// feature and lies midway between the cylindrical ends.</remarks>
        public PlaneType? CenterPlane { get; set; }

        /// <remarks> The DepthVector element is the nominal unit vector
        /// direction of the depth of the elongated cylinder.The depth
        /// vector is parallel to the axis vector of each cylindrical
        /// end and points into the elongated cylinder.The elongated
        /// cylinder does not extend from the location point in the
        /// direction opposite the depth vector.</remarks>
        public UnitVectorType? DepthVector { get; set; }

        /// <remarks> The optional Constructed element signifies that the
        /// elongated cylinder is constructed and provides details of
        /// the construction method.</remarks>
        public ElongatedCylinderConstructionMethodType? Constructed { get; set; }
    }
}
