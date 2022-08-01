/*! \file MeasuredPointType.cs
    \brief defines an XYZ location in which the length units, accuracy, uncertainty and error of the coordinates may be specified.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The MeasuredPointType defines an XYZ location in which the length
    /// units, accuracy, uncertainty and error of the coordinates may be specified./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MeasuredPointType : PointType
    {
        #region ref="AttrMeasuredPoint"
        private AttrMeasuredPoint attributes = new AttrMeasuredPoint();

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("combinedUncertainty")]
        public decimal CombinedUncertainty
        {
            get => this.attributes.CombinedUncertainty;
            set => this.attributes.CombinedUncertainty = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CombinedUncertaintySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("meanError")]
        public decimal MeanError
        {
            get => this.attributes.MeanError;
            set => this.attributes.MeanError = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeanErrorSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("xCombinedUncertainty")]
        public decimal XCombinedUncertainty
        {
            get => this.attributes.XCombinedUncertainty;
            set => this.attributes.XCombinedUncertainty = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XCombinedUncertaintySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("xMeanError")]
        public decimal XMeanError
        {
            get => this.attributes.XMeanError;
            set => this.attributes.XMeanError = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XMeanErrorSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("yCombinedUncertainty")]
        public decimal YCombinedUncertainty
        {
            get => this.attributes.YCombinedUncertainty;
            set => this.attributes.YCombinedUncertainty = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YCombinedUncertaintySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("yMeanError")]
        public decimal YMeanError
        {
            get => this.attributes.YMeanError;
            set => this.attributes.YMeanError = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YMeanErrorSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("zCombinedUncertainty")]
        public decimal ZCombinedUncertainty
        {
            get => this.attributes.ZCombinedUncertainty;
            set => this.attributes.ZCombinedUncertainty = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZCombinedUncertaintySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("zMeanError")]
        public decimal ZMeanError
        {
            get => this.attributes.ZMeanError;
            set => this.attributes.ZMeanError = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZMeanErrorSpecified { get; set; }
        #endregion
    }
}