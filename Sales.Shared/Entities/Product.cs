﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sales.Shared.Entities
{
   public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Product")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]

        public string Name { get; set; } = null!;

        public int ProductId { get; set; }


        public Category? Category { get; set; }

        public ICollection<ProdCategory>? prodCategories { get; set; }


        public int prodCategoriesNumber => prodCategories == null ? 0 : prodCategories.Count;

    }
}
