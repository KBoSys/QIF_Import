/*! \file VisualizationSetType.cs
	\brief defines a container for storing all visualization data used for drawing PMI entities in a graphical 3D scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The VisualizationSetType defines a container for storing all
    /// visualization data used for drawing PMI entities in a graphical 3D scene.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VisualizationSetType
    {
        /// <remarks> The Fonts element is a container for storing all used fonts.</remarks>
        public FontsType Fonts { get; set; } = new FontsType();

        /// <remarks> The TrailingZeroDisplay element is a container for storing trailing zero display options.</remarks>
        public TrailingZeroDisplayType TrailingZeroDisplay { get; set; } = new TrailingZeroDisplayType();

        /// <remarks> The PMIDisplaySet element is a container for storing all
        /// display data used for visualization of PMI entities.</remarks>
        public PMIDisplaySetType PMIDisplaySet { get; set; } = new PMIDisplaySetType();
    }
}
