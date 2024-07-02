namespace Autodesk.Revit.DB;

public partial class Definitions : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.Definition>,System.IDisposable
{
	public Definitions() {}
	public virtual Autodesk.Revit.DB.Definition get_Item(System.String name) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Definition Create(Autodesk.Revit.DB.ExternalDefinitionCreationOptions option) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(Autodesk.Revit.DB.Definition definition) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Definition> GetEnumerator() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Int32 Size
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsEmpty
	{
		get => throw new System.NotImplementedException();
	}
}
