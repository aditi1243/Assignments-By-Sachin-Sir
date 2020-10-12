using System;

// We use < > to specify Parameter type 
public class Gen<T>
{

    // private data members 
    private T data;

    // using properties 
    public T value
    {

        // using accessors 
        get
        {
            return this.data;
        }
        set
        {
            this.data = value;
        }
    }
}

// Driver class 
class Test
{

    // Main method 
    static void Main(string[] args)
    {

        // instance of string type 
        Gen<string> name = new Gen<string>();
        name.value = "Its not a copied Program";

        // instance of float type 
        Gen<float> version = new Gen<float>();
        version.value = 5.0F;

        // display string 
        Console.WriteLine(name.value);

        // display -- 
        Console.WriteLine(version.value);
    }
}