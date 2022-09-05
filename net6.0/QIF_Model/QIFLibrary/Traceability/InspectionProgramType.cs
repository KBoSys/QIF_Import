/*! \file InspectionProgramType.cs
    \brief The InspectionProgramType defines the inspection program.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Traceability
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class InspectionProgramType
    {
        /// <summary>
        /// The File element is information about the inspection program
        /// file, include its name, version, and format.
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.FileType? File { get; set; }

        //! The optional Description element is a description of the file.
        [XmlElement]
        public string? Description { get; set; }

        /// <summary>
        /// The FormalStandardId element is the id of the standard or
        /// specification against which the inspection characteristics are to be evaluated.
        /// </summary>
        [XmlElement]
        public Primitives.QIFReferenceType? FormalStandardId { get; set; }

        /// <summary>
        /// The Author element gives information about the author of the
        /// inspection program.
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.EmployeeType? Author { get; set; }
    }
}
