using MiniPMS.Api.Models;

namespace MiniPMS.Api.Services;

// Interface giup phan tach logic (Loose coupling)
public interface IThemCongViecService
{
    Task<CongViec> ThucHienAsync(CongViec congViec);
}
