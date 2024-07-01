namespace Autodesk.Revit.DB.Structure;

public partial class FabricWireType : Autodesk.Revit.DB.ElementType
{
  public FabricWireType() { }

  public static Autodesk.Revit.DB.ElementId CreateDefaultFabricWireType(Autodesk.Revit.DB.Document ADoc) =>
    throw new System.NotImplementedException();

  public virtual System.Double BendDiameter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double WireDiameter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
