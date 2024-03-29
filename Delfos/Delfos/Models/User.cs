﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Delfos.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique, MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(255)]
        public string Password { get; set; }
        [OneToMany]
        public List<Note> Notes { get; set; }
    }
}
