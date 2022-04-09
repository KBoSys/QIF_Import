/*! \file StandardsOrganizationEnumType.cs
    \brief Enumeration for most often-used standards organization name.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
	/// <summary>
	/// The StandardsOrganizationEnumType enumerates values that describe
	/// standards organization names.
	/// </summary>
	public enum StandardsOrganizationEnumType
	{
		AIAG,	///> AIAG - Automotive Industry Action Group
		ANSI,	///> ANSI - American National Standards Institute
		ASAM,   ///> ASAM - Association for Automation and Measuring Systems
		ASME,   ///> ASME - American Society of Mechanical Engineers
		AWS,    ///> AWS - American Welding Society
		BSI,    ///> BSI - British Standards Institution
		DIN,    ///> DIN - Deutsches Institut für Normung
		DOD,    ///> DOD - U.S.Department of Defense
		EASC,   ///> EASC - Euro-Asian Council for Standardization, Metrology and Certification
		GOST,   ///> GOST - Standards of former USSR
		GOST_R, ///> GOST_R - Russian Standards
		IEC,    ///> IEC - International Electrotechnical Commission
		IEEE,	///> IEEE Standards Association
		ISO,    ///> ISO -  International Organization for Standardization
		JEITA,  ///> JEITA - Japan Electronics and Information Technology Industries Association
		JIS,    ///> JIS - Japanese Industrial Standards
		UL,     ///> UL - Underwriters Laboratories
		VDA,    ///> VDA - German Association of the Automotive Industry
		W3C,    ///> W3C - World Wide Web Consortium
	}
}
