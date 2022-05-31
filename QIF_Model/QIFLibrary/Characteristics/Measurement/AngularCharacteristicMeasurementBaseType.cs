/*! \file AngularCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured angular characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The AngularCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured angular characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleBetweenCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleFromCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedAngularCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class AngularCharacteristicMeasurementBaseType : DimensionalCharacteristicMeasurementBaseType<MeasuredAngularValueType>
    {
    }

    /// <remarks The AngleBetweenCharacteristicMeasurementType defines the results of a measured angle-between characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngleBetweenCharacteristicMeasurementType : AngularCharacteristicMeasurementBaseType
    {
        /// <remarks The optional, measured AnalysisVector element used by the
        /// AnalysisMode gives a measured vector defining a unit vector
        /// normal to the plane in which the angle-between characteristic is evaluated./>
        public MeasuredUnitVectorType AnalysisVector { get; set; }

        /// <remarks The optional Vertex element is the point defining the
        /// location of the vertex of the measured angle./>
        public MeasuredPointType Vertex { get; set; }
    }

    /// <remarks The AngleFromCharacteristicMeasurementType defines the results of a measured angle-from characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngleFromCharacteristicMeasurementType : AngularCharacteristicMeasurementBaseType
    {
        /// <remarks The optional, measured AnalysisVector element used by the
        /// AnalysisMode gives a measured vector defining a unit vector
        /// normal to the plane in which the angle-from characteristic is evaluated./>
        public MeasuredUnitVectorType AnalysisVector { get; set; }

        /// <remarks The optional Vertex element is the point defining the
        /// location of the vertex of the measured angle./>
        public MeasuredPointType Vertex { get; set; }
    }

    /// <remarks The AngleCharacteristicMeasurementType defines the results of a measured angle characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngleCharacteristicMeasurementType : AngularCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The UserDefinedAngularCharacteristicMeasurementType is a
    /// characteristic measurement specified by the user that is measured
    /// in angle units.This user defined type is not to be used where an
    /// appropriate type already exists, in particular it is not to be used
    /// for: angle-between, angle (the feature angle: included, draft, taper), angular-coordinate or angle-from./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedAngularCharacteristicMeasurementType : AngularCharacteristicMeasurementBaseType
    {
    }
}
