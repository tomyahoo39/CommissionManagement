using System.ComponentModel.DataAnnotations;

namespace CommissionManagement.DTO
{
    public class QaSettingServiceClientDTO
    {

        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }

    }
}
