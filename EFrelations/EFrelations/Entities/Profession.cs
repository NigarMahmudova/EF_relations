namespace EFrelations.Entities
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Testimonial> Testimonial { get; set; }
        public List<Chef> Chef { get; set; }
    }
}
