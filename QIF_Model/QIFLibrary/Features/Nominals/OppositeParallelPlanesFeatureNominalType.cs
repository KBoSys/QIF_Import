/*! \file OppositeParallelPlanesFeatureNominalType.cs
    \brief Defines the opposite parallel planes feature nominal information for an individual opposite parallel planes feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The OppositeParallelPlanesFeatureNominalType defines the opposite
    /// parallel planes feature nominal information for an individual opposite parallel planes feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelPlanesFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The CenterPlane element is the nominal location point and a
        /// unit vector normal of the center plane of the opposite
        /// parallel planes feature.The location point is both midway
        /// between the sides and between the ends(real or
        /// virtual). Or in other words, the sides are located half the
        /// width away from the location point in directions along and
        /// against the center plane normal.The ends are located half
        /// the length away from the location point in directions along
        /// and against the length vector./>
        public PlaneType CenterPlane { get; set; }

        /// <remarks The optional LengthVector element is the nominal unit vector of the long axis of the feature./>
        public UnitVectorType LengthVector { get; set; }

        /// <remarks The optional DepthVector element is the nominal unit vector
        /// pointing out of the feature(away from the bottom if there is one) and is perpendicular to both the LengthVector and
        /// the normal to the center plane./>
        public UnitVectorType DepthVector { get; set; }

        /// <remarks The optional Constructed element signifies that the
        /// opposite parallel planes feature is constructed and
        /// provides details of the construction method./>
        public OppositeParallelPlanesConstructionMethodType Constructed { get; set; }
    }

    /// <remarks The OppositeParallelPlanesFeatureMeasurementType defines the
    /// opposite parallel planes feature measurement information for an
    /// individual opposite parallel planes feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelPlanesConstructionMethodType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(OppositeParallelPlanesBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(OppositeParallelPlanesCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(OppositeParallelPlanesCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(OppositeParallelPlanesFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(OppositeParallelPlanesRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(OppositeParallelPlanesTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
