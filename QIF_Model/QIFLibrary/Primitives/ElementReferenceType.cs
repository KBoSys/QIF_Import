﻿/*! \file ElementReferenceType.cs
    \brief The ElementReferenceType is an entity ID.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// The ElementReferenceType is an entity ID.
    /// </summary>
	public class ElementReferenceType
	{
        /// <summary>
        /// The Id element is a reference to a QIF id that may not include an AsmPath.
        /// </summary>
        [XmlElement(IsNullable = false)]
        public QIFReferenceType Id { get; set; }
    }

    /// <remarks The ElementReferenceFullType is an entity ID./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElementReferenceFullType
    {
        /// <remarks The Id element is a reference to a QIF id that may include an AsmPath./>
        public QIFReferenceFullType Id { get; set; }
    }
}
