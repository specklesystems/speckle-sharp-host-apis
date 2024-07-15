namespace Autodesk.Revit.DB.Architecture;

public partial class StairsPath : Autodesk.Revit.DB.Element
{
	public StairsPath() {}
	public static Autodesk.Revit.DB.Architecture.StairsPath Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.LinkElementId stairsId,Autodesk.Revit.DB.ElementId typeId,Autodesk.Revit.DB.ElementId planViewId) => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.Architecture.StairsPath> CreateOnMultistoryStairs(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.LinkElementId multistoryStairsId,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public static System.Boolean CanCreateOnMultistoryStairs(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.LinkElementId multistoryStairsId) => throw new System.NotImplementedException();
	public virtual System.Boolean ShowDownText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowUpText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Architecture.StairsTextOrientation TextOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.LinkElementId StairsId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double StairsPathOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ UpTextOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ DownTextOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String DownText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String UpText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
