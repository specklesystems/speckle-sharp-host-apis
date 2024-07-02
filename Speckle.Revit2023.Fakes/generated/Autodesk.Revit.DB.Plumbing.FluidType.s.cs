namespace Autodesk.Revit.DB.Plumbing;

public partial class FluidType : Autodesk.Revit.DB.ElementType,System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.Plumbing.FluidTemperature>
{
	public FluidType() {}
	public virtual Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator GetFluidTemperatureSetIterator() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plumbing.FluidType Create(Autodesk.Revit.DB.Document document,System.String fluidTypeName,Autodesk.Revit.DB.Plumbing.FluidType basedOnFluidType) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plumbing.FluidType Create(Autodesk.Revit.DB.Document document,System.String fluidTypeName) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plumbing.FluidType GetFluidType(Autodesk.Revit.DB.Document document,System.String fluidTypeName) => throw new System.NotImplementedException();
	public static System.Boolean IsFluidInUse(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId fluidId) => throw new System.NotImplementedException();
	public virtual void ClearAllTemperatures() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Plumbing.FluidTemperature GetTemperature(System.Double temperature) => throw new System.NotImplementedException();
	public virtual void AddTemperature(Autodesk.Revit.DB.Plumbing.FluidTemperature fluidTemperature) => throw new System.NotImplementedException();
	public virtual void RemoveTemperature(System.Double temperature) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Plumbing.FluidTemperature> GetEnumerator() => throw new System.NotImplementedException();
}
