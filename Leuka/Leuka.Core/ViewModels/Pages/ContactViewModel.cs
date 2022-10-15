﻿using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class ContactViewModel : PageViewModel
    {
        public string Title { get; set; }
        public ContactViewModel(IPageContext<Contact> context) : base(context)
        {
            Title = context.Page.Title;
        }
    }
}