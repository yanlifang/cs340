﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS340_Group_Project.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contributor { get; set; }
        public string Description { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }
        public string Instructions { get; set; }
    }
}
