using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Images
{
    public interface IImagesNewsModel:IModel
    {
        ImagesNewsViewModel GetModel(string ID);
    }
}
