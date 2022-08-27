/*! \file WorkInstructionsType.cs
    \brief Defines a set of sets of work instructions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <summary>
    /// The WorkInstructionsType defines a set of sets of work instructions.
    /// </summary>
    public class WorkInstructionsType
    {
        /// <remarks> Each WorkInstruction element is a single set of work instructions.</remarks>
        [XmlElement(ElementName = "TextInstruction", Type = typeof(TextInstructionType))]
        [XmlElement(ElementName = "DocumentFileInstruction", Type = typeof(DocumentFileInstructionType))]
        [XmlElement(ElementName = "ImageInstruction", Type = typeof(ImageInstructionType))]
        [XmlElement(ElementName = "VideoInstruction", Type = typeof(VideoInstructionType))]
        public WorkInstructionBaseType[] WorkInstructions { get; set; }

        /// <remarks> The required n attribute is the number of work instructions in the set.</remarks>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.WorkInstructions.Length;
            set { }
        }
    }

    /// <summary>
    /// The WorkInstructionBaseType is the abstract base type that defines
    /// the specific media types that provide instructions that have
    /// meaning in an application context.
    /// </summary>
    public abstract class WorkInstructionBaseType
    {
        /// <remarks> The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.AttributesType Attributes { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        #region QIFIdType
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
        #endregion
    }

    /// <summary>
    /// The TextInstructionType defines work instructions that consist of text.
    /// </summary>
    public class TextInstructionType : WorkInstructionBaseType
    {
        /// <remarks> The TextInstruction element provides instructions in text.</remarks>
        [XmlElement]
        public string TextInstruction { get; set; }
    }

    /// <summary>
    /// The DocumentFileInstructionType defines an external file that provides work instructions in a text file.
    /// </summary>
    public class DocumentFileInstructionType : WorkInstructionBaseType
    {
        /// <remarks> The ExternalFile element gives information about an external document instruction file.</remarks>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.ExternalFileReferenceType ExternalFile { get; set; }
    }

    /// <summary>
    /// The ImageInstructionType defines an external file that provides	work instructions in an image.
    /// </summary>
    public class ImageInstructionType : WorkInstructionBaseType
    {
        /// <remarks> The ExternalFile element gives information about an external image instruction file.</remarks>
        [XmlElement(IsNullable = false)]
        public QIFLibrary.IntermediatesPMI.ExternalFileReferenceType ExternalFile { get; set; }
    }

    /// <summary>
    /// The ImageInstructionType defines an external file that provides	work instructions in an image.
    /// </summary>
    public class VideoInstructionType : WorkInstructionBaseType
    {
        /// <remarks> The ExternalFile element gives information about an external video instruction file.</remarks>
        [XmlElement(IsNullable = false)]
        public QIFLibrary.IntermediatesPMI.ExternalFileReferenceType ExternalFile { get; set; }
    }
}
