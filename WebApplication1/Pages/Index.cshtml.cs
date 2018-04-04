 and github﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {

        public string Msg { get; set; }

        public void OnGet()
        {
            Msg += "hello from server and GitHub and VS";
        }
    }
}
