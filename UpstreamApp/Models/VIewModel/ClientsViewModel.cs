using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UpstreamApp.Models
{
    public class ClientsViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int WorkNumber { get; set; }
        public int CellNumber { get; set; }
        public string ResidentialAddress { get; set; }
        public string PostalAddress { get; set; }
        public string WorkAddress { get; set; }
    }
    
}