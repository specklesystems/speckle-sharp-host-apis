namespace Rhino;

public partial class PersistentSettings : System.Runtime.Serialization.ISerializable
{
  public PersistentSettings() { }

  public virtual Rhino.Geometry.Point3d GetPoint3d(System.String key, Rhino.Geometry.Point3d defaultValue) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d GetPoint3d(
    System.String key,
    Rhino.Geometry.Point3d defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetSize(System.String key, out System.Drawing.Size value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetSize(
    System.String key,
    out System.Drawing.Size value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Drawing.Size GetSize(System.String key) => throw new System.NotImplementedException();

  public virtual System.Drawing.Size GetSize(System.String key, System.Drawing.Size defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Size GetSize(
    System.String key,
    System.Drawing.Size defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetRectangle(System.String key, out System.Drawing.Rectangle value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetRectangle(
    System.String key,
    out System.Drawing.Rectangle value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Drawing.Rectangle GetRectangle(System.String key) => throw new System.NotImplementedException();

  public virtual System.Drawing.Rectangle GetRectangle(System.String key, System.Drawing.Rectangle defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Rectangle GetRectangle(
    System.String key,
    System.Drawing.Rectangle defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.Boolean value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.Byte value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.Int32 value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.Char value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.String[] value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.DateTime value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.Drawing.Color value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out Rhino.Geometry.Point3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.Drawing.Size value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDefault(System.String key, out System.Drawing.Rectangle value) =>
    throw new System.NotImplementedException();

  public virtual T GetEnumValue<T>(T defaultValue) => throw new System.NotImplementedException();

  public virtual T GetEnumValue<T>(System.String key, T defaultValue) => throw new System.NotImplementedException();

  public virtual T GetEnumValue<T>(System.String key) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetEnumValue<T>(System.String key, out T enumValue) =>
    throw new System.NotImplementedException();

  public virtual void SetGuid(System.String key, System.Guid value) => throw new System.NotImplementedException();

  public virtual void SetBool(System.String key, System.Boolean value) => throw new System.NotImplementedException();

  public virtual void SetByte(System.String key, System.Byte value) => throw new System.NotImplementedException();

  public virtual void SetInteger(System.String key, System.Int32 value) => throw new System.NotImplementedException();

  public virtual void SetUnsignedInteger(System.String key, System.UInt32 value) =>
    throw new System.NotImplementedException();

  public virtual void SetDouble(System.String key, System.Double value) => throw new System.NotImplementedException();

  public virtual void SetChar(System.String key, System.Char value) => throw new System.NotImplementedException();

  public virtual void SetString(System.String key, System.String value) => throw new System.NotImplementedException();

  public virtual void SetStringList(System.String key, System.String[] value) =>
    throw new System.NotImplementedException();

  public virtual void DeleteItem(System.String key) => throw new System.NotImplementedException();

  public virtual void SetDate(System.String key, System.DateTime value) => throw new System.NotImplementedException();

  public virtual void SetColor(System.String key, System.Drawing.Color value) =>
    throw new System.NotImplementedException();

  public virtual void SetPoint3d(System.String key, Rhino.Geometry.Point3d value) =>
    throw new System.NotImplementedException();

  public virtual void SetRectangle(System.String key, System.Drawing.Rectangle value) =>
    throw new System.NotImplementedException();

  public virtual void SetSize(System.String key, System.Drawing.Size value) =>
    throw new System.NotImplementedException();

  public virtual void SetPoint(System.String key, System.Drawing.Point value) =>
    throw new System.NotImplementedException();

  public virtual void SetEnumValue<T>(T enumValue) => throw new System.NotImplementedException();

  public virtual void SetEnumValue<T>(System.String key, T value) => throw new System.NotImplementedException();

  public virtual Rhino.PersistentSettings GetChild(System.String key) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetChild(System.String key, out Rhino.PersistentSettings value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetSettingType(System.String key, out System.Type type) =>
    throw new System.NotImplementedException();

  public virtual System.Type GetSettingType(System.String key) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetSettingIsReadOnly(System.String key, out System.Boolean value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetSettingIsReadOnly(System.String key) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetSettingIsHiddenFromUserInterface(System.String key, out System.Boolean value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetSettingIsHiddenFromUserInterface(
    System.String key,
    out System.Boolean value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetSettingIsHiddenFromUserInterface(System.String key) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetSettingIsHiddenFromUserInterface(
    System.String key,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual void HideSettingFromUserInterface(System.String key) => throw new System.NotImplementedException();

  public virtual Rhino.PersistentSettings AddChild(System.String key) => throw new System.NotImplementedException();

  public virtual void DeleteChild(System.String key) => throw new System.NotImplementedException();

  public static Rhino.PersistentSettings FromPlugInId(System.Guid pluginId) =>
    throw new System.NotImplementedException();

  public virtual void RegisterSettingsValidator<T>(
    System.String key,
    System.EventHandler<Rhino.PersistentSettingsEventArgs<T>> validator
  ) => throw new System.NotImplementedException();

  public virtual System.EventHandler<Rhino.PersistentSettingsEventArgs<T>> GetValidator<T>(System.String key) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ContainsChangedValues() => throw new System.NotImplementedException();

  public virtual void ClearChangedFlag() => throw new System.NotImplementedException();

  public virtual System.Boolean ContainsModifiedValues(Rhino.PersistentSettings allUserSettings) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetGuid(System.String key, out System.Guid value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetGuid(
    System.String key,
    out System.Guid value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetBool(System.String key, out System.Boolean value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetBool(
    System.String key,
    out System.Boolean value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetBool(System.String key) => throw new System.NotImplementedException();

  public virtual System.Boolean GetBool(System.String key, System.Boolean defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetBool(
    System.String key,
    System.Boolean defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetByte(System.String key, out System.Byte value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetByte(
    System.String key,
    out System.Byte value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Byte GetByte(System.String key) => throw new System.NotImplementedException();

  public virtual System.Byte GetByte(System.String key, System.Byte defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Byte GetByte(
    System.String key,
    System.Byte defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetInteger(System.String key, out System.Int32 value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetInteger(
    System.String key,
    out System.Int32 value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetInteger(System.String key) => throw new System.NotImplementedException();

  public virtual System.Int32 GetInteger(System.String key, System.Int32 defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetInteger(
    System.String key,
    System.Int32 defaultValue,
    System.Int32 bound,
    System.Boolean boundIsLower
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetInteger(
    System.String key,
    System.Int32 defaultValue,
    System.Int32 lowerBound,
    System.Int32 upperBound
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetInteger(
    System.String key,
    System.Int32 defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetUnsignedInteger(System.String key, out System.UInt32 value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetUnsignedInteger(
    System.String key,
    out System.UInt32 value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.UInt32 GetUnsignedInteger(System.String key) => throw new System.NotImplementedException();

  public virtual System.UInt32 GetUnsignedInteger(System.String key, System.UInt32 defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.UInt32 GetUnsignedInteger(
    System.String key,
    System.UInt32 defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDouble(System.String key, out System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDouble(
    System.String key,
    out System.Double value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Double GetDouble(System.String key) => throw new System.NotImplementedException();

  public virtual System.Double GetDouble(System.String key, System.Double defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetDouble(
    System.String key,
    System.Double defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetChar(System.String key, out System.Char value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetChar(
    System.String key,
    out System.Char value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Char GetChar(System.String key) => throw new System.NotImplementedException();

  public virtual System.Char GetChar(System.String key, System.Char defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Char GetChar(
    System.String key,
    System.Char defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetString(System.String key, out System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetString(
    System.String key,
    out System.String value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.String GetString(System.String key) => throw new System.NotImplementedException();

  public virtual System.String GetString(System.String key, System.String defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.String GetString(
    System.String key,
    System.String defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetStringList(System.String key, out System.String[] value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetStringList(
    System.String key,
    out System.String[] value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.String[] GetStringList(System.String key) => throw new System.NotImplementedException();

  public virtual System.String[] GetStringList(System.String key, System.String[] defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.String[] GetStringList(
    System.String key,
    System.String[] defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDate(System.String key, out System.DateTime value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDate(
    System.String key,
    out System.DateTime value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.DateTime GetDate(System.String key) => throw new System.NotImplementedException();

  public virtual System.DateTime GetDate(System.String key, System.DateTime defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.DateTime GetDate(
    System.String key,
    System.DateTime defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetColor(System.String key, out System.Drawing.Color value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetColor(
    System.String key,
    out System.Drawing.Color value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Drawing.Color GetColor(System.String key) => throw new System.NotImplementedException();

  public virtual System.Drawing.Color GetColor(System.String key, System.Drawing.Color defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Color GetColor(
    System.String key,
    System.Drawing.Color defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Guid GetGuid(System.String key) => throw new System.NotImplementedException();

  public virtual System.Guid GetGuid(System.String key, System.Guid defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Guid GetGuid(
    System.String key,
    System.Guid defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoint(System.String key, out System.Drawing.Point value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoint(
    System.String key,
    out System.Drawing.Point value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Drawing.Point GetPoint(System.String key) => throw new System.NotImplementedException();

  public virtual System.Drawing.Point GetPoint(System.String key, System.Drawing.Point defaultValue) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Point GetPoint(
    System.String key,
    System.Drawing.Point defaultValue,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoint3d(System.String key, out Rhino.Geometry.Point3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoint3d(
    System.String key,
    out Rhino.Geometry.Point3d value,
    System.Collections.Generic.IEnumerable<System.String> legacyKeyList
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d GetPoint3d(System.String key) => throw new System.NotImplementedException();

  void System.Runtime.Serialization.ISerializable.GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HiddenFromUserInterface
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Collections.Generic.ICollection<System.String> Keys
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.ICollection<System.String> ChildKeys
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.PersistentSettings RhinoAppSettings
  {
    get => throw new System.NotImplementedException();
  }
  public static System.String StringListRootKey
  {
    get => throw new System.NotImplementedException();
  }
}
