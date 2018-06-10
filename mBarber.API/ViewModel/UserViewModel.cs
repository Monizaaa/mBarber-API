using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mBarber.API
{
    public class SignInRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "user is required")]
        [MinLength(6)]
        public string user { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "password is required")]
        [MinLength(6)]
        public string password { get; set; }
    }

    public class SignInResponse : JsonResponse
    {
        public string user { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string path_profile { get; set; }
        public string token { get; set; }
        public string expire_date { get; set; }
    }

    public class SignUpRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "user is required")]
        public string user { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "password is required")]
        public string password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "first_name is required")]
        public string first_name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "last_name is required")]
        public string last_name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "email is required")]
        public string email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "location is required")]
        public string location { get; set; }
    }

    public class SignUpResponse : JsonResponse
    {
        public SignUpRequest data { get; set; }
    }

}
