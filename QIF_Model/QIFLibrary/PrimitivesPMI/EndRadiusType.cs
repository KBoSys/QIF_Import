/*! \file EndRadiusType.cs
	\brief defines the radius of the end of a slot.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The EndRadiusType defines the radius of the end of a slot./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EndRadiusType
    {
        /// <remarks The EndRadius element describes the end radius of the slot./>
        public LinearValueType EndRadius { get; set; }

        /// <remarks The optional Expanded element when set to "true" indicates that
        /// the round end of a slot expands to be larger than the width
        /// like the end of a dumbbell./>
        public bool Expanded { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpandedSpecified { get; set; }
    }
}
