using QIF_Model.QIFLibrary.Features.FeatureDefinitions;
using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Features.Nominals;
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Geometry;
using X3DCad.Model.Nodes;
using X3DCad.Model.Types;

namespace QIFtoX3D
{
    public partial class QIF2X3D
    {
        private void CreateFeatures(CADPart part)
        {
            // All 3 aspects must be present
            if (qifDocument?.Features?.FeatureDefinitions == null)
                return;
            if (qifDocument?.Features?.FeatureNominals == null)
                return;
            if (qifDocument?.Features?.FeatureItems == null)
                return;

            var featureItems = qifDocument?.Features?.FeatureItems?.Items;
            if (featureItems == null)
                return;

            foreach (FeatureItemBaseType item in featureItems)
            {
                //CADFace face = new CADFace()
                //{
                //    Name = item.FeatureName,
                //};

                CreateNominalGeometry(item, part);

                //part.Children.Add(face);
            }
        }
        private void CreateNominalGeometry(FeatureItemBaseType item, CADPart part)
        {
            FeatureNominalBaseType? nominal = qifDocument?.Features?.FeatureNominals?.GetById(item.FeatureNominalId);
            if (nominal != null)
            {
                FeatureDefinitionBaseType? featureDef = qifDocument?.Features?.FeatureDefinitions?.GetById(nominal.FeatureDefinitionId);
                if (featureDef != null)
                {
                    switch (item)
                    {
                        case EdgePointFeatureItemType pt:
                            break;
                        case PointFeatureItemType pt:
                            break;
                        case CircleFeatureItemType circle:
                            CreateCircle(part, circle, nominal as CircleFeatureNominalType, featureDef as CircleFeatureDefinitionType);
                            break;
                        default:
                            break;
                        case null:
                            throw new ArgumentNullException(nameof(featureDef));
                    }
                }
            }
        }
        private void CreateAppearance(FeatureItemBaseType item, Shape shape)
        {
            //TODO
            shape.Appearance = new Appearance()
            {
                DEF = "APP01" 
            };
        }

        private void CreateCircle(CADPart part, CircleFeatureItemType featureItem, CircleFeatureNominalType? nominal, CircleFeatureDefinitionType? featureDef)
        {
            Shape shape = new Shape();
            CreateAppearance(featureItem, shape);

            if (featureDef != null)
            {
                Circle2D circle = new Circle2D((float)(featureDef.Diameter.Value / 2));
                shape.Geometry = circle;
            }

            if (nominal != null)
            {
                Transform tr = new Transform();
                if (nominal.Location != null)
                {
                    tr.Translation = new SFVec3f((float)nominal.Location.X, (float)nominal.Location.Y, (float)nominal.Location.Z);
                }
                if (nominal.Normal != null)
                {
                    tr.Rotation = new SFRotation((float)nominal.Normal.Value[0], (float)nominal.Normal.Value[1], (float)nominal.Normal.Value[2], 0);
                }

                tr.Children.Add(shape);
                part.Children.Add(tr);
            }
            else
            {
                part.Children.Add(shape);
            }
        }
    }
}
