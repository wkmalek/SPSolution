using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Publishing.WebControls;
using Microsoft.SharePoint.WebPartPages;

namespace WebParts.NewsFeedVer2
{
    [ToolboxItemAttribute(false)]
    public class NewsFeedVer2 : ContentByQueryWebPart
    {
        protected override void ModifyXsltArgumentList(ArgumentClassWrapper argList)
        {
            //argList.SetParameter("ItemXslLink", "", "/Style Library/XSL Style Sheets/CQWPCustomItemStyle.xsl");
            this.ItemXslLink = "/Style Library/XSL Style Sheets/CQWPCustomItemStyle.xsl";
            //this.ListName = "NewsList";
            //this.ListGuid = "ace22ef0-168b-41d0-90f5-bc8391615029";
            //this.ContentTypeBeginsWithId = "0x01";
            //this.ServerTemplate = "10001";
            this.ItemStyle = "Custom";
            this.GroupStyle = "Custom";
            this.ShowUntargetedItems = true;
            //this.WebUrl = "~sitecollection";
            this.UseCopyUtil = true;
            base.ModifyXsltArgumentList(argList);
        }

        protected override void OnLoad(EventArgs e)
        {
            this.CommonViewFields = "NewsBody,Note;NewsTitle,Text;CompanyName,Text;";
            base.OnLoad(e);
        }

        protected override void CreateChildControls()
        {
            this.CommonViewFields = "NewsBody,Note;NewsTitle,Text;CompanyName,Text;";
            base.CreateChildControls();
        }

        protected override void OnPreRender(EventArgs e)
        {
            this.CommonViewFields = "NewsBody,Note;NewsTitle,Text;CompanyName,Text;";
            base.OnPreRender(e);
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            this.CommonViewFields = "NewsBody,Note;NewsTitle,Text;CompanyName,Text;";
            base.RenderContents(writer);
        }
    }
}
