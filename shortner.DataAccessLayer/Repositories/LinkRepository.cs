using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using shortner.DataAccessLayer.Context;
using shortner.DataAccessLayer.Entites;
using shortner.DataAccessLayer.Repositories.Interface;

namespace shortner.DataAccessLayer.Repositories;

public class LinkRepository : ILinkRepository
{
    private shortnerDbContext _shortnerDbContext;

    public LinkRepository(shortnerDbContext shortnerDbContext)
    {
        _shortnerDbContext = shortnerDbContext;
    }

    public async Task<Link> GetById(long id)
    {
        Link link =new Link();

        link = await _shortnerDbContext.Links.FindAsync(id);

        return link;
    }

    public async Task<List<Link>> GetAll()
    {
        return await _shortnerDbContext.Links.ToListAsync();
    }

    public async Task Add(Link link)
    {
        _shortnerDbContext.Links.Add(link);
        await _shortnerDbContext.SaveChangesAsync(); //unite of work concept
    }

    public async Task Update(Link link)
    {
        throw new NotImplementedException();
    }

    public async Task SoftDelete(long id)
    {
        var result = await _shortnerDbContext.Links.FindAsync(id);
        result.SoftDelete = true;

        await _shortnerDbContext.SaveChangesAsync();
    }

    public async Task HardDelete(long id)
    {
        _shortnerDbContext.Remove(id);
    }

    public async Task<IEnumerable<Link>> GetByPage(int pageIndex, int pagesize)
    {
        return _shortnerDbContext.Links.Skip((pageIndex - 1) * pagesize).Take(pagesize);
    }
}