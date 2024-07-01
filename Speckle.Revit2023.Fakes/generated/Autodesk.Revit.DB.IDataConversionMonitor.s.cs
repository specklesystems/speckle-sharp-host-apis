namespace Autodesk.Revit.DB;

public partial interface IDataConversionMonitor
{
	public  System.Boolean ProcessMessage(Autodesk.Revit.DB.DataExchangeMessageId messageId,Autodesk.Revit.DB.DataExchangeMessageSeverity messageSeverity,System.Collections.Generic.IList<System.String> entityIds);
	public  Autodesk.Revit.DB.DataExchangeMessageVerbosity GetVerbosity();
}
