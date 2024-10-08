﻿using CrudAPI.Domain.Entities;

namespace CrudAPI.Application.DTOs.Response.Books
{
    public sealed class GetBookResDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public BookGenre BookGenre { get; set; }
    }
}
