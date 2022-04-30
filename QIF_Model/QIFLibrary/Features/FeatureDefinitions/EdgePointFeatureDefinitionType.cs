/*! \file EdgePointFeatureDefinitionType.cs
    
	The EdgePointFeatureDefinitionType defines the edge-point feature
	nominal information that can be common to one or more edge point features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
	public class EdgePointFeatureDefinitionType : PointFeatureDefinitionBaseType
	{
		private PrimitivesPMI.InternalExternalEnumType internalExternalEnumField;
		public EdgePointFeatureDefinitionType()
		{
			internalExternalEnumField = PrimitivesPMI.InternalExternalEnumType.NOT_APPLICABLE;
		}

		/// <summary>
		/// The InternalExternal element indicates whether the feature
		/// is internal or external.For example, an edge point on the
		/// edge of a desk would be external, and an edge point where
		/// a floor meets a wall would be internal.
		/// </summary>
		public PrimitivesPMI.InternalExternalEnumType InternalExternal 
		{ 
			get => internalExternalEnumField; 
			set => internalExternalEnumField = value; 
		}
	}
}
