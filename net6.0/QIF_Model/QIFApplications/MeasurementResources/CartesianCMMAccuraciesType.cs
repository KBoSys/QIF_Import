/*! \file CartesianCMMAccuraciesType.cs
	\brief Defines a list of Cartesian CMM accuracies.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The CartesianCMMAccuraciesType defines a list of Cartesian CMM accuracies.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMAccuraciesType : ArrayBaseType<CartesianCMMAccuracyType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMAccuracy")]
        public CartesianCMMAccuracyType[]? Items { get => base.itemsField; set => base.itemsField = value; } 
    }

    /// <remarks> The CartesianCMMAccuracyType describes the accuracy of a Cartesian CMM.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMAccuracyType : MeasurementDeviceAccuracyBaseType
    {
        /// <remarks> The CartesianCMMAccuracyTest element is the test that was used to determine the accuracy.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMFPSTest", typeof(FPSTestType))]
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMB89Test", typeof(CartesianCMMB89TestType))]
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMISO10360Test", typeof(ISO10360TestType))]
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMPointAccuracyTest", typeof(PointAccuracyTestType))]
        public CMMAccuracyTestBaseType? CartesianCMMAccuracyTest { get; set; }

        /// <remarks> The AccuracySource element is the source of the accuracy.</remarks>
        public AccuracySourceType? AccuracySource { get; set; }
    }

}
