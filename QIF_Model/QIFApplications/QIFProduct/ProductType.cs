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

namespace QIF_Model.QIFApplications.QIFProduct
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
        public QIFLibrary.Geometry.GeometrySetType GeometrySet { get; set; }

        /// <remarks The optional TopologySet element is a collection of all
        /// topological entities present in the CAD scene, divided by type in a number of sub-sets./>
        [XmlElement(IsNullable = true)]
        public QIFLibrary.Topology.TopologySetType TopologySet { get; set; }

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
        public QIFLibrary.Visualization.ViewSetType ViewSet { get; set; }

        /// <remarks The optional LayerSet element is a collection of all model layers./>
        [XmlElement(IsNullable = true)]
        public LayerSetType LayerSet { get; set; }

        /// <remarks The optional CoordinateSystemSet element is a collection of all coordinate systems present in the CAD scene./>
        [XmlElement(IsNullable = true)]
        public QIFLibrary.Auxiliary.CoordinateSystemSetType CoordinateSystemSet { get; set; }

        /// <remarks The optional VisualizationSet element is a collection of display info objects associated with PMI entities./>
        [XmlElement(IsNullable = true)]
        public QIFLibrary.Visualization.VisualizationSetType VisualizationSet { get; set; }

        /// <remarks The optional AuxiliarySet element is a collection of all auxiliary objects present in the CAD scene./>
        [XmlElement(IsNullable = true)]
        public QIFLibrary.Auxiliary.AuxiliarySetType AuxiliarySet { get; set; }

        /// <remarks The optional PartSet element is a collection of all parts present in the CAD scene./>
        [XmlElement(IsNullable = true)]
        public PartSetType PartSet { get; set; }

        /// <remarks The optional AssemblySet element is a collection of all assemblies present in the CAD scene./>
        [XmlElement(IsNullable = true)]
        public AssemblySetType AssemblySet { get; set; }

        /// <remarks The optional ComponentSet element is a collection of all components present in the CAD scene./>
        [XmlElement(IsNullable = true)]
        public ComponentSetType ComponentSet { get; set; }

        /// <remarks This optional compositor provides a choice of the root of the CAD scene./>
        #region Choice
        /// <remarks The RootPart element is a root of CAD scene./>
        [XmlElement(IsNullable = true)]
        public QIFLibrary.Primitives.ElementReferenceType RootPart { get; set; }

        /// <remarks The RootAssembly element is a root of CAD scene./>
        [XmlElement(IsNullable = true)]
        public QIFLibrary.Primitives.ElementReferenceType RootAssembly { get; set; }

        /// <remarks The RootComponent element is a root of CAD scene./>
        [XmlElement(IsNullable = true)]
        public QIFLibrary.Primitives.ElementReferenceType RootComponent { get; set; }
        #endregion

        /// <remarks The optional AsmPaths element is a collection of all parts present in the CAD scene./>
        [XmlElement(IsNullable = true)]
        public AsmPathsType AsmPaths { get; set; }

        /// <remarks The optional MaterialLibrary element is a list of the materials from which the actual product is fabricated./>
        [XmlElement(IsNullable = true)]
        public QIFLibrary.PrimitivesPMI.MaterialsType MaterialLibrary { get; set; }
    }
}