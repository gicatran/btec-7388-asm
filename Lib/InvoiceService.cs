using ASM.Components;
using ASM.Constants;
using ASM.Lib.Constants;
using ASM.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
using System.IO;

namespace ASM.Lib {
    internal static class InvoiceService {
        public static void GenerateInvoice(CustomerModel customer) {
            try {
                string invoiceFileName = $"Invoice_{customer.Id}.pdf";
                string invoiceFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), invoiceFileName);

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(invoiceFilePath, FileMode.Create));
                doc.Open();

                Font titleFont = Util.Load(18, 1);
                Font normalFont = Util.Load(10);
                Font boldFont = Util.Load(12, 1);

                doc.Add(new Paragraph(Localizer.GetResources(ResourceConstants.INVOICE_TITLE), titleFont) { Alignment = Element.ALIGN_CENTER });

                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph($"{Localizer.GetResources(ResourceConstants.INVOICE_ID)}: {customer.Id}", normalFont));
                doc.Add(new Paragraph($"{Localizer.GetResources(ResourceConstants.INVOICE_NAME)}: {customer.Name}", normalFont));
                doc.Add(new Paragraph($"{Localizer.GetResources(ResourceConstants.INVOICE_TYPE)}: {customer.Type}", normalFont));
                doc.Add(new Paragraph($"{Localizer.GetResources(ResourceConstants.INVOICE_PEOPLE)}: {customer.NumberOfPeople}", normalFont));
                doc.Add(new Paragraph($"{Localizer.GetResources(ResourceConstants.INVOICE_LAST)}: {customer.LastWaterReading}", normalFont));
                doc.Add(new Paragraph($"{Localizer.GetResources(ResourceConstants.INVOICE_CURRENT)}: {customer.CurrentWaterReading}", normalFont));
                doc.Add(new Paragraph($"{Localizer.GetResources(ResourceConstants.INVOICE_CONSUMPTION)}: {customer.AmountOfConsumption}", normalFont));
                doc.Add(new Paragraph("\n"));

                doc.Add(new Paragraph($"{Localizer.GetResources(ResourceConstants.INVOICE_TOTAL)}: {Util.PrefixAndFormat(Convert.ToInt32(customer.CalculateTotalBill()))} VND", boldFont));

                doc.Close();
                Process.Start(new ProcessStartInfo(invoiceFilePath) { UseShellExecute = true });
                Toast.ShowToast($"{Localizer.GetResources(ResourceConstants.SUCCESS_INVOICE)}!", ToastType.SUCCESS);
            } catch (Exception ex) {
                Toast.ShowToast($"{Localizer.GetResources(ResourceConstants.ERROR_INVOICE)}: {ex.Message}!", ToastType.ERROR);
            }
        }
    }
}
