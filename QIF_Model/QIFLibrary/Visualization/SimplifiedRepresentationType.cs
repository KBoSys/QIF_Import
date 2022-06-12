/*! \file SimplifiedRepresentationType.cs
	\brief defines a simplified model representation to be used in a saved view.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The SimplifiedRepresentationType defines a simplified model representation to be used in a saved view./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimplifiedRepresentationType : NodeWithIdBaseType
    {
        /// <remarks/>
        public SimplifiedRepresentationFormEnumType Form { get; set; }

        /// <remarks/>
        public SimplifiedRepresentationGroupsType SimplifiedRepresentationGroups { get; set; }
    }

    /// <remarks The SimplifiedRepresentationFormEnumType enumerates values that describe simplified representation forms./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SimplifiedRepresentationFormEnumType
    {
        /// <remarks/>
        MASTER,

        /// <remarks/>
        HIDE,

        /// <remarks/>
        BOUNDING_BOX,
    }

    /// <remarks The SimplifiedRepresentationGroupsType is a collection of groups of components and bodies with defined simplified representation forms./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimplifiedRepresentationGroupsType
    {
        /// <remarks Each SimplifiedRepresentationGroup element is a group of
        /// components and bodies with defined simplified representation forms./>
        [System.Xml.Serialization.XmlElementAttribute("SimplifiedRepresentationGroup")]
        public SimplifiedRepresentationGroupType[] Items { get; set; }

        /// <remarks The required n attribute is the number of elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The SimplifiedRepresentationGroupType defines a simplified representation for a group of components and bodies./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimplifiedRepresentationGroupType
    {
        /// <remarks The Form element is a simplified representation form./>
        public SimplifiedRepresentationFormEnumType Form { get; set; }

        /// <remarks The optional ComponentIds element is an array of component identifiers./>
        public ArrayReferenceFullType ComponentIds { get; set; }

        /// <remarks The optional BodyIds element is an array of body identifiers./>
        public ArrayReferenceFullType BodyIds { get; set; }
    }
}
