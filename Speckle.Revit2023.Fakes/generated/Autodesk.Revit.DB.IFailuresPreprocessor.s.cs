namespace Autodesk.Revit.DB;

public partial interface IFailuresPreprocessor
{
	public  Autodesk.Revit.DB.FailureProcessingResult PreprocessFailures(Autodesk.Revit.DB.FailuresAccessor failuresAccessor);
}
