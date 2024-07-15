namespace Autodesk.Revit.DB.Mechanical;

public partial class MechanicalSystemType : Autodesk.Revit.DB.MEPSystemType
{
	public MechanicalSystemType() {}
	public static Autodesk.Revit.DB.Mechanical.MechanicalSystemType Create(Autodesk.Revit.DB.Document ADoc,Autodesk.Revit.DB.MEPSystemClassification systemClassification,System.String name) => throw new System.NotImplementedException();
	public virtual System.Boolean ValidateRiseDropSymbolType(Autodesk.Revit.DB.Mechanical.RiseDropSymbol risedropType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Mechanical.RiseDropSymbol RiseDropSettings
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
