﻿/*! \file TransformListType.cs
    \brief The TransformListType defines a list of one or more transforms.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The TransformListType defines a list of one or more transforms.</remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class TransformListType : ArrayBaseType<TransformInstanceType>
    {
        /// <remarks> Each Transform element is a transform in the list.</remarks>
        [XmlElement(ElementName = "Transform", Type = typeof(TransformInstanceType))]
        public TransformInstanceType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The TransformInstanceType defines a transform matrix that can be referenced via its QIF id.</remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class TransformInstanceType : Primitives.TransformMatrixType
    {
        public TransformInstanceType() { }

        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement]
        public Primitives.AttributesType Attributes { get; set; }

        /// <summary>
        /// The optional Name element is the name of the transform.
        /// </summary>
        [XmlElement]
        public string Name { get; set; }

        /// <summary>
        /// The id attribute is the QIF id of the feature, used for referencing.
        /// </summary>
        [XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        [XmlAttribute]
        public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
    }
}
