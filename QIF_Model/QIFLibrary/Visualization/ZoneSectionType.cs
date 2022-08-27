/*! \file ZoneSectionType.cs
	\brief defines model clipping by specifying a set of section planes and logical operations between them.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The ZoneSectionType defines model clipping by specifying a set of section planes and logical operations between them.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneSectionType : NodeWithIdBaseType
    {
        /// <remarks> The Planes element is a set of zone section planes.</remarks>
        public ZoneSectionPlanesType SectionPlanes { get; set; }

        /// <remarks> The optional LogicalOperations element defines logical operations between zone section planes.</remarks>
        public LogicalOperationsType LogicalOperations { get; set; }

        /// <remarks> The optional hatching attribute indicates if hatching is On or Off.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("hatching")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Hatching { get; set; } = true;
    }

    /// <remarks> The ZoneSectionPlanesType is a collection of zone section planes.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneSectionPlanesType
    {
        /// <remarks> Each SectionPlane element is a section plane.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SectionPlane")]
        public ZoneSectionPlaneType[] SectionPlanes { get; set; }

        /// <remarks> The required n attribute is the number of SectionPlane elements in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.SectionPlanes.Length;
            set { }
        }
    }

    /// <remarks> The ZoneSectionPlaneType defines a zone section plane.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneSectionPlaneType
    {
        /// <remarks> The Plane element is a section plane.</remarks>
        public PlaneXType Plane { get; set; }

        /// <remarks> The optional SectionGroups element is a group of cross-sections.</remarks>
        public SectionGroupsType SectionGroups { get; set; }

        /// <remarks> The required index attribute is an index identifying a zone section plane within the SectionPlanes set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("index")]
        public uint Index { get; set; }
    }

    /// <remarks> The SectionGroupsType defines an array of the section groups.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionGroupsType
    {
        /// <remarks> Each SectionGroup element is a section group of the zone section.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SectionGroup")]
        public SectionGroupType[] SectionGroups { get; set; }

        /// <remarks> The required n attribute is the number of SectionGroup elements in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.SectionGroups.Length;
            set { }
        }
    }

    /// <remarks> The SectionGroupType defines a section group as areas, paths and vertices on body.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionGroupType
    {
        /// <remarks> The optional BodyId element is an identifier of the body.</remarks>
        public QIFReferenceFullType BodyId { get; set; }

        /// <remarks> The optional Areas element is a set of section areas.</remarks>
        public SectionAreasType Areas { get; set; }

        /// <remarks> The optional Paths element is a set of section paths.</remarks>
        public SectionPathsType Paths { get; set; }

        /// <remarks> The optional Vertices element is a set of section vertices.</remarks>
        public ArrayReferenceType Vertices { get; set; }
    }

    /// <remarks> The SectionAreasType defines an array of section areas.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionAreasType
    {
        /// <remarks> Each Area element is a section area.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Area")]
        public SectionAreaType[] Areas { get; set; }

        /// <remarks> The required n attribute is the number of areas in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Areas.Length;
            set { }
        }
    }

    /// <remarks> The SectionAreaType defines a section area.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionAreaType
    {
        /// <remarks> The optional HatchStyleId element is an identifier of the hatch style for the section area.</remarks>
        public QIFReferenceType HatchStyleId { get; set; }

        /// <remarks> The Loops element is a set of section closed loops - boundary of the area.</remarks>
        public SectionLoopsType Loops { get; set; }
    }

    /// <remarks> The SectionLoopsType is an array of closed section loops.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionLoopsType
    {
        /// <remarks> Each Loop element is a closed section loop.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Loop")]
        public SectionPathType[] Loops { get; set; }

        /// <remarks> The required n attribute is the number of Loop elements in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Loops.Length;
            set { }
        }
    }

    /// <remarks> The SectionPathType defines a section path as an array of edges.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionPathType
    {
        /// <remarks> The Edges element is a set of section edges.</remarks>
        public SectionEdgesType Edges { get; set; }
    }

    /// <remarks> The SectionEdgesType defines an array of section edges.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionEdgesType
    {
        /// <remarks> Each Edge element is an edge of the section path.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Edge")]
        public EdgeOrientedType[] Edges { get; set; }

        /// <remarks> The required n attribute is the number of edges in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Edges.Length;
            set { }
        }
    }

    /// <remarks> The SectionPathsType is an array of section paths.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SectionPathsType
    {
        /// <remarks> Each Path element is a section path.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Path")]
        public SectionPathType[] Paths { get; set; }

        /// <remarks> The required n attribute is the number of Path elements in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Paths.Length;
            set { }
        }
    }

    /// <remarks> The ZoneSectionSetType defines a collection of zone sections.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneSectionSetType
    {
        /// <remarks> Each ZoneSection element defines a zone section.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ZoneSection")]
        public ZoneSectionType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of zone sections in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
