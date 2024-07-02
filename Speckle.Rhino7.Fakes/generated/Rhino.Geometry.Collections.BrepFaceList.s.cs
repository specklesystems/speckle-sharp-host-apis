namespace Rhino.Geometry.Collections;

public partial class BrepFaceList
  : System.Collections.Generic.IEnumerable<Rhino.Geometry.BrepFace>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<Rhino.Geometry.BrepFace>
{
  public BrepFaceList() { }

  public virtual System.Boolean ShrinkFaces() => throw new System.NotImplementedException();

  public virtual System.Boolean SplitKinkyFaces() => throw new System.NotImplementedException();

  public virtual System.Boolean SplitKinkyFaces(System.Double kinkTolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SplitKinkyFaces(System.Double kinkTolerance, System.Boolean compact) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SplitKinkyFace(System.Int32 faceIndex, System.Double kinkTolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SplitClosedFaces(System.Int32 minimumDegree) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SplitBipolarFaces() => throw new System.NotImplementedException();

  public virtual System.Boolean SplitFacesAtTangents() => throw new System.NotImplementedException();

  public virtual System.Boolean SplitFaceAtTangents(System.Int32 faceIndex) =>
    throw new System.NotImplementedException();

  public virtual void Flip(System.Boolean onlyReversedFaces) => throw new System.NotImplementedException();

  public virtual void RemoveAt(System.Int32 faceIndex) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ExtractFace(System.Int32 faceIndex) => throw new System.NotImplementedException();

  public virtual System.Boolean StandardizeFaceSurface(System.Int32 faceIndex) =>
    throw new System.NotImplementedException();

  public virtual void StandardizeFaceSurfaces() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepFace Add(System.Int32 surfaceIndex) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepFace Add(Rhino.Geometry.Surface surface) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepFace AddRuledFace(
    Rhino.Geometry.BrepEdge edgeA,
    System.Boolean revEdgeA,
    Rhino.Geometry.BrepEdge edgeB,
    System.Boolean revEdgeB
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepFace AddConeFace(
    Rhino.Geometry.BrepVertex vertex,
    Rhino.Geometry.BrepEdge edge,
    System.Boolean revEdge
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean RemoveSlits() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.BrepFace> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepFace this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
}
