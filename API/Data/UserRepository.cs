using API.DTOs;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class UserRepository(DataContext context, IMapper mapper) : IUserRepository
{
    public async Task<MemberDto?> GetMemberAsyn(string username)
    {
        return await context.Users
        .Where(u => u.UserName == username)
        .ProjectTo<MemberDto>(mapper.ConfigurationProvider)
        .SingleOrDefaultAsync();

    }

    public async Task<PageList<MemberDto>> GetMembersAsync(UserParams userParams)
    {
        var query = context.Users.AsNoTracking()
        .ProjectTo<MemberDto>(mapper.ConfigurationProvider)
        .AsQueryable();

        return await PageList<MemberDto>.CreateAsync(query, userParams.PageNumber, userParams.PageSize);
    }

    public async Task<AppUser?> GetUserByIdAsync(int id)
    {
        return await context.Users.FindAsync(id);
    }

    public async Task<AppUser?> GetUserByUserNameAsync(string username)
    {
        return await context.Users
        .Include(u => u.Photos)
        .SingleOrDefaultAsync(u => u.UserName == username);
    }

    public async Task<IEnumerable<AppUser>> GetUsersAsync()
    {
        return await context.Users.AsNoTracking()
        .Include(u => u.Photos)
        .ToListAsync();
    }

    public async Task<bool> SaveAllAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public void Update(AppUser user)
    {
        context.Entry(user).State = EntityState.Modified;
    }
}
