using Parcial2PA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2PA.ViewModels
{
    public class AlbumViewModel:BaseViewModel
    {
        #region Services
        private apiService apiService;
        #endregion
        #region Attribute
        private string tittle;
        private int Id;
        #endregion
        #region Properties
        public string Tittle
        {
            get { return this.tittle; }
            set { SetValue(ref this.tittle, value); }
        }
        public int AlbumId
        {
            get { return this.Id; }
            set { SetValue(ref this.Id, value); }
        }
        #endregion
        #region Methods
        private async void LoadCountry()
        {
            var Id = await this.apiService.Get<AlbumModel>("https://jsonplaceholder.typicode.com/", "", "photos/");
            this.Tittle = Id[0].Tittle;
            this.AlbumId = Id[0].AlbumId;
        }
        #endregion

    }
}
