namespace EFrelations.Entities
{
    public class ChefSocialMedia
    {
        public int Id { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public int ChefId { get; set; }
        public Chef Chef { get; set; }
    }
}
