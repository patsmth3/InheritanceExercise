namespace Inheritance
{
    // Create a class Reptile
    // Set this class to inherit from your Animal Class
    public class Reptile : Animal
    {
        public Reptile()
        {
        }
        // give this class 4 members that are specific to Reptile
        public string Oviparous { get; set; }
        public string ColdBlooded { get; set; }
        public string Lungs { get; set; }
        public string Scales { get; set; }


    }
}