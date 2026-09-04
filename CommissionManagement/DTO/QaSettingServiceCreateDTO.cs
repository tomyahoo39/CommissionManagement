namespace CommissionManagement.DTO
{
    public class QaSettingServiceCreateDTO
    {
        public string Question { get; set; }

        public string Answer { get; set; }

        public int SortOrder { get; set; }

        public bool IsVisible { get; set; }
    }
}
