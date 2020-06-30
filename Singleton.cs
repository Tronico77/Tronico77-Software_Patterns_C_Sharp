//Author: José Aurelio Quezada Alvarez
public class Singleton
{ 
	private static Singleton instance = null;
	
	private Singleton() //private or protected
	{ }

    public static Singleton GetInstance()
    {
        if (instance == null)        
            instance = new Singleton();
        
        return instance;
    }
}
