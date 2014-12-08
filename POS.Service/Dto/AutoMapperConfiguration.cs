using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Model;

namespace POS.Service.Dto
{
    public class MappingProfile : AutoMapper.Profile
    {
        protected override void Configure()
        {
            base.Configure();

            AutoMapper.Mapper.CreateMap<PersonDto, Person>();
            AutoMapper.Mapper.CreateMap<PersonDto, Person>();

        }
    }

    public class PersonDto
    {
        
    }
}
