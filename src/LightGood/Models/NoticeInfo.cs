using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightGood.Models
{
    public class NoticeInfo
    {
        public string Title { get; set; }
        public string Content { get; set; }

         /// <summary>
         /// Giá trị của Type chỉ có thể là Info, Success, Warn, Error
         /// </summary>
         public string Type { get; set; }
    }
}
