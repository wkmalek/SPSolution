using SharedLib.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls.WebParts;

namespace SharedLib
{
    public class MySandboxedWebPart<TPresenter,TMyView>:WebPart
        where TPresenter:AbstractPresenter<TMyView>,new()
        where TMyView:IMyView
    {
        public string newsID { get { return Page.Request.QueryString["ID"]; } }
        public string listID { get { return Page.Request.QueryString["List"]; } }
        public string contentTypeID { get { return Page.Request.QueryString["ContentTypeID"]; } }

        protected TPresenter _presenter;



        public TPresenter Presenter
        {
            set
            {
                _presenter = value;
                var smth = this;
                //_presenter._pView = (TMyView)this;
            }
        }

        public virtual TMyView GetView()
        {
            throw new NotImplementedException();
            //return 
        }
    }
}
