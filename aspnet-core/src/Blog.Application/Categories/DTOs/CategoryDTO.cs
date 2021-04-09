using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Categories.DTOs
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDTO : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
