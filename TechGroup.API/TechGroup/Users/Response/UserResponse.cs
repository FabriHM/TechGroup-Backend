﻿namespace TechGroup.API.TechGroup.Users.Response
{
    public class UserResponse
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Dni { get; set; }
        public DateOnly CreatedAt { get; set; }
    }
}
