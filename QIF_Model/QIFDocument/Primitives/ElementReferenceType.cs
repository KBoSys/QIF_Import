/*! \file ElementReferenceType.cs
    \brief The ElementReferenceType is an entity ID.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Primitives
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
}
