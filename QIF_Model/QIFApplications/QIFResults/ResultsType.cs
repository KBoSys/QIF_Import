/*! \file ResultsType.cs
    \brief The ResultsType is the top level type for QIF measurement results.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFResults
{
    /// <remarks The ResultsType is the top level type for QIF measurement results./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ResultsType
    {
        /// <remarks The optional Version element gives version information about the measurements results./>
        public QIFLibrary.IntermediatesPMI.VersionType Version { get; set; }

        /// <remarks The MeasurementResultsSet element is a set of collections of measurement results./>
        public MeasurementResultsSetType MeasurementResultsSet { get; set; }

        /// <remarks The optional ActualComponentSets element is a collection
        /// of data associated with the actual components of one or more manufactured products./>
        public ActualComponentSetsType ActualComponentSets { get; set; }

        /// <remarks The optional InspectionTraceability element gives traceability information that applies to all measurement results./>
        public InspectionTraceabilityType InspectionTraceability { get; set; }
    }
}
