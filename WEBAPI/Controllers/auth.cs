using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class auth : Controller
    {
        [HttpPost]
        public IActionResult Auth([FromBody] LoginModel loginData)
        {
            if (loginData != null && IsValidUser(loginData.Username, loginData.Password))
            {
                return Ok("OK");
            }
            else
            {
                return Unauthorized("OSHIBKA");
            }
        }
        private bool IsValidUser(string username, string password)
        {
            return username == "User" && password == "Pass";
        }
    }
}
