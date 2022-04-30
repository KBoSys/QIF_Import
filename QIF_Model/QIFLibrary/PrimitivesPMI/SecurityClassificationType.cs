/*! \file SecurityClassificationType.cs
    \brief The SecurityClassificationType defines a security classification.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <summary>
    /// The SecurityClassificationEnumType enumerates values that describe
    /// various government and corporate classifications used to protect
    /// sensitive information from being improperly disseminated.Security
    /// Classification Enumerations for various countries are designated in
    /// a table at www.wikipedia.org/wiki/Classified_information
    /// </summary>
    public enum SecurityClassificationEnumType
    { 
      NONE,
      UNCLASSIFIED,
      RESTRICTED,
      EU_RESTRICTED,
      WEU_RESTRICTED,
      FOR_OFFICIAL_USE_ONLY,
      PROTECTED,
      PROTECTED_A,
      PROTECTED_B,
      PROTECTED_C,
      CONFIDENTIAL,
      EU_CONFIDENTIAL,
      WEU_CONFIDENTIAL,
      SECRET,
      SECRET_NATIONAL_SECURITY_INFORMATION,
      SECRET_FORMERLY_RESTRICTED_DATA,
      SECRET_RESTRICTED_DATA,
      EU_SECRET,
      WEU_SECRET,
      TOP_SECRET_NATIONAL_SECURITY_INFORMATION,
      TOP_SECRET_FORMERLY_RESTRICTED_DATA,
      TOP_SECRET_RESTRICTED_DATA,
      EU_TOP_SECRET,
      FOCAL_TOP_SECRET,
      COMPANY_CONFIDENTIAL,
      OFFICIAL_USE_ONLY,
      TRADE_SECRET,
      TRADEMARK,
      REGISTERED_TRADEMARK,
      PATENT,
      UNDEFINED,
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SecurityClassificationType
	{
        public SecurityClassificationType() { }

        //! The SecurityClassificationEnum element describes an often-used security classification.
        [XmlElement]
        public SecurityClassificationEnumType SecurityClassificationEnum { get; set; }

        //! The OtherSecurityClassification element describes a security classification in natural language.
        [XmlElement]
        public string OtherSecurityClassification { get; set; }
    }
}
