﻿using System.Threading.Tasks;
using Core.Controls.Interfaces;
using Microsoft.Playwright;

namespace Core.Controls.Elements
{
    public class MenuItem : PageElement, IMenuItem
    {
        public MenuItem(ILocator locator) : base(locator)
        {
        }

        public Task<string> GetText()
        {
            return Locator.TextContentAsync();
        }

        public Task Click()
        {
            return Locator.ClickAsync();
        }
    }
}