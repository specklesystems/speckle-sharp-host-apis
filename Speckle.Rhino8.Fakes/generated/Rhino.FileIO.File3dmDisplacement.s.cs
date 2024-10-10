namespace Rhino.FileIO;

public partial class File3dmDisplacement
{
  public File3dmDisplacement() { }

  public virtual System.Int32[] GetSubItemFaceIndexes() => throw new System.NotImplementedException();

  public virtual System.Boolean AddSubItem(
    System.Int32 face_index,
    System.Boolean on,
    System.Guid texture,
    System.Int32 mapping_channel,
    System.Double black_point,
    System.Double white_point
  ) => throw new System.NotImplementedException();

  public virtual void DeleteSubItem(System.Int32 face_index) => throw new System.NotImplementedException();

  public virtual void DeleteAllSubItems() => throw new System.NotImplementedException();

  public virtual System.Boolean SubItemOn(System.Int32 face_index) => throw new System.NotImplementedException();

  public virtual void SetSubItemOn(System.Int32 face_index, System.Boolean on) =>
    throw new System.NotImplementedException();

  public virtual System.Guid SubItemTexture(System.Int32 face_index) => throw new System.NotImplementedException();

  public virtual void SetSubItemTexture(System.Int32 face_index, System.Guid texture_id) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 SubItemMappingChannel(System.Int32 face_index) =>
    throw new System.NotImplementedException();

  public virtual void SetSubItemMappingChannel(System.Int32 face_index, System.Int32 chan) =>
    throw new System.NotImplementedException();

  public virtual System.Double SubItemBlackPoint(System.Int32 face_index) => throw new System.NotImplementedException();

  public virtual void SetSubItemBlackPoint(System.Int32 face_index, System.Double black_point) =>
    throw new System.NotImplementedException();

  public virtual System.Double SubItemWhitePoint(System.Int32 face_index) => throw new System.NotImplementedException();

  public virtual void SetSubItemWhitePoint(System.Int32 face_index, System.Double white_point) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean On
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid TextureId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MappingChannel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BlackPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double WhitePoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 InitialQuality
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean FinalMaxFacesOn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 FinalMaxFaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean FairingOn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Fairing
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PostWeldAngle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MeshMemoryLimit
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 RefineSteps
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double RefineSensitivity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.File3dmDisplacement.SweepResolutionFormulas SweepResolutionFormula
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
