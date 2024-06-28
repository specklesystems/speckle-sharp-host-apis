namespace Autodesk.Revit.DB;

public partial class ExportLayerTable : System.Object
{
	public virtual Autodesk.Revit.DB.ExportLayerTableIterator GetLayerTableIterator() => throw new System.NotImplementedException();
	public static IList<Autodesk.Revit.DB.ModifierType> GetAvaliableLayerModifierTypes(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ExportLayerKey exportLayerKey) => throw new System.NotImplementedException();
	public virtual System.Boolean ContainsKey(Autodesk.Revit.DB.ExportLayerKey exportlayerKey) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExportLayerInfo GetExportLayerInfo(Autodesk.Revit.DB.ExportLayerKey exportLayerKey) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ExportLayerKey> GetKeys() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ExportLayerInfo> GetValues() => throw new System.NotImplementedException();
	public virtual void Add(Autodesk.Revit.DB.ExportLayerKey exportLayerKey,Autodesk.Revit.DB.ExportLayerInfo exportLayerInfo) => throw new System.NotImplementedException();
	public virtual void Remove(Autodesk.Revit.DB.ExportLayerKey exportLayerKey) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual IEnumerator<KeyValuePair<Autodesk.Revit.DB.ExportLayerKey, Autodesk.Revit.DB.ExportLayerInfo>> GetEnumerator() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
}
