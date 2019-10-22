namespace ClassLib
{
    using OfficeOpenXml;

    public class Class1
    {
        public void MakeExcel()
        {
            using (var package = new ExcelPackage())
            {
                // Use 'package'
                package.Compatibility.IsWorksheets1Based = true;
            }
        }
    }
}
