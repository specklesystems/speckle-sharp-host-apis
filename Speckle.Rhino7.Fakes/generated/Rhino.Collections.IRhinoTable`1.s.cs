namespace Rhino.Collections;

public partial interface IRhinoTable<T>
{
	public  T get_Item(System.Int32 index);
	public  System.Int32 Count
	{
		get;
	}
}
