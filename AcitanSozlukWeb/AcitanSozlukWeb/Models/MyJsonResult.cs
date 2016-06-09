using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcitanSozlukWeb.Models
{
    public class MyJsonResult<T,K>
    {
        public bool HasError { get; set; }
        public string Error { get; set; }
        public T Value1 { get; set; }
        public K Value2 { get; set; }
    }
}