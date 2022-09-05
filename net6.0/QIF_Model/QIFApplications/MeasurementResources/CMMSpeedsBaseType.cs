/*! \file CMMSpeedsBaseType.cs
	\brief Base type for defining the maximum traverse speeds of CMM axes.These axes could be linear or rotary.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The abstract CMMSpeedsBaseType is the base type for defining the
    /// maximum traverse speeds of CMM axes.These axes could be linear or rotary.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelLinkCMMSpeedsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCMMSpeedsType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CMMSpeedsBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ParallelLinkCMMSpeedsType : CMMSpeedsBaseType
    {
        /// <remarks></remarks>
        public SpeedValueType? MaxXTraverseSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxYTraverseSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxZTraverseSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxXProbingSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxYProbingSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxZProbingSpeed { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxXRotation { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxYRotation { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxZRotation { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMSpeedsType : CMMSpeedsBaseType
    {
        /// <remarks></remarks>
        public SpeedValueType? MaxXTraverseSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxYTraverseSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxZTraverseSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxXProbingSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxYProbingSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? MaxZProbingSpeed { get; set; }
    }
}
