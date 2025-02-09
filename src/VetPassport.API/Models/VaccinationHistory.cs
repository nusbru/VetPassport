namespace VetPassport.API.Models
{
    public class VaccinationHistory
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public int VaccineId { get; set; }
        public Pet Pet { get; set; }
        public ICollection<Vaccine> Vaccines { get; set; }
    }
}