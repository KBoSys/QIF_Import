﻿/*! \file CMMAxisDirectionsBaseType.cs
	\brief Base class for defining different CMM axis directions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks The abstract CMMAxisDirectionsBaseType is the base class for defining different CMM axis directions./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCMMAxisDirectionsType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CMMAxisDirectionsBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMAxisDirectionsType : CMMAxisDirectionsBaseType
    {
        /// <remarks/>
        public CMMDirectionEnumType XAxisDirection { get; set; }

        /// <remarks/>
        public CMMDirectionEnumType YAxisDirection { get; set; }

        /// <remarks/>
        public CMMDirectionEnumType ZAxisDirection { get; set; }
    }

    /// <remarks The CMMDirectionEnumType enumerates values that describe the
    /// directions on a CMM with which axes may be aligned.
    /// The directions are those seen when standing in front of the CMM./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CMMDirectionEnumType
    {
        /// <remarks/>
        RIGHT,

        /// <remarks/>
        LEFT,

        /// <remarks/>
        FRONT,

        /// <remarks/>
        BACK,

        /// <remarks/>
        UP,

        /// <remarks/>
        DOWN,
    }
}
