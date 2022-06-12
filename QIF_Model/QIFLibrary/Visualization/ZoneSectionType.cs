/*! \file ZoneSectionType.cs
	\brief defines model clipping by specifying a set of section planes and logical operations between them.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The ZoneSectionType defines model clipping by specifying a set of section planes and logical operations between them./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneSectionType : NodeWithIdBaseType
    {
        /// <remarks The Planes element is a set of zone section planes./>
        public ZoneSectionPlanesType SectionPlanes { get; set; }

        /// <remarks The optional LogicalOperations element defines logical operations between zone section planes./>
        public LogicalOperationsType LogicalOperations { get; set; }

        /// <remarks The optional hatching attribute indicates if hatching is On or Off./>
        [System.Xml.Serialization.XmlAttributeAttribute("hatching")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Hatching { get; set; } = true;
    }

    /// <remarks The ZoneSectionPlanesType is a collection of zone section planes./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneSectionPlanesType
    {
        /// <remarks Each SectionPlane element is a section plane./>
        [System.Xml.Serialization.XmlElementAttribute("SectionPlane")]
        public ZoneSectionPlaneType[] SectionPlanes { get; set; }

        /// <remarks The required n attribute is the number of SectionPlane elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.SectionPlanes.Length;
            set { }
        }
    }

    /// <remarks The ZoneSectionPlaneType defines a zone section plane./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneSectionPlaneType
    {
        /// <remarks The Plane element is a section plane./>
        public PlaneXType Plane { get; set; }

        /// <remarks The optional SectionGroups element is a group of cross-sections./>
        public SectionGroupsType SectionGroups { get; set; }

        /// <remarks The required index attribute is an index identifying a zone section plane within the SectionPlanes set./>
        [System.Xml.Serialization.XmlAttributeAttribute("index")]
        public uint Index { get; set; }
    }

    /// <remarks The SectionGroupsType defines an array of the section groups./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionGroupsType
    {
        /// <remarks Each SectionGroup element is a section group of the zone section./>
        [System.Xml.Serialization.XmlElementAttribute("SectionGroup")]
        public SectionGroupType[] SectionGroups { get; set; }

        /// <remarks The required n attribute is the number of SectionGroup elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.SectionGroups.Length;
            set { }
        }
    }

    /// <remarks The SectionGroupType defines a section group as areas, paths and vertices on body./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionGroupType
    {
        /// <remarks The optional BodyId element is an identifier of the body./>
        public QIFReferenceFullType BodyId { get; set; }

        /// <remarks The optional Areas element is a set of section areas./>
        public SectionAreasType Areas { get; set; }

        /// <remarks The optional Paths element is a set of section paths./>
        public SectionPathsType Paths { get; set; }

        /// <remarks The optional Vertices element is a set of section vertices./>
        public ArrayReferenceType Vertices { get; set; }
    }

    /// <remarks The SectionAreasType defines an array of section areas./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionAreasType
    {
        /// <remarks Each Area element is a section area./>
        [System.Xml.Serialization.XmlElementAttribute("Area")]
        public SectionAreaType[] Areas { get; set; }

        /// <remarks The required n attribute is the number of areas in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Areas.Length;
            set { }
        }
    }

    /// <remarks The SectionAreaType defines a section area./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionAreaType
    {
        /// <remarks The optional HatchStyleId element is an identifier of the hatch style for the section area./>
        public QIFReferenceType HatchStyleId { get; set; }

        /// <remarks The Loops element is a set of section closed loops - boundary of the area./>
        public SectionLoopsType Loops { get; set; }
    }

    /// <remarks The SectionLoopsType is an array of closed section loops./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionLoopsType
    {
        /// <remarks Each Loop element is a closed section loop./>
        [System.Xml.Serialization.XmlElementAttribute("Loop")]
        public SectionPathType[] Loops { get; set; }

        /// <remarks The required n attribute is the number of Loop elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Loops.Length;
            set { }
        }
    }

    /// <remarks The SectionPathType defines a section path as an array of edges./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionPathType
    {
        /// <remarks The Edges element is a set of section edges./>
        public SectionEdgesType Edges { get; set; }
    }

    /// <remarks The SectionEdgesType defines an array of section edges./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionEdgesType
    {
        /// <remarks Each Edge element is an edge of the section path./>
        [System.Xml.Serialization.XmlElementAttribute("Edge")]
        public EdgeOrientedType[] Edges { get; set; }

        /// <remarks The required n attribute is the number of edges in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Edges.Length;
            set { }
        }
    }

    /// <remarks The SectionPathsType is an array of section paths./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionPathsType
    {
        /// <remarks Each Path element is a section path./>
        [System.Xml.Serialization.XmlElementAttribute("Path")]
        public SectionPathType[] Paths { get; set; }

        /// <remarks The required n attribute is the number of Path elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Paths.Length;
            set { }
        }
    }
}
