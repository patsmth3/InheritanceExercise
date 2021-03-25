using System;
using System.Reflection.PortableExecutable;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            
            //Create an object of your Bird class
            Bird traits = new Bird();
            
             //  give values to your members using the object of your Bird class
             traits.Wings = "Some birds are feathered and others are not.";
             traits.Bill = "Birds have different sizes/types of bills.";
             traits.WarmBlooded = "All birds are warm-blooded, even penquins.";
             traits.Bipedal = "All birds have 2 legs used for perching, walking, hopping or running.";
             
             // Creatively display the class member values 
             Console.WriteLine($"Birds are amazing. {traits.Wings} {traits.Bill} {traits.WarmBlooded} {traits.Bipedal}\n");  

             //Create an object of your Reptile class
             Reptile characteristics = new Reptile();
              
              //give values to your members using the object of your Bird class

              characteristics.Oviparous = "All reptiles lay eggs";
              characteristics.ColdBlooded =
                  "Most reptiles are cold-blooded vertebrates. They do not have the psychological means of regulating " +
                  "their body temperatures and have to depend on the external environment.";
              characteristics.Lungs =
                  "Reptiles breathe through their lungs. Although turtles have permeable skin through which gaseous exchange " +
                  "takes place while some species increase the rate of gaseous exchange " +
                  "through the cloaca, the breathing process can only be completed through the lungs";
              characteristics.Scales =
                  "One of the major distinguishing factors between reptiles and other animal classes is the " +
                  "presence of scutes or scales.";  
              
              //Creatively display the class member values 
              Console.WriteLine($"The amazing Reptile. {characteristics.Oviparous} {characteristics.ColdBlooded} {characteristics.Lungs} {characteristics.Scales}");

        }
    }
}
