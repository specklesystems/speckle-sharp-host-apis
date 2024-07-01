namespace Autodesk.Revit.DB;

public partial class FormatOptions : System.IDisposable
{
  public FormatOptions() { }

  public FormatOptions(Autodesk.Revit.DB.FormatOptions other) => throw new System.NotImplementedException();

  public FormatOptions(Autodesk.Revit.DB.ForgeTypeId unitTypeId, Autodesk.Revit.DB.ForgeTypeId symbolTypeId) =>
    throw new System.NotImplementedException();

  public FormatOptions(Autodesk.Revit.DB.ForgeTypeId unitTypeId) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ForgeTypeId GetUnitTypeId() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FormatOptions SetUnitTypeId(Autodesk.Revit.DB.ForgeTypeId unitTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidForSpec(Autodesk.Revit.DB.ForgeTypeId specTypeId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ForgeTypeId GetSymbolTypeId() => throw new System.NotImplementedException();

  public virtual void SetSymbolTypeId(Autodesk.Revit.DB.ForgeTypeId symbolTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanHaveSymbol() => throw new System.NotImplementedException();

  public static System.Boolean CanHaveSymbol(Autodesk.Revit.DB.ForgeTypeId unitTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidSymbol(Autodesk.Revit.DB.ForgeTypeId symbolTypeId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidSymbol(
    Autodesk.Revit.DB.ForgeTypeId unitTypeId,
    Autodesk.Revit.DB.ForgeTypeId symbolTypeId
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ForgeTypeId> GetValidSymbols() =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.ForgeTypeId> GetValidSymbols(
    Autodesk.Revit.DB.ForgeTypeId unitTypeId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidAccuracy(System.Double accuracy) => throw new System.NotImplementedException();

  public static System.Boolean IsValidAccuracy(Autodesk.Revit.DB.ForgeTypeId unitTypeId, System.Double accuracy) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanSuppressTrailingZeros() => throw new System.NotImplementedException();

  public static System.Boolean CanSuppressTrailingZeros(Autodesk.Revit.DB.ForgeTypeId unitTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanSuppressLeadingZeros() => throw new System.NotImplementedException();

  public static System.Boolean CanSuppressLeadingZeros(Autodesk.Revit.DB.ForgeTypeId unitTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanSuppressSpaces() => throw new System.NotImplementedException();

  public static System.Boolean CanSuppressSpaces(Autodesk.Revit.DB.ForgeTypeId unitTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanUsePlusPrefix() => throw new System.NotImplementedException();

  public static System.Boolean CanUsePlusPrefix(Autodesk.Revit.DB.ForgeTypeId unitTypeId) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.RoundingMethod RoundingMethod
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseDigitGrouping
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UsePlusPrefix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SuppressSpaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SuppressLeadingZeros
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SuppressTrailingZeros
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Accuracy
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseDefault
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
