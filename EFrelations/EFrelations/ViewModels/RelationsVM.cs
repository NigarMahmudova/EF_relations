using EFrelations.Entities;

namespace EFrelations.ViewModels
{
    public class RelationsVM
    {
        public List<Chef> Chefs { get; set; } = null!;
        public List<Testimonial> Testimonials { get; set; } = null!;
        public List<Profession> Professions { get; set; } = null!;
        public List<ChefSocialMedia> ChefSocialMedias { get; set; } = null!;
    }
}
