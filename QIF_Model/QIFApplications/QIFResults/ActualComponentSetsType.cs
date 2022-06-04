/*! \file ActualComponentSetsType.cs
    \brief describes a container for storing a list of actual component sets.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFResults
{
    /// <remarks The ActualComponentSetsType describes a container for storing a list of actual component sets. 
    /// Each instance of a product can have multiple actual components. 
    /// This type collects such information over multiple instances of a product./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ActualComponentSetsType
    {
        /// <remarks Each ActualComponentSet element is an actual component set./>
        [System.Xml.Serialization.XmlElementAttribute("ActualComponentSet")]
        public ActualComponentSetType[] Items { get; set; }

        /// <remarks The required n attribute is the number of actual component sets in this list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The ActualComponentSetType describes the container for storing data of actual components./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ActualComponentSetType
    {
        /// <remarks Each ActualComponent element is an actual component./>
        [System.Xml.Serialization.XmlElementAttribute("ActualComponent")]
        public ActualComponentType[] Items { get; set; }

        /// <remarks The required n attribute is the number of actual components in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The ActualComponentType defines data of an actual component./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ActualComponentType
    {
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks The optional SerialNumber element is a label of a specific
        /// actual component of a given type.Components with the same
        /// ModelNumber have different SerialNumbers.The combination of
        /// ModelNumber and SerialNumber should differentiate a given
        /// actual component from all other actual components in a QIF application instance file./>
        public string SerialNumber { get; set; }

        /// <remarks The optional AdditionalChanges element is a record of any
        /// changes to the product beyond what is recorded in the product
        /// model. The information recorded here may be used for the
        /// Additional Changes field of an AS9102A form./>
        public string AdditionalChanges { get; set; }

        /// <remarks The Status element gives the inspection status of the actual component./>
        public QIFLibrary.IntermediatesPMI.InspectionStatusType Status { get; set; }

        /// <remarks The optional Traceability element gives traceability information for an actual component./>
        public QIFLibrary.Traceability.ActualProductTraceabilityType Traceability { get; set; }

        /// <remarks The optional AsmPathId element is the id of the assembly path of this component./>
        public QIFReferenceType AsmPathId { get; set; }

        /// <remarks The QIF id of the measured point set, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The required id attribute is the QIF id of the measured point set, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public UInt32 Id { get => this.QIFID; set => this.QIFID = value; }
    }
}
