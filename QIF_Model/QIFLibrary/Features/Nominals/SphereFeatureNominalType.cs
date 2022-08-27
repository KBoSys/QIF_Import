/*! \file SphereFeatureNominalType.cs
    \brief Defines the sphere feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The SphereFeatureNominalType defines the sphere feature nominal information for an individual sphere feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphereFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks> The Location element is the nominal center of the sphere.</remarks>
        public PointType Location { get; set; }

        /// <remarks> The optional LatitudeLongitude Sweep element gives the
        /// partial sphere with angular sweep in two directions
        /// analogous to terrestrial latitude and longitude.</remarks>
        public OrientedLatitudeLongitudeSweepType LatitudeLongitudeSweep { get; set; }

        /// <remarks> The optional Constructed element signifies that the sphere
        /// is constructed and provides details of the construction method.</remarks>
        public SphereConstructionMethodType Constructed { get; set; }
    }

    /// <remarks> The SphereConstructionMethodType defines the method for constructing a unique nominal or measured sphere feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphereConstructionMethodType
    {
        /// <remarks> This optional compositor provides a choice of the construction method for the sphere.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(SphereBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(SphereCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(SphereCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(SphereFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(SphereRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(SphereTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
