/*! \file AngularCharacteristicItemBaseType.cs
    \brief abstract base type	that defines an angular characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <summary>
    /// The AngularCharacteristicItemBaseType is the abstract base type	that defines an angular characteristic item.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class AngularCharacteristicItemBaseType : DimensionalCharacteristicItemBaseType
    {
    }

    /// <remarks> The AngleBetweenCharacteristicItemType defines an angle-between characteristic item.</remarks>
    public class AngleBetweenCharacteristicItemType : AngularCharacteristicItemBaseType
    {

    }

    /// <remarks> The AngleFromCharacteristicItemType defines an angle-from characteristic item.</remarks>
    public class AngleFromCharacteristicItemType : AngularCharacteristicItemBaseType
    {

    }

    /// <remarks> The AngleCharacteristicItemType defines an angle characteristic item.</remarks>
    public class AngleCharacteristicItemType : AngularCharacteristicItemBaseType
    {

    }

    /// <remarks> The UserDefinedAngularCharacteristicItemType is a characteristic
    /// item specified by the user that is measured in angular units.This
    /// user defined type is not to be used where an appropriate type
    /// already exists, in particular it is not to be used for:
    /// angle-between, angle (the feature angle: included, draft, taper),
    /// angular-coordinate or angle-from.</remarks>
    public class UserDefinedAngularCharacteristicItemType : AngularCharacteristicItemBaseType
    {

    }
}
