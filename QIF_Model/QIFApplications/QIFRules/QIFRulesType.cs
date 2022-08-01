/*! \file QIFRulesType.cs
    \brief Defines a collection of sets of rules

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks The QIFRulesType defines a collection of sets of rules for
    /// selecting quality measurement items.Currently it contains a
    /// complete model of rules for selecting the quantity of hit points
    /// and/or the strategy for selecting hit points and/or a substitute
    /// feature algorithm.It also contains a model of rules for selecting
    /// DMEs. Rules sets for other types of decisions might be added./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFRulesType
    {
        /// <remarks The optional Version element gives version information about the rules./>
        public VersionType Version { get; set; }

        /// <remarks The optional RulesUnits element defines the units that apply in the FeatureRules. 
        /// If this element does not exist, the units are the primary units given in the FileUnits element of the QIFDocument. 
        /// Feature and characteristic information expressed elsewhere in other units must be converted to these units while using rules./>
        public RulesUnitsType RulesUnits { get; set; }

        /// <remarks The optional FeatureRules element defines rules for
        /// selecting the quantity of hit points for a feature and/or
        /// the strategy to use for selecting the points and/or the
        /// substitute feature algorithm to use./>
        public FeatureRulesType FeatureRules { get; set; }

        /// <remarks The optional DMESelectionRules element defines a set of rules for selecting or not selecting DMEs./>
        public DMESelectionRulesType DMESelectionRules { get; set; }
    }
}
