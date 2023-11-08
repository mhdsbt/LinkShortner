using shortner.DataAccessLayer.Entites;

namespace shortner.DataAccessLayer.Repositories.Interface;

public interface ILinkRepository
{
    Task<Link> GetById(long id);
    Task<List<Link>> GetAll();
    Task Add(Link link);
    Task Update(Link link);
    Task SoftDelete(long id);
    Task HardDelete(long id);
    Task<IEnumerable<Link>> GetByPage(int pageIndex, int pageSize);
}