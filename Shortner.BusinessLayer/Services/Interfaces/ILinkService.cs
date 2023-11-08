using shortner.DataAccessLayer.Entites;

namespace Shortner.BusinessLayer.Services.Interfaces;

public interface ILinkService
{
    Task<Link> GetById(long id);
    Task<List<Link>> GetAll();
    Task Add(Link link);
    Task Update(Link link);
    Task SoftDelete(long id);
    Task HardDelete(long id);
    Task<IEnumerable<Link>> GetByPage(int pageIndex, int pageSize);
    Task<string> GenerateShortLink();
}