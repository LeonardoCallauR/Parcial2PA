using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2PA.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public AlbumViewModel Countries { get; set; }
        #endregion
        #region Constructor
        public MainViewModel()
        {
            this.Countries = new AlbumViewModel();
        }
        #endregion
    }
}
