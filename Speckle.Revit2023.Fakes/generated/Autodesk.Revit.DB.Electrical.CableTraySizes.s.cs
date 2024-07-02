namespace Autodesk.Revit.DB.Electrical;

public partial class CableTraySizes : Autodesk.Revit.DB.Element,System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.MEPSize>
{
	public CableTraySizes() {}
	public virtual System.Int32 GetSizeCount() => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(System.Double nominalDiameter) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Electrical.CableTraySizes GetCableTraySizes(Autodesk.Revit.DB.Document aDoc) => throw new System.NotImplementedException();
	public virtual void AddSize(Autodesk.Revit.DB.MEPSize sizeInfo) => throw new System.NotImplementedException();
	public virtual void RemoveSize(Autodesk.Revit.DB.MEPSize sizeInfo) => throw new System.NotImplementedException();
	public virtual void ClearAll() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.CableTraySizeIterator GetCableTraySizesIterator() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.MEPSize> GetEnumerator() => throw new System.NotImplementedException();
}
