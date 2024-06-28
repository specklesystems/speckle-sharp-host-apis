namespace Autodesk.Revit.DB;

public partial class PartUtils : System.Object
{
	public static void CreateParts(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public static void CreateParts(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.LinkElementId> hostOrLinkElementIds) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.PartMaker DivideParts(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> elementIdsToDivide,ICollection<Autodesk.Revit.DB.ElementId> intersectingReferenceIds,IList<Autodesk.Revit.DB.Curve> curveArray,Autodesk.Revit.DB.ElementId sketchPlaneId) => throw new System.NotImplementedException();
	public static System.Boolean IsValidForCreateParts(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.LinkElementId hostOrLinkElementId) => throw new System.NotImplementedException();
	public static ISet<Autodesk.Revit.DB.ElementId> GetSplittingElements(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId partId) => throw new System.NotImplementedException();
	public static IList<Autodesk.Revit.DB.Curve> GetSplittingCurves(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId partId) => throw new System.NotImplementedException();
	public static System.Boolean AreElementsValidForCreateParts(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public static System.Boolean ArePartsValidForDivide(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> elementIdsToDivide) => throw new System.NotImplementedException();
	public static System.Int32 GetChainLengthToOriginal(Autodesk.Revit.DB.Part part) => throw new System.NotImplementedException();
	public static System.Boolean HasAssociatedParts(Autodesk.Revit.DB.Document hostDocument,Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public static System.Boolean HasAssociatedParts(Autodesk.Revit.DB.Document hostDocument,Autodesk.Revit.DB.LinkElementId hostOrLinkElementId) => throw new System.NotImplementedException();
	public static ICollection<Autodesk.Revit.DB.ElementId> GetAssociatedParts(Autodesk.Revit.DB.Document hostDocument,Autodesk.Revit.DB.ElementId elementId,System.Boolean includePartsWithAssociatedParts,System.Boolean includeAllChildren) => throw new System.NotImplementedException();
	public static ICollection<Autodesk.Revit.DB.ElementId> GetAssociatedParts(Autodesk.Revit.DB.Document hostDocument,Autodesk.Revit.DB.LinkElementId hostOrLinkElementId,System.Boolean includePartsWithAssociatedParts,System.Boolean includeAllChildren) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.PartMaker GetAssociatedPartMaker(Autodesk.Revit.DB.Document hostDocument,Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.PartMaker GetAssociatedPartMaker(Autodesk.Revit.DB.Document hostDocument,Autodesk.Revit.DB.LinkElementId hostOrLinkElementId) => throw new System.NotImplementedException();
	public static System.Boolean ArePartsValidForMerge(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> partIds) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.PartMaker CreateMergedPart(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> partIds) => throw new System.NotImplementedException();
	public static IList<ICollection<Autodesk.Revit.DB.ElementId>> FindMergeableClusters(Autodesk.Revit.DB.Document doc,ICollection<Autodesk.Revit.DB.ElementId> partIds) => throw new System.NotImplementedException();
	public static System.Boolean IsMergedPart(Autodesk.Revit.DB.Part part) => throw new System.NotImplementedException();
	public static ICollection<Autodesk.Revit.DB.ElementId> GetMergedParts(Autodesk.Revit.DB.Part part) => throw new System.NotImplementedException();
	public static System.Boolean IsPartDerivedFromLink(Autodesk.Revit.DB.Part dPart) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.PartMakerMethodToDivideVolumes GetPartMakerMethodToDivideVolumeFW(Autodesk.Revit.DB.PartMaker partMaker) => throw new System.NotImplementedException();
}
