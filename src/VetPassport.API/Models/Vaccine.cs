namespace VetPassport.API.Models
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int PetId { get; set; }
    }
}
