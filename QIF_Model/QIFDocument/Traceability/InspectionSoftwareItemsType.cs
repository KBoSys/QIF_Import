/*! \file InspectionSoftwareItemsType.cs

        The InspectionSoftwareItemsType defines information about software
        used to create the product model, to analyze data and/or to perform
        the product inspection.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Traceability
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class InspectionSoftwareItemsType
	{
        public InspectionSoftwareItemsType() { }

        /// <summary>
        /// The optional InspectionProgramGenerationSoftware element gives
        /// information about the ids of software used to generate the program.
        /// </summary>
        [XmlElement]
        public Primitives.ArrayReferenceType InspectionProgramGenerationSoftware { get; set; }

        /// <summary>
        /// The optional InspectionProgramExecutionSoftware element gives
        /// information about the ids of software used to perform the inspection.
        /// </summary>
        [XmlElement]
        public Primitives.ArrayReferenceType InspectionProgramExecutionSoftware { get; set; }

        /// <summary>
        /// The optional AnalysisSoftware element gives information about
        /// the ids of software used for inspection data analysis.
        /// </summary>
        [XmlElement]
        public Primitives.ArrayReferenceType AnalysisSoftware { get; set; }

        /// <summary>
        /// The optional CADSoftware element gives information about the
        /// ids of CAD software used to create the product model.
        /// </summary>
        [XmlElement]
        public Primitives.ArrayReferenceType CADSoftware { get; set; }

        /// <summary>
        /// The optional DMESoftware element gives information about the
        /// ids of software running on the DME.
        /// </summary>
        [XmlElement]
        public Primitives.ArrayReferenceType DMESoftware { get; set; }
    }
}
