namespace Autodesk.Revit.DB;

public partial interface IDataConversionMonitor
{
	public  System.Boolean ProcessMessage(Autodesk.Revit.DB.DataExchangeMessageId messageId,Autodesk.Revit.DB.DataExchangeMessageSeverity messageSeverity,IList<System.String> entityIds);
	public  Autodesk.Revit.DB.DataExchangeMessageVerbosity GetVerbosity();
}
