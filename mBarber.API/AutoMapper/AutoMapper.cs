using AutoMapper;
using mBarber.Model;
using System;

namespace mBarber.API
{
    public class AutoMapperConfig
    {
        public static void InitializeMappers()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<UserProfile>();
            });
        }
    }
    

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<SignUpRequest, UserModel>()
                .AfterMap((src, dest) =>
                {
                    dest.create_date = DateTime.UtcNow.ToString();
                    dest.update_date = DateTime.UtcNow.ToString();
                });
        }
    }
}
