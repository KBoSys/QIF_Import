/*! \file OppositeParallelPlanes.cs
    \brief defines an opposite parallel planes feature constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks The OppositeParallelPlanesFromScanType defines an opposite parallel planes feature construction by the retrieval of an opposite
    /// parallel planes feature from a scanned surface feature(point cloud)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelPlanesFromScanType : ConstructionMethodBaseType
    {

        private BaseFeatureType surfaceFeatureField;

        private LinearValueType searchRadiusField;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelPlanesTransformType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseOppositeParallelPlanesField;

        private TransformationReferenceType transformationField;

        /// <remarks/>
        public BaseFeatureType BaseOppositeParallelPlanes
        {
            get
            {
                return this.baseOppositeParallelPlanesField;
            }
            set
            {
                this.baseOppositeParallelPlanesField = value;
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
    public partial class OppositeParallelPlanesCastType : ConstructionMethodBaseType
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
    public partial class OppositeParallelPlanesCopyType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseOppositeParallelPlanesField;

        /// <remarks/>
        public BaseFeatureType BaseOppositeParallelPlanes
        {
            get
            {
                return this.baseOppositeParallelPlanesField;
            }
            set
            {
                this.baseOppositeParallelPlanesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelPlanesRecompType : ConstructionMethodBaseType
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
    public partial class OppositeParallelPlanesBestFitType : ConstructionMethodBaseType
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledLinesFromScanType : ConstructionMethodBaseType
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
    public partial class OppositeAngledLinesTransformType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseOppositeAngledLinesField;

        private TransformationReferenceType transformationField;

        /// <remarks/>
        public BaseFeatureType BaseOppositeAngledLines
        {
            get
            {
                return this.baseOppositeAngledLinesField;
            }
            set
            {
                this.baseOppositeAngledLinesField = value;
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
    public partial class OppositeParallelLinesFromScanType : ConstructionMethodBaseType
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
    public partial class OppositeParallelLinesTransformType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseOppositeParallelLinesField;

        private TransformationReferenceType transformationField;

        /// <remarks/>
        public BaseFeatureType BaseOppositeParallelLines
        {
            get
            {
                return this.baseOppositeParallelLinesField;
            }
            set
            {
                this.baseOppositeParallelLinesField = value;
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
    public partial class OppositeParallelLinesCastType : ConstructionMethodBaseType
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
    public partial class OppositeParallelLinesCopyType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseOppositeParallelLinesField;

        /// <remarks/>
        public BaseFeatureType BaseOppositeParallelLines
        {
            get
            {
                return this.baseOppositeParallelLinesField;
            }
            set
            {
                this.baseOppositeParallelLinesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesProjectionType : ConstructionMethodBaseType
    {

        private BaseFeatureType projectionPlaneField;

        private BaseFeatureType projectionOppositeParallelLinesField;

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

        /// <remarks/>
        public BaseFeatureType ProjectionOppositeParallelLines
        {
            get
            {
                return this.projectionOppositeParallelLinesField;
            }
            set
            {
                this.projectionOppositeParallelLinesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesIntersectionType : ConstructionMethodBaseType
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
    public partial class OppositeParallelLinesRecompType : ConstructionMethodBaseType
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
    public partial class OppositeParallelLinesBestFitType : ConstructionMethodBaseType
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
