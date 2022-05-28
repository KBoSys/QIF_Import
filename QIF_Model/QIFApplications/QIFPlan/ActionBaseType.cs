/*! \file ActionBaseType.cs
    \brief abstract base type that defines an action to be carried out.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <remarks The ActionBaseType is the abstract base type that defines an action to be carried out./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ActionBaseType : PlanElementBaseType
    {
        /// <remarks The optional PreferredActionMethodId element is the QIF id
        /// of the preferred action method applicable to the action being executed./>
        public QIFReferenceType PreferredActionMethodId { get; set; }

        /// <remarks The optional AlternativeActionMethodIds element captures
        /// any possible alternative action methods applicable to the action being executed./>
        public ArrayReferenceType AlternativeActionMethodIds { get; set; }

        /// <remarks The optional PreferredResourceIds element gives the QIF ids
        /// of resources preferred to perform the action, for example,
        /// one of the Fixtures in the MeasurementResources in the Plan./>
        public ArrayReferenceType PreferredResourceIds { get; set; }
    }

    /// <remarks The MeasureSpecifiedMeasurandsActionType defines an action that
    /// means: measure the Measurands whose QIF ids are given, and populate
    /// the corresponding FeatureMeasurements with values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasureSpecifiedMeasurandsActionType : ActionBaseType
    {
        /// <remarks The MeasurandIds element is a list of the QIF ids of measurands that are to be measured./>
        public ArrayReferenceType MeasurandIds { get; set; }
    }

    /// <remarks The MeasureSpecifiedFeaturesActionType defines an action that
    /// means: measure the FeatureItems whose QIF ids are specified,
    /// and populate the corresponding FeatureMeasurements with values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasureSpecifiedFeaturesActionType : ActionBaseType
    {
        /// <remarks The FeatureItemIds element is a list of the QIF ids of feature items that are to be measured./>
        public ArrayReferenceType FeatureItemIds { get; set; }
    }

    /// <remarks The EvaluateSpecifiedCharacteristicsActionType defines an action
    /// that means: find CharacteristicMeasurements for the
    /// CharacteristicItems whose QIF ids are specified.Do not measure
    /// anything while performing this action.All features that need to be
    /// measured in order to evaluate the CharacteristicMeasurements must already be measured./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EvaluateSpecifiedCharacteristicsActionType : ActionBaseType
    {
        /// <remarks The CharacteristicItemIds element is a list of the QIF ids of characteristic items that are to be evaluated./>
        public ArrayReferenceType CharacteristicItemIds { get; set; }
    }

    /// <remarks The MeasureEvaluateSpecifiedActionType defines an action that
    /// means: measure whatever is necessary in order to find
    /// CharacteristicMeasurements for the CharacteristicItems whose QIF
    /// ids are specified, and find those measurements.For any
    /// FeatureItems that are measured, also populate the corresponding FeatureMeasurements with values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasureEvaluateSpecifiedActionType : ActionBaseType
    {
        /// <remarks The CharacteristicItemIds element is a list of the QIF ids of characteristic items that are to be evaluated./>
        public ArrayReferenceType CharacteristicItemIds { get; set; }
    }

    /// <remarks The HaltActionType defines an action that means stop executing the
    /// plan.A plan is not required to include an instance of HaltActionType./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HaltActionType : ActionBaseType
    {
    }

    /// <remarks The MeasureEvaluateAllActionType defines an action that means:
    /// measure whatever is necessary in order to find CharacteristicMeasurements for all CharacteristicItems, and find
    /// those measurements.For any FeatureItems that are measured, also populate the corresponding FeatureMeasurements with values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasureEvaluateAllActionType : ActionBaseType
    {
    }
}
