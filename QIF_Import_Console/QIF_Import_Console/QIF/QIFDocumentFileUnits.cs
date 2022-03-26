using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Import_Console.QIF
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnits
    {

        private QIFDocumentFileUnitsPrimaryUnits primaryUnitsField;

        private QIFDocumentFileUnitsOtherUnits otherUnitsField;

        private QIFDocumentFileUnitsUserDefinedUnits userDefinedUnitsField;

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnits PrimaryUnits
        {
            get
            {
                return this.primaryUnitsField;
            }
            set
            {
                this.primaryUnitsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnits OtherUnits
        {
            get
            {
                return this.otherUnitsField;
            }
            set
            {
                this.otherUnitsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsUserDefinedUnits UserDefinedUnits
        {
            get
            {
                return this.userDefinedUnitsField;
            }
            set
            {
                this.userDefinedUnitsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnits
    {

        private QIFDocumentFileUnitsPrimaryUnitsAreaUnit areaUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsPMIAreaUnit pMIAreaUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsAngularUnit angularUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsPMIAngularUnit pMIAngularUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsForceUnit forceUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsLinearUnit linearUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsPMILinearUnit pMILinearUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsMassUnit massUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsPressureUnit pressureUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsSpeedUnit speedUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsTemperatureUnit temperatureUnitField;

        private QIFDocumentFileUnitsPrimaryUnitsTimeUnit timeUnitField;

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsAreaUnit AreaUnit
        {
            get
            {
                return this.areaUnitField;
            }
            set
            {
                this.areaUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsPMIAreaUnit PMIAreaUnit
        {
            get
            {
                return this.pMIAreaUnitField;
            }
            set
            {
                this.pMIAreaUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsAngularUnit AngularUnit
        {
            get
            {
                return this.angularUnitField;
            }
            set
            {
                this.angularUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsPMIAngularUnit PMIAngularUnit
        {
            get
            {
                return this.pMIAngularUnitField;
            }
            set
            {
                this.pMIAngularUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsForceUnit ForceUnit
        {
            get
            {
                return this.forceUnitField;
            }
            set
            {
                this.forceUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsLinearUnit LinearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsPMILinearUnit PMILinearUnit
        {
            get
            {
                return this.pMILinearUnitField;
            }
            set
            {
                this.pMILinearUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsMassUnit MassUnit
        {
            get
            {
                return this.massUnitField;
            }
            set
            {
                this.massUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsPressureUnit PressureUnit
        {
            get
            {
                return this.pressureUnitField;
            }
            set
            {
                this.pressureUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsSpeedUnit SpeedUnit
        {
            get
            {
                return this.speedUnitField;
            }
            set
            {
                this.speedUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsTemperatureUnit TemperatureUnit
        {
            get
            {
                return this.temperatureUnitField;
            }
            set
            {
                this.temperatureUnitField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsTimeUnit TimeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsAreaUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsAreaUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsAreaUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsAreaUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsPMIAreaUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsPMIAreaUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsPMIAreaUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsPMIAreaUnitUnitConversion
    {

        private string factorField;

        private byte offsetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsAngularUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsAngularUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsAngularUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsAngularUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsPMIAngularUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsPMIAngularUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsPMIAngularUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsPMIAngularUnitUnitConversion
    {

        private string factorField;

        private byte offsetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsForceUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsForceUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsForceUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsForceUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsLinearUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsLinearUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsLinearUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsLinearUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsPMILinearUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsPMILinearUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsPMILinearUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsPMILinearUnitUnitConversion
    {

        private string factorField;

        private byte offsetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsMassUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsMassUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsMassUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsMassUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsPressureUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsPressureUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsPressureUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsPressureUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsSpeedUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsSpeedUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsSpeedUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsSpeedUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsTemperatureUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsTemperatureUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsTemperatureUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsTemperatureUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsTimeUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsPrimaryUnitsTimeUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsPrimaryUnitsTimeUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsPrimaryUnitsTimeUnitUnitConversion
    {

        private byte factorField;

        private byte offsetField;

        /// <remarks/>
        public byte Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public byte Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnits
    {

        private QIFDocumentFileUnitsOtherUnitsAreaUnit[] areaUnitField;

        private QIFDocumentFileUnitsOtherUnitsAngularUnit[] angularUnitField;

        private QIFDocumentFileUnitsOtherUnitsForceUnit[] forceUnitField;

        private QIFDocumentFileUnitsOtherUnitsLinearUnit[] linearUnitField;

        private QIFDocumentFileUnitsOtherUnitsMassUnit[] massUnitField;

        private QIFDocumentFileUnitsOtherUnitsPressureUnit[] pressureUnitField;

        private QIFDocumentFileUnitsOtherUnitsSpeedUnit[] speedUnitField;

        private QIFDocumentFileUnitsOtherUnitsTemperatureUnit[] temperatureUnitField;

        private QIFDocumentFileUnitsOtherUnitsTimeUnit[] timeUnitField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AreaUnit")]
        public QIFDocumentFileUnitsOtherUnitsAreaUnit[] AreaUnit
        {
            get
            {
                return this.areaUnitField;
            }
            set
            {
                this.areaUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AngularUnit")]
        public QIFDocumentFileUnitsOtherUnitsAngularUnit[] AngularUnit
        {
            get
            {
                return this.angularUnitField;
            }
            set
            {
                this.angularUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceUnit")]
        public QIFDocumentFileUnitsOtherUnitsForceUnit[] ForceUnit
        {
            get
            {
                return this.forceUnitField;
            }
            set
            {
                this.forceUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinearUnit")]
        public QIFDocumentFileUnitsOtherUnitsLinearUnit[] LinearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MassUnit")]
        public QIFDocumentFileUnitsOtherUnitsMassUnit[] MassUnit
        {
            get
            {
                return this.massUnitField;
            }
            set
            {
                this.massUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PressureUnit")]
        public QIFDocumentFileUnitsOtherUnitsPressureUnit[] PressureUnit
        {
            get
            {
                return this.pressureUnitField;
            }
            set
            {
                this.pressureUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpeedUnit")]
        public QIFDocumentFileUnitsOtherUnitsSpeedUnit[] SpeedUnit
        {
            get
            {
                return this.speedUnitField;
            }
            set
            {
                this.speedUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TemperatureUnit")]
        public QIFDocumentFileUnitsOtherUnitsTemperatureUnit[] TemperatureUnit
        {
            get
            {
                return this.temperatureUnitField;
            }
            set
            {
                this.temperatureUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeUnit")]
        public QIFDocumentFileUnitsOtherUnitsTimeUnit[] TimeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsAreaUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsAreaUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsAreaUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsAreaUnitUnitConversion
    {

        private decimal factorField;

        private decimal offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public decimal Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsAngularUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsAngularUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsAngularUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsAngularUnitUnitConversion
    {

        private decimal factorField;

        private decimal offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public decimal Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsForceUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsForceUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsForceUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsForceUnitUnitConversion
    {

        private decimal factorField;

        private string offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsLinearUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsLinearUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsLinearUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsLinearUnitUnitConversion
    {

        private decimal factorField;

        private decimal offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        public decimal Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsMassUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsMassUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsMassUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsMassUnitUnitConversion
    {

        private decimal factorField;

        private string offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsPressureUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsPressureUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsPressureUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsPressureUnitUnitConversion
    {

        private decimal factorField;

        private string offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsSpeedUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsSpeedUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsSpeedUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsSpeedUnitUnitConversion
    {

        private decimal factorField;

        private string offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsTemperatureUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsTemperatureUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsTemperatureUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsTemperatureUnitUnitConversion
    {

        private decimal factorField;

        private string offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsTimeUnit
    {

        private string sIUnitNameField;

        private string unitNameField;

        private QIFDocumentFileUnitsOtherUnitsTimeUnitUnitConversion unitConversionField;

        /// <remarks/>
        public string SIUnitName
        {
            get
            {
                return this.sIUnitNameField;
            }
            set
            {
                this.sIUnitNameField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentFileUnitsOtherUnitsTimeUnitUnitConversion UnitConversion
        {
            get
            {
                return this.unitConversionField;
            }
            set
            {
                this.unitConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsOtherUnitsTimeUnitUnitConversion
    {

        private decimal factorField;

        private string offsetField;

        /// <remarks/>
        public decimal Factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsUserDefinedUnits
    {

        private QIFDocumentFileUnitsUserDefinedUnitsUserDefinedUnit[] userDefinedUnitField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnit")]
        public QIFDocumentFileUnitsUserDefinedUnitsUserDefinedUnit[] UserDefinedUnit
        {
            get
            {
                return this.userDefinedUnitField;
            }
            set
            {
                this.userDefinedUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentFileUnitsUserDefinedUnitsUserDefinedUnit
    {

        private string whatIsMeasuredField;

        private string unitNameField;

        private string standardNameField;

        /// <remarks/>
        public string WhatIsMeasured
        {
            get
            {
                return this.whatIsMeasuredField;
            }
            set
            {
                this.whatIsMeasuredField = value;
            }
        }

        /// <remarks/>
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public string StandardName
        {
            get
            {
                return this.standardNameField;
            }
            set
            {
                this.standardNameField = value;
            }
        }
    }

}
