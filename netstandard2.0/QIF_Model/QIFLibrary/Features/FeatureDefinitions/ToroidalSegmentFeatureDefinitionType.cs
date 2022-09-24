﻿/*! \file ToroidalSegmentFeatureDefinitionType.cs
	\brief Defines the toroidal segment feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The ToroidalSegmentFeatureDefinitionType defines the toroidal
    /// segment feature nominal information that can be common to one or
    /// more toroidal segment features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The MinorDiameter element is the nominal minor diameter of the toroidal segment.</remarks>
        public LinearValueType MinorDiameter { get; set; }

        /// <remarks> The MajorDiameter element is the nominal major diameter of the toroidal segment.</remarks>
        public LinearValueType MajorDiameter { get; set; }
    }
}