﻿using API.DTOs;

namespace API.Entities;

public interface IUserRepository
{
    void Update(AppUser user);
    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppUser>> GetUserAsync();
    Task<AppUser> GetUserByIdAsync(int id);
    Task<AppUser> GetUserByUsernameAsync(string username);
    Task<IEnumerable<MemberDto>> GetMembersAsync();
    Task<MemberDto> GetMemberAsync(string username);
}
