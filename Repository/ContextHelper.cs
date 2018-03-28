using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    internal class ContextHelper : IDisposable
    {

        private readonly string Url;
        public SPSite site {get; private set;}
        public SPWeb web { get; private set; }
        public SPList list { get; private set; }

        public ContextHelper(string Url, string listName)
        {
            this.Url = Url;
            //site = new SPSite(Url);
            site = SPContext.Current.Site;
            //web = site.OpenWeb();
            web = site.RootWeb;
            list = web.Lists[listName];
        }

        public DateTime GetSiteCreatedDate()
        {
            return web.Created;
        }

        public void Dispose()
        {
            //site.Dispose();
            //web.Dispose();
        }
    }
}
