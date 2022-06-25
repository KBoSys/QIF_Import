﻿/*! \file ExtrudedCrossSection.cs
    \brief defines an extruded cross section constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks The ExtrudedCrossSectionTransformType defines an extruded cross section construction by the transformation of an extruded cross
    /// section through the specified nominal or actual coordinate system./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionTransformType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseExtrudedCrossSectionField;

        private TransformationReferenceType transformationField;

        /// <remarks/>
        public BaseFeatureType BaseExtrudedCrossSection
        {
            get
            {
                return this.baseExtrudedCrossSectionField;
            }
            set
            {
                this.baseExtrudedCrossSectionField = value;
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
    public partial class ExtrudedCrossSectionCastType : ConstructionMethodBaseType
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
    public partial class ExtrudedCrossSectionCopyType : ConstructionMethodBaseType
    {

        private BaseFeatureType baseExtrudedCrossSectionField;

        /// <remarks/>
        public BaseFeatureType BaseExtrudedCrossSection
        {
            get
            {
                return this.baseExtrudedCrossSectionField;
            }
            set
            {
                this.baseExtrudedCrossSectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionRecompType : ConstructionMethodBaseType
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
    public partial class ExtrudedCrossSectionBestFitType : ConstructionMethodBaseType
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
