using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace kp
{
    public class ExcelHelper
    {
        private List<ExcelModel> items;

        public List<ExcelModel> ReadAllExcelFiles(string path)
        {
            items = new List<ExcelModel>();

            Directory.EnumerateFiles(path, "*.xlsx", SearchOption.AllDirectories)
            .ToList()
            .ForEach(f => RadExcelFile(f));

            return items;
        }

        public void RadExcelFile(string excelFilePath)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Open the Workbook:
            Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(
                excelFilePath,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // Get the first worksheet.
            // (Excel uses base 1 indexing, not base 0.)
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

            for (int row = 1; row < ws.UsedRange.Rows.Count; row++) // Count is 1048576 instead of 4
            {

                var studentId = Int64.Parse((ws.Cells[row + 1, 1] as Microsoft.Office.Interop.Excel.Range).Value.ToString());

                var cours = Int64.Parse((ws.Cells[row + 1, 3] as Microsoft.Office.Interop.Excel.Range).Value.ToString());
                var semester = Int64.Parse((ws.Cells[row + 1, 4] as Microsoft.Office.Interop.Excel.Range).Value.ToString());
                var subId = Int64.Parse((ws.Cells[row + 1, 6] as Microsoft.Office.Interop.Excel.Range).Value.ToString());
                var mark = Int64.Parse((ws.Cells[row + 1, 8] as Microsoft.Office.Interop.Excel.Range).Value.ToString());
                var attempt = Int64.Parse((ws.Cells[row + 1, 9] as Microsoft.Office.Interop.Excel.Range).Value.ToString());
                var semesterCount = Int64.Parse((ws.Cells[row + 1, 10] as Microsoft.Office.Interop.Excel.Range).Value.ToString());

                ExcelModel model = new ExcelModel()
                {
                    StudentId = (int)studentId,
                    Fulllname = ((Range)ws.Cells[row + 1, 2]).Value2.ToString(),
                    Cours = (int)cours,
                    Semester = (int)semester,
                    Speciality = ((Range)ws.Cells[row + 1, 5]).Value2.ToString(),
                    SubId = (int)subId,
                    SubName = ((Range)ws.Cells[row + 1, 7]).Value2.ToString(),
                    Mark = (int)mark,
                    Attempt = (int)attempt,
                    SemesterCount = (int)semesterCount
                };

                items.Add(model);


            }
        }

        public void AddToDB(List<ExcelModel> list)
        {
            foreach (var item in list)
            {

            }
        }

        public string CreateDirectory()
        {
            var path = ConfigurationSettings.AppSettings["SemestersDirectory"];//Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);//Directory.GetCurrentDirectory();

            string directoryName = Guid.NewGuid().ToString();

            Directory.CreateDirectory(Path.Combine(path,directoryName));

            return Path.Combine(path, directoryName);
        }

        public void SaveFilte(string path, HttpPostedFileBase file)
        {
            file.SaveAs(Path.Combine(path, file.FileName));
        }
    }
}