/*! \file ToroidalSegmentFeatureItemType.cs
    \brief Defines an individual toroidal segment feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Nominals;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The ToroidalSegmentFeatureItemType defines an individual toroidal segment feature.
    /// A toroidal segment feature is a partial torus such as the fillet surface between a cylinder and a plane.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentFeatureItemType : SurfaceFeatureItemBaseType
    {

        private ToroidalSegmentMeasurementDeterminationType determinationModeField;

        /// <remarks></remarks>
        public ToroidalSegmentMeasurementDeterminationType DeterminationMode
        {
            get
            {
                return this.determinationModeField;
            }
            set
            {
                this.determinationModeField = value;
            }
        }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentMeasurementDeterminationType
    {

        private object itemField;

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(ToroidalSegmentCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentCheckedFeatureType
    {

        private ToroidalSegmentCheckedType checkDetailsField;

        /// <remarks></remarks>
        public ToroidalSegmentCheckedType CheckDetails
        {
            get
            {
                return this.checkDetailsField;
            }
            set
            {
                this.checkDetailsField = value;
            }
        }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentCheckedType
    {

        private object itemField;

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(ToroidalSegmentConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
