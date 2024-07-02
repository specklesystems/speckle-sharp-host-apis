namespace Rhino.Geometry;

public partial class Matrix : System.IDisposable
{
	public Matrix() {}
	public Matrix(System.Int32 rowCount,System.Int32 columnCount) => throw new System.NotImplementedException();
	public Matrix(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Matrix Duplicate() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Double get_Item(System.Int32 row,System.Int32 column) => throw new System.NotImplementedException();
	public virtual void set_Item(System.Int32 row,System.Int32 column,System.Double value) => throw new System.NotImplementedException();
	public virtual void Zero() => throw new System.NotImplementedException();
	public virtual void SetDiagonal(System.Double d) => throw new System.NotImplementedException();
	public virtual System.Boolean Transpose() => throw new System.NotImplementedException();
	public virtual System.Boolean SwapRows(System.Int32 rowA,System.Int32 rowB) => throw new System.NotImplementedException();
	public virtual System.Boolean SwapColumns(System.Int32 columnA,System.Int32 columnB) => throw new System.NotImplementedException();
	public virtual System.Boolean Invert(System.Double zeroTolerance) => throw new System.NotImplementedException();
	public virtual void Scale(System.Double s) => throw new System.NotImplementedException();
	public virtual System.Double[] BackSolve(System.Double zeroTolerance,System.Double[] b) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d BackSolvePoints(System.Double zeroTolerance,Rhino.Geometry.Point3d b) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSquare
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 RowCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ColumnCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRowOrthogonal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsColumnOrthogonal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRowOrthoNormal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsColumnOrthoNormal
	{
		get => throw new System.NotImplementedException();
	}
}
