using CommissionManagement.DTO;

namespace CommissionManagement.Services
{
    public interface IQaSettingService
    {
        Task<IEnumerable<QaSettingServiceClientDTO>> GetAllQaForClient();
        Task<IEnumerable<QaSettingServiceDTO>> GetAllQaForAdmin();

        Task Create(QaSettingServiceGetAllDTO newQa);

        Task<bool> Update(int id, QaSettingServiceDTO updatedQa);

        Task<bool> Delete(int id);

    }
}
