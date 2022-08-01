/*! \file AngularCharacteristicNominalBaseType.cs
    \brief an abstract base type that defines a unique angular characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <summary>
    /// The AngularCharacteristicNominalBaseType is the abstract base type that defines a unique angular characteristic nominal.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class AngularCharacteristicNominalBaseType : DimensionalCharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the angle./>
        public Units.AngularValueType TargetValue { get; set; }
    }

    /// <remarks TODO/>
    public class AngleBetweenCharacteristicNominalType : AngularCharacteristicNominalBaseType
    {

    }

    /// <remarks TODO/>
    public class AngleFromCharacteristicNominalType : AngularCharacteristicNominalBaseType
    {

    }

    /// <remarks TODO/>
    public class AngleCharacteristicNominalType : AngularCharacteristicNominalBaseType
    {

    }

    /// <remarks TODO/>
    public class UserDefinedAngularCharacteristicNominalType : AngularCharacteristicNominalBaseType
    {

    }
}
