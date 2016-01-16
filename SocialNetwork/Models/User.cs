﻿using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;

namespace SocialNetwork.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; } 

        public virtual List<User> Followers { get; set; }
        public virtual List<User> Followed { get; set; }
    }

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.UserId);
            Property(u => u.FirstName).IsRequired();
            Property(u => u.LastName).IsRequired();
            Property(u => u.Password).IsRequired();
        }
    }
}