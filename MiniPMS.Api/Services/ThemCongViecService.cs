using MiniPMS.Api.Data;
using MiniPMS.Api.Models;

namespace MiniPMS.Api.Services;

public class ThemCongViecService : IThemCongViecService
{
    private readonly AppDbContext _db;
    
    // Su dung Dependency Injection de nhan DB
    public ThemCongViecService(AppDbContext db) => _db = db;

    public async Task<CongViec> ThucHienAsync(CongViec congViec)
    {
        _db.CongViec.Add(congViec);
        await _db.SaveChangesAsync();
        return congViec;
    }
}
