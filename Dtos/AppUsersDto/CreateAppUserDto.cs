﻿namespace RealEstateDapper8.Dtos.AppUsersDto
{
    public class CreateAppUserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public int UserRol { get; set; }
        public string UserİmageUrl { get; set; }
        public string Phone { get; set; }
        public string UserTitle { get; set; }
        public string UserStatus { get; set; }
    }
}
