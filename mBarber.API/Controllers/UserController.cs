using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mBarber.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/user")]
    public class UserController : BaseController
    {
        #region SignIn
        [Route("signin")]
        [HttpPost]
        public IActionResult SignIn([FromBody] SignInRequest request_model)
        {
            return null;
        }
        #endregion

        #region SignOut
        [Route("signout")]
        [HttpPost]
        public object SignOut()
        {
            return null;
        }
        #endregion

        #region SignUp
        [Route("signup")]
        [ProducesResponseType(typeof(SignUpResponse), 200)]
        [HttpPost]
        public IActionResult SignUp([FromBody] SignUpRequest request_model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelError());
            }
            return Ok();
        }
        #endregion

        #region Update Profile
        [Route("updateprofile")]
        [HttpPost]
        public object UpdateProfile()
        {
            return null;
        }
        #endregion

        #region Change Password
        [Route("changepassword")]
        [HttpPost]
        public object ChangePassword()
        {
            return null;
        }
        #endregion
    }
}