namespace Rhino.Render;

public partial class Utilities
{
	public Utilities() {}
	public static System.Boolean SetDefaultRenderPlugIn(System.Guid pluginId) => throw new System.NotImplementedException();
	public static System.Boolean SafeFrameEnabled(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent ChangeContentType(Rhino.Render.RenderContent oldContent,System.Guid newType,System.Boolean harvestParameters) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderContent LoadPersistentRenderContentFromFile(System.UInt32 docSerialNumber,System.String filename) => throw new System.NotImplementedException();
	public static Rhino.Render.Utilities.ShowContentChooserResults ShowContentChooser(Rhino.RhinoDoc doc,System.Guid defaultType,System.Guid defaultInstanceId,Rhino.Render.RenderContentKind kinds,Rhino.Render.RenderContent.ShowContentChooserFlags flags,System.String presetCategory,System.Collections.Generic.IEnumerable<System.String> categories,System.Collections.Generic.IEnumerable<System.Guid> types,out System.Guid[] instanceIdsOut) => throw new System.NotImplementedException();
	public static Rhino.Render.Utilities.ShowContentChooserResults ShowContentChooser(Rhino.RhinoDoc doc,System.Guid defaultType,System.Guid defaultInstanceId,Rhino.Render.RenderContentKind kinds,Rhino.Render.Utilities.ContentChooserFlags flags,System.String presetCategory,System.Collections.Generic.IEnumerable<System.String> categories,System.Collections.Generic.IEnumerable<System.Guid> types,out System.Guid[] instanceIdsOut) => throw new System.NotImplementedException();
	public static System.String FindFile(Rhino.RhinoDoc doc,System.String fullPathToFile) => throw new System.NotImplementedException();
	public static System.String FindFile(Rhino.RhinoDoc doc,System.String fullPathToFile,System.Boolean unpackFromBitmapTableIfNecessary) => throw new System.NotImplementedException();
	public static System.Boolean IsCachedTextureFileInUse(System.String textureFileName) => throw new System.NotImplementedException();
	public static void MoveWindow(System.IntPtr hwnd,System.Drawing.Rectangle rect,System.Boolean bRepaint,System.Boolean bRepaintNC) => throw new System.NotImplementedException();
	public static System.Guid DefaultRenderPlugInId
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean ShowIncompatibleMaterials
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static System.Boolean ShowIncompatibleEnvironments
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static System.Boolean ShowIncompatibleTextures
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
