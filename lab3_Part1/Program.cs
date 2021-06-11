namespace Part_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // declare a Car object reference named myCar
            Car myCar;
// create a Car object, and assign its address to myCar
            System.Console.WriteLine(&quot;Creating a Car object and assigning &quot;
            + &quot;its memory location to myCar&quot;);
            myCar = new Car();
// assign values to the Car object&#39;s fields using myCar
            myCar.make = &quot;Toyota&quot;;
            myCar.model = &quot;MR2&quot;;
            myCar.color = &quot;black&quot;;
            myCar.yearBuilt = 1995;
// display the field values using myCar
            System.Console.WriteLine(&quot;myCar details:&quot;);
            System.Console.WriteLine(&quot;myCar.make = &quot;+ myCar.make);
            System.Console.WriteLine(&quot;myCar.model= &quot;+myCar.model);
            System.Console.WriteLine(&quot;myCar.color = &quot;+myCar.color);
            System.Console.WriteLine(&quot;myCar.yearBuilt=&quot; +myCar.yearBuilt);
// call the methods using myCar
            myCar.Start();
            myCar.Stop();
// declare another Car object reference and
// create another Car object
            System.Console.WriteLine(&quot;Creating another Car object
            and&quot;+&quot;assigning its memory location to redPorsche&quot;);
            Car redPorsche = new Car();
            redPorsche.make = &quot;Porsche&quot;;
            redPorsche.model = &quot;Boxster&quot;;
            redPorsche.color = &quot;red&quot;;
            redPorsche.yearBuilt = 2000;
            System.Console.WriteLine(&quot;redPorsche is a &quot; + redPorsche.model);
//change the object referenced by the
        }
    }
}