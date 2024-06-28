namespace Autodesk.Revit.DB;

public enum FamilySizeTableErrorType
{
	Undefined,
	FileNotFound,
	CannotOpenFile,
	CannotReadFile,
	InvalidHeaderSeparator,
	CannotParseColumnHeader,
	IncorrectNumberOfColumns,
}
