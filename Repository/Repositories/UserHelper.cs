using Microsoft.SharePoint;
using PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class UserHelper:IDisposable
    {
        private readonly string Url;
        public SPSite site { get; private set; }
        public SPWeb web { get; private set; }

        public UserHelper(string Url)
        {
            this.Url = Url;
            //site = new SPSite(Url);
            site = SPContext.Current.Site;
            web = site.RootWeb;

            //dsweb = site.OpenWeb();
        }

        public UserModel GetUserByID(string ID)
        {
            SPUser user = web.Users.GetByID(int.Parse(ID));
            return mapUser(user);
        }

        private UserModel mapUser(SPUser user)
        {
            UserModel model = new UserModel()
            {
                Mail = user.Email,
                Name = user.Name,
                SID = user.ID.ToString(),
                Url = this.Url + "/_layouts/userdisp.aspx?ID=" + user.ID.ToString(),
            };
            return model;
        }

        public void Dispose()
        {
           // site.Dispose();
           // web.Dispose();
        }
    }
}
