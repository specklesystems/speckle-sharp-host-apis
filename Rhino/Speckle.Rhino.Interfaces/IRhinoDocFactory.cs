namespace Speckle.Rhino7.Interfaces;

public interface IRhinoDocFactory
{
  IRhinoDoc ActiveDoc();

  IRhinoLayer CreateLayer(string name);
  IRhinoLayer CreateLayer(string name, Guid parentLayerId);

  IRhinoObjectAttributes CreateAttributes(int layerIndex);
  
  int UnsetIntIndex { get; }
  string LayerPathSeparator { get; }
}
