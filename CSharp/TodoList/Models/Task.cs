﻿using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Task
    {
       [Key]
       public int Id { get; set; }

        [MinLength(1)]
        public string Title { get; set; }

        [MinLength(1)]
        public string Comments { get; set; }
    }
}