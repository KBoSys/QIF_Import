/*! \file ActionGroupBaseType.cs
    \brief abstract base type that defines an action group.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFPlan
{
	/// <remarks The MeasureActionGroupFunctionEnumType enumerates values that
	/// describe the functions of action groups within the context of a	measurement plan./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public enum MeasureActionGroupFunctionEnumType
	{
		/// <remarks Routing Plan is a group of actions that may route the product from one measurement work cell to another/>
		ROUTING_PLAN,

		/// <remarks Operation Sequence is a group of actions that are performed
		/// at one work cell, typically referencing a measurement device resource/>
		OPERATION_SEQUENCE,

		/// <remarks Setup Usage Group is a group of actions that are performed at one part setup, typically referencing a fixture resource./>
		SETUP_USAGE_GROUP,

		/// <remarks Sensor Usage Group is a group of actions that are performed at one sensor tool change, typically referencing a sensor resource./>
		SENSOR_USAGE_GROUP,

		/// <remarks Carriage Usage Group is a group of actions that are performed
		/// at one carriage, typically referencing a carriage of a measurement device resource./>
		CARRIAGE_USAGE_GROUP,

		/// <remarks PCS Usage Group is a group of actions that are performed at one
		/// active part coordinate system which usually corresponds with a datum reference frame./>
		PCS_USAGE_GROUP,

		/// <remarks Evaluate Characteristic Actions is a group of actions that are performed to evaluate a characteristic./>
		EVALUATE_CHAR_ACTIONS,

		/// <remarks Establish Datum Actions is a group of actions that are performed to establish a datum with a datum reference frame./>
		ESTABLISH_DATUM_ACTIONS,

		/// <remarks UNDEFINED/>
		UNDEFINED,
	}

	/// <remarks The MeasureActionGroupFunctionType defines the function of the	action group within the context of a measurement plan./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class MeasureActionGroupFunctionType
	{
		/// <remarks The MeasureActionGroupFunctionEnum element describes an often-used function of the action group within the context of a measurement plan./>
		/// <remarks The OtherMeasureActionGroupFunction element describes the function of the action group within the context of a measurement plan./>
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
		/// <remarks The optional MeasureActionGroupFunction element identifies the function of the action group./>
		public MeasureActionGroupFunctionType MeasureActionGroupFunction { get; set; }
	}

	/// <remarks The UnorderedActionGroupType defines an action group for which all
	/// of the steps it contains should be executed, but any order of
	/// executing them will work, and no particular order of execution is required./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class UnorderedActionGroupType : ActionGroupBaseType
	{
		/// <remarks The Steps element is a list of plan elements without numbers./>
		public UnnumberedPlanElementsType Steps { get; set; }
	}

	/// <remarks The OrderedActionGroupType defines an action group for which the
	/// all the steps it contains must be executed in order of increasing
	/// sequence number.The SequenceNumbers of the Steps in an instance of
	/// OrderedActionGroupType must be present, must be assigned 1, 2, 3,
	/// ..., and must be executed in that order./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class OrderedActionGroupType : ActionGroupBaseType
	{
		/// <remarks The Steps element is a set of numbered plan elements./>
		public NumberedPlanElementsType Steps { get; set; }
	}

	public class PartiallyOrderedActionGroupType : ActionGroupBaseType
	{
		// TODO
	}

	public class OneOfActionGroupType : ActionGroupBaseType
	{
		// TODO
	}

	public class PickSomeActionGroupType : ActionGroupBaseType
	{
		// TODO
	}
}
