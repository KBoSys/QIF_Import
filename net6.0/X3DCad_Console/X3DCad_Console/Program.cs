using QIFtoX3D;
using X3DCad.Helpers;
using X3DCad.Model;

X3D? x3d = X3DCadSerializer.Import(@"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\net6.0\X3DCad\Examples\NistFtc06Asme1Ap242Spri.x3d");
if (x3d != null)
{
    X3DCadSerializer.Export(x3d, @"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\net6.0\X3DCad\Examples\NistFtc06Asme1Ap242Spri.conv.x3d");
}

//string qifFile = @"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\TestFiles\QIF_PLAN_SAMPLE.QIF";
//string x3dFile = @"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\net6.0\X3DCad\Examples\QIF_PLAN_SAMPLE.X3D";

//QIF2X3D converter = new QIF2X3D(qifFile, x3dFile);
//converter.Convert();

