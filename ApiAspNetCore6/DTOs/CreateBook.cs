﻿using ApiAspNetCore6.Validations;
using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCore6.DTOs
{
    public class CreateBook
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [FirstLetterCapitalized]
        [StringLength(maximumLength: 250)]
        public string Title { get; set; }
        public List<int> AuthorsIds { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
