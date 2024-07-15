namespace Autodesk.Revit.DB;

public enum CompoundStructureError
{
	BadShellOrder,
	CoreTooThin,
	MembraneTooThick,
	NonmembraneTooThin,
	BadShellsStructure,
	ThinOuterLayer,
	VerticalUnusedLayer,
	VerticalWrongOrderLayer,
	VerticalWrongOrderCoreExterior,
	VerticalWrongOrderCoreInterior,
	VerticalWrongOrderMembrane,
	DeckCantBoundAbove,
	DeckCantBoundBelow,
	VarThickLayerCantBeZero,
	InvalidMaterialId,
	ExtensibleRegionsNotContiguousAlongTop,
	ExtensibleRegionsNotContiguousAlongBottom,
	InvalidProfileId,
}
