/*! \file VisualizationSetType.cs
	\brief defines a container for storing all visualization data used for drawing PMI entities in a graphical 3D scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The VisualizationSetType defines a container for storing all
    /// visualization data used for drawing PMI entities in a graphical 3D scene./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VisualizationSetType
    {
        /// <remarks The Fonts element is a container for storing all used fonts./>
        public FontsType Fonts { get; set; }

        /// <remarks The TrailingZeroDisplay element is a container for storing trailing zero display options./>
        public TrailingZeroDisplayType TrailingZeroDisplay { get; set; }

        /// <remarks The PMIDisplaySet element is a container for storing all
        /// display data used for visualization of PMI entities./>
        public PMIDisplaySetType PMIDisplaySet { get; set; }
    }
}
