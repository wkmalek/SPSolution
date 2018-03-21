using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedLib.Presenter
{
    public class AbstractPresenter<TView> where TView : IMyView
    {
        public TView _pView { get; set; }
    }
}
