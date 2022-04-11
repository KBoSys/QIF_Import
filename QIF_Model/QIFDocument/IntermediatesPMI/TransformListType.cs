/*! \file TransformListType.cs
    \brief The TransformListType defines a list of one or more transforms.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
    /// <remarks The TransformListType defines a list of one or more transforms./>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class TransformListType
    {
        public TransformListType() { }

        /// <remarks Each Transform element is a transform in the list./>
        [XmlElement(ElementName = "Transform", Type = typeof(TransformInstanceType))]
        public TransformInstanceType[] Transforms { get; set; }

        /// <remarks The required n attribute is the number of transforms in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.Transforms.Length;
        }
    }

    /// <remarks The TransformInstanceType defines a transform matrix that can be referenced via its QIF id./>
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
        public AttributesType Attributes { get; set; }

        /// <summary>
        /// The optional Name element is the name of the transform.
        /// </summary>
        [XmlElement]
        public string Name { get; set; }

        /// <summary>
        /// The id attribute is the QIF id of the feature, used for referencing.
        /// </summary>
        [XmlIgnore]
        public QIFIdType QIFID { get; set; }

        [XmlAttribute]
        public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
    }
}
