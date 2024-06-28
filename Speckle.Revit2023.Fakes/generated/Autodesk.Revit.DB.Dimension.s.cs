namespace Autodesk.Revit.DB;

public partial class Dimension : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.ReferenceArray get_References() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve get_Curve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.View get_View() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DimensionType get_DimensionType() => throw new System.NotImplementedException();
	public virtual void set_DimensionType(Autodesk.Revit.DB.DimensionType newType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter get_FamilyLabel() => throw new System.NotImplementedException();
	public virtual void set_FamilyLabel(Autodesk.Revit.DB.FamilyParameter famPara) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DimensionShape get_DimensionShape() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DimensionSegmentArray get_Segments() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_LeaderEndPosition() => throw new System.NotImplementedException();
	public virtual void set_LeaderEndPosition(Autodesk.Revit.DB.XYZ leaderPnt) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_Origin() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_TextPosition() => throw new System.NotImplementedException();
	public virtual void set_TextPosition(Autodesk.Revit.DB.XYZ position) => throw new System.NotImplementedException();
	public virtual void ResetTextPosition() => throw new System.NotImplementedException();
}
