namespace Rhino.Render;

public partial class RenderContent : System.IDisposable
{
	public RenderContent() {}
	public virtual void Uninitialize() => throw new System.NotImplementedException();
	public virtual System.Boolean Replace(Rhino.Render.RenderContent newcontent) => throw new System.NotImplementedException();
	public virtual System.Boolean IsFactoryProductAcceptableAsChild(System.Guid kindId,System.String factoryKind,System.String childSlotName) => throw new System.NotImplementedException();
	public virtual System.Boolean VirtualIcon(System.Drawing.Size size,out System.Drawing.Bitmap bitmap) => throw new System.NotImplementedException();
	public virtual System.Boolean Icon(System.Drawing.Size size,out System.Drawing.Bitmap bitmap) => throw new System.NotImplementedException();
	public virtual System.Boolean DynamicIcon(System.Drawing.Size size,out System.Drawing.Bitmap bitmap,Rhino.Render.DynamicIconUsage usage) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent Create(System.Guid type,Rhino.Render.RenderContent.ShowContentChooserFlags flags,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent Create(System.Type type,Rhino.Render.RenderContent.ShowContentChooserFlags flags,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent Create(System.Guid type,Rhino.Render.RenderContent parent,System.String childSlotName,Rhino.Render.RenderContent.ShowContentChooserFlags flags,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent Create(System.Type type,Rhino.Render.RenderContent parent,System.String childSlotName,Rhino.Render.RenderContent.ShowContentChooserFlags flags,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent Create(Rhino.RhinoDoc doc,System.Guid type) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent Create(Rhino.RhinoDoc doc,System.Type type) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent Create(Rhino.RhinoDoc doc,System.Guid type,Rhino.Render.RenderContent parent,System.String childSlotName) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent Create(Rhino.RhinoDoc doc,System.Type type,Rhino.Render.RenderContent parent,System.String childSlotName) => throw new System.NotImplementedException();
	public static System.Type[] RegisterContent(System.Reflection.Assembly assembly,System.Guid pluginId) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent LoadFromFile(System.String filename) => throw new System.NotImplementedException();
	public static System.Boolean AddPersistentRenderContent(Rhino.Render.RenderContent renderContent) => throw new System.NotImplementedException();
	public static System.Boolean AddPersistentRenderContent(Rhino.RhinoDoc document,Rhino.Render.RenderContent renderContent) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent FromId(Rhino.RhinoDoc document,System.Guid id) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderContent MakeCopy() => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent FromXml(System.String xml) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent FromXml(System.String xml,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public virtual void SetName(System.String name,System.Boolean renameEvents,System.Boolean ensureNameUnique) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderContent ForDisplay() => throw new System.NotImplementedException();
	public virtual System.Boolean IsReference() => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderContent MakeGroupInstance() => throw new System.NotImplementedException();
	public virtual System.Boolean Ungroup() => throw new System.NotImplementedException();
	public virtual System.Boolean UngroupRecursive() => throw new System.NotImplementedException();
	public virtual System.Boolean SmartUngroupRecursive() => throw new System.NotImplementedException();
	public virtual System.Int32 UseCount() => throw new System.NotImplementedException();
	public virtual void SetRenderHash(System.UInt32 hash) => throw new System.NotImplementedException();
	public virtual System.Boolean IsRenderHashCached() => throw new System.NotImplementedException();
	public virtual void SetIsRenderHashRecursive(System.Boolean recursive) => throw new System.NotImplementedException();
	public virtual System.UInt32 RenderHashExclude(Rhino.Render.TextureRenderHashFlags flags,System.String excludeParameterNames) => throw new System.NotImplementedException();
	public virtual System.UInt32 RenderHashExclude(Rhino.Render.CrcRenderHashFlags flags,System.String excludeParameterNames) => throw new System.NotImplementedException();
	public virtual System.UInt32 RenderHashExclude(Rhino.Render.CrcRenderHashFlags flags,System.String excludeParameterNames,Rhino.Render.LinearWorkflow lw) => throw new System.NotImplementedException();
	public virtual System.Boolean OpenInEditor() => throw new System.NotImplementedException();
	public virtual System.Boolean OpenInModalEditor() => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderContent Edit() => throw new System.NotImplementedException();
	public virtual void BeginChange(Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual void EndChange() => throw new System.NotImplementedException();
	public virtual System.Boolean AddAutomaticUserInterfaceSection(System.String caption,System.Int32 id) => throw new System.NotImplementedException();
	public virtual System.UInt64 GetUiHash() => throw new System.NotImplementedException();
	public virtual System.Boolean IsContentTypeAcceptableAsChild(System.Guid type,System.String childSlotName) => throw new System.NotImplementedException();
	public virtual void ConvertUnits(Rhino.UnitSystem from,Rhino.UnitSystem to) => throw new System.NotImplementedException();
	public virtual System.Object GetParameter(System.String parameterName) => throw new System.NotImplementedException();
	public virtual System.Boolean SetParameter(System.String parameterName,System.Object value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual System.Boolean SetParameter(System.String parameterName,System.Object value) => throw new System.NotImplementedException();
	public virtual System.Object GetChildSlotParameter(System.String contentParameterName,System.String extraRequirementParameter) => throw new System.NotImplementedException();
	public virtual System.Object GetExtraRequirementParameter(System.String contentParameterName,System.String extraRequirementParameter) => throw new System.NotImplementedException();
	public virtual System.Boolean SetChildSlotParameter(System.String contentParameterName,System.String extraRequirementParameter,System.Object value,Rhino.Render.RenderContent.ExtraRequirementsSetContexts sc) => throw new System.NotImplementedException();
	public virtual System.Boolean SetExtraRequirementParameter(System.String contentParameterName,System.String extraRequirementParameter,System.Object value,Rhino.Render.RenderContent.ExtraRequirementsSetContexts sc) => throw new System.NotImplementedException();
	public virtual System.Boolean ChildSlotOn(System.String childSlotName) => throw new System.NotImplementedException();
	public virtual void SetChildSlotOn(System.String childSlotName,System.Boolean bOn,Rhino.Render.RenderContent.ChangeContexts cc) => throw new System.NotImplementedException();
	public virtual System.Double ChildSlotAmount(System.String childSlotName) => throw new System.NotImplementedException();
	public virtual void SetChildSlotAmount(System.String childSlotName,System.Double amount,Rhino.Render.RenderContent.ChangeContexts cc) => throw new System.NotImplementedException();
	public virtual Rhino.Render.PreviewSceneServer NewPreviewSceneServer(Rhino.Render.SceneServerData ssd) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderContent.MatchDataResult MatchData(Rhino.Render.RenderContent oldContent) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCompatible(System.Guid renderEngineId) => throw new System.NotImplementedException();
	public virtual System.String ChildSlotNameFromParamName(System.String paramName) => throw new System.NotImplementedException();
	public virtual System.String ParamNameFromChildSlotName(System.String childSlotName) => throw new System.NotImplementedException();
	public virtual void BeginCreateDynamicFields(System.Boolean automatic) => throw new System.NotImplementedException();
	public virtual System.Boolean CreateDynamicField(System.String internalName,System.String localName,System.String englishName,System.Object value,System.Object minValue,System.Object maxValue,System.Int32 sectionId) => throw new System.NotImplementedException();
	public virtual void EndCreateDynamicFields() => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderContent FindChild(System.String childSlotName) => throw new System.NotImplementedException();
	public virtual System.Boolean SetChild(Rhino.Render.RenderContent renderContent,System.String childSlotName) => throw new System.NotImplementedException();
	public virtual System.Boolean SetChild(Rhino.Render.RenderContent renderContent,System.String childSlotName,Rhino.Render.RenderContent.ChangeContexts changeContexts) => throw new System.NotImplementedException();
	public virtual System.Boolean AddChild(Rhino.Render.RenderContent renderContent) => throw new System.NotImplementedException();
	public virtual System.Boolean AddChild(Rhino.Render.RenderContent renderContent,System.String childSlotName) => throw new System.NotImplementedException();
	public virtual System.Boolean DeleteChild(System.String childSlotName,Rhino.Render.RenderContent.ChangeContexts changeContexts) => throw new System.NotImplementedException();
	public virtual void DeleteAllChildren(Rhino.Render.RenderContent.ChangeContexts changeContexts) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeChild(Rhino.Render.RenderContent oldContent,Rhino.Render.RenderContent newContent) => throw new System.NotImplementedException();
	public virtual System.String[] GetEmbeddedFilesList() => throw new System.NotImplementedException();
	public virtual System.Boolean Initialize() => throw new System.NotImplementedException();
	public virtual System.IntPtr CppPointer
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String TypeName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String TypeDescription
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String DisplayName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Notes
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Tags
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ChildSlotDisplayName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Category
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid Id
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid TypeId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid GroupId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.UInt32 RenderHash
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean TopLevel
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Hidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsHiddenByAutoDelete
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CanBeEdited
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDefaultInstance
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.ProxyTypes ProxyType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderContent Parent
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderContent FirstChild
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderContent NextSibling
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderContent TopLevelParent
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.RhinoDoc DocumentOwner
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.RhinoDoc DocumentRegistered
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.RhinoDoc DocumentAssoc
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Xml
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsLocked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ChildSlotName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Collections.Generic.IEnumerable<System.String> FilesToEmbed
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Filename
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Render.RenderContentStyles Styles
	{
		get => throw new System.NotImplementedException();
	}
}
