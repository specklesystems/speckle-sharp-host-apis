namespace Autodesk.Revit.DB;

public partial class Color : Autodesk.Revit.DB.APIObject
{
	public Color() {}
	public Color(System.Byte red,System.Byte green,System.Byte blue) => throw new System.NotImplementedException();
	public static  Autodesk.Revit.DB.Color InvalidColorValue
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Byte Blue
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Byte Green
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Byte Red
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
