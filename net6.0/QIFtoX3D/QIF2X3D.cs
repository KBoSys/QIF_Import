using QIF_Model.Helpers;
using QIF_Model.QIFApplications;
using QIF_Model.QIFLibrary.Features;
using X3DCad.Helpers;
using X3DCad.Model;
using X3DCad.Model.Nodes;
using X3DCad.Model.Types;

namespace QIFtoX3D
{
    public partial class QIF2X3D
    {
        #region Fields
        string qifFile;
        string x3dFile;
        QIFDocumentType? qifDocument;
        X3D x3d;
        #endregion Fields

        public QIF2X3D(string _qifFile, string _x3dFile)
        {
            qifFile = _qifFile;
            x3dFile = _x3dFile;
            x3d = new X3D();
        }

        #region Public Methods
        public bool Convert()
        {
            // Create QIF document from the input file
            QIFSerializer qifImport = new QIFSerializer();
            qifDocument = qifImport.CreateQIFDocument(qifFile);
            if (qifDocument == null)
            {
                throw new Exception("Could not create QIF Document");
            }

            DoConvert();

            X3DCadSerializer.Export(x3d, x3dFile);
            return true;
        }
        #endregion

        #region Converter

        private void DoConvert()
        {
            CreateHeader();
            CreateScene();
        }

        private void CreateHeader()
        {
            x3d.Head.AddMetaData("title", Path.GetFileName(x3dFile));
            x3d.Head.AddMetaData("description", $"Converted from {Path.GetFileName(qifFile)}");
            x3d.Head.AddMetaData("creator", "KBO Systems Inc.");
            x3d.Head.AddMetaData("created", DateTime.Now.ToString());
            x3d.Head.AddMetaData("modified", DateTime.Now.ToString());
            x3d.Head.AddMetaData("generator", "QIF2X3D 1.0");

            // QIF Header
            string? text = qifDocument?.Header?.Application?.Name;
            if (text != null)
                x3d.Head.AddMetaData("Name", text);

            text = qifDocument?.Header?.Author?.Name;
            if (text != null)
                x3d.Head.AddMetaData("Author", text);

            text = qifDocument?.Header?.ApplicationSource?.Name;
            if (text != null)
                x3d.Head.AddMetaData("ApplicationSource", text);

            text = qifDocument?.Header?.Description;
            if (text != null)
                x3d.Head.AddMetaData("Description", text);

            text = qifDocument?.Header?.Scope;
            if (text != null)
                x3d.Head.AddMetaData("Scope", text);

            text = qifDocument?.Header?.Application?.AddonName;
            if (text != null)
                x3d.Head.AddMetaData("AddonName", text);

            text = qifDocument?.Header?.Application?.AddonOrganization;
            if (text != null)
                x3d.Head.AddMetaData("AddonOrganization", text);
        }
        private void CreateScene()
        {
            x3d.Scene.Items.Add(new WorldInfo()
            {
                Title = Path.GetFileName(x3dFile)
            });
            x3d.Scene.Items.Add(new Background()
            {
                SkyColor = new SFColor(0.25f, 0.25f, 0.25f) //TODO
            });
            x3d.Scene.Items.Add(new Viewpoint()
            {
                Position = new SFVec3f(0, 0, 1), //TODO
                //ViewAll = true
            });

            CreateLayers();
        }

        private void CreateLayers()
        {
            // Product
            if (qifDocument?.Product != null)
            {
                CADLayer layer = new CADLayer()
                {
                    Name = "Product",
                    DEF = "Product"
                };
                CreateProductLayer(qifDocument.Product, layer);
                x3d.Scene.Items.Add(layer);
            }

            // Features
            if (qifDocument?.Features != null)
            {
                CADLayer layer = new CADLayer()
                {
                    Name = "Features",
                    DEF = "Features"
                };
                CreateFeatures(qifDocument.Features, layer);
                x3d.Scene.Items.Add(layer);
            }

            // Characteristics
            if (qifDocument?.Characteristics != null)
            {
                CADLayer layer = new CADLayer()
                {
                    Name = "Characteristics",
                    DEF = "Characteristics"
                };
                CreateCharacteristics(qifDocument.Characteristics, layer);
                x3d.Scene.Items.Add(layer);
            }
        }
        #endregion Converter
    }
}
