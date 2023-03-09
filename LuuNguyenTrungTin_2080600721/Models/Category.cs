﻿using System.ComponentModel.DataAnnotations;

namespace LuuNguyenTrungTin_2080600721.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}