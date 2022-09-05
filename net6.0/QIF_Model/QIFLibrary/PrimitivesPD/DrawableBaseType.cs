/*! \file DrawableBaseType.cs
	\brief The DrawableBaseType is the abstract base type for drawable elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications.QIFProduct;
using QIF_Model.QIFLibrary.Auxiliary;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Topology;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks> Drawable attributes</remarks>
    public class AttrDrawable
    {
        #region Fields
        private ColorType colorTypeField = null;
        private TransparencyType transparencyTypeField = new TransparencyType();
        private Primitives.DoublePositiveType sizeField = new Primitives.DoublePositiveType();
        #endregion

        public ColorType? Color { get => colorTypeField; set => colorTypeField = value; }
        public string? ColorRGB
        {
            get => colorTypeField != null ? colorTypeField.ToString() : null;
            set => colorTypeField = ColorType.FromString(value);
        }

        public TransparencyType Transparency { get => transparencyTypeField; set => transparencyTypeField = value; }
        public bool Hidden { get; set; } = false;
        public Primitives.DoublePositiveType Size { get => sizeField; set => sizeField = value; }
    }

    /// <remarks> The DrawableBaseType is the abstract base type for drawable
    /// elements.It contains data necessary for a model entity visualization.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoteFlagType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartNoteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LayerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderPartAssemblyBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderAssemblyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderPartType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartAssemblyBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AssemblyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryPlaneBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneReferenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineAuxiliaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointAuxiliaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CADCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopologyBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointCloudType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BodyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShellType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceMeshType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopMeshType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VertexType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class DrawableBaseType : NodeWithIdBaseType
    {
        private AttrDrawable attrDrawable = new AttrDrawable();

        /// <remarks> The optional color attribute defines the RGB color property of a model entity.</remarks>
        [System.ComponentModel.DefaultValueAttribute("")]
        [XmlAttribute("color")]
        public string? ColorRGB
        {
            get => this.attrDrawable.Color?.ToString();
            set => this.attrDrawable.Color = ColorType.FromString(value);
        }

        /// <remarks> The optional transparency attribute defines the transparency property of a model entity.</remarks>
        [XmlAttribute("transparency")]
        public double Transparency { get => this.attrDrawable.Transparency; set => this.attrDrawable.Transparency = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransparencySpecified { get; set; }

        /// <remarks> The optional hidden attribute defines the visibility property of a model entity in the graphical window.</remarks>
        [XmlAttribute("hidden")]
        public bool Hidden { get => this.attrDrawable.Hidden; set => this.attrDrawable.Hidden = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HiddenSpecified { get; set; }

        /// <remarks> The optional size attribute defines a recommended size for
        /// visualization of an infinite drawable element such as plane,
        /// cylinder, axis, etc., or objects without explicit geometric parameters(e.g.coordinate system).</remarks>
        [XmlAttribute("size")]
        [System.ComponentModel.DefaultValueAttribute(typeof(double), "0.0")]
        public double Size { get => this.attrDrawable?.Size; set => this.attrDrawable.Size = value; }
    }

    /// <remarks> The LayerType is the type which represents one of the model "grouping" objects.
    /// NOTE1: The user can specify arbitrary number of layers for one model.
    /// NOTE2: Any model entity can be included in an arbitrary number of layers.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LayerType : DrawableBaseType
    {
        /// <remarks> The optional ElementIds element is an array of entity identifiers present in this layer.</remarks>
        public ArrayReferenceFullType? ElementIds { get; set; }

        /// <remarks> The optional applyColor attribute shows if the layer color
        /// supersedes colors of the model entities associated with this layer.
        /// The default value is FALSE.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("applyColor")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ApplyColor { get; set; } = false;

        /// <remarks> The required index attribute defines the layer index.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("index")]
        public uint Index { get; set; }
    }
}