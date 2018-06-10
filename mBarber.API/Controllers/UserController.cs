using mBarber.Model;
using AutoMapper;
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

            var userModel = Mapper.Map<UserModel>(request_model);

            UserRepo rp = new UserRepo();
            rp.InsertUser(userModel);

            return Ok(new SignUpResponse { status = 200, message = "SUCCESS", data = request_model });
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