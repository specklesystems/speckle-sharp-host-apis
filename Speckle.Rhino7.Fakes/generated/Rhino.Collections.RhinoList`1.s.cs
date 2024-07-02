namespace Rhino.Collections;

public partial class RhinoList<T> : IList<T>,System.Collections.IList,System.ICloneable
{
	public RhinoList() {}
	public RhinoList(System.Int32 initialCapacity) => throw new System.NotImplementedException();
	public RhinoList(System.Int32 amount,T defaultValue) => throw new System.NotImplementedException();
	public RhinoList(IEnumerable<T> collection) => throw new System.NotImplementedException();
	public RhinoList(Rhino.Collections.RhinoList<T> list) => throw new System.NotImplementedException();
	public virtual T[] ToArray() => throw new System.NotImplementedException();
	public virtual void TrimExcess() => throw new System.NotImplementedException();
	public virtual T get_Item(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void set_Item(System.Int32 index,T value) => throw new System.NotImplementedException();
	public virtual System.Int32 RemapIndex(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual void Add(T item) => throw new System.NotImplementedException();
	public virtual void AddRange(IEnumerable<T> collection) => throw new System.NotImplementedException();
	public virtual void AddRange(System.Collections.IEnumerable collection) => throw new System.NotImplementedException();
	public virtual void Insert(System.Int32 index,T item) => throw new System.NotImplementedException();
	public virtual void InsertRange(System.Int32 index,IEnumerable<T> collection) => throw new System.NotImplementedException();
	public virtual System.Boolean Remove(T item) => throw new System.NotImplementedException();
	public virtual System.Int32 RemoveAll(Predicate<T> match) => throw new System.NotImplementedException();
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
	public virtual System.Int32 BinarySearch(T item,IComparer<T> comparer) => throw new System.NotImplementedException();
	public virtual System.Int32 BinarySearch(System.Int32 index,System.Int32 count,T item,IComparer<T> comparer) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(T item) => throw new System.NotImplementedException();
	public virtual System.Boolean Exists(Predicate<T> match) => throw new System.NotImplementedException();
	public virtual T Find(Predicate<T> match) => throw new System.NotImplementedException();
	public virtual T FindLast(Predicate<T> match) => throw new System.NotImplementedException();
	public virtual Rhino.Collections.RhinoList<T> FindAll(Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Boolean TrueForAll(Predicate<T> match) => throw new System.NotImplementedException();
	public virtual void ForEach(Action<T> action) => throw new System.NotImplementedException();
	public virtual System.Int32 FindIndex(Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindIndex(System.Int32 startIndex,Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindIndex(System.Int32 startIndex,System.Int32 count,Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindLastIndex(Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindLastIndex(System.Int32 startIndex,Predicate<T> match) => throw new System.NotImplementedException();
	public virtual System.Int32 FindLastIndex(System.Int32 startIndex,System.Int32 count,Predicate<T> match) => throw new System.NotImplementedException();
	public virtual void Sort() => throw new System.NotImplementedException();
	public virtual void Sort(IComparer<T> comparer) => throw new System.NotImplementedException();
	public virtual void Sort(Comparison<T> comparison) => throw new System.NotImplementedException();
	public virtual void Sort(System.Int32 index,System.Int32 count,IComparer<T> comparer) => throw new System.NotImplementedException();
	public virtual void Sort(System.Double[] keys) => throw new System.NotImplementedException();
	public virtual void Sort(System.Int32[] keys) => throw new System.NotImplementedException();
	public virtual void Reverse() => throw new System.NotImplementedException();
	public virtual void Reverse(System.Int32 index,System.Int32 count) => throw new System.NotImplementedException();
	public virtual ReadOnlyCollection<T> AsReadOnly() => throw new System.NotImplementedException();
	public virtual RhinoList<TOutput> ConvertAll(Converter<T, TOutput> converter) => throw new System.NotImplementedException();
	public virtual void CopyTo(T[] array) => throw new System.NotImplementedException();
	public virtual void CopyTo(T[] array,System.Int32 arrayIndex) => throw new System.NotImplementedException();
	public virtual void CopyTo(System.Int32 index,T[] array,System.Int32 arrayIndex,System.Int32 count) => throw new System.NotImplementedException();
	public virtual Rhino.Collections.RhinoList<T> Duplicate() => throw new System.NotImplementedException();
	public virtual IEnumerator<T> GetEnumerator() => throw new System.NotImplementedException();
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
}
