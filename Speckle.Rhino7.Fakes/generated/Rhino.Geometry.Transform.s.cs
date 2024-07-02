namespace Rhino.Geometry;

public partial struct Transform
{
	public Transform() {}
	public Transform(System.Double diagonalValue) => throw new System.NotImplementedException();
	public Transform(Rhino.Geometry.Transform value) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform RotationZYX(System.Double yaw,System.Double pitch,System.Double roll) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform RotationZYZ(System.Double alpha,System.Double beta,System.Double gamma) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Translation(Rhino.Geometry.Vector3d motion) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Translation(System.Double dx,System.Double dy,System.Double dz) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Diagonal(Rhino.Geometry.Vector3d diagonal) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Diagonal(System.Double d0,System.Double d1,System.Double d2) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Scale(Rhino.Geometry.Point3d anchor,System.Double scaleFactor) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Scale(Rhino.Geometry.Plane plane,System.Double xScaleFactor,System.Double yScaleFactor,System.Double zScaleFactor) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Rotation(System.Double sinAngle,System.Double cosAngle,Rhino.Geometry.Vector3d rotationAxis,Rhino.Geometry.Point3d rotationCenter) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Rotation(System.Double angleRadians,Rhino.Geometry.Point3d rotationCenter) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Rotation(System.Double angleRadians,Rhino.Geometry.Vector3d rotationAxis,Rhino.Geometry.Point3d rotationCenter) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Rotation(Rhino.Geometry.Vector3d startDirection,Rhino.Geometry.Vector3d endDirection,Rhino.Geometry.Point3d rotationCenter) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Rotation(Rhino.Geometry.Vector3d x0,Rhino.Geometry.Vector3d y0,Rhino.Geometry.Vector3d z0,Rhino.Geometry.Vector3d x1,Rhino.Geometry.Vector3d y1,Rhino.Geometry.Vector3d z1) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Mirror(Rhino.Geometry.Point3d pointOnMirrorPlane,Rhino.Geometry.Vector3d normalToMirrorPlane) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Mirror(Rhino.Geometry.Plane mirrorPlane) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform ChangeBasis(Rhino.Geometry.Plane plane0,Rhino.Geometry.Plane plane1) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform PlaneToPlane(Rhino.Geometry.Plane plane0,Rhino.Geometry.Plane plane1) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform ChangeBasis(Rhino.Geometry.Vector3d initialBasisX,Rhino.Geometry.Vector3d initialBasisY,Rhino.Geometry.Vector3d initialBasisZ,Rhino.Geometry.Vector3d finalBasisX,Rhino.Geometry.Vector3d finalBasisY,Rhino.Geometry.Vector3d finalBasisZ) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform PlanarProjection(Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform ProjectAlong(Rhino.Geometry.Plane plane,Rhino.Geometry.Vector3d direction) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Shear(Rhino.Geometry.Plane plane,Rhino.Geometry.Vector3d x,Rhino.Geometry.Vector3d y,Rhino.Geometry.Vector3d z) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Multiply(Rhino.Geometry.Transform a,Rhino.Geometry.Transform b) => throw new System.NotImplementedException();
	public  System.Double get_Item(System.Int32 row,System.Int32 column) => throw new System.NotImplementedException();
	public  void set_Item(System.Int32 row,System.Int32 column,System.Double value) => throw new System.NotImplementedException();
	public  System.Boolean IsZeroTransformaton(System.Double zeroTolerance) => throw new System.NotImplementedException();
	public  System.Boolean IsZeroTransformationWithTolerance(System.Double zeroTolerance) => throw new System.NotImplementedException();
	public  Rhino.Geometry.TransformSimilarityType IsSimilarity(System.Double tolerance) => throw new System.NotImplementedException();
	public  Rhino.Geometry.TransformRigidType IsRigid(System.Double tolerance) => throw new System.NotImplementedException();
	public  void Affineize() => throw new System.NotImplementedException();
	public  void Linearize() => throw new System.NotImplementedException();
	public  System.Boolean Orthogonalize(System.Double tolerance) => throw new System.NotImplementedException();
	public  Rhino.Geometry.BoundingBox TransformBoundingBox(Rhino.Geometry.BoundingBox bbox) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d TransformList(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Transform other) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Transpose() => throw new System.NotImplementedException();
	public  System.Single[] ToFloatArray(System.Boolean rowDominant) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Clone() => throw new System.NotImplementedException();
	public  System.Int32 CompareTo(Rhino.Geometry.Transform other) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform Identity
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Transform ZeroTransformation
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Transform Unset
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double M00
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M01
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M02
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M03
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M10
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M11
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M12
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M13
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M20
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M21
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M22
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M23
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M30
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M31
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M32
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double M33
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Boolean IsIdentity
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsZero
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsZero4x4
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsZeroTransformation
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.TransformSimilarityType SimilarityType
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.TransformRigidType RigidType
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsAffine
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsLinear
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsRotation
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Determinant
	{
		get => throw new System.NotImplementedException();
	}
}
