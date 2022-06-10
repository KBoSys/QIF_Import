/*! \file BodySetType.cs
	\brief a container for storing all model bodies.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks The BodySetType represents a container for storing all model bodies./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BodySetType
    {
        /// <remarks Each Body element is a model body./>
        [System.Xml.Serialization.XmlElementAttribute("Body")]
        public BodyType[] Items { get; set; }

        /// <remarks The required n attribute is the number of bodies in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
