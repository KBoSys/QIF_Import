/*! \file CylinderFromScanType.cs
    \brief defines a cylinder constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks The CylinderFromScanType defines a cylinder construction by the
    /// retrieval of a cylinder from a scanned surface feature(point cloud)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderFromScanType : ConstructionMethodBaseType
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
    public partial class CylinderTransformType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseCylinderField;

        private TransformationReferenceType transformationField;

        /// <remarks/>
        public BaseFeatureType BaseCylinder
        {
            get
            {
                return this.baseCylinderField;
            }
            set
            {
                this.baseCylinderField = value;
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
    public partial class CylinderCastType : ConstructionMethodBaseType
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
    public partial class CylinderCopyType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseCylinderField;

        /// <remarks/>
        public BaseFeatureType BaseCylinder
        {
            get
            {
                return this.baseCylinderField;
            }
            set
            {
                this.baseCylinderField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderRecompType : ConstructionMethodBaseType
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
    public partial class CylinderBestFitType : ConstructionMethodBaseType
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
