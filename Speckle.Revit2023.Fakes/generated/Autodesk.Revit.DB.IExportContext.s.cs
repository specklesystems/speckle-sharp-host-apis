namespace Autodesk.Revit.DB;

public partial class IExportContext
{
	public virtual void Finish() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RenderNodeAction OnViewBegin(Autodesk.Revit.DB.ViewNode node) => throw new System.NotImplementedException();
	public virtual void OnViewEnd(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RenderNodeAction OnElementBegin(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void OnElementEnd(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RenderNodeAction OnInstanceBegin(Autodesk.Revit.DB.InstanceNode node) => throw new System.NotImplementedException();
	public virtual void OnInstanceEnd(Autodesk.Revit.DB.InstanceNode node) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RenderNodeAction OnLinkBegin(Autodesk.Revit.DB.LinkNode node) => throw new System.NotImplementedException();
	public virtual void OnLinkEnd(Autodesk.Revit.DB.LinkNode node) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RenderNodeAction OnFaceBegin(Autodesk.Revit.DB.FaceNode node) => throw new System.NotImplementedException();
	public virtual void OnFaceEnd(Autodesk.Revit.DB.FaceNode node) => throw new System.NotImplementedException();
	public virtual void OnRPC(Autodesk.Revit.DB.RPCNode node) => throw new System.NotImplementedException();
	public virtual void OnLight(Autodesk.Revit.DB.LightNode node) => throw new System.NotImplementedException();
	public virtual void OnMaterial(Autodesk.Revit.DB.MaterialNode node) => throw new System.NotImplementedException();
	public virtual void OnPolymesh(Autodesk.Revit.DB.PolymeshTopology node) => throw new System.NotImplementedException();
}
