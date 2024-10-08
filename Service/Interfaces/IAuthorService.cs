﻿using Bookbox.DTOs.Request;
using Bookbox.DTOs.Response;

namespace Bookbox.Service.Interfaces
{
    public interface IAuthorService
    {
        Task<List<AuthorDto>> GetAllAuthorAsync(string name);
        Task<AuthorDto> GetAuthorByIdAsync(Guid id);
        Task<AuthorDto> AddAuthorAsync(AddAuthorDto addAuthorDto);
        Task<AuthorDto> UpdateAuthorAsync(Guid id, UpdateAuthorDto updateAuthorDto);
        Task<AuthorDto> DeleteAuthorAsync(Guid id);
    }
}
