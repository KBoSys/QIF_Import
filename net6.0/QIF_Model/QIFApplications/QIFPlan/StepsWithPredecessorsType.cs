/*! \file StepsWithPredecessorsType.cs
    \brief defines a list of StepWithPredecessors elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Characteristics;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <remarks> The StepsWithPredecessorsType defines a list of StepWithPredecessors elements.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StepsWithPredecessorsType : ArrayBaseType<StepWithPredecessorsType>
    {
        /// <remarks> Each StepWithPredecessors element is a single member of the list.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("StepWithPredecessors")]
        public StepWithPredecessorsType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The StepWithPredecessorsType defines information about a single PlanElement that has predecessors.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StepWithPredecessorsType
    {
        /// <remarks>
        /// The optional Predecessors element is a list of the numbers of
        /// steps that must be executed before this step is executed.Care
        /// should be taken that no step has itself as a predecessor and
        /// that there are no loops of predecessors, as when step 1 is a
        /// predecessor of step 2 and step 2 is a predecessor of step 1.</remarks>
        public PredecessorsType? Predecessors { get; set; }

        /// <remarks> The Step element is a numbered PlanElement.</remarks>
        public NumberedPlanElementType? Step { get; set; }
    }

    /// <remarks> The PredecessorsType defines a list of the numbers of predecessor steps.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PredecessorsType : ArrayBaseType<uint>
    {
        /// <remarks> Each Predecessor element is a single member of the list. It is
        /// a positive integer that is the number of a step and is
        /// different from any other member of the list.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Predecessor")]
        public uint[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
