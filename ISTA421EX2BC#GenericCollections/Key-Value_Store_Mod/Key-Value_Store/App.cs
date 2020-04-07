using System;

namespace Key_Value_Store
{
    public class App
    {
        public App()
        {
            MyDictionary d = new MyDictionary();
            try 
            {
                Console.WriteLine(d["Cats"]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            } 

            d["Cats"] = 42;
            d["Dogs"] = 17; 
            
            Console.WriteLine ($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}