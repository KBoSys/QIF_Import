/*! \file ThreadCharacteristicDefinitionType.cs
    \brief The ThreadCharacteristicDefinitionType defines information that can
        be common to more than one thread characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The ThreadCharacteristicDefinitionType defines information that can	be common to more than one thread characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ThreadCharacteristicDefinitionType : CharacteristicDefinitionBaseType
    {
        /// <remarks The ThreadSpecificationId element is the QIF id of the
        /// thread specification for the thread characteristic.This
        /// must be the QIF id of a thread specification./>
        public Primitives.QIFReferenceType ThreadSpecificationId { get; set; }
    }
}
