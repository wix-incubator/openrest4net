using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    public class CMenu : IMenu
    {
        public CMenu(Menu menu)
        {
            this.menu = menu;
        }

        public IItems GetItems()
        {
            return new CItems(menu.items);
        }

        public ITags GetTags()
        {
            return new CTags(menu.tags);
        }

        public ICategories GetCategories()
        {
            return new CCategories(menu.categories);
        }

        private readonly Menu menu;
    }
}
