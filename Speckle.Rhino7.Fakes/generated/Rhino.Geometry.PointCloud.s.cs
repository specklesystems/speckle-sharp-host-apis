namespace Rhino.Geometry;

public partial class PointCloud : Rhino.Geometry.GeometryBase,System.Collections.Generic.IEnumerable<Rhino.Geometry.PointCloudItem>
{
	public PointCloud() {}
	public PointCloud(Rhino.Geometry.PointCloud other) => throw new System.NotImplementedException();
	public PointCloud(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public virtual void ClearColors() => throw new System.NotImplementedException();
	public virtual void ClearNormals() => throw new System.NotImplementedException();
	public virtual void ClearHiddenFlags() => throw new System.NotImplementedException();
	public virtual void ClearPointValues() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointCloudItem AppendNew() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointCloudItem InsertNew(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void Merge(Rhino.Geometry.PointCloud other) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d normal) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Point3d point,System.Drawing.Color color) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d normal,System.Drawing.Color color) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d normal,System.Drawing.Color color,System.Double value) => throw new System.NotImplementedException();
	public virtual void AddRange(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public virtual void AddRange(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Collections.Generic.IEnumerable<Rhino.Geometry.Vector3d> normals) => throw new System.NotImplementedException();
	public virtual void AddRange(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Collections.Generic.IEnumerable<System.Drawing.Color> colors) => throw new System.NotImplementedException();
	public virtual void AddRange(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Collections.Generic.IEnumerable<Rhino.Geometry.Vector3d> normals,System.Collections.Generic.IEnumerable<System.Drawing.Color> colors) => throw new System.NotImplementedException();
	public virtual void AddRange(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Collections.Generic.IEnumerable<Rhino.Geometry.Vector3d> normals,System.Collections.Generic.IEnumerable<System.Drawing.Color> colors,System.Collections.Generic.IEnumerable<System.Double> values) => throw new System.NotImplementedException();
	public virtual void Insert(System.Int32 index,Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual void Insert(System.Int32 index,Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d normal) => throw new System.NotImplementedException();
	public virtual void Insert(System.Int32 index,Rhino.Geometry.Point3d point,System.Drawing.Color color) => throw new System.NotImplementedException();
	public virtual void Insert(System.Int32 index,Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d normal,System.Drawing.Color color) => throw new System.NotImplementedException();
	public virtual void Insert(System.Int32 index,Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d normal,System.Drawing.Color color,System.Double value) => throw new System.NotImplementedException();
	public virtual void InsertRange(System.Int32 index,System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public virtual void RemoveAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Int32 RemoveRange(System.Collections.Generic.IEnumerable<System.Int32> indices) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d[] GetPoints() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d PointAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d[] GetNormals() => throw new System.NotImplementedException();
	public virtual System.Drawing.Color[] GetColors() => throw new System.NotImplementedException();
	public virtual System.Double[] GetPointValues() => throw new System.NotImplementedException();
	public virtual System.Int32 ClosestPoint(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointCloud GetRandomSubsample(System.UInt32 numberOfPoints) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointCloud GetRandomSubsample(System.UInt32 numberOfPoints,System.Threading.CancellationToken cancelToken,System.IProgress<System.Double> progress) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointCloudUnsafeLock GetUnsafeLock(System.Boolean writable) => throw new System.NotImplementedException();
	public virtual void ReleaseUnsafeLock(Rhino.Geometry.PointCloudUnsafeLock pointCloudData) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IReadOnlyList<Rhino.Geometry.Point3d> AsReadOnlyListOfPoints() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.PointCloudItem> GetEnumerator() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.PointCloudItem this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 HiddenPointCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ContainsColors
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ContainsNormals
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ContainsHiddenFlags
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ContainsPointValues
	{
		get => throw new System.NotImplementedException();
	}
}
