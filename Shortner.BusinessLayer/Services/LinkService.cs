using System.Runtime.InteropServices.JavaScript;
using shortner.Api.ExceptionHelper;
using Shortner.BusinessLayer.Services.Interfaces;
using shortner.DataAccessLayer.Entites;
using shortner.DataAccessLayer.Repositories.Interface;

namespace Shortner.BusinessLayer.Services;

public class LinkService : ILinkService
{
    private ILinkRepository _linkRepository;

    public LinkService(ILinkRepository linkRepository)
    {
        _linkRepository = linkRepository;
    }

    public async Task<Link> GetById(long id)
    {
        try
        {
            return await _linkRepository.GetById(id);
        }
        catch (Exception e)
        {
            throw new DataBaseException();
        }
    }

    public async Task<List<Link>> GetAll()
    {
        return await _linkRepository.GetAll();
    }

    public async Task Add(Link link)
    {
        await _linkRepository.Add(link);
    }

    public async Task Update(Link link)
    {
        await _linkRepository.Update(link);
    }

    public async Task SoftDelete(long id)
    {
        await _linkRepository.SoftDelete(id);
    }

    public async Task HardDelete(long id)
    {
        await _linkRepository.HardDelete(id);
    }

    public Task<IEnumerable<Link>> GetByPage(int pageIndex, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<string> GenerateShortLink()
    {
        throw new NotImplementedException();
    }
}