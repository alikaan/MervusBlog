﻿
using System;
using System.ComponentModel.DataAnnotations;

namespace MervusBlog_API.Models.Dto
{
	public class CategoryCreateDTO
	{
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public string Context { get; set; }
    }
}

