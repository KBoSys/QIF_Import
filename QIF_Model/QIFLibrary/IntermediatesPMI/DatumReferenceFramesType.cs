/*! \file DatumReferenceFramesType.cs
	\brief Defines a list of datum reference frames.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks 
    /// The DatumReferenceFrameType defines the datum reference component
    /// of a feature control frame.If no datums are referenced by a
    /// feature control frame(such as in a 'to itself' profile or position
    /// characteristic or in the lowermost segment of a composite profile
    /// or position) then a datum reference frame can still be needed but
    /// it contains no datums.Such a datum reference frame indicates that
    /// all 6 degrees of freedom are available unconstrained by datum features. 
    /// />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumReferenceFrameType : QIFIdTypeBase
    {
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        [XmlElement(IsNullable = true)]
        public Primitives.AttributesType Attributes { get; set; }

        /// <remarks 
        /// The optional Datums element is a list of datums (simple,
        /// compound, or datum feature) with an assigned precedence (order). />
        [XmlElement(IsNullable = true)]
        public DatumsType Datums { get; set; }

        /// <remarks 
        /// The optional Name element is the name of the datum reference frame, e.g.ABC, STARTUP, AD(m)E(m). />
        [XmlElement(IsNullable = true)]
        public string Name { get; set; }

        /// <remarks 
        /// The optional Description element is a description of the datum reference frame. />
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }

        /// <remarks 
        /// The optional CoordinateSystemId element is the QIF id of the coordinate system in which the characteristic is evaluated. />
        [XmlElement(IsNullable = true)]
        public Primitives.QIFReferenceFullType CoordinateSystemId { get; set; }
    }

    /// <remarks The DatumReferenceFramesType defines a list of datum reference frames./>
    [System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumReferenceFramesType
    {
        /// <remarks Each DatumReferenceFrame element gives information about a datum reference frame./>
		[XmlElement(ElementName = "DatumReferenceFrame", Type = typeof(DatumReferenceFrameType))]
        public DatumReferenceFrameType[] DatumReferenceFrames { get; set; }

		/// <remarks The required n attribute is the number of datum reference frames in the list./>
		[XmlAttribute("n")]
        public int Count
        {
            get => this.DatumReferenceFrames.Length;
        }
    }
}
