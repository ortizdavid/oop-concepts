namespace Dependency;

public class ReportService
{
    private readonly Repository _repository;

    public ReportService(Repository repository)
    {
        _repository = repository;
    }

    public object GetAllProducts() => _repository.FetchAllProducts();

    public object GetAllProductsBySupplier() => _repository.FetchBySupplier();

    public object GetAllProductsByCategories() => _repository.FetchByCategory();
}
