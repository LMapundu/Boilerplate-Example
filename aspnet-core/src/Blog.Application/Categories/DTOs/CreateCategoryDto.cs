using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Categories.DTOs
{
    [AutoMapTo(typeof(Category))]
    public class CreateCategoryDto
    {
        public string Name { get; set; }
    }
}
