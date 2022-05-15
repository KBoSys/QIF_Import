/*! \file ActionMethodsType.cs
    \brief Defines a set of action methods.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFPlan
{
	/// <summary>
	/// The ActionMethodsType defines a set of action methods.
	/// </summary>
	public class ActionMethodsType
	{
		/// <remarks Each ActionMethod element is a single action method./>
		[XmlElement(ElementName = "AutocollimatorMeasureFeatureMethod", Type = typeof(AutocollimatorMeasureFeatureMethodType))]
		[XmlElement(ElementName = "CalibratedComparatorMeasureFeatureMethod", Type = typeof(CalibratedComparatorMeasureFeatureMethodType))]
		[XmlElement(ElementName = "CoordinateMeasureFeatureMethod", Type = typeof(CoordinateMeasureFeatureMethodType))]
		[XmlElement(ElementName = "ComputedTomographyMeasureFeatureMethod", Type = typeof(ComputedTomographyMeasureFeatureMethodType))]
		[XmlElement(ElementName = "ExternalReferenceMeasureFeatureMethod", Type = typeof(ExternalReferenceMeasureFeatureMethodType))]
		[XmlElement(ElementName = "GageMeasureFeatureMethod", Type = typeof(GageMeasureFeatureMethodType))]
		[XmlElement(ElementName = "LaserRadarMeasureFeatureMethod", Type = typeof(LaserRadarMeasureFeatureMethodType))]
		[XmlElement(ElementName = "LaserTrackerMeasureFeatureMethod", Type = typeof(LaserTrackerMeasureFeatureMethodType))]
		[XmlElement(ElementName = "ManualMeasureFeatureMethod", Type = typeof(ManualMeasureFeatureMethodType))]
		[XmlElement(ElementName = "MicroscopeMeasureFeatureMethod", Type = typeof(MicroscopeMeasureFeatureMethodType))]
		[XmlElement(ElementName = "ProfileProjectorMeasureFeatureMethod", Type = typeof(ProfileProjectorMeasureFeatureMethodType))]
		[XmlElement(ElementName = "TheodoliteMeasureFeatureMethod", Type = typeof(TheodoliteMeasureFeatureMethodType))]
		[XmlElement(ElementName = "UniversalLengthMeasureFeatureMethod", Type = typeof(UniversalLengthMeasureFeatureMethodType))]
		[XmlElement(ElementName = "OtherMeasureFeatureMethod", Type = typeof(OtherMeasureFeatureMethodType))]
		public ActionMethodBaseType[] ActionMethods { get; set; }

		/// <remarks The required n attribute is the number of action methods in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.ActionMethods.Length;
		}
	}

	/// <summary>
	/// The global ActionMethod element (to be used via 'ref') is a
	/// single action method.This element may be replaced(as
	/// provided by substitution group declarations) by any of the
	/// following elements representing types of action method:
	///		AutocollimatorMeasureFeatureMethod
	///		CalibratedComparatorMeasureFeatureMethod
	///		CoordinateMeasureFeatureMethod
	///		ComputedTomographyMeasureFeatureMethod
	///		ExternalReferenceMeasureFeatureMethod
	///		GageMeasureFeatureMethod
	///		LaserRadarMeasureFeatureMethod
	///		LaserTrackerMeasureFeatureMethod
	///		ManualMeasureFeatureMethod
	///		MicroscopeMeasureFeatureMethod
	///		ProfileProjectorMeasureFeatureMethod
	///		TheodoliteMeasureFeatureMethod
	///		UniversalLengthMeasureFeatureMethod
	///		OtherMeasureFeatureMethod
	/// </summary>
	public abstract class ActionMethodBaseType
	{
	}

	/// <summary>
	/// The MeasureFeatureMethodBaseType is the abstract base type that
	/// defines a feature measurement method.
	/// </summary>
	public abstract class MeasureFeatureMethodBaseType : ActionMethodBaseType
	{
	}

	/// <summary>
	/// The AutocollimatorMeasureFeatureMethodType is the metrology method
	/// in which an autocollimator(an optical instrument for non-contact
	/// measurement of angles) is used for measuring the feature.
	/// </summary>
	public class AutocollimatorMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The CalibratedComparatorMeasureFeatureMethodType is the metrology
	/// method in which a calibrated comparator is used for measuring the feature.
	/// </summary>
	public class CalibratedComparatorMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The CoordinateMeasureFeatureMethodType is the metrology method in
	/// which a coordinate metrology device(e.g., a CMM) is used for measuring the feature.
	/// </summary>
	public class CoordinateMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
		/// <remarks The optional NumberOfMeasurementPoints element is the
		/// suggested number of a measurement points for measuring the designated feature./>
		[XmlElement]
		public uint NumberOfMeasurementPoints { get; set; } = 0;
	}

	/// <summary>
	/// The ComputedTomographyMeasureFeatureMethodType is the metrology
	/// method in which computed tomography is used for measuring the feature.
	/// </summary>
	public class ComputedTomographyMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The ExternalReferenceMeasureFeatureMethodType references an
	/// external metrology method for measuring the feature.
	/// </summary>
	public class ExternalReferenceMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
		/// <remarks The optional ExternalFileReferences element is a list of
		/// references to additional files that specify the measurement method, e.g.ASTM standard./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.IntermediatesPMI.ExternalFileReferencesType ExternalFileReferences { get; set; }
	}

	/// <summary>
	/// The GageMeasureFeatureMethodType defines the metrology method
	/// in which a gage is used for measuring the feature.
	/// </summary>
	public class GageMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The LaserRadarMeasureFeatureMethodType is the metrology method in
	/// which a laser radar is used for measuring the feature.
	/// </summary>
	public class LaserRadarMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The LaserTrackerMeasureFeatureMethodType is the metrology method in
	/// which a laser tracker is used for measuring the feature.
	/// </summary>
	public class LaserTrackerMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The ManualMeasureFeatureMethodType is the metrology method in which
	/// a manual device(e.g., caliper, micrometer) is used for measuring the feature.
	/// </summary>
	public class ManualMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The MicroscopeMeasureFeatureMethodType is the metrology method in
	/// which a microscope is used for measuring the feature.
	/// </summary>
	public class MicroscopeMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The ProfileProjectorMeasureFeatureMethodType is the metrology
	/// method in which an optical comparator(shadowgraph) is used for measuring the feature.
	/// </summary>
	public class ProfileProjectorMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The TheodoliteMeasureFeatureMethodType is the metrology method in
	/// which a theodolite is used for measuring the feature.
	/// </summary>
	public class TheodoliteMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The UniversalLengthMeasureFeatureMethodType is the metrology method
	/// in which a universal length measuring machine is used for measuring	the feature.
	/// </summary>
	public class UniversalLengthMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}

	/// <summary>
	/// The OtherMeasureFeatureMethodType is the metrology method in which
	/// some device not named in the other measure feature types is used for measuring the feature.
	/// </summary>
	public class OtherMeasureFeatureMethodType : MeasureFeatureMethodBaseType
	{
	}
}
