using DataAccess.Concrete;
using Entity.Concrete;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tourism_Project.Models;

namespace Tourism_Project.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/pdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");


        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfReports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(4);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");
            pdfPTable.AddCell("Mail");

            pdfPTable.AddCell("Ali");
            pdfPTable.AddCell("Yılmaz");
            pdfPTable.AddCell("11111111111");
            pdfPTable.AddCell("yılmaz@gmail.com");

            pdfPTable.AddCell("Hayri");
            pdfPTable.AddCell("Kuturoğlu");
            pdfPTable.AddCell("22222222222");
            pdfPTable.AddCell("kuturoglu@gmail.com");

            pdfPTable.AddCell("Çiçek");
            pdfPTable.AddCell("Yılmaz");
            pdfPTable.AddCell("33333333333");
            pdfPTable.AddCell("cicek@gmail.com");

            pdfPTable.AddCell("Ayşe");
            pdfPTable.AddCell("Kuturoğlu");
            pdfPTable.AddCell("4444444444");
            pdfPTable.AddCell("kuturoglu@gmail.com");

            document.Add(pdfPTable);

            document.Close();

            return File("/pdfReports/dosya2.pdf", "application/pdf", "dosya2.pdf");

        }

        public IActionResult DinamicCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfReports/" + "dosya3.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();

            PdfPTable pdfPTable = new PdfPTable(4);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");
            pdfPTable.AddCell("Mail");
            foreach (var item in UsersList())
            {
                pdfPTable.AddCell(item.FirstName);
                pdfPTable.AddCell(item.LastName);
                pdfPTable.AddCell(item.UserName);
                pdfPTable.AddCell(item.Mail);
            }

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfReports/dosya3.pdf", "application/pdf", "dosya3.pdf");
        }

        public List<UserModel> UsersList()
        {
            List<UserModel> UsernModels = new List<UserModel>();
            using (var c = new Context())
            {
                UsernModels = c.Users.Select(x => new UserModel
                {
                    FirstName = x.Name,
                    LastName = x.Surname,
                    UserName = x.UserName,
                    Mail = x.Email
                }).ToList();
            }
            return UsernModels;
        }
    }
}