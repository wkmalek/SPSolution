using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Image = System.Drawing.Image;

namespace NewsStaisticsWebParts.NewestNews
{
    [ToolboxItemAttribute(false)]
    public class NewestNews : WebPart
    {

        protected override void CreateChildControls()
        {
            //Use create child control or use visual webpart, also rewrite to caml
        }

        protected override void Render(HtmlTextWriter writer)
        {
            SPListItem item = GetNewestListItem(SPContext.Current.Web.Url, "NewsList", "Created");
            
            string imageUrl = SPContext.Current.Web.Url + "/NewestNewsStyle/images.jpg";
            //string newsLink = SPContext.Current.Web.Url+(item.Url.Split('_')[0]);
            int itemID = item.ID;
            int lastSlash = item.Url.LastIndexOf('/');

            string listUrl = item.Url.Substring(0,lastSlash);
            string newsLink = listUrl+"News.aspx"+"?ID="+itemID;
            string Title = (string)item["Title"];
            string Descritpion = (string)item["NewsBody"];
            
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "background");
            writer.AddStyleAttribute("background", "url("+imageUrl+") no-repeat");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "transbox");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            //SOME TEXT
            writer.Write(@"<h2><a href="+newsLink+"\">"+ Title +"</a></h2><br>");
            writer.Write("<p>"+ Descritpion+ "</p>");

            writer.RenderEndTag();
            writer.RenderEndTag();
        }

        private SPListItem GetNewestListItem(string siteUrl, string listName, string columnName)
        {
            try
            {
                using (SPSite site = new SPSite(siteUrl))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        SPList list = web.Lists[listName];

                        SPQuery objQuery = new SPQuery();
                        objQuery.Query = "<OrderBy><FieldRef Name='" + columnName + "' Ascending='False' /></OrderBy>";
                        objQuery.RowLimit = 1;

                        SPListItemCollection items = list.GetItems(objQuery);

                        if (items.Count == 1)
                        {
                            return items[0];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return null;
        }

    }
}
