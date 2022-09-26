using X3DCad.Helpers;
using X3DCad.Model;

X3D? x3d = X3DCadSerializer.Import(@"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\net6.0\X3DCad\Examples\GeometryPrimitiveNodesWhiteBackground.x3d");

if (x3d != null)
{
    X3DCadSerializer.Export(x3d, @"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\net6.0\X3DCad\Examples\Test.conv.x3d");
}
