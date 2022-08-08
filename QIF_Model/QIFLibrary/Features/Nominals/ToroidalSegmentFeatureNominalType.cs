/*! \file ToroidalSegmentFeatureNominalType.cs
    \brief Defines the toroidal segment feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The ToroidalSegmentFeatureNominalType defines the toroidal segment
    /// feature nominal information for an individual toroidal segment feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The Location element is the nominal center of the toroidal segment./>
        public PointType Location { get; set; }

        /// <remarks The AxisVector element is the nominal unit axis vector of the toroidal segment./>
        public UnitVectorType AxisVector { get; set; }

        /// <remarks The LatitudeLongitudeSweep element is the extent of the
        /// toroidal segment feature with angular sweep in two
        /// directions analogous to terrestrial latitude and longitude./>
        public LatitudeLongitudeSweepType LatitudeLongitudeSweep { get; set; }

        /// <remarks The optional Constructed element signifies that the
        /// toroidal segment is constructed and provides details of the
        /// construction method./>
        public ToroidalSegmentConstructionMethodType Constructed { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentConstructionMethodType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(ToroidalSegmentBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(ToroidalSegmentCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(ToroidalSegmentCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(ToroidalSegmentRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(ToroidalSegmentTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }

    /// <remarks The TorusFeatureNominalType defines the torus feature nominal information for an individual torus feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The Location element is the nominal center of the torus./>
        public PointType Location { get; set; }

        /// <remarks The AxisVector element is the nominal unit axis vector of the torus./>
        public UnitVectorType AxisVector { get; set; }

        /// <remarks The optional LatitudeLongitudeSweep element gives the
        /// extent of a partial torus with angular sweep in two
        /// directions analogous to terrestrial latitude and longitude./>
        public LatitudeLongitudeSweepType LatitudeLongitudeSweep { get; set; }

        /// <remarks The optional Constructed element signifies that the torus is
        /// constructed and provides details of the construction method./>
        public TorusConstructionMethodType Constructed { get; set; }
    }
}
