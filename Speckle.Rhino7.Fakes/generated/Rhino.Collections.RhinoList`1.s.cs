namespace Rhino.Collections;

public partial class RhinoList<T> : System.Collections.Generic.IList<T>,System.Collections.Generic.ICollection<T>,System.Collections.Generic.IEnumerable<T>,System.Collections.IEnumerable,System.Collections.IList,System.Collections.ICollection,System.ICloneable
{
	public RhinoList() {}
	public RhinoList(System.Int32 initialCapacity) => throw new System.NotImplementedException();
	public RhinoList(System.Int32 amount,T defaultValue) => throw new System.NotImplementedException();
	public RhinoList(System.Collections.Generic.IEnumerable<T> collection) => throw new System.NotImplementedException();
	public RhinoList(Rhino.Collections.RhinoList<T> list) => throw new System.NotImplementedException();
	public virtual T[] ToArray() => throw new System.NotImplementedException();
	public virtual void TrimExcess() => throw new System.NotImplementedException();
	public virtual System.Int32 RemapIndex(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual void Add(T item) => throw new System.NotImplementedException();
	public virtual void AddRange(System.Collections.Generic.IEnumerable<T> collection) => throw new System.NotImplementedException();
	public virtual void AddRange(System.Collections.IEnumerable collection) => throw new System.NotImplementedException();
	public virtual void Insert(System.Int32 index,T item) => throw new System.NotImplementedException();
	public virtual void InsertRange(System.Int32 index,System.Collections.Generic.IEnumerable<T> collection) => throw new System.NotImplementedException();
	public virtual System.Boolean Remove(T item) => throw new System.NotImplementedException();
	public virtual System.Int32 RemoveAll(System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 RemoveNulls() => throw new System.NotImplementedException();
	public virtual void RemoveAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void RemoveRange(System.Int32 index,System.Int32 count) => throw new System.NotImplementedException();
	public virtual Rhino.Collections.RhinoList<T> GetRange(System.Int32 index,System.Int32 count) => throw new System.NotImplementedException();
	public virtual System.Int32 IndexOf(T item) => throw new System.NotImplementedException();
	public virtual System.Int32 IndexOf(T item,System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Int32 IndexOf(T item,System.Int32 index,System.Int32 count) => throw new System.NotImplementedException();
	public virtual System.Int32 LastIndexOf(T item) => throw new System.NotImplementedException();
	public virtual System.Int32 LastIndexOf(T item,System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Int32 LastIndexOf(T item,System.Int32 index,System.Int32 count) => throw new System.NotImplementedException();
	public virtual System.Int32 BinarySearch(T item) => throw new System.NotImplementedException();
	public virtual System.Int32 BinarySearch(T item,System.Collections.Generic.IComparer<T> comparer) => throw new System.NotImplementedException();
	public virtual System.Int32 BinarySearch(System.Int32 index,System.Int32 count,T item,System.Collections.Generic.IComparer<T> comparer) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(T item) => throw new System.NotImplementedException();
	public virtual System.Boolean Exists(System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual T Find(System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual T FindLast(System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual Rhino.Collections.RhinoList<T> FindAll(System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Boolean TrueForAll(System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual void ForEach(System.Action<T> action) => throw new System.NotImplementedException();
	public virtual System.Int32 FindIndex(System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindIndex(System.Int32 startIndex,System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindIndex(System.Int32 startIndex,System.Int32 count,System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindLastIndex(System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindLastIndex(System.Int32 startIndex,System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindLastIndex(System.Int32 startIndex,System.Int32 count,System.Predicate<T> match) => throw new System.NotImplementedException();
	public virtual void Sort() => throw new System.NotImplementedException();
	public virtual void Sort(System.Collections.Generic.IComparer<T> comparer) => throw new System.NotImplementedException();
	public virtual void Sort(System.Comparison<T> comparison) => throw new System.NotImplementedException();
	public virtual void Sort(System.Int32 index,System.Int32 count,System.Collections.Generic.IComparer<T> comparer) => throw new System.NotImplementedException();
	public virtual void Sort(System.Double[] keys) => throw new System.NotImplementedException();
	public virtual void Sort(System.Int32[] keys) => throw new System.NotImplementedException();
	public virtual void Reverse() => throw new System.NotImplementedException();
	public virtual void Reverse(System.Int32 index,System.Int32 count) => throw new System.NotImplementedException();
	public virtual System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly() => throw new System.NotImplementedException();
	public virtual Rhino.Collections.RhinoList<TOutput> ConvertAll<TOutput>(System.Converter<T, TOutput> converter) => throw new System.NotImplementedException();
	public virtual void CopyTo(T[] array) => throw new System.NotImplementedException();
	public virtual void CopyTo(T[] array,System.Int32 arrayIndex) => throw new System.NotImplementedException();
	public virtual void CopyTo(System.Int32 index,T[] array,System.Int32 arrayIndex,System.Int32 count) => throw new System.NotImplementedException();
	public virtual Rhino.Collections.RhinoList<T> Duplicate() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() => throw new System.NotImplementedException();
	System.Int32 System.Collections.IList.Add(System.Object item) => throw new System.NotImplementedException();
	void System.Collections.IList.Insert(System.Int32 index,System.Object item) => throw new System.NotImplementedException();
	void System.Collections.IList.Remove(System.Object item) => throw new System.NotImplementedException();
	System.Int32 System.Collections.IList.IndexOf(System.Object item) => throw new System.NotImplementedException();
	System.Boolean System.Collections.IList.Contains(System.Object item) => throw new System.NotImplementedException();
	void System.Collections.ICollection.CopyTo(System.Array array,System.Int32 arrayIndex) => throw new System.NotImplementedException();
	System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Capacity
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NullCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual T this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual T First
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual T Last
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	System.Object System.Collections.IList.this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	System.Boolean System.Collections.IList.IsReadOnly
	{
		get => throw new System.NotImplementedException();
	}
	System.Boolean System.Collections.IList.IsFixedSize
	{
		get => throw new System.NotImplementedException();
	}
	System.Boolean System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		get => throw new System.NotImplementedException();
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
