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
    public partial class QIFDocumentProduct
    {

        private QIFDocumentProductHeader headerField;

        private object geometrySetField;

        private QIFDocumentProductTopologySet topologySetField;

        private QIFDocumentProductNoteSet noteSetField;

        private QIFDocumentProductNoteFlagSet noteFlagSetField;

        private QIFDocumentProductPartNoteSet partNoteSetField;

        private QIFDocumentProductViewSet viewSetField;

        private QIFDocumentProductRootPart rootPartField;

        /// <remarks/>
        public QIFDocumentProductHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public object GeometrySet
        {
            get
            {
                return this.geometrySetField;
            }
            set
            {
                this.geometrySetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySet TopologySet
        {
            get
            {
                return this.topologySetField;
            }
            set
            {
                this.topologySetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductNoteSet NoteSet
        {
            get
            {
                return this.noteSetField;
            }
            set
            {
                this.noteSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductNoteFlagSet NoteFlagSet
        {
            get
            {
                return this.noteFlagSetField;
            }
            set
            {
                this.noteFlagSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductPartNoteSet PartNoteSet
        {
            get
            {
                return this.partNoteSetField;
            }
            set
            {
                this.partNoteSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSet ViewSet
        {
            get
            {
                return this.viewSetField;
            }
            set
            {
                this.viewSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductRootPart RootPart
        {
            get
            {
                return this.rootPartField;
            }
            set
            {
                this.rootPartField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductHeader
    {

        private string nameField;

        private QIFDocumentProductHeaderFile fileField;

        private QIFDocumentProductHeaderApplication applicationField;

        private QIFDocumentProductHeaderAuthor authorField;

        private QIFDocumentProductHeaderApplicationSource applicationSourceField;

        private string descriptionField;

        private decimal scaleCoefficientField;

        private byte modelToleranceField;

        private byte massPropertyToleranceField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductHeaderFile File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductHeaderApplication Application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductHeaderAuthor Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductHeaderApplicationSource ApplicationSource
        {
            get
            {
                return this.applicationSourceField;
            }
            set
            {
                this.applicationSourceField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public decimal ScaleCoefficient
        {
            get
            {
                return this.scaleCoefficientField;
            }
            set
            {
                this.scaleCoefficientField = value;
            }
        }

        /// <remarks/>
        public byte ModelTolerance
        {
            get
            {
                return this.modelToleranceField;
            }
            set
            {
                this.modelToleranceField = value;
            }
        }

        /// <remarks/>
        public byte MassPropertyTolerance
        {
            get
            {
                return this.massPropertyToleranceField;
            }
            set
            {
                this.massPropertyToleranceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductHeaderFile
    {

        private string nameField;

        private QIFDocumentProductHeaderFileVersion versionField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductHeaderFileVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductHeaderFileVersion
    {

        private System.DateTime timeCreatedField;

        private QIFDocumentProductHeaderFileVersionSignOffs signOffsField;

        private string thisInstanceQPIdField;

        /// <remarks/>
        public System.DateTime TimeCreated
        {
            get
            {
                return this.timeCreatedField;
            }
            set
            {
                this.timeCreatedField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductHeaderFileVersionSignOffs SignOffs
        {
            get
            {
                return this.signOffsField;
            }
            set
            {
                this.signOffsField = value;
            }
        }

        /// <remarks/>
        public string ThisInstanceQPId
        {
            get
            {
                return this.thisInstanceQPIdField;
            }
            set
            {
                this.thisInstanceQPIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductHeaderFileVersionSignOffs
    {

        private QIFDocumentProductHeaderFileVersionSignOffsEmployee[] employeeField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Employee")]
        public QIFDocumentProductHeaderFileVersionSignOffsEmployee[] Employee
        {
            get
            {
                return this.employeeField;
            }
            set
            {
                this.employeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductHeaderFileVersionSignOffsEmployee
    {

        private string nameField;

        private string employeeIdField;

        private string shiftField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string EmployeeId
        {
            get
            {
                return this.employeeIdField;
            }
            set
            {
                this.employeeIdField = value;
            }
        }

        /// <remarks/>
        public string Shift
        {
            get
            {
                return this.shiftField;
            }
            set
            {
                this.shiftField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductHeaderApplication
    {

        private string nameField;

        private string organizationField;

        private string addonNameField;

        private string addonOrganizationField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        public string AddonName
        {
            get
            {
                return this.addonNameField;
            }
            set
            {
                this.addonNameField = value;
            }
        }

        /// <remarks/>
        public string AddonOrganization
        {
            get
            {
                return this.addonOrganizationField;
            }
            set
            {
                this.addonOrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductHeaderAuthor
    {

        private string nameField;

        private string organizationField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductHeaderApplicationSource
    {

        private string nameField;

        private string organizationField;

        private string addonNameField;

        private string addonOrganizationField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        public string AddonName
        {
            get
            {
                return this.addonNameField;
            }
            set
            {
                this.addonNameField = value;
            }
        }

        /// <remarks/>
        public string AddonOrganization
        {
            get
            {
                return this.addonOrganizationField;
            }
            set
            {
                this.addonOrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySet
    {

        private QIFDocumentProductTopologySetShellSet shellSetField;

        private QIFDocumentProductTopologySetBodySet bodySetField;

        private QIFDocumentProductTopologySetPointCloudSet pointCloudSetField;

        /// <remarks/>
        public QIFDocumentProductTopologySetShellSet ShellSet
        {
            get
            {
                return this.shellSetField;
            }
            set
            {
                this.shellSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySet BodySet
        {
            get
            {
                return this.bodySetField;
            }
            set
            {
                this.bodySetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetPointCloudSet PointCloudSet
        {
            get
            {
                return this.pointCloudSetField;
            }
            set
            {
                this.pointCloudSetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetShellSet
    {

        private QIFDocumentProductTopologySetShellSetShell[] shellField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Shell")]
        public QIFDocumentProductTopologySetShellSetShell[] Shell
        {
            get
            {
                return this.shellField;
            }
            set
            {
                this.shellField = value;
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
    public partial class QIFDocumentProductTopologySetShellSetShell
    {

        private QIFDocumentProductTopologySetShellSetShellFaceIds faceIdsField;

        private bool turnedField;

        private bool closedField;

        private string formField;

        private string colorField;

        private byte transparencyField;

        private bool hiddenField;

        private double sizeField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductTopologySetShellSetShellFaceIds FaceIds
        {
            get
            {
                return this.faceIdsField;
            }
            set
            {
                this.faceIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool turned
        {
            get
            {
                return this.turnedField;
            }
            set
            {
                this.turnedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte transparency
        {
            get
            {
                return this.transparencyField;
            }
            set
            {
                this.transparencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetShellSetShellFaceIds
    {

        private QIFDocumentProductTopologySetShellSetShellFaceIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductTopologySetShellSetShellFaceIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductTopologySetShellSetShellFaceIdsID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySet
    {

        private QIFDocumentProductTopologySetBodySetBody[] bodyField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Body")]
        public QIFDocumentProductTopologySetBodySetBody[] Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
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
    public partial class QIFDocumentProductTopologySetBodySetBody
    {

        private QIFDocumentProductTopologySetBodySetBodyValidation validationField;

        private QIFDocumentProductTopologySetBodySetBodyTransform transformField;

        private QIFDocumentProductTopologySetBodySetBodyShellIds shellIdsField;

        private QIFDocumentProductTopologySetBodySetBodyFaceIds faceIdsField;

        private QIFDocumentProductTopologySetBodySetBodyLoopIds loopIdsField;

        private QIFDocumentProductTopologySetBodySetBodyEdgeIds edgeIdsField;

        private QIFDocumentProductTopologySetBodySetBodyVertexIds vertexIdsField;

        private string formField;

        private uint materialIndexField;

        private string colorField;

        private decimal transparencyField;

        private bool hiddenField;

        private double sizeField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyValidation Validation
        {
            get
            {
                return this.validationField;
            }
            set
            {
                this.validationField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyTransform Transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyShellIds ShellIds
        {
            get
            {
                return this.shellIdsField;
            }
            set
            {
                this.shellIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyFaceIds FaceIds
        {
            get
            {
                return this.faceIdsField;
            }
            set
            {
                this.faceIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyLoopIds LoopIds
        {
            get
            {
                return this.loopIdsField;
            }
            set
            {
                this.loopIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyEdgeIds EdgeIds
        {
            get
            {
                return this.edgeIdsField;
            }
            set
            {
                this.edgeIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyVertexIds VertexIds
        {
            get
            {
                return this.vertexIdsField;
            }
            set
            {
                this.vertexIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint materialIndex
        {
            get
            {
                return this.materialIndexField;
            }
            set
            {
                this.materialIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal transparency
        {
            get
            {
                return this.transparencyField;
            }
            set
            {
                this.transparencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyValidation
    {

        private double areaField;

        private string centroidField;

        private double volumeField;

        private QIFDocumentProductTopologySetBodySetBodyValidationBox boxField;

        private QIFDocumentProductTopologySetBodySetBodyValidationFacePoints facePointsField;

        private QIFDocumentProductTopologySetBodySetBodyValidationEdgePoints edgePointsField;

        /// <remarks/>
        public double Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        public string Centroid
        {
            get
            {
                return this.centroidField;
            }
            set
            {
                this.centroidField = value;
            }
        }

        /// <remarks/>
        public double Volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyValidationBox Box
        {
            get
            {
                return this.boxField;
            }
            set
            {
                this.boxField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyValidationFacePoints FacePoints
        {
            get
            {
                return this.facePointsField;
            }
            set
            {
                this.facePointsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyValidationEdgePoints EdgePoints
        {
            get
            {
                return this.edgePointsField;
            }
            set
            {
                this.edgePointsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyValidationBox
    {

        private string pointMinField;

        private string pointMaxField;

        /// <remarks/>
        public string PointMin
        {
            get
            {
                return this.pointMinField;
            }
            set
            {
                this.pointMinField = value;
            }
        }

        /// <remarks/>
        public string PointMax
        {
            get
            {
                return this.pointMaxField;
            }
            set
            {
                this.pointMaxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyValidationFacePoints
    {

        private QIFDocumentProductTopologySetBodySetBodyValidationFacePointsPoints pointsField;

        private QIFDocumentProductTopologySetBodySetBodyValidationFacePointsDirections directionsField;

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyValidationFacePointsPoints Points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyValidationFacePointsDirections Directions
        {
            get
            {
                return this.directionsField;
            }
            set
            {
                this.directionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyValidationFacePointsPoints
    {

        private byte countField;

        private string linearUnitField;

        private byte decimalPlacesField;

        private byte significantFiguresField;

        private string validityField;

        private byte xDecimalPlacesField;

        private byte xSignificantFiguresField;

        private string xValidityField;

        private byte yDecimalPlacesField;

        private byte ySignificantFiguresField;

        private string yValidityField;

        private byte zDecimalPlacesField;

        private byte zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyValidationFacePointsDirections
    {

        private byte countField;

        private string linearUnitField;

        private byte decimalPlacesField;

        private byte significantFiguresField;

        private string validityField;

        private byte xDecimalPlacesField;

        private byte xSignificantFiguresField;

        private string xValidityField;

        private byte yDecimalPlacesField;

        private byte ySignificantFiguresField;

        private string yValidityField;

        private byte zDecimalPlacesField;

        private byte zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyValidationEdgePoints
    {

        private QIFDocumentProductTopologySetBodySetBodyValidationEdgePointsPoints pointsField;

        private QIFDocumentProductTopologySetBodySetBodyValidationEdgePointsDirections directionsField;

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyValidationEdgePointsPoints Points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyValidationEdgePointsDirections Directions
        {
            get
            {
                return this.directionsField;
            }
            set
            {
                this.directionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyValidationEdgePointsPoints
    {

        private uint countField;

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyValidationEdgePointsDirections
    {

        private uint countField;

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyTransform
    {

        private QIFDocumentProductTopologySetBodySetBodyTransformID idField;

        /// <remarks/>
        public QIFDocumentProductTopologySetBodySetBodyTransformID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyTransformID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyShellIds
    {

        private QIFDocumentProductTopologySetBodySetBodyShellIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductTopologySetBodySetBodyShellIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductTopologySetBodySetBodyShellIdsID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyFaceIds
    {

        private QIFDocumentProductTopologySetBodySetBodyFaceIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductTopologySetBodySetBodyFaceIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductTopologySetBodySetBodyFaceIdsID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyLoopIds
    {

        private QIFDocumentProductTopologySetBodySetBodyLoopIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductTopologySetBodySetBodyLoopIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductTopologySetBodySetBodyLoopIdsID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyEdgeIds
    {

        private QIFDocumentProductTopologySetBodySetBodyEdgeIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductTopologySetBodySetBodyEdgeIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductTopologySetBodySetBodyEdgeIdsID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetBodySetBodyVertexIds
    {

        private QIFDocumentProductTopologySetBodySetBodyVertexIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductTopologySetBodySetBodyVertexIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductTopologySetBodySetBodyVertexIdsID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetPointCloudSet
    {

        private QIFDocumentProductTopologySetPointCloudSetPointCloud[] pointCloudField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointCloud")]
        public QIFDocumentProductTopologySetPointCloudSetPointCloud[] PointCloud
        {
            get
            {
                return this.pointCloudField;
            }
            set
            {
                this.pointCloudField = value;
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
    public partial class QIFDocumentProductTopologySetPointCloudSetPointCloud
    {

        private QIFDocumentProductTopologySetPointCloudSetPointCloudPoints pointsField;

        private QIFDocumentProductTopologySetPointCloudSetPointCloudNormals normalsField;

        private QIFDocumentProductTopologySetPointCloudSetPointCloudPointsVisible pointsVisibleField;

        private QIFDocumentProductTopologySetPointCloudSetPointCloudPointsColor pointsColorField;

        private string colorField;

        private decimal transparencyField;

        private bool hiddenField;

        private double sizeField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductTopologySetPointCloudSetPointCloudPoints Points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetPointCloudSetPointCloudNormals Normals
        {
            get
            {
                return this.normalsField;
            }
            set
            {
                this.normalsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetPointCloudSetPointCloudPointsVisible PointsVisible
        {
            get
            {
                return this.pointsVisibleField;
            }
            set
            {
                this.pointsVisibleField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductTopologySetPointCloudSetPointCloudPointsColor PointsColor
        {
            get
            {
                return this.pointsColorField;
            }
            set
            {
                this.pointsColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal transparency
        {
            get
            {
                return this.transparencyField;
            }
            set
            {
                this.transparencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetPointCloudSetPointCloudPoints
    {

        private uint countField;

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetPointCloudSetPointCloudNormals
    {

        private uint countField;

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetPointCloudSetPointCloudPointsVisible
    {

        private uint countField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductTopologySetPointCloudSetPointCloudPointsColor
    {

        private uint countField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductNoteSet
    {

        private QIFDocumentProductNoteSetNote[] noteField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public QIFDocumentProductNoteSetNote[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
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
    public partial class QIFDocumentProductNoteSetNote
    {

        private QIFDocumentProductNoteSetNoteEntityInternalIds entityInternalIdsField;

        private QIFDocumentProductNoteSetNoteEntityExternalIds entityExternalIdsField;

        private string textField;

        private string formField;

        private string colorField;

        private decimal transparencyField;

        private bool hiddenField;

        private double sizeField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductNoteSetNoteEntityInternalIds EntityInternalIds
        {
            get
            {
                return this.entityInternalIdsField;
            }
            set
            {
                this.entityInternalIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductNoteSetNoteEntityExternalIds EntityExternalIds
        {
            get
            {
                return this.entityExternalIdsField;
            }
            set
            {
                this.entityExternalIdsField = value;
            }
        }

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal transparency
        {
            get
            {
                return this.transparencyField;
            }
            set
            {
                this.transparencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductNoteSetNoteEntityInternalIds
    {

        private QIFDocumentProductNoteSetNoteEntityInternalIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductNoteSetNoteEntityInternalIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductNoteSetNoteEntityInternalIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductNoteSetNoteEntityExternalIds
    {

        private QIFDocumentProductNoteSetNoteEntityExternalIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductNoteSetNoteEntityExternalIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductNoteSetNoteEntityExternalIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductNoteFlagSet
    {

        private QIFDocumentProductNoteFlagSetNoteFlag[] noteFlagField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NoteFlag")]
        public QIFDocumentProductNoteFlagSetNoteFlag[] NoteFlag
        {
            get
            {
                return this.noteFlagField;
            }
            set
            {
                this.noteFlagField = value;
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
    public partial class QIFDocumentProductNoteFlagSetNoteFlag
    {

        private QIFDocumentProductNoteFlagSetNoteFlagEntityInternalIds entityInternalIdsField;

        private QIFDocumentProductNoteFlagSetNoteFlagEntityExternalIds entityExternalIdsField;

        private string textField;

        private string textHiddenField;

        private string uRIField;

        private string formField;

        private string colorField;

        private decimal transparencyField;

        private bool hiddenField;

        private double sizeField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductNoteFlagSetNoteFlagEntityInternalIds EntityInternalIds
        {
            get
            {
                return this.entityInternalIdsField;
            }
            set
            {
                this.entityInternalIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductNoteFlagSetNoteFlagEntityExternalIds EntityExternalIds
        {
            get
            {
                return this.entityExternalIdsField;
            }
            set
            {
                this.entityExternalIdsField = value;
            }
        }

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public string TextHidden
        {
            get
            {
                return this.textHiddenField;
            }
            set
            {
                this.textHiddenField = value;
            }
        }

        /// <remarks/>
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal transparency
        {
            get
            {
                return this.transparencyField;
            }
            set
            {
                this.transparencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductNoteFlagSetNoteFlagEntityInternalIds
    {

        private QIFDocumentProductNoteFlagSetNoteFlagEntityInternalIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductNoteFlagSetNoteFlagEntityInternalIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductNoteFlagSetNoteFlagEntityInternalIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductNoteFlagSetNoteFlagEntityExternalIds
    {

        private QIFDocumentProductNoteFlagSetNoteFlagEntityExternalIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductNoteFlagSetNoteFlagEntityExternalIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductNoteFlagSetNoteFlagEntityExternalIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductPartNoteSet
    {

        private QIFDocumentProductPartNoteSetPartNote[] partNoteField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartNote")]
        public QIFDocumentProductPartNoteSetPartNote[] PartNote
        {
            get
            {
                return this.partNoteField;
            }
            set
            {
                this.partNoteField = value;
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
    public partial class QIFDocumentProductPartNoteSetPartNote
    {

        private string textField;

        private QIFDocumentProductPartNoteSetPartNotePartNoteIds partNoteIdsField;

        private string colorField;

        private decimal transparencyField;

        private bool hiddenField;

        private double sizeField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductPartNoteSetPartNotePartNoteIds PartNoteIds
        {
            get
            {
                return this.partNoteIdsField;
            }
            set
            {
                this.partNoteIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal transparency
        {
            get
            {
                return this.transparencyField;
            }
            set
            {
                this.transparencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductPartNoteSetPartNotePartNoteIds
    {

        private QIFDocumentProductPartNoteSetPartNotePartNoteIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductPartNoteSetPartNotePartNoteIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductPartNoteSetPartNotePartNoteIdsID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSet
    {

        private QIFDocumentProductViewSetCameraSet cameraSetField;

        private QIFDocumentProductViewSetSavedViewSet savedViewSetField;

        private QIFDocumentProductViewSetAnnotationViewSet annotationViewSetField;

        private QIFDocumentProductViewSetSimplifiedRepresentationSet simplifiedRepresentationSetField;

        private QIFDocumentProductViewSetExplodedViewSet explodedViewSetField;

        private QIFDocumentProductViewSetDisplayStyleSet displayStyleSetField;

        private QIFDocumentProductViewSetZoneSectionSet zoneSectionSetField;

        /// <remarks/>
        public QIFDocumentProductViewSetCameraSet CameraSet
        {
            get
            {
                return this.cameraSetField;
            }
            set
            {
                this.cameraSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSet SavedViewSet
        {
            get
            {
                return this.savedViewSetField;
            }
            set
            {
                this.savedViewSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetAnnotationViewSet AnnotationViewSet
        {
            get
            {
                return this.annotationViewSetField;
            }
            set
            {
                this.annotationViewSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSimplifiedRepresentationSet SimplifiedRepresentationSet
        {
            get
            {
                return this.simplifiedRepresentationSetField;
            }
            set
            {
                this.simplifiedRepresentationSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetExplodedViewSet ExplodedViewSet
        {
            get
            {
                return this.explodedViewSetField;
            }
            set
            {
                this.explodedViewSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetDisplayStyleSet DisplayStyleSet
        {
            get
            {
                return this.displayStyleSetField;
            }
            set
            {
                this.displayStyleSetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSet ZoneSectionSet
        {
            get
            {
                return this.zoneSectionSetField;
            }
            set
            {
                this.zoneSectionSetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetCameraSet
    {

        private QIFDocumentProductViewSetCameraSetCamera[] cameraField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Camera")]
        public QIFDocumentProductViewSetCameraSetCamera[] Camera
        {
            get
            {
                return this.cameraField;
            }
            set
            {
                this.cameraField = value;
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
    public partial class QIFDocumentProductViewSetCameraSetCamera
    {

        private string viewPlaneOriginField;

        private QIFDocumentProductViewSetCameraSetCameraOrientation orientationField;

        private double ratioField;

        private QIFDocumentProductViewSetCameraSetCameraNear nearField;

        private QIFDocumentProductViewSetCameraSetCameraFar farField;

        private double heightField;

        private string formField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public string ViewPlaneOrigin
        {
            get
            {
                return this.viewPlaneOriginField;
            }
            set
            {
                this.viewPlaneOriginField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetCameraSetCameraOrientation Orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }

        /// <remarks/>
        public double Ratio
        {
            get
            {
                return this.ratioField;
            }
            set
            {
                this.ratioField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetCameraSetCameraNear Near
        {
            get
            {
                return this.nearField;
            }
            set
            {
                this.nearField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetCameraSetCameraFar Far
        {
            get
            {
                return this.farField;
            }
            set
            {
                this.farField = value;
            }
        }

        /// <remarks/>
        public double Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetCameraSetCameraOrientation
    {

        private string valueField;

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetCameraSetCameraNear
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetCameraSetCameraFar
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSet
    {

        private QIFDocumentProductViewSetSavedViewSetSavedView[] savedViewField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SavedView")]
        public QIFDocumentProductViewSetSavedViewSetSavedView[] SavedView
        {
            get
            {
                return this.savedViewField;
            }
            set
            {
                this.savedViewField = value;
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
    public partial class QIFDocumentProductViewSetSavedViewSetSavedView
    {

        private bool activeViewField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationVisibleIds annotationVisibleIdsField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationHiddenIds annotationHiddenIdsField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewBodyIds bodyIdsField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewComponentIds componentIdsField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewSimplifiedRepresentationId simplifiedRepresentationIdField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewExplodedViewId explodedViewIdField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewDisplayStyleId displayStyleIdField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewZoneSectionId zoneSectionIdField;

        private QIFDocumentProductViewSetSavedViewSetSavedViewCameraIds cameraIdsField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public bool ActiveView
        {
            get
            {
                return this.activeViewField;
            }
            set
            {
                this.activeViewField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationVisibleIds AnnotationVisibleIds
        {
            get
            {
                return this.annotationVisibleIdsField;
            }
            set
            {
                this.annotationVisibleIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationHiddenIds AnnotationHiddenIds
        {
            get
            {
                return this.annotationHiddenIdsField;
            }
            set
            {
                this.annotationHiddenIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewBodyIds BodyIds
        {
            get
            {
                return this.bodyIdsField;
            }
            set
            {
                this.bodyIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewComponentIds ComponentIds
        {
            get
            {
                return this.componentIdsField;
            }
            set
            {
                this.componentIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewSimplifiedRepresentationId SimplifiedRepresentationId
        {
            get
            {
                return this.simplifiedRepresentationIdField;
            }
            set
            {
                this.simplifiedRepresentationIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewExplodedViewId ExplodedViewId
        {
            get
            {
                return this.explodedViewIdField;
            }
            set
            {
                this.explodedViewIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewDisplayStyleId DisplayStyleId
        {
            get
            {
                return this.displayStyleIdField;
            }
            set
            {
                this.displayStyleIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewZoneSectionId ZoneSectionId
        {
            get
            {
                return this.zoneSectionIdField;
            }
            set
            {
                this.zoneSectionIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSavedViewSetSavedViewCameraIds CameraIds
        {
            get
            {
                return this.cameraIdsField;
            }
            set
            {
                this.cameraIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationVisibleIds
    {

        private QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationVisibleIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationVisibleIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationVisibleIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationHiddenIds
    {

        private QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationHiddenIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationHiddenIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewAnnotationHiddenIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewBodyIds
    {

        private QIFDocumentProductViewSetSavedViewSetSavedViewBodyIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetSavedViewSetSavedViewBodyIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewBodyIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewComponentIds
    {

        private QIFDocumentProductViewSetSavedViewSetSavedViewComponentIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetSavedViewSetSavedViewComponentIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewComponentIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewSimplifiedRepresentationId
    {

        private bool activeField;

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewExplodedViewId
    {

        private bool activeField;

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewDisplayStyleId
    {

        private bool activeField;

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewZoneSectionId
    {

        private bool activeField;

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewCameraIds
    {

        private QIFDocumentProductViewSetSavedViewSetSavedViewCameraIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetSavedViewSetSavedViewCameraIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetSavedViewSetSavedViewCameraIdsID
    {

        private bool activeField;

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetAnnotationViewSet
    {

        private QIFDocumentProductViewSetAnnotationViewSetAnnotationView[] annotationViewField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnnotationView")]
        public QIFDocumentProductViewSetAnnotationViewSetAnnotationView[] AnnotationView
        {
            get
            {
                return this.annotationViewField;
            }
            set
            {
                this.annotationViewField = value;
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
    public partial class QIFDocumentProductViewSetAnnotationViewSetAnnotationView
    {

        private QIFDocumentProductViewSetAnnotationViewSetAnnotationViewNormal normalField;

        private QIFDocumentProductViewSetAnnotationViewSetAnnotationViewDirection directionField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductViewSetAnnotationViewSetAnnotationViewNormal Normal
        {
            get
            {
                return this.normalField;
            }
            set
            {
                this.normalField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetAnnotationViewSetAnnotationViewDirection Direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetAnnotationViewSetAnnotationViewNormal
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetAnnotationViewSetAnnotationViewDirection
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSimplifiedRepresentationSet
    {

        private QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentation[] simplifiedRepresentationField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SimplifiedRepresentation")]
        public QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentation[] SimplifiedRepresentation
        {
            get
            {
                return this.simplifiedRepresentationField;
            }
            set
            {
                this.simplifiedRepresentationField = value;
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
    public partial class QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentation
    {

        private string formField;

        private QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroups simplifiedRepresentationGroupsField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public string Form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroups SimplifiedRepresentationGroups
        {
            get
            {
                return this.simplifiedRepresentationGroupsField;
            }
            set
            {
                this.simplifiedRepresentationGroupsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroups
    {

        private QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroup[] simplifiedRepresentationGroupField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SimplifiedRepresentationGroup")]
        public QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroup[] SimplifiedRepresentationGroup
        {
            get
            {
                return this.simplifiedRepresentationGroupField;
            }
            set
            {
                this.simplifiedRepresentationGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroup
    {

        private string formField;

        private QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupComponentIds componentIdsField;

        private QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupBodyIds bodyIdsField;

        /// <remarks/>
        public string Form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupComponentIds ComponentIds
        {
            get
            {
                return this.componentIdsField;
            }
            set
            {
                this.componentIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupBodyIds BodyIds
        {
            get
            {
                return this.bodyIdsField;
            }
            set
            {
                this.bodyIdsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupComponentIds
    {

        private QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupComponentIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupComponentIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupComponentIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupBodyIds
    {

        private QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupBodyIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupBodyIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetSimplifiedRepresentationSetSimplifiedRepresentationSimplifiedRepresentationGroupsSimplifiedRepresentationGroupBodyIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetExplodedViewSet
    {

        private QIFDocumentProductViewSetExplodedViewSetExplodedView[] explodedViewField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExplodedView")]
        public QIFDocumentProductViewSetExplodedViewSetExplodedView[] ExplodedView
        {
            get
            {
                return this.explodedViewField;
            }
            set
            {
                this.explodedViewField = value;
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
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedView
    {

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroups moveGroupsField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroups MoveGroups
        {
            get
            {
                return this.moveGroupsField;
            }
            set
            {
                this.moveGroupsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroups
    {

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroup[] moveGroupField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MoveGroup")]
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroup[] MoveGroup
        {
            get
            {
                return this.moveGroupField;
            }
            set
            {
                this.moveGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroup
    {

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslate translateField;

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupComponentIds componentIdsField;

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupBodyIds bodyIdsField;

        /// <remarks/>
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslate Translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupComponentIds ComponentIds
        {
            get
            {
                return this.componentIdsField;
            }
            set
            {
                this.componentIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupBodyIds BodyIds
        {
            get
            {
                return this.bodyIdsField;
            }
            set
            {
                this.bodyIdsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslate
    {

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslateDirection directionField;

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslateValue valueField;

        /// <remarks/>
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslateDirection Direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslateValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslateDirection
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupTranslateValue
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupComponentIds
    {

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupComponentIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupComponentIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupComponentIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupBodyIds
    {

        private QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupBodyIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupBodyIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetExplodedViewSetExplodedViewMoveGroupsMoveGroupBodyIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetDisplayStyleSet
    {

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyle[] displayStyleField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DisplayStyle")]
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyle[] DisplayStyle
        {
            get
            {
                return this.displayStyleField;
            }
            set
            {
                this.displayStyleField = value;
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
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyle
    {

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyleMode modeField;

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroups displayStyleGroupsField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyleMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroups DisplayStyleGroups
        {
            get
            {
                return this.displayStyleGroupsField;
            }
            set
            {
                this.displayStyleGroupsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyleMode
    {

        private string formField;

        private string colorField;

        private byte transparencyField;

        /// <remarks/>
        public string Form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public byte Transparency
        {
            get
            {
                return this.transparencyField;
            }
            set
            {
                this.transparencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroups
    {

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroup[] displayStyleGroupField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DisplayStyleGroup")]
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroup[] DisplayStyleGroup
        {
            get
            {
                return this.displayStyleGroupField;
            }
            set
            {
                this.displayStyleGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroup
    {

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupMode modeField;

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupComponentIds componentIdsField;

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupBodyIds bodyIdsField;

        /// <remarks/>
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupComponentIds ComponentIds
        {
            get
            {
                return this.componentIdsField;
            }
            set
            {
                this.componentIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupBodyIds BodyIds
        {
            get
            {
                return this.bodyIdsField;
            }
            set
            {
                this.bodyIdsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupMode
    {

        private string formField;

        private string colorField;

        private byte transparencyField;

        /// <remarks/>
        public string Form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public byte Transparency
        {
            get
            {
                return this.transparencyField;
            }
            set
            {
                this.transparencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupComponentIds
    {

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupComponentIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupComponentIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupComponentIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupBodyIds
    {

        private QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupBodyIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupBodyIdsID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetDisplayStyleSetDisplayStyleDisplayStyleGroupsDisplayStyleGroupBodyIdsID
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSet
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSection[] zoneSectionField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ZoneSection")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSection[] ZoneSection
        {
            get
            {
                return this.zoneSectionField;
            }
            set
            {
                this.zoneSectionField = value;
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSection
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanes sectionPlanesField;

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionLogicalOperations logicalOperationsField;

        private bool hatchingField;

        private uint idField;

        private string labelField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanes SectionPlanes
        {
            get
            {
                return this.sectionPlanesField;
            }
            set
            {
                this.sectionPlanesField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionLogicalOperations LogicalOperations
        {
            get
            {
                return this.logicalOperationsField;
            }
            set
            {
                this.logicalOperationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hatching
        {
            get
            {
                return this.hatchingField;
            }
            set
            {
                this.hatchingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanes
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlane[] sectionPlaneField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SectionPlane")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlane[] SectionPlane
        {
            get
            {
                return this.sectionPlaneField;
            }
            set
            {
                this.sectionPlaneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlane
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlane planeField;

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroups sectionGroupsField;

        private uint indexField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlane Plane
        {
            get
            {
                return this.planeField;
            }
            set
            {
                this.planeField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroups SectionGroups
        {
            get
            {
                return this.sectionGroupsField;
            }
            set
            {
                this.sectionGroupsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlane
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlanePoint pointField;

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlaneNormal normalField;

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlaneDirection directionField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlanePoint Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlaneNormal Normal
        {
            get
            {
                return this.normalField;
            }
            set
            {
                this.normalField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlaneDirection Direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlanePoint
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlaneNormal
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlanePlaneDirection
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroups
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroup[] sectionGroupField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SectionGroup")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroup[] SectionGroup
        {
            get
            {
                return this.sectionGroupField;
            }
            set
            {
                this.sectionGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroup
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupBodyId bodyIdField;

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreas areasField;

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPaths pathsField;

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupVertices verticesField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupBodyId BodyId
        {
            get
            {
                return this.bodyIdField;
            }
            set
            {
                this.bodyIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreas Areas
        {
            get
            {
                return this.areasField;
            }
            set
            {
                this.areasField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPaths Paths
        {
            get
            {
                return this.pathsField;
            }
            set
            {
                this.pathsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupVertices Vertices
        {
            get
            {
                return this.verticesField;
            }
            set
            {
                this.verticesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupBodyId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreas
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasArea[] areaField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Area")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasArea[] Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasArea
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaHatchStyleId hatchStyleIdField;

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoops loopsField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaHatchStyleId HatchStyleId
        {
            get
            {
                return this.hatchStyleIdField;
            }
            set
            {
                this.hatchStyleIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoops Loops
        {
            get
            {
                return this.loopsField;
            }
            set
            {
                this.loopsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaHatchStyleId
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoops
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoop[] loopField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Loop")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoop[] Loop
        {
            get
            {
                return this.loopField;
            }
            set
            {
                this.loopField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoop
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdges edgesField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdges Edges
        {
            get
            {
                return this.edgesField;
            }
            set
            {
                this.edgesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdges
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdgesEdge[] edgeField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Edge")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdgesEdge[] Edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdgesEdge
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdgesEdgeID idField;

        private bool turnedField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdgesEdgeID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool turned
        {
            get
            {
                return this.turnedField;
            }
            set
            {
                this.turnedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupAreasAreaLoopsLoopEdgesEdgeID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPaths
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPath[] pathField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Path")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPath[] Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPath
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdges edgesField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdges Edges
        {
            get
            {
                return this.edgesField;
            }
            set
            {
                this.edgesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdges
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdgesEdge[] edgeField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Edge")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdgesEdge[] Edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdgesEdge
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdgesEdgeID idField;

        private bool turnedField;

        /// <remarks/>
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdgesEdgeID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool turned
        {
            get
            {
                return this.turnedField;
            }
            set
            {
                this.turnedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupPathsPathEdgesEdgeID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupVertices
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupVerticesID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupVerticesID[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionSectionPlanesSectionPlaneSectionGroupsSectionGroupVerticesID
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionLogicalOperations
    {

        private QIFDocumentProductViewSetZoneSectionSetZoneSectionLogicalOperationsLogicalOperation[] logicalOperationField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LogicalOperation")]
        public QIFDocumentProductViewSetZoneSectionSetZoneSectionLogicalOperationsLogicalOperation[] LogicalOperation
        {
            get
            {
                return this.logicalOperationField;
            }
            set
            {
                this.logicalOperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
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
    public partial class QIFDocumentProductViewSetZoneSectionSetZoneSectionLogicalOperationsLogicalOperation
    {

        private string actionField;

        private uint sectionPlaneField;

        private uint logicalOperationResultField;

        private uint indexField;

        /// <remarks/>
        public string Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        public uint SectionPlane
        {
            get
            {
                return this.sectionPlaneField;
            }
            set
            {
                this.sectionPlaneField = value;
            }
        }

        /// <remarks/>
        public uint LogicalOperationResult
        {
            get
            {
                return this.logicalOperationResultField;
            }
            set
            {
                this.logicalOperationResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductRootPart
    {

        private QIFDocumentProductRootPartID idField;

        /// <remarks/>
        public QIFDocumentProductRootPartID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductRootPartID
    {

        private ushort xIdField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
