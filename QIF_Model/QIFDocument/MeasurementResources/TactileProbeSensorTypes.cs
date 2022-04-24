﻿/*! \file TactileProbeSensorTypes.cs
	\brief Defines a tactile probes (stylus)

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.MeasurementResources
{
	/// <remarks The abstract TactileProbeSensorBaseType is the base type that
	/// defines a tactile probe. A TactileProbeSensorBaseType is often called a stylus./>
	public abstract class TactileProbeSensorBaseType : DetachableSensorBaseType
	{
	}

	/// <remarks 
	/// The SimpleTactileProbeSensorType defines a detachable tactile probe with a single tip that extends straight from its mounting.
	/// The tip may or may not be detachable from the body of the probe./>
	public class SimpleTactileProbeSensorType : TactileProbeSensorBaseType
	{
		/// <remarks The optional Qualifications element is a list of qualifications of the simple tactile probe./>
		[XmlElement(IsNullable = true)]
		public QualificationsType Qualifications { get; set; }

		/// <remarks The optional StylusLength element is the length of the
		/// tactile probe from the point where the probe attaches to the tool to the end of the tip./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType Length { get; set; }

		/// <remarks The optional TipEndGeometry element is the shape of the end
		/// of the tip, i.e.the thing at the end of the tip that contacts an object being probed./>
		[XmlElement(IsNullable = true)]
		public TipEndGeometryType TipEndGeometry { get; set; }

		/// <remarks The optional TipEndDiameter element is the nominal diameter of the end of the probe tip./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType TipEndDiameter { get; set; }

		/// <remarks The optional TipEndMaterial element is the material that the tip end is made of./>
		[XmlElement(IsNullable = true)]
		public string TipEndMaterial { get; set; }

		/// <remarks The optional StemMaterial element is the material that the stem of the tip is made of./>
		[XmlElement(IsNullable = true)]
		public string StemMaterial { get; set; }

		/// <remarks The optional StemDiameter element is the diameter of the stem of the probe./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType StemDiameter { get; set; }
	}

	/// <remarks 
	/// The TipEndGeometryEnumType enumerates values that describe the
	/// shape of the end of a probe tip.The tip end is the portion of a
	/// probe tip that that contacts the workpiece being probed.
	public enum TipEndGeometryEnumType
	{
		SPHERE,
		CYLINDER,
		CYLINDER_WITH_SPHERE,
		HEMISPHERE,
		SPHERICAL_DISC,
		POINT,
	}

	/// <remarks 
	/// The TipEndGeometryType defines a type of probe tip end shape. The
	/// tip end is the portion of a probe tip that contacts the workpiece being probed.
	public class TipEndGeometryType
	{
		#region Choice
		/// <remarks The TipEndGeometryEnum element describes an often-used tip end shape./>
		[XmlElement(IsNullable = true)]
		public TipEndGeometryEnumType TipEndGeometryEnum { get; set; }

		/// <remarks The OtherTipEndGeometry element describes a tip end shape in natural language./>
		[XmlElement(IsNullable = true)]
		public string OtherTipEndGeometry { get; set; }
		#endregion
	}

	/// <remarks 
	/// The ComplexTactileProbeSensorType defines a tactile probe with one or more tips.
	public class ComplexTactileProbeSensorType : TactileProbeSensorBaseType
	{
		/// <remarks The LocatedTips element is a list of located tips. Each
		/// located tip is the tip of the probe plus the location of
		/// the end of its tip with respect to the coordinate system of
		/// the probe.Each tip may or may not be detachable from the probe./>
		[XmlElement(IsNullable = false)]
		public LocatedTipsType LocatedTips { get; set; }
	}

	/// <remarks 
	/// The ComplexTactileProbeSensorType defines a tactile probe with one or more tips.
	public class LocatedTipsType
	{
		/// <remarks Each LocatedTip element gives information about a located tip. />
		[XmlElement("LocatedTip", Type = typeof(LocatedTipType))]
		public LocatedTipType[] LocatedTips { get; set; }

		/// <remarks The required n attribute is the number of located tips in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.LocatedTips.Length;
		}
	}

	/// <remarks 
	/// The LocatedTipType defines a tip of a tactile probe and the location of the end of tip. />
	public class LocatedTipType
	{
		/// <remarks The ProbeTip element is a probe tip. />
		[XmlElement(IsNullable = false)]
		public ProbeTipType ProbeTip { get; set; }

		/// <remarks The TipEndLocation element is the location of the point at the end of the tip. />
		[XmlElement(IsNullable = false)]
		public Primitives.PointType TipEndLocation { get; set; }
	}

	/// <remarks 
	/// The ProbeTipType defines a tip of a tactile probe. A probe tip has a stem and an end.A ProbeTipType may or may not be detachable. />
	public class ProbeTipType : MeasurementResourceBaseType
	{
		/// <remarks The optional TipEndGeometry element is the shape of the end
		/// of the tip, i.e.the thing at the end of the tip that
		/// contacts an object being probed./>
		[XmlElement(IsNullable = true)]
		public TipEndGeometryType TipEndGeometry { get; set; }

		/// <remarks The optional TipEndDiameter element is the nominal diameter of the end of the probe tip./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType TipEndDiameter { get; set; }

		/// <remarks The optional TipEndMaterial element is the material that the tip end is made of./>
		[XmlElement(IsNullable = true)]
		public string TipEndMaterial { get; set; }

		/// <remarks The optional StemMaterial element is the material that the stem of the tip is made of./>
		[XmlElement(IsNullable = true)]
		public string StemMaterial { get; set; }

		/// <remarks The optional StemDiameter element is the diameter of the stem of the probe./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType StemDiameter { get; set; }
	}
}