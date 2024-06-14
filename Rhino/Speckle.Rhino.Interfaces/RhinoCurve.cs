namespace Speckle.Rhino7.Interfaces;

public interface IRhinoCurve : IRhinoGeometryBase;

public interface IRhinoGeometryBase : IRhinoCommonObject;

public interface IRhinoCommonObject;

public interface IRhinoObject : IRhinoModelComponent;

public interface IRhinoModelComponent : IRhinoCommonObject;

public interface IRhinoArcCurve : IRhinoCurve;
public interface IRhinoCircle;
