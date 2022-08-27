/*! \file Area2dType.cs
	\brief defines a 2D area.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The Area2dType defines a 2D area.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Area2dType
    {
        /// <remarks> This compositor provides a choice of the representation method for the area.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Loops", typeof(Loops2dType))]
        [System.Xml.Serialization.XmlElementAttribute("Triangulation", typeof(Triangulation2dType))]
        public object Item { get; set; }
    }

    /// <remarks> The Areas2dType defines a container for storing 2D areas.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Areas2dType
    {
        /// <remarks> Each Area element is a 2D area.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Area")]
        public Area2dType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of areas in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
