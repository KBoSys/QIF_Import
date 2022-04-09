/*! \file InspectionModeEnumType.cs

        The InspectionModeEnumType enumerates values that describe the
        first article inspection mode. For an AS9102A or AS9102B
        application, allowable values are FAI_Full for a full first article
        inspection or FAI_Partial for a partial first article inspection.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Traceability
{
    public enum InspectionModeEnumType
    {
      FAI_Full,
      FAI_Partial,

      [XmlEnumAttribute("100Percent")]
      Percent100,

      APQP,
      KPC,
      PPAP,
    }
}
