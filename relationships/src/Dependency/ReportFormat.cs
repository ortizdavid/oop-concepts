namespace Dependency;

public static class ReportFormat
{
    public static IActionResult Handle(Generator generator, string format, object data)
    {
        return format switch
        {
            "excel" => new FileContentResult(generator.GenerateExcel(data), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"),
            "csv" => new FileContentResult(generator.GenerateCsv(data), "text/csv"),
            "pdf" => new FileContentResult(generator.GeneratePDF(data), "application/pdf"),
            _ => new BadRequestResult()
        };
    }
}
