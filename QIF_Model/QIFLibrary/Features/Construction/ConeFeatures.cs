/*! \file ConeFeatures.cs
    \brief defines a cone constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks The ConeFromScanType defines a cone construction by the retrieval of a cone from a scanned surface feature(point cloud)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeFromScanType : ConstructionMethodBaseType
    {
        /// <remarks The SurfaceFeature element identifies the scanned surface
        /// feature from which the cone is retrieved./>
        public BaseFeatureType SurfaceFeature { get; set; }

        /// <remarks The SearchRadius element is the radius around the nominal
        /// feature, wherein the measured feature can be expected.The
        /// SearchRadius is the radius added to and subtracted from the
        /// nominal feature radius(normal to the cone surface) to
        /// define a conical shell.All scanned points within this
        /// conical shell are used for the retrieval of the feature.
        /// The conical shell's axis is defined by the feature's
        /// direction and the conical shell's axis passes through the
        /// feature's center point. The conical acceptance shell is
        /// evenly disposed about the nominal cone./>
        public LinearValueType SearchRadius { get; set; }
    }

    /// <remarks The ConeTransformType defines a cone construction by the
    /// transformation of a base cone through the specified nominal or
    /// actual coordinate system./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeTransformType : ConstructionMethodBaseType
    {
        /// <remarks The BaseCone element identifies the cone to be transformed./>
        public BaseFeatureType BaseCone { get; set; }

        /// <remarks The Transformation element identifies the coordinate system to be used to transform the cone./>
        public TransformationReferenceType Transformation { get; set; }
    }

    /// <remarks The ConeCastType defines the cast of feature type to a cone. The
    /// location, vector and angle are copied from the base feature.Any
    /// information not available on the base feature will remain at nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeCastType : ConstructionMethodBaseType
    {
        /// <remarks The BaseFeature element identifies the base feature to be cast to a cone./>
        public BaseFeatureType BaseFeature { get; set; }
    }

    /// <remarks The ConeCopyType defines a copied cone construction./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeCopyType : ConstructionMethodBaseType
    {
        /// <remarks The BaseCone element identifies the cone to be copied./>
        public BaseFeatureType BaseCone { get; set; }
    }

    /// <remarks The ConeRecompType defines a list of base feature points for
    /// construction of a re-compensated-for-probe-size best-fit cone
    /// through the measurement points of base features./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeRecompType : ConstructionMethodBaseType
    {
        /// <remarks The BaseFeaturePointList element gives a list of sets of
        /// points for construction of a re-compensated-for-probe-size best-fit cone.
        /// The total number of points in the BaseFeaturePointSets in the list must be 6 or greater./>
        public BaseFeaturePointListType BaseFeaturePointList { get; set; }
    }

    /// <remarks The ConeBestFitType defines the information for a best-fit cone
    /// which includes a list of point-reducible base features; the points
    /// to which those features reduce are used in the best-fit
    /// construction of the cone./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeBestFitType : ConstructionMethodBaseType
    {
        /// <remarks Each BaseFeature element identifies a base feature to be
        /// used for the construction of a cone.The number of base features must be 6 or greater./>
        [System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
        public SequencedBaseFeatureType[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
