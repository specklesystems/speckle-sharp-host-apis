namespace Rhino.DocObjects;

public partial class MaterialRefs : System.Collections.Generic.IDictionary<System.Guid, Rhino.DocObjects.MaterialRef>
{
	public MaterialRefs() {}
	public virtual Rhino.DocObjects.MaterialRef Create(Rhino.DocObjects.MaterialRefCreateParams createParams) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Guid, Rhino.DocObjects.MaterialRef>> GetEnumerator() => throw new System.NotImplementedException();
	public virtual void Add(System.Collections.Generic.KeyValuePair<System.Guid, Rhino.DocObjects.MaterialRef> item) => throw new System.NotImplementedException();
	public virtual void Add(System.Guid key,Rhino.DocObjects.MaterialRef value) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(System.Collections.Generic.KeyValuePair<System.Guid, Rhino.DocObjects.MaterialRef> item) => throw new System.NotImplementedException();
	public virtual System.Boolean Remove(System.Collections.Generic.KeyValuePair<System.Guid, Rhino.DocObjects.MaterialRef> item) => throw new System.NotImplementedException();
	public virtual System.Boolean ContainsKey(System.Guid key) => throw new System.NotImplementedException();
	public virtual System.Boolean Remove(System.Guid key) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.MaterialRef get_Item(System.Guid key) => throw new System.NotImplementedException();
	public virtual void set_Item(System.Guid key,Rhino.DocObjects.MaterialRef value) => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReadOnly
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Collections.Generic.ICollection<System.Guid> Keys
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Collections.Generic.ICollection<Rhino.DocObjects.MaterialRef> Values
	{
		get => throw new System.NotImplementedException();
	}
}
