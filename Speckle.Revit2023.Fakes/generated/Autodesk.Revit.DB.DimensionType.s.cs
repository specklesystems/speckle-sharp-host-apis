namespace Autodesk.Revit.DB;

public partial class DimensionType : Autodesk.Revit.DB.ElementType
{
  public virtual Autodesk.Revit.DB.FormatOptions GetAlternateUnitsFormatOptions() =>
    throw new System.NotImplementedException();

  public virtual void SetAlternateUnitsFormatOptions(Autodesk.Revit.DB.FormatOptions formatOptions) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FormatOptions GetUnitsFormatOptions() => throw new System.NotImplementedException();

  public virtual void SetUnitsFormatOptions(Autodesk.Revit.DB.FormatOptions formatOptions) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ForgeTypeId GetSpecTypeId() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.DimensionEqualityLabelFormatting> GetEqualityFormula() =>
    throw new System.NotImplementedException();

  public virtual void SetEqualityFormula(
    System.Collections.Generic.IList<Autodesk.Revit.DB.DimensionEqualityLabelFormatting> formattingArr
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanHaveEqualityFormula() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.OrdinateDimensionSetting GetOrdinateDimensionSetting() =>
    throw new System.NotImplementedException();

  public virtual void SetOrdinateDimensionSetting(Autodesk.Revit.DB.OrdinateDimensionSetting ordinateDimSetting) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanHaveOrdinateDimensionSetting() => throw new System.NotImplementedException();

  public virtual System.String Suffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Prefix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String AlternateUnitsSuffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String AlternateUnitsPrefix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.AlternateUnits AlternateUnits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.DimensionStyleType StyleType
  {
    get => throw new System.NotImplementedException();
  }
}
