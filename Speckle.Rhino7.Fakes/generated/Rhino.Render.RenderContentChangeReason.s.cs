namespace Rhino.Render;

public enum RenderContentChangeReason
{
	None,
	Attach,
	Detach,
	ChangeAttach,
	ChangeDetach,
	AttachUndo,
	DetachUndo,
	Open,
	Delete,
}
