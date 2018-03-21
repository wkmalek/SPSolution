using Microsoft.SharePoint;
using Models.Post;
using Repository;
using Repository.Repositories;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace TestProj.VisualWebPart
{
    public partial class VisualWebPartUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IRepository<NewsModel> repo = RepositoryFactory.GetRepositoryInstance<NewsModel, NewsRepository>();
            dupa.Text = repo.GetSingleElementByID(1).ID.ToString();
        }
    }
}
