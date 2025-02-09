namespace VetPassport.API.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Species { get; set; }
        public int UserId { get; set; }
    }
}
