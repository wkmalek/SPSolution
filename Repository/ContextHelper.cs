using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    internal class ContextHelper
    {
        private readonly string Url;
        public SPSite site {get; private set;}
        public SPWeb web { get; private set; }
        public SPList list { get; private set; }

        public ContextHelper(string Url, string listName)
        {
            this.Url = Url;
            site = new SPSite(Url);
            web = site.OpenWeb();
            list = web.Lists[listName];
        }
    }
}
