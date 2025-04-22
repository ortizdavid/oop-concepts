namespace Dependency;

public class ReportController
{
    private readonly ReportService _service;
    private readonly Generator _generator;

    public ReportController(ReportService service, Generator generator)
    {
        _service = service;
        _generator = generator;
    }

    public IActionResult AllProducts(string format)
    {
        var data = _service.GetAllProducts();
        return ReportFomat.Handle(_generator, format, data);
    }

    public IActionResult ProductsBySupplier(string format)
    {
        var data = _service.GetAllProductsBySupplier();
        return ReportFomat.Handle(_generator, format, data);
    }

    public IActionResult ProductsByCategories(string format)
    {
        var data = _service.GetAllProductsByCategories();
        return ReportFomat.Handle(_generator, format, data);
    }
}
