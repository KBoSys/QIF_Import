/*! \file FileUnits.cs
    \brief Defines the units used in the file

    The FileUnits element gives explicit primary units for the file and 
    optionally gives other units and user defined units that may be used in the file. 
    The FileUnits element is optional, but it is strongly recommended that it be used. 
    In the absence of a FileUnits element, the default units are SI units.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFDocument.FileUnits
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FileUnits
    {
		#region Private Members
		private PrimaryUnits primaryUnitsField;
        private OtherUnits otherUnitsField;
        private UserDefinedUnits userDefinedUnitsField;
		#endregion

		#region Properties
		/// <remarks The primary units of the document/>
		public PrimaryUnits PrimaryUnits
        {
            get => this.primaryUnitsField;
            set => this.primaryUnitsField = value;
        }

        /// <remarks The alternate units of the document/>
        public OtherUnits OtherUnits
        {
            get => this.otherUnitsField;
            set => this.otherUnitsField = value;
        }

        /// <remarks User defined units of the document/>
        public UserDefinedUnits UserDefinedUnits
        {
            get => this.userDefinedUnitsField;
            set => this.userDefinedUnitsField = value;
        }
		#endregion
	}
}
