using Models.Statistics;
using NewsStaisticsWebParts.NewsStatsWP;
using SharedLib.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsStaisticsWebParts.Presenter
{
    public class NewsStatsWPPresenter: AbstractPresenter<INewsStatsWPView>
    {
        internal readonly INewsStatsModel _pModel = new NewsStatsModel();

        public void LoadNews()
        {
            NewsStatsModelSingle model = _pModel.GetModel();
            _pView.NewsCount = model.NewsCount.ToString();
            _pView.NewsPerDay = model.NewsPerDay.ToString();
        }
    }
}
