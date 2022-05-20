/*! \file PlanType.cs
    \brief The PlanType defines information about a measurement plan.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFPlan
{
	/// <summary>
	/// The PlanType defines information about a measurement plan.
	/// </summary>
	public class PlanType
	{
		/// <remarks The optional Version element gives version information about the measurement plan./>
		[XmlElement()]
		public QIFLibrary.IntermediatesPMI.VersionType Version { get; set; }

		/// <remarks The optional RulesUsedQPId element gives the QPId of the rules
		/// that were used in creating the plan.The rules may be in the
		/// same QIFDocument as the plan, or in a separate QIFDocument, or
		/// both(in which case the two sets of rules must be identical)./>
		[XmlElement()]
		public QIFLibrary.Primitives.QPIdFullReferenceType RulesUsedQPId { get; set; }

		/// <remarks The optional RulesToUseQPId element gives the QPId of the rules
		/// to be used in making a more detailed plan from the plan or in
		/// generating a program from the plan(a DMIS program, for
		/// example). The rules may be in the same QIFDocument as the plan,
		/// or in a separate QIFDocument, or both(in which case the two sets of rules must be identical)./>
		[XmlElement()]
		public QIFLibrary.Primitives.QPIdFullReferenceType RulesToUseQPId { get; set; }

		/// <remarks The optional WorkInstructions element captures any instructions
		/// necessary for executing the Plan./>
		[XmlElement()]
		public WorkInstructionsType WorkInstructions { get; set; }

		/// <remarks The optional ActionMethods element captures any action methods
		/// necessary for executing the Plan./>
		[XmlElement()]
		public ActionMethodsType ActionMethods { get; set; }

		/// <remarks The optional Measurands element captures any measurands used in the Plan./>
		[XmlElement()]
		public MeasurandsType Measurands { get; set; }

		/// <remarks The optional LocalVariables element declares local variables and sets their initial values./>
		[XmlElement()]
		public LocalVariablesType LocalVariables { get; set; }

		/// <remarks The PlanRoot element gives information about the activities to
		/// be carried out in executing the measurement plan and how
		/// execution of the measurement plan is to be controlled.
		/// Structurally, the PlanRoot is at the top of an (upside down)
		/// plan tree of PlanElements. All PlanElement instances occur within the tree./>
		[XmlElement(ElementName = "OrderedPlanRoot", Type = typeof(OrderedActionGroupType))]
		[XmlElement(ElementName = "UnorderedPlanRoot", Type = typeof(UnorderedActionGroupType))]
		[XmlElement(ElementName = "PartiallyOrderedPlanRoot", Type = typeof(PartiallyOrderedActionGroupType))]
		[XmlElement(ElementName = "OneOfPlanRoot", Type = typeof(OneOfActionGroupType))]
		[XmlElement(ElementName = "PickSomePlanRoot", Type = typeof(PickSomeActionGroupType))]
		public ActionGroupBaseType PlanRoot { get; set; }
	}

	/// <summary>
	/// The ActionGroupBaseType is the abstract base type that defines an action group.
	/// </summary>
	public abstract class ActionGroupBaseType
	{
		// TODO
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
