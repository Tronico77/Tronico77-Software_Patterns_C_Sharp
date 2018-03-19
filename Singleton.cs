//Author: José Aurelio Quezada Alvarez
public class Singleton
{ 
	private static Singleton instance = null;
	
	public Singleton()
	{ }

    public static Singleton getInstance()
    {
        if (instance == null)        
            instance = new Singleton();
        
        return instance;
    }
}
