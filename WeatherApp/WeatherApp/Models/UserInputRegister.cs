using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WeatherApp.Models
{
    internal class UserInputRegister
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; } = true;
        public string PhoneNumber { get; set; }
        public List<String> Roles { get; set; }
    }
}
