namespace Rhino.Display;

public partial class DisplayModeDescription : System.IDisposable,System.Runtime.Serialization.ISerializable
{
	public DisplayModeDescription() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public static Rhino.Display.DisplayModeDescription[] GetDisplayModes() => throw new System.NotImplementedException();
	public static Rhino.Display.DisplayModeDescription GetDisplayMode(System.Guid id) => throw new System.NotImplementedException();
	public static Rhino.Display.DisplayModeDescription FindByName(System.String englishName) => throw new System.NotImplementedException();
	public static System.Guid AddDisplayMode(Rhino.Display.DisplayModeDescription displayMode) => throw new System.NotImplementedException();
	public static System.Guid AddDisplayMode(System.String name) => throw new System.NotImplementedException();
	public static System.Guid CopyDisplayMode(System.Guid id,System.String name) => throw new System.NotImplementedException();
	public static System.Boolean UpdateDisplayMode(Rhino.Display.DisplayModeDescription displayMode) => throw new System.NotImplementedException();
	public static System.Boolean DeleteDiplayMode(System.Guid id) => throw new System.NotImplementedException();
	public static System.Boolean DeleteDisplayMode(System.Guid id) => throw new System.NotImplementedException();
	public static System.Guid ImportFromFile(System.String filename) => throw new System.NotImplementedException();
	public static System.Boolean ExportToFile(Rhino.Display.DisplayModeDescription displayMode,System.String filename) => throw new System.NotImplementedException();
	void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context) => throw new System.NotImplementedException();
	public virtual System.Boolean InMenu
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean SupportsShadeCommand
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean SupportsShading
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AllowObjectAssignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShadedPipelineRequired
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean WireframePipelineRequired
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean PipelineLocked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.DisplayPipelineAttributes DisplayAttributes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String EnglishName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LocalName
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid ArtisticId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid GhostedId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid PenId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid RenderedId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid RenderedShadowsId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid ShadedId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid TechId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid WireframeId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid XRayId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid AmbientOcclusionId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid RaytracedId
	{
		get => throw new System.NotImplementedException();
	}
}
