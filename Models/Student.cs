namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DateCreated{ get; set; }
        public DateTime? DateModified { get; set; }
        public int? OpstinaId { get; set; }
        public Opstina?  Opstina { get; set; }

    }
}
