using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SktProject.Models.ViewModel
{
    public class CategoryProductViewModels
    {

        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<Category> Category { get; set; }

        public LoginViewModel LoginViewModel { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }

    }
}