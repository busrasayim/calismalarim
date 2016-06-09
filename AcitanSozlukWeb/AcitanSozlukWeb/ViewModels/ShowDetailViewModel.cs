using AcitanSozlukWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AcitanSozlukWeb.ViewModels
{
    [NotMapped]
    public class ShowDetailViewModel : Article
    {
        public bool? IsLiked { get; set; }
    }
}