/*! \file CoordinateSystemActualTransformAssociationsType.cs
 	\brief defines a list of coordinate system actual transform associations.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The CoordinateSystemActualTransformAssociationsType defines a list of coordinate system actual transform associations.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoordinateSystemActualTransformAssociationsType : ArrayBaseType<CoordinateSystemActualTransformAssociationType>
    {
        /// <remarks> Each CoordinateSystemActualTransformAssociation element gives
        /// information about a coordinate system actual transform association.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CoordinateSystemActualTransformAssociation")]
        public CoordinateSystemActualTransformAssociationType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The CoordinateSystemActualTransformAssociationType defines the id of
    /// an actual transform associated with a coordinate system.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoordinateSystemActualTransformAssociationType
    {
        /// <remarks> The ActualTransformId element references the id of the actual
        /// transformation matrix used to establish the coordinate system.</remarks>
        public Primitives.QIFReferenceType? ActualTransformId { get; set; }

        /// <remarks> The CoordinateSystemId element is the QIF id of the coordinate
        /// system to which the actual transform applies.</remarks>
        public Primitives.QIFReferenceFullType? CoordinateSystemId { get; set; }
    }
}
