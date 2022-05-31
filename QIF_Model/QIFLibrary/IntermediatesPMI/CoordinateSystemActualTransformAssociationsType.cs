/*! \file CoordinateSystemActualTransformAssociationsType.cs
 	\brief defines a list of coordinate system actual transform associations.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The CoordinateSystemActualTransformAssociationsType defines a list of coordinate system actual transform associations./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoordinateSystemActualTransformAssociationsType
    {
        /// <remarks Each CoordinateSystemActualTransformAssociation element gives
        /// information about a coordinate system actual transform association./>
        [System.Xml.Serialization.XmlElementAttribute("CoordinateSystemActualTransformAssociation")]
        public CoordinateSystemActualTransformAssociationType[] Items { get; set; }

        /// <remarks The required n attribute is the number of coordinate system actual
        /// transform associations in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The CoordinateSystemActualTransformAssociationType defines the id of
    /// an actual transform associated with a coordinate system./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoordinateSystemActualTransformAssociationType
    {
        /// <remarks The ActualTransformId element references the id of the actual
        /// transformation matrix used to establish the coordinate system./>
        public Primitives.QIFReferenceType ActualTransformId { get; set; }

        /// <remarks The CoordinateSystemId element is the QIF id of the coordinate
        /// system to which the actual transform applies./>
        public Primitives.QIFReferenceFullType CoordinateSystemId { get; set; }
    }
}
