using LightGood.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightGood.Models
{
   public class SupportUser
   {
      public SupportUser(string name,string contact,string headerurl,string describe, string[] supportTypes)
      {
         Name = name;
         Contact = contact;
         Header = headerurl;
         Describe = describe;
         SupportTypes = supportTypes;
      }
      public int Id { get; set; }
      public string Name { get; set; }
      public string Contact { get; set; }
      public string Header { get; set; }
      public string Describe { get; set; }
      public string[] SupportTypes { get; set; }
   }
}
