using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Zapocet.Data;
using Zapocet.Logic;
using Zapocet.Models;

namespace Zapocet.Pages.Forms
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _dbContext;
        private readonly CreditLogic _creditLogic;

        [BindProperty]
        public int Value { get; set; } // Toto uzivatel zada do formulare

        [BindProperty]
        public bool Success { get; set; }// Toto take zada uzivatel ve formulari

        public List<Credit> ExistingCredits { get; set; }

        public CreateModel(AppDbContext dbContext, CreditLogic creditLogic)
        {
            _dbContext = dbContext;
            _creditLogic = creditLogic;
        }

        public void OnGet()
        {
            // Naèítání existujících credits z databáze
            ExistingCredits = _dbContext.Credits.ToList();
        }

        public IActionResult OnPost() 
        {
            if(ModelState.IsValid) 
            {
                _creditLogic.AddCredit(Value, Success);

                //Reload page and show DB data again:
                OnGet();
                return RedirectToPage("/Forms/Create");
            }
            return RedirectToPage("/Index");
        }
    }
}
