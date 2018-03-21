using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Comments
{
    public class CommentsNewsModel : ICommentsNewsModel
    {
        private readonly CommentsRepository repo = RepositoryFactory.GetRepositoryInstance<CommentsModel, CommentsRepository>();

        public CommentsNewsViewModel GetModel(string ID)
        {
            List<CommentsModel> comments =  repo.GetCommentsByNewsID(ID);
            List<CommentNewsModel> commentsModelList = new List<CommentNewsModel>();

            foreach(CommentsModel item in comments)
            {
                commentsModelList.Add(new CommentNewsModel(item));
            }

            return new CommentsNewsViewModel(commentsModelList);
        }
    }
}
