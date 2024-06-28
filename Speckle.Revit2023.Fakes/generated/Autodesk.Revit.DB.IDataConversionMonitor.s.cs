namespace Autodesk.Revit.DB;

public partial class IDataConversionMonitor
{
	public virtual System.Boolean ProcessMessage(Autodesk.Revit.DB.DataExchangeMessageId messageId,Autodesk.Revit.DB.DataExchangeMessageSeverity messageSeverity,IList<System.String> entityIds) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DataExchangeMessageVerbosity GetVerbosity() => throw new System.NotImplementedException();
}
