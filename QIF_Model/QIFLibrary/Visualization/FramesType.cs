/*! \file FramesType.cs
	\brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FramesType
    {

        private FrameBaseType[] frameField;

        private uint nField;

        /// <remarks/>
        // MANEDIT [System.Xml.Serialization.XmlElementAttribute("Frame")] replaced with substitutions to base class
        [System.Xml.Serialization.XmlElementAttribute("FrameRectangular", typeof(FrameRectangularType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameCircular", typeof(FrameCircularType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameFlag", typeof(FrameFlagType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameIrregularForm", typeof(FrameIrregularFormType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameTriangle", typeof(FrameTriangleType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameHexagonal", typeof(FrameHexagonalType))]
        [System.Xml.Serialization.XmlElementAttribute("FramePentagonal", typeof(FramePentagonalType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameOctagonal", typeof(FrameOctagonalType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameWeldSymbol", typeof(FrameWeldSymbolType))]
        public FrameBaseType[] Frame
        {
            get
            {
                return this.frameField;
            }
            set
            {
                this.frameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

}
