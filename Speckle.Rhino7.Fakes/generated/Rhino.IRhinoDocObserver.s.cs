namespace Rhino;

public partial interface IRhinoDocObserver
{
	public  void RhinoDocClosed(Rhino.RhinoDocObserverArgs e);
	public  void ActiveRhinoDocChanged(Rhino.RhinoDocObserverArgs e);
}
