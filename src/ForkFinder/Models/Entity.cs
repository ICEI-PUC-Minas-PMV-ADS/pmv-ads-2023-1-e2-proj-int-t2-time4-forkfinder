﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForkFinder.Models
{
    public abstract class Entity
    {
        
        protected Entity()
        {
          
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
    }
}
