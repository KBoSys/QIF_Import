/*! \file ConeFeatureNominalType.cs
    \brief Defines the cone feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The ConeFeatureNominalType defines the cone feature nominal information for an individual cone feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The Axis element is the nominal locating point and nominal
        /// unit axis vector of the cone which points from the locating
        /// point into the expanding end of the cone./>
        public AxisType Axis { get; set; }

        /// <remarks The optional Sweep element is the swept angle for a partial cone.
        /// The swept angle is typically greater than 180 degrees
        /// for a feature of size.If the sweep is not specified then
        /// the feature subtends a full 360 degrees.The StartVector of
        /// the Sweep must lie in a plane normal to the axis of the cone./>
        public SweepType Sweep { get; set; }

        /// <remarks The optional Constructed element signifies that the cone is constructed and provides details of the construction method./>
        public ConeConstructionMethodType Constructed { get; set; }
    }

    /// <remarks The ConeConstructionMethodType defines the method for constructing a unique nominal or measured cone feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeConstructionMethodType
    {
        /// <remarks This optional compositor provides a choice of the construction method for the cone./>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(ConeBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(ConeCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(ConeCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(ConeFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(ConeRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(ConeTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
