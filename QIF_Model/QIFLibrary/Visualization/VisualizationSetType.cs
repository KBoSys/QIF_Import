/*! \file VisualizationSetType.cs
	\brief TODO

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VisualizationSetType
    {

        private FontsType fontsField;

        private TrailingZeroDisplayType trailingZeroDisplayField;

        private PMIDisplaySetType pMIDisplaySetField;

        /// <remarks/>
        public FontsType Fonts
        {
            get
            {
                return this.fontsField;
            }
            set
            {
                this.fontsField = value;
            }
        }

        /// <remarks/>
        public TrailingZeroDisplayType TrailingZeroDisplay
        {
            get
            {
                return this.trailingZeroDisplayField;
            }
            set
            {
                this.trailingZeroDisplayField = value;
            }
        }

        /// <remarks/>
        public PMIDisplaySetType PMIDisplaySet
        {
            get
            {
                return this.pMIDisplaySetField;
            }
            set
            {
                this.pMIDisplaySetField = value;
            }
        }
    }
}
