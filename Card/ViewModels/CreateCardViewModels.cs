using System.ComponentModel.DataAnnotations;

namespace Card.ViewModels
{
    public class CreateCardViewModels
    {
        [Required(ErrorMessage = "TitleName is required")]
        public string TitleName { get; set; }

        [Required(ErrorMessage = "CardNumber is required")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Expiration is required")]
        public string Expiration { get; set; }

        [Required(ErrorMessage = "CVC is required")]
        public string CVC { get; set; }
    }
}
