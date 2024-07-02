namespace Autodesk.Revit.DB;

public partial interface IExportContext
{
	public  System.Boolean Start();
	public  void Finish();
	public  System.Boolean IsCanceled();
	public  Autodesk.Revit.DB.RenderNodeAction OnViewBegin(Autodesk.Revit.DB.ViewNode node);
	public  void OnViewEnd(Autodesk.Revit.DB.ElementId elementId);
	public  Autodesk.Revit.DB.RenderNodeAction OnElementBegin(Autodesk.Revit.DB.ElementId elementId);
	public  void OnElementEnd(Autodesk.Revit.DB.ElementId elementId);
	public  Autodesk.Revit.DB.RenderNodeAction OnInstanceBegin(Autodesk.Revit.DB.InstanceNode node);
	public  void OnInstanceEnd(Autodesk.Revit.DB.InstanceNode node);
	public  Autodesk.Revit.DB.RenderNodeAction OnLinkBegin(Autodesk.Revit.DB.LinkNode node);
	public  void OnLinkEnd(Autodesk.Revit.DB.LinkNode node);
	public  Autodesk.Revit.DB.RenderNodeAction OnFaceBegin(Autodesk.Revit.DB.FaceNode node);
	public  void OnFaceEnd(Autodesk.Revit.DB.FaceNode node);
	public  void OnRPC(Autodesk.Revit.DB.RPCNode node);
	public  void OnLight(Autodesk.Revit.DB.LightNode node);
	public  void OnMaterial(Autodesk.Revit.DB.MaterialNode node);
	public  void OnPolymesh(Autodesk.Revit.DB.PolymeshTopology node);
}
