using AcitanSozlukWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcitanSozlukWeb.ViewModels
{
    public class HomePageViewModel
    {
        public List<Article> Articles { get; set; }
        public List<int> LikedArticleIds { get; set; }
        public List<int> DislikedArticleIds { get; set; }

        public HomePageViewModel()
        {
            Articles = new List<Article>();
            LikedArticleIds = new List<int>();
            DislikedArticleIds = new List<int>();
        }
    }
}