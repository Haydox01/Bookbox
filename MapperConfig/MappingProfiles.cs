﻿using AutoMapper;
using Bookbox.DTOs.Request;
using Bookbox.DTOs.Response;
using Bookbox.Models;

namespace Bookbox.MapperConfig
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Mapping Models to Dto and in reverse 

            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<AddBookDto, BookDto>().ReverseMap();
            CreateMap<Book, UpdateBookDto>().ReverseMap();
            CreateMap<AddBookDto, Book>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();
            CreateMap<Author, AddAuthorDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
