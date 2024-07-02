namespace Autodesk.Revit.DB.Structure;

public partial interface IRebarUpdateServer
{
	public  System.Boolean GetCustomHandles(Autodesk.Revit.DB.Structure.RebarHandlesData handlesInfoData);
	public  System.Boolean GetCustomHandleName(Autodesk.Revit.DB.Structure.RebarHandleNameData handleNameData);
	public  System.Boolean GenerateCurves(Autodesk.Revit.DB.Structure.RebarCurvesData curvesData);
	public  System.Boolean TrimExtendCurves(Autodesk.Revit.DB.Structure.RebarTrimExtendData trimExtendData);
	public  System.Boolean GetHandlesPosition(Autodesk.Revit.DB.Structure.RebarHandlePositionData handlePositionData);
}
