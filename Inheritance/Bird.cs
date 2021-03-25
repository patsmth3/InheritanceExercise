namespace Inheritance
{
    // Create a class Bird
    // Set this class to inherit from your Animal Class
    public class Bird : Animal 
    {
        // Constructor for the Bird class
        public Bird()
        {
        }
        // give this class 4 members that are specific to Bird
        public string Wings { get; set; }
        public string Bill { get; set; }
        public string WarmBlooded { get; set; }
        public string Bipedal { get; set; }
    }
}