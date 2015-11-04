using DataCleansing.Models;
using DataCleansing.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCleansing.Web.ViewModels
{
    public class BicCodeEuropeViewModels : IMapFrom<BicCodeEurope>
    {
        public int Id { get; set; }

        public string BankOrInstitution { get; set; }

        public string BankCode { get; set; }
    }
}
