using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PocoModels;

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
                commentsModelList.Add(new CommentNewsModel(item, repo.userHelper.GetUserByID(item.Author.Split(';').First())));
            }

            return new CommentsNewsViewModel(commentsModelList);
        }

        public void AddComment(NewComment comment)
        {
            CommentsModel model = new CommentsModel()
            {
                CommentBody = comment.Body,
                Title = comment.Title,
                NewsLookup = int.Parse(comment.LookupID),
                //_DCDateCreated = DateTime.Now,
            };
            repo.AddElement(model);

        }
    }
}
