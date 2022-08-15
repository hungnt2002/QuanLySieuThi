using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace BLL
{
    public class ExcelProduct
    {
        public static void ExportFile(DataTable dataTable)
        {
            //Tạo các đối tượng Excel

            Excel.Application oExcel = new Excel.Application();

            Excel.Workbooks oBooks;

            Excel.Sheets oSheets;

            Excel.Workbook oBook;

            Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = "Sheet1";

            // Tạo phần Tiêu đề
            //Excel.Range head = oSheet.get_Range("A1", "E1");

            //head.MergeCells = true;

            //head.Value2 = "Hóa đơn mua hàng";

            //head.Font.Bold = true;

            //head.Font.Name = "Times New Roman";

            //head.Font.Size = "20";

            //head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            

            
            // Kẻ viền

            

            // Thiết lập màu nền

            

            

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 1;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Excel.Range c1 = (Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Excel.Range c2 = (Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            // Excel.Range c3 = ( Excel.Range)oSheet.Cells[rowEnd, columnStart];

            // Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
