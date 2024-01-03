using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zapocet.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		[BindProperty(SupportsGet = true)] // Toto pridame pokud chceme do property zapisovat jine hodnoty, plati to pouze pro metodu post, aby to platilo i pro Get, musime přidat (SupportsGet = true)
		public string firstName { get; set; }
		
		public void OnGet() // This code gets run when you ask for an index page
		{
			if (string.IsNullOrWhiteSpace(firstName))
			{
				firstName = "User";
			}
		}

		/*
		public void OnPost() //This code gets run whenever you post data to this page
		{

		}*/
	}
}
