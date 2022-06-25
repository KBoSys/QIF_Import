/*! \file ElongatedCircle.cs
    \brief defines an elliptical arc constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks The EllipticalArcFromScanType defines an elliptical arc construction by the retrieval of an elliptical arc from a scanned
    /// surface feature(point cloud)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcFromScanType : ConstructionMethodBaseType
    {

        private BaseFeatureType surfaceFeatureField;

        private LinearValueType searchRadiusField;

        private LinearValueType depthField;

        /// <remarks/>
        public BaseFeatureType SurfaceFeature
        {
            get
            {
                return this.surfaceFeatureField;
            }
            set
            {
                this.surfaceFeatureField = value;
            }
        }

        /// <remarks/>
        public LinearValueType SearchRadius
        {
            get
            {
                return this.searchRadiusField;
            }
            set
            {
                this.searchRadiusField = value;
            }
        }

        /// <remarks/>
        public LinearValueType Depth
        {
            get
            {
                return this.depthField;
            }
            set
            {
                this.depthField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcTransformType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseEllipticalArcField;

        private TransformationReferenceType transformationField;

        /// <remarks/>
        public BaseFeatureType BaseEllipticalArc
        {
            get
            {
                return this.baseEllipticalArcField;
            }
            set
            {
                this.baseEllipticalArcField = value;
            }
        }

        /// <remarks/>
        public TransformationReferenceType Transformation
        {
            get
            {
                return this.transformationField;
            }
            set
            {
                this.transformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcCastType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseFeatureField;

        /// <remarks/>
        public BaseFeatureType BaseFeature
        {
            get
            {
                return this.baseFeatureField;
            }
            set
            {
                this.baseFeatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcCopyType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseEllipticalArcField;

        /// <remarks/>
        public BaseFeatureType BaseEllipticalArc
        {
            get
            {
                return this.baseEllipticalArcField;
            }
            set
            {
                this.baseEllipticalArcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcIntersectionType : ConstructionMethodBaseType
    {

        private BaseFeatureType intersectionPlaneField;

        private BaseFeatureType intersectionFeatureField;

        /// <remarks/>
        public BaseFeatureType IntersectionPlane
        {
            get
            {
                return this.intersectionPlaneField;
            }
            set
            {
                this.intersectionPlaneField = value;
            }
        }

        /// <remarks/>
        public BaseFeatureType IntersectionFeature
        {
            get
            {
                return this.intersectionFeatureField;
            }
            set
            {
                this.intersectionFeatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcProjectionType : ConstructionMethodBaseType
    {

        private BaseFeatureType projectionFeatureField;

        private BaseFeatureType projectionPlaneField;

        /// <remarks/>
        public BaseFeatureType ProjectionFeature
        {
            get
            {
                return this.projectionFeatureField;
            }
            set
            {
                this.projectionFeatureField = value;
            }
        }

        /// <remarks/>
        public BaseFeatureType ProjectionPlane
        {
            get
            {
                return this.projectionPlaneField;
            }
            set
            {
                this.projectionPlaneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcRecompType : ConstructionMethodBaseType
    {

        private BaseFeaturePointListType baseFeaturePointListField;

        /// <remarks/>
        public BaseFeaturePointListType BaseFeaturePointList
        {
            get
            {
                return this.baseFeaturePointListField;
            }
            set
            {
                this.baseFeaturePointListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcBestFitType : ConstructionMethodBaseType
    {
        /// <remarks/>
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
