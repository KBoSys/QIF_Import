/*! \file DefinitionExternalType.cs
    \brief The DefinitionExternalType defines the geometry of a product
        (a part or an assembly) in various degrees of detail.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks> The GDTEnumType enumerates values that describe the geometric dimensioning and tolerancing information in model. </remarks>
    public enum GDTEnumType
    {
        UNKNOWN, HUMANREAD, MACHINEREAD, ABSENT
    }

    /// <remarks> The TopologyEnumType enumerates values that describe the topology information in model. </remarks>
    public enum TopologyEnumType
    {
        UNKNOWN, PRESENT, ABSENT
    }

    [Serializable]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class DrawingBaseType : QIFIdTypeBase
    {
        /// <remarks> The Name element is the name of the model. </remarks>
        [XmlElement]
        public string Name { get; set; }

        /// <remarks> The optional Description element is a description of the model.</remarks>
        [XmlElement()]
        public string Description { get; set; }

        /// <remarks> The optional Author element is the author who created this drawing.</remarks>
        [XmlElement()]
        public AuthorType Author { get; set; }
    }

    /// <remarks> The PrintedDrawingType defines information about a printed drawing
    /// of a product.This may be on paper, mylar, or some other physical media.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [XmlRoot]
    public class PrintedDrawingType : DrawingBaseType
    {
        /// <remarks> The optional Version element is the version of the
        /// model associated with product being inspected. The information recorded here may be used for the
        /// DrawingRevisionLevel field of an AS9102A form.</remarks>
        //public string Version { get; set; }

        /// <remarks> The optional DrawingNumber element is the drawing number of the
        /// printed drawing associated with product being inspected.This
        /// may be used for the Drawing Number field of an AS9102A form.</remarks>
        public string DrawingNumber { get; set; }

        /// <remarks> The optional AdditionalChanges element is a description or
        /// references to descriptions of any additional changes to the
        /// drawing beyond what is included at the Version.If there
        /// are no additional changes to the drawing, this element should
        /// be omitted. The information recorded here may be used for the
        /// Additional Changes field of an AS9102A form.</remarks>
        public string AdditionalChanges { get; set; }

        /// <remarks> The optional Location element is a description of the physical location of the printed drawing.</remarks>
        public string Location { get; set; }
    }

    /// <remarks> The DigitalDrawing element gives information about a digital part drawing.This element is in an optional choice.</remarks>
    public class DigitalDrawingType : DrawingBaseType
    {
        /// <remarks> The File element specifies the file used in the model.</remarks>
        [XmlElement()]
        public FileType File { get; set; }

        /// <remarks> The optional Application element is information about the
        /// software application wherein the model was most recently edited.</remarks>
        [XmlElement()]
        public ApplicationType Application { get; set; }

        /// <remarks> The optional ApplicationSource element is the name of the
        /// software application wherein the model was created.</remarks>
        [XmlElement()]
        public ApplicationType ApplicationSource { get; set; }

        /// <remarks> The optional Entities element is a list of instances of the
        /// EntityExternalType associated with the model.Only those
        /// entities from the model that need to be referenced should be included in this list.</remarks>
        [XmlElement()]
        public EntitiesExternalType Entities { get; set; }
    }

    /// <remarks> The DigitalModelType defines a digital design model
    /// that represents information about an assembly or part.</remarks>
    public class DigitalModelType : DrawingBaseType
    {
        /// <remarks> The File element specifies the file used in the model.</remarks>
        [XmlElement()]
        public FileType File { get; set; }

        /// <remarks> The optional Application element is information about the
        /// software application wherein the model was most recently edited.</remarks>
        [XmlElement()]
        public ApplicationType Application { get; set; }

        /// <remarks> The optional ApplicationSource element is the name of the software application wherein the model was created.</remarks>
        [XmlElement()]
        public ApplicationType ApplicationSource { get; set; }

        /// <remarks> The optional Units element specifies the units used in the model.</remarks>
        [XmlElement()]
        public QIFLibrary.Units.OtherUnitsType Units { get; set; }

        /// <remarks> The optional GDT element specifies the presence of geometric dimensioning and tolerancing information in model.</remarks>
        [XmlElement]
        [System.ComponentModel.DefaultValueAttribute(typeof(GDTEnumType), "UNKNOWN")]
        public GDTEnumType GDT { get; set; } = GDTEnumType.UNKNOWN;

        /// <remarks> The optional Topology element specifies the presence of topology information in model.</remarks>
        [XmlElement]
        [System.ComponentModel.DefaultValueAttribute(typeof(TopologyEnumType), "UNKNOWN")]
        public TopologyEnumType Topology { get; set; } = TopologyEnumType.UNKNOWN;

        /// <remarks> The optional Entities element is a list of instances of the
        /// EntityExternalType associated with the model.Only those
        /// entities from the model that need to be referenced should be included in this list.</remarks>
        [XmlElement()]
        public EntitiesExternalType EntitiesTopology { get; set; }
    }

    /// <remarks> The PhysicalModel element is an actual, hands-on, physical,
    /// 3D model or prototype of a part that is used to communicate
    /// features, datum reference frames, characteristics, or other
    /// information.Examples of physical models include actual part
    /// instances, part instances made from other materials, and 3D
    /// printing and stereolithography models. This element is in an optional choice.</remarks>
    public class PhysicalModelType : DrawingBaseType
    {
        /// <remarks> The optional Version element is the version of the model associated with product being inspected.</remarks>
        [XmlElement()]
        public string Version { get; set; }

        /// <remarks> The optional Location element is a description of the physical location of the printed drawing.</remarks>
        [XmlElement()]
        public string Location { get; set; }

        /// <remarks> The optional ModelNumber element is the drawing number of the
        /// printed drawing associated with product being inspected.This
        /// may be used for the Drawing Number field of an AS9102A form.</remarks>
        [XmlElement()]
        public string ModelNumber { get; set; }
    }

    /// <remarks> The DefinitionExternalType defines the geometry of a product
    /// (a part or an assembly) in various degrees of detail.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DefinitionExternalType : QIFIdTypeBase
    {
        /// <remarks> This compositor provides a choice among types of drawing and types of model.</remarks>
        [XmlElement(ElementName = "PrintedDrawing", Type = typeof(PrintedDrawingType))]
        [XmlElement(ElementName = "DigitalDrawing", Type = typeof(DigitalDrawingType))]
        [XmlElement(ElementName = "DigitalModel", Type = typeof(DigitalModelType))]
        [XmlElement(ElementName = "PhysicalModel", Type = typeof(PhysicalModelType))]
        public DrawingBaseType[] Types { get; set; }

        /// <remarks> The required n attribute is the number of external product definitions in this list.</remarks>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.Types.Length;
            set { }
        }
    }
}
