﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace opa_site.Pages
{
	public class ContactModel : PageModel
	{
		private readonly ILogger<ContactModel> _logger;

		public ContactModel(ILogger<ContactModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}
