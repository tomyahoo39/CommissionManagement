using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommissionManagement.Models;
using CommissionManagement.Services;
using CommissionManagement.DTO;

[Route("api/[controller]")]
[ApiController]
public class QaSettingsController : ControllerBase
{
    private readonly IQaSettingService _service;
    public QaSettingsController(IQaSettingService service)
    {
        _service = service;
    }

    [HttpGet("AdminQaSetting")]
    public async Task<ActionResult<IEnumerable<QaSettingServiceDTO>>> GetAllQaForAdmin()
    {
        var qa = await _service.GetAllQaForAdmin();

        return Ok(qa);
    }

    [HttpGet("ClientQaSetting")]
    public async Task<ActionResult<IEnumerable<QaSettingServiceClientDTO>>> GetAllQaForClient()
    {
        var qa = await _service.GetAllQaForClient();
        return Ok(qa);
    }
}
