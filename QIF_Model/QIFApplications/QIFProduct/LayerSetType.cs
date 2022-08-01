/*! \file LayerSetType.cs
	\brief an array of model layers.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks LayerSetType defines an array of model layers./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class LayerSetType : ArrayBaseType<LayerType>
    {
        /// <remarks The Layer element defines the model layer with associated model entities stored in the direct references./>
        [System.Xml.Serialization.XmlElementAttribute("Layer", Type = typeof(LayerType))]
        public LayerType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}