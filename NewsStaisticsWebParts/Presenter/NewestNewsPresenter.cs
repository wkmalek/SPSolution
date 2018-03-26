using Models.News;
using Models.Statistics;
using NewsStaisticsWebParts.NewestNewsStats;
using SharedLib.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsStaisticsWebParts.Presenter
{
    public class NewestNewsPresenter:AbstractPresenter<INewestNewsView>
    {
        internal readonly INewestNewsModel _pModel = new NewestNewsModel();

        internal void LoadNewestNews()
        {
            NewestNewsModelSingle model = _pModel.GetModel();
            _pView._Description = model._Description;
            _pView._imageUrl = model._imageUrl;
            _pView._listUrl = model._listUrl;
            _pView._Title = model._Title;
        }

    }
}
