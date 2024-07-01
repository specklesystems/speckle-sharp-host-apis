namespace Autodesk.Revit.DB.Mechanical;

public partial class DuctSizeSettings : Autodesk.Revit.DB.Element,System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Autodesk.Revit.DB.Mechanical.DuctShape, Autodesk.Revit.DB.Mechanical.DuctSizes>>
{
	public virtual Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator GetDuctSizeSettingIterator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Mechanical.DuctSizes get_Item(Autodesk.Revit.DB.Mechanical.DuctShape ductShape) => throw new System.NotImplementedException();
	public virtual System.Int32 GetSizeCount(Autodesk.Revit.DB.Mechanical.DuctShape shape) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Mechanical.DuctSizeSettings GetDuctSizeSettings(Autodesk.Revit.DB.Document aDoc) => throw new System.NotImplementedException();
	public virtual void AddSize(Autodesk.Revit.DB.Mechanical.DuctShape shape,Autodesk.Revit.DB.MEPSize sizeInfo) => throw new System.NotImplementedException();
	public virtual void RemoveSize(Autodesk.Revit.DB.Mechanical.DuctShape shape,System.Double nominalDiameter) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Autodesk.Revit.DB.Mechanical.DuctShape, Autodesk.Revit.DB.Mechanical.DuctSizes>> GetEnumerator() => throw new System.NotImplementedException();
}
