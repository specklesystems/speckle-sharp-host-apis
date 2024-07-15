namespace Autodesk.Revit.DB.Plumbing;

public partial class Pipe : Autodesk.Revit.DB.MEPCurve
{
	public Pipe() {}
	public static Autodesk.Revit.DB.Plumbing.Pipe Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId pipeTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.Connector startConnector,Autodesk.Revit.DB.Connector endConnector) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plumbing.Pipe Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId pipeTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.Connector startConnector,Autodesk.Revit.DB.XYZ endPoint) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plumbing.Pipe Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId,Autodesk.Revit.DB.ElementId pipeTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.XYZ startPoint,Autodesk.Revit.DB.XYZ endPoint) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plumbing.Pipe CreatePlaceholder(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId,Autodesk.Revit.DB.ElementId pipeTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.XYZ startPoint,Autodesk.Revit.DB.XYZ endPoint) => throw new System.NotImplementedException();
	public virtual void SetSystemType(Autodesk.Revit.DB.ElementId systemTypeId) => throw new System.NotImplementedException();
	public static System.Boolean IsPipeTypeId(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId pipeTypeId) => throw new System.NotImplementedException();
	public static System.Boolean IsPipingConnector(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public static System.Boolean IsPipingSystemTypeId(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Plumbing.PipeSegment PipeSegment
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsPlaceholder
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Plumbing.PipeType PipeType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Plumbing.PipeFlowState FlowState
	{
		get => throw new System.NotImplementedException();
	}
}
