﻿using bienesoft.Funcions;
using bienesoft.models;
using bienesoft.Models;
using bienesoft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace bienesoft.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginUserController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly JWTModels _jwtSettings;

        public UserServices _userServices;

        public GeneralFunction GeneralFunction;
        public LoginUserController(IConfiguration configuration, UserServices userservices)
        {
            _configuration = configuration;
            _userServices = userservices;
            _jwtSettings = configuration.GetSection("JWT").Get<JWTModels>();
        }

        [HttpPost]
        public IActionResult Create(loginUser user)
        {
            try
            {
                //GeneralFunction generalFunction = new GeneralFunction();
                //generalFunction.Addlog("El programa fallo");
                var key = Encoding.UTF8.GetBytes(_jwtSettings.keysecret);

                ClaimsIdentity subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("User", user.Email)
                });

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = subject,
                    Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_jwtSettings.JWTExpireTime)),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature
                    )
                };

                var token = new JwtSecurityTokenHandler().CreateToken(tokenDescriptor);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost("ResetPassUser")]
        public async Task<IActionResult> ResetPassword(ResetPassUser user)
        {
            try
            {
                // Implementa aquí la lógica para enviar el correo de restablecimiento de contraseña
                // Ejemplo: await EnviarCorreoRestablecimiento(user.Email);
                // Reemplaza con tu implementación real
                // ...

                return Ok("Correo de restablecimiento de contraseña enviado correctamente.");
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser(User user)
        {
            try
            {
                // Implementa aquí la lógica para crear un usuario
                // ...

                return Ok("Usuario creado correctamente.");
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString());
            }
        }
        [HttpGet("AllUsers")]
        public ActionResult<IEnumerable<LearnerModel>> AllUser()
        {
            return Ok(_userServices.GetLearnerModels());
        }  
    }
}
