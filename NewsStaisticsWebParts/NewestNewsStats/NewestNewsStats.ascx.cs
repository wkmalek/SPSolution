using Microsoft.SharePoint;
using NewsStaisticsWebParts.Presenter;
using SharedLib;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;

namespace NewsStaisticsWebParts.NewestNewsStats
{
    [ToolboxItemAttribute(false)]
    //[System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
    public partial class NewestNewsStats : MySandboxedWebPart<NewestNewsPresenter,INewestNewsView>,INewestNewsView
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        

        public string _listUrl { set { listUrl.Text = value;  } }
        public string _imageUrl { set { background.Attributes.Add("style", "background:url(" + value + ") no-repeat"); } }
        public string _Title { set { Title.Text = value; } }
        public string _Description { set { Description.Text = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            NewestNewsPresenter _presenter = new NewestNewsPresenter();
            _presenter._pView = this;
            _presenter.LoadNewestNews();
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }
    }
}
