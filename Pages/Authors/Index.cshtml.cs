﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marcu_Andreea_Cosmina_Lab2.Data;
using Marcu_Andreea_Cosmina_Lab2.Models;

namespace Marcu_Andreea_Cosmina_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Marcu_Andreea_Cosmina_Lab2.Data.Marcu_Andreea_Cosmina_Lab2Context _context;

        public IndexModel(Marcu_Andreea_Cosmina_Lab2.Data.Marcu_Andreea_Cosmina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Models.Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}