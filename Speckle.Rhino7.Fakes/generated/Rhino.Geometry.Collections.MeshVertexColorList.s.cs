namespace Rhino.Geometry.Collections;

public partial class MeshVertexColorList : Rhino.Collections.IResizableList<System.Drawing.Color>,System.Collections.Generic.IList<System.Drawing.Color>,System.Collections.Generic.ICollection<System.Drawing.Color>,System.Collections.Generic.IEnumerable<System.Drawing.Color>,System.Collections.IEnumerable,System.Collections.IList,System.Collections.ICollection,System.Collections.Generic.IReadOnlyList<System.Drawing.Color>,System.Collections.Generic.IReadOnlyCollection<System.Drawing.Color>
{
	public MeshVertexColorList() {}
	public virtual System.Int32[] ToARGBArray() => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual System.Int32 Add(System.Int32 red,System.Int32 green,System.Int32 blue) => throw new System.NotImplementedException();
	public virtual System.Int32 Add(System.Drawing.Color color) => throw new System.NotImplementedException();
	public virtual System.Boolean SetColor(System.Int32 index,System.Int32 red,System.Int32 green,System.Int32 blue) => throw new System.NotImplementedException();
	public virtual System.Boolean SetColor(System.Int32 index,System.Drawing.Color color) => throw new System.NotImplementedException();
	public virtual System.Boolean SetColor(Rhino.Geometry.MeshFace face,System.Drawing.Color color) => throw new System.NotImplementedException();
	public virtual System.Boolean CreateMonotoneMesh(System.Drawing.Color baseColor) => throw new System.NotImplementedException();
	public virtual System.Boolean SetColors(System.Drawing.Color[] colors) => throw new System.NotImplementedException();
	public virtual System.Boolean AppendColors(System.Drawing.Color[] colors) => throw new System.NotImplementedException();
	public virtual void Destroy() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<System.Drawing.Color> GetEnumerator() => throw new System.NotImplementedException();
	System.Int32 System.Collections.Generic.IList<System.Drawing.Color>.IndexOf(System.Drawing.Color item) => throw new System.NotImplementedException();
	void System.Collections.Generic.IList<System.Drawing.Color>.Insert(System.Int32 index,System.Drawing.Color item) => throw new System.NotImplementedException();
	void System.Collections.Generic.IList<System.Drawing.Color>.RemoveAt(System.Int32 index) => throw new System.NotImplementedException();
	void System.Collections.Generic.ICollection<System.Drawing.Color>.Add(System.Drawing.Color item) => throw new System.NotImplementedException();
	System.Boolean System.Collections.Generic.ICollection<System.Drawing.Color>.Contains(System.Drawing.Color item) => throw new System.NotImplementedException();
	void System.Collections.Generic.ICollection<System.Drawing.Color>.CopyTo(System.Drawing.Color[] array,System.Int32 arrayIndex) => throw new System.NotImplementedException();
	System.Boolean System.Collections.Generic.ICollection<System.Drawing.Color>.Remove(System.Drawing.Color item) => throw new System.NotImplementedException();
	System.Int32 System.Collections.IList.Add(System.Object value) => throw new System.NotImplementedException();
	System.Boolean System.Collections.IList.Contains(System.Object value) => throw new System.NotImplementedException();
	System.Int32 System.Collections.IList.IndexOf(System.Object value) => throw new System.NotImplementedException();
	void System.Collections.IList.Insert(System.Int32 index,System.Object value) => throw new System.NotImplementedException();
	void System.Collections.IList.Remove(System.Object value) => throw new System.NotImplementedException();
	void System.Collections.IList.RemoveAt(System.Int32 index) => throw new System.NotImplementedException();
	void System.Collections.ICollection.CopyTo(System.Array array,System.Int32 index) => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Drawing.Color this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Render.MappingTag Tag
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Capacity
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	System.Boolean System.Collections.Generic.ICollection<System.Drawing.Color>.IsReadOnly
	{
		get => throw new System.NotImplementedException();
	}
	System.Boolean System.Collections.IList.IsFixedSize
	{
		get => throw new System.NotImplementedException();
	}
	System.Boolean System.Collections.IList.IsReadOnly
	{
		get => throw new System.NotImplementedException();
	}
	System.Object System.Collections.IList.this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	System.Boolean System.Collections.ICollection.IsSynchronized
	{
		get => throw new System.NotImplementedException();
	}
	System.Object System.Collections.ICollection.SyncRoot
	{
		get => throw new System.NotImplementedException();
	}
}
