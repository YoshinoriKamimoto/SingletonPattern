// Singletonパターン
public class SingletonItem
{
    private static SingletonItem item;
    
    private SingletonItem()
    {

    }

    public static SingletonItem GetInstance()
    {
        if (item == null)
        {
            item = new SingletonItem();
        }
        return item;
    }
}