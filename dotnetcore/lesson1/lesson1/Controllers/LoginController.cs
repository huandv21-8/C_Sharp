using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lesson1.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lesson1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private DataContext _context = new DataContext();

        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet("{token}")]
        public LoginResult Get(string token)
        {
            Token t = _context.Tokens.Where(e => e.StrToken.Equals(token)).FirstOrDefault();
            User u = _context.Users.Find(t.UserId);
            if (u == null)
            {
                return new LoginResult()
                {
                    Status = false,
                    Message = "login fail"
                }

        } 
            return new LoginResult()
        {
            Status = true,
                Message = "login success",
                Token = t.StrToken,
                User = u
            };
    }

    // POST api/<LoginController>
    [HttpPost]
    public LoginResult Post([FromBody] LoginModel login)
    {
        User u = _context.Users.Where(us => us.UserName.Equals(login.UserName) && us.Pwd.Equals(login.Pwd)).FirstOrDefault();
        if (u == null)
        {
            return new LoginResult()
            {
                Status = false,
                Message = "login fail"
        }
        string token = new Random().NextDouble().ToString();
        DateTime dt = new DateTime().AddMinutes(120);
        token += dt.GetHashCode();
        Token t = new Token { StrToken = token, UserId = u.Id, ExpireAt = dt };

        _context.Tokens.Add(t);
        _context.SaveChanges();
        return new LoginResult()
        {
            Status = true,
            Message = "login success",
            Token = t.StrToken,
            User = u
        };
    }



    // PUT api/<LoginController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<LoginController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

}