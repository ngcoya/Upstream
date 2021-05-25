using UpstreamApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office;
using OfficeOpenXml;
using ContosoUniversity.DAL;

namespace UpstreamApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.clientList = loadClients();

            return View(new ClientsViewModel());
        }

        [HttpPost]
        public ActionResult Index(UpstreamApp.Models.ClientsViewModel c)
        {
                using (var db = new UpstreamContext())
                {
                    db.Clients.Add(new Models.Clients
                    {
                        CellNumber = c.CellNumber,
                        Gender = c.Gender,
                        Name = c.Name,
                        PostalAddress = c.PostalAddress,
                        ResidentialAddress = c.ResidentialAddress,
                        Surname = c.Surname,
                        WorkAddress = c.WorkAddress,
                        WorkNumber = c.WorkNumber
                    });
                db.SaveChanges(); 
                }
  
            ViewBag.clientList = loadClients();

            return Index();
        }

        public List<Clients> loadClients()
        {
            List<Clients> ClientList = new List<Clients>();

            using (var db = new UpstreamContext())
            {
                ClientList = (from clients in db.Clients select clients).ToList<Clients>();
            }

            return ClientList;
        }

        public ActionResult GetExcelFile()
        {
            var fileDownloadName = "File.xlsx";
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            
            var package = new ExcelPackage();
            
            var fileStream = new MemoryStream();
            package.SaveAs(fileStream);
            fileStream.Position = 0;
            
            return File(fileStream, contentType, fileDownloadName);
        }
    }
}