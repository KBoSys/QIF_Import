/*! \file ActionGroupBaseType.cs
    \brief abstract base type that defines an action group.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <remarks> The MeasureActionGroupFunctionEnumType enumerates values that
    /// describe the functions of action groups within the context of a	measurement plan.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum MeasureActionGroupFunctionEnumType
    {
        /// <remarks> Routing Plan is a group of actions that may route the product from one measurement work cell to another</remarks>
        ROUTING_PLAN,

        /// <remarks> Operation Sequence is a group of actions that are performed
        /// at one work cell, typically referencing a measurement device resource</remarks>
        OPERATION_SEQUENCE,

        /// <remarks> Setup Usage Group is a group of actions that are performed at one part setup, typically referencing a fixture resource.</remarks>
        SETUP_USAGE_GROUP,

        /// <remarks> Sensor Usage Group is a group of actions that are performed at one sensor tool change, typically referencing a sensor resource.</remarks>
        SENSOR_USAGE_GROUP,

        /// <remarks> Carriage Usage Group is a group of actions that are performed
        /// at one carriage, typically referencing a carriage of a measurement device resource.</remarks>
        CARRIAGE_USAGE_GROUP,

        /// <remarks> PCS Usage Group is a group of actions that are performed at one
        /// active part coordinate system which usually corresponds with a datum reference frame.</remarks>
        PCS_USAGE_GROUP,

        /// <remarks> Evaluate Characteristic Actions is a group of actions that are performed to evaluate a characteristic.</remarks>
        EVALUATE_CHAR_ACTIONS,

        /// <remarks> Establish Datum Actions is a group of actions that are performed to establish a datum with a datum reference frame.</remarks>
        ESTABLISH_DATUM_ACTIONS,

        /// <remarks> UNDEFINED</remarks>
        UNDEFINED,
    }

    /// <remarks> The MeasureActionGroupFunctionType defines the function of the	action group within the context of a measurement plan.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasureActionGroupFunctionType
    {
        /// <remarks> The MeasureActionGroupFunctionEnum element describes an often-used function of the action group within the context of a measurement plan.</remarks>
        /// <remarks> The OtherMeasureActionGroupFunction element describes the function of the action group within the context of a measurement plan.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MeasureActionGroupFunctionEnum", typeof(MeasureActionGroupFunctionEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherMeasureActionGroupFunction", typeof(string))]
        public object Item { get; set; }
    }

    /// <summary>
    /// The ActionGroupBaseType is the abstract base type that defines an action group.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ActionGroupBaseType : PlanElementBaseType
    {
        /// <remarks> The optional MeasureActionGroupFunction element identifies the function of the action group.</remarks>
        public MeasureActionGroupFunctionType MeasureActionGroupFunction { get; set; }
    }

    /// <remarks> The UnorderedActionGroupType defines an action group for which all
    /// of the steps it contains should be executed, but any order of
    /// executing them will work, and no particular order of execution is required.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UnorderedActionGroupType : ActionGroupBaseType
    {
        /// <remarks> The Steps element is a list of plan elements without numbers.</remarks>
        public UnnumberedPlanElementsType Steps { get; set; }
    }

    /// <remarks> The OrderedActionGroupType defines an action group for which the
    /// all the steps it contains must be executed in order of increasing
    /// sequence number.The SequenceNumbers of the Steps in an instance of
    /// OrderedActionGroupType must be present, must be assigned 1, 2, 3,
    /// ..., and must be executed in that order.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OrderedActionGroupType : ActionGroupBaseType
    {
        /// <remarks> The Steps element is a set of numbered plan elements.</remarks>
        public NumberedPlanElementsType Steps { get; set; }
    }

    /// <remarks>
    /// The PartiallyOrderedActionGroupType defines an action group for
    /// which all of the steps it contains should be executed, but each
    /// step may be executed only after all of the predecessors of that
    /// step have been executed.If more than one step meets that
    /// condition, any order of executing those steps will work, and no
    /// particular order is required by the plan.The SequenceNumbers of
    /// the Steps in the StepsWithPredecessors in an instance of
    /// PartiallyOrderedActionGroupType must be assigned 1, 2, 3, ... but
    /// usually will not be executed in that order.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PartiallyOrderedActionGroupType : ActionGroupBaseType
    {
        /// <remarks> The StepsWithPredecessors element is a list of PlanElements with predecessors.</remarks>
        public StepsWithPredecessorsType StepsWithPredecessors { get; set; }
    }

    /// <remarks>
    /// The OneOfActionGroupType defines an action group for which exactly
    /// one of the steps it contains must be executed.Any step in the list
    /// will do. The SequenceNumbers of the Steps in an instance of
    /// OneOfActionGroupType are not required to be distinct.The
    /// SequenceNumbers indicate a preference for which step is executed,
    /// with 1 the most preferred, 2 the second most preferred, and so on.
    /// Steps with the same SequenceNumber are equally preferred.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OneOfActionGroupType : ActionGroupBaseType
    {
        /// <remarks> The Steps element is a list of numbered plan elements.</remarks>
        public NumberedPlanElementsType Steps { get; set; }
    }

    /// <remarks> The PickSomeActionGroupType defines an action group for which a
    /// specified number of the steps it contains must be executed; they may be executed in any order.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PickSomeActionGroupType : ActionGroupBaseType
    {
        /// <remarks> The Steps element is a list of unnumbered plan elements.</remarks>
        public UnnumberedPlanElementsType Steps { get; set; }

        /// <remarks> The NumberOfSteps element is the number of steps from the
        /// Steps list to be executed.This must be at least one and
        /// must not be larger than the number of Steps.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfSteps { get; set; }
    }

}
