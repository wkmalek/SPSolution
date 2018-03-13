using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace NewsFeedWP.NewsFeed
{
    public partial class NewsFeedUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PostOnListViewModel post = new PostOnListViewModel()
            {
                PostCategory = "Category",
                ImageLink = "images/_thumb1.jpg",
                ArticleTitle = "Lorem Ipsum Dolor Sit Amet Libera Sequitor",
                ShortDescription = "Sed auctor, purus et elementum gravida, felis augue faucibus velit, nec aliquet leo tellus eget purus. Sed est metus, placerat at, commodo ut, ultrices cursus, mauris. Cum sociis natoque penatibus",
            };
            PostOnListViewModel post2 = new PostOnListViewModel()
            {
                ArticleTitle = "Lorem Ipsum Dolor Sit Amet Libera Sequitor",
                PostCategory = "Category2",
                ImageLink = "images/_thumb1.jpg",
                ShortDescription = "Sed auctor, purus et elementum gravida, felis augue faucibus velit, nec aliquet leo tellus eget purus. Sed est metus, placerat at, commodo ut, ultrices cursus, mauris. Cum sociis natoque penatibus",

            };

            List<PostOnListViewModel> list = new List<PostOnListViewModel>();
            list.Add(post);
            list.Add(post2);

            


            Posts.DataSource = list;
            Posts.DataBind();
        }
    }
}
