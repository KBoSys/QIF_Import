/*! \file ProductType.cs
    \brief The ProductType defines parts and assemblies.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Product
{
    /// <remarks The ProductType defines parts and assemblies./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ProductType
    {
        /// <remarks The Header element gives information about the provenance of the Product data set./>
        [XmlElement(IsNullable = true)]
        public ProductHeaderType Header { get; set; }

        /// <remarks The optional GeometrySet element is a collection of all
        /// geometric entities present in the CAD scene, divided by type in a number of sub-sets./>
        [XmlElement(IsNullable = true)]
        public Geometry.GeometrySetType GeometrySet { get; set; }

        /// <remarks The optional TopologySet element is a collection of all
        /// topological entities present in the CAD scene, divided by type in a number of sub-sets./>
        [XmlElement(IsNullable = true)]
        public Topology.TopologySetType TopologySet { get; set; }

        /// <remarks The optional NoteSet element is a collection of all notes present in the QIF document./>
        [XmlElement(IsNullable = true)]
        public NoteSetType NoteSet { get; set; }

        /// <remarks The optional NoteFlagSet element is a collection of all flag notes present in the QIF document./>
        [XmlElement(IsNullable = true)]
        public NoteFlagSetType NoteFlagSet { get; set; }

        /// <remarks The optional PartNoteSet element is a collection of all part notes and standard notes present in the QIF document./>
        [XmlElement(IsNullable = true)]
        public PartNoteSetType PartNoteSet { get; set; }

        /// <remarks The optional ViewSet element is a collection of all views present in the CAD scene./>
        [XmlElement(IsNullable = true)]
        public Visualization.ViewSetType ViewSet { get; set; }

        /// <remarks The RootPart element is a root of CAD scene./>
        [XmlElement(IsNullable = true)]
        public Primitives.ElementReferenceType RootPart { get; set; }
    }
}