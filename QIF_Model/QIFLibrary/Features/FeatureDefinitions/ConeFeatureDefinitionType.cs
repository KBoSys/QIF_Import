/*! \file ConeFeatureDefinitionType.cs

	The ConeFeatureDefinitionType defines the cone feature nominal
    information that can be common to one or more cone features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class ConeFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
	{
		#region Fields 
		private QIFLibrary.PrimitivesPMI.InternalExternalEnumType internalExternalField;
		private QIFLibrary.Units.AngularValueType angleField;

		/// <summary>
		/// This optional compositor defines the extents of a truncated
		/// cone with respect to the locating point.The distance to an
		/// end is positive if it is in the direction of the axis
		/// vector and negative if it is in a direction opposite the axis vector.
		/// </summary>
		class Extents
		{
			LinearValueType largeEndDistanceField;
			LinearValueType smallEndDistanceField;
			public Extents()
			{
				largeEndDistanceField = new LinearValueType();
				smallEndDistanceField = null;
			}
			public LinearValueType LargeEndDistance
			{
				get => largeEndDistanceField;
				set => largeEndDistanceField = value;
			}
			public LinearValueType SmallEndDistance
			{
				get => smallEndDistanceField;
				set => smallEndDistanceField = value;
			}
		}

		Extents extentsField = null;
		#endregion

		public ConeFeatureDefinitionType()
		{
			internalExternalField = QIFLibrary.PrimitivesPMI.InternalExternalEnumType.INTERNAL;
		}

		#region Properties
		/// <remarks The InternalExternal element indicates whether the feature is internal or external./>
		public QIFLibrary.PrimitivesPMI.InternalExternalEnumType InternalExternal
		{
			get => internalExternalField;
			set => internalExternalField = value;
		}

		/// <summary>
		/// The Diameter element is the nominal diameter of the cone at
		/// the locating point.If the locating point is defined at the
		/// cone vertex then this value will be zero.
		/// </summary>
		public QIFLibrary.Units.LinearValueType Diameter { get; set; }

		/// <summary>
		/// The HalfAngle element the nominal angle between the side
		/// of the cone and its axis(this is half of the included
		/// angle of the cone). This angle will be greater than zero
		/// and less than 90 degrees.
		/// </summary>
		public AngularValueType HalfAngle
		{
			get => angleField;
			set => angleField = value;
		}
		/// <summary>
		/// The FullAngle element is the nominal angle between the
		/// sides of the cone in a plane including the cone's axis
		/// (this is the included angle of the cone). This angle will
		/// be greater than zero and less than 180 degrees.
		/// </summary>
		public AngularValueType FullAngle
		{
			get => angleField;
			set => angleField = value;
		}

		public QIFLibrary.Units.LinearValueType LargeEndDistance 
		{ 
			get => extentsField?.LargeEndDistance; 
			set 
			{ 
				if (extentsField == null)
				{
					extentsField = new Extents();
				}
				extentsField.LargeEndDistance = value; 
			}	
		}
		public QIFLibrary.Units.LinearValueType SmallEndDistance
		{
			get => extentsField?.SmallEndDistance;
			set
			{
				if (extentsField == null)
				{
					extentsField = new Extents();
				}
				extentsField.SmallEndDistance = value;
			}
		}

		#endregion
	}
}
