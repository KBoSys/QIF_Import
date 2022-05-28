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
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(WhileActionGroupType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(IfActionGroupType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PickSomeActionGroupType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(OneOfActionGroupType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PartiallyOrderedActionGroupType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(UnorderedActionGroupType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderedActionGroupType))]
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

	public class OrderedActionGroupType : ActionGroupBaseType
	{
		// TODO
	}

	public class UnorderedActionGroupType : ActionGroupBaseType
	{
		// TODO
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
