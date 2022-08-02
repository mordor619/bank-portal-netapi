using Microsoft.AspNetCore.Mvc;
using RegisterAPI.BankingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace RegisterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly BankingContext db;
        public RegisterController(BankingContext _db)
        {
            db = _db;
        }
  
        [HttpPost]
        [Route("Signup")]
        public async Task<IActionResult> Signup(UserAccount user)
        {
            db.UserAccounts.Add(user);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
