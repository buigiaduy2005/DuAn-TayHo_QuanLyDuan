using Microsoft.AspNetCore.Mvc;
using MiniPMS.Api.Models;
using MiniPMS.Api.Services;

namespace MiniPMS.Api.Controllers;

[ApiController]
[Route("api/cong-viec")]
public class ThemCongViecController : ControllerBase
{
    private readonly IThemCongViecService _service;
    
    public ThemCongViecController(IThemCongViecService srv) => _service = srv;

    [HttpPost]
    public async Task<IActionResult> Them([FromBody] CongViec cv)
    {
        // Buoc 1: Kiem tra neu data gui len bi thieu
        if (!ModelState.IsValid) return BadRequest(ModelState);
        
        // Buoc 2: Chuyen logic xuong tang Service xu ly chuyen mon
        var result = await _service.ThucHienAsync(cv);
        
        // Buoc 3: Tra ve ma 200 thanh cong
        return Ok(result);
    }
}
