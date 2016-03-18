// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.52
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace XunitDemo.Entity
{
    using System;
    using System.Data.Entity;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.18.1.0")]
    public partial class FakeNorthwindDbContext : INorthwindDbContext
    {
        public System.Data.Entity.DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        public System.Data.Entity.DbSet<Category> Categories { get; set; }
        public System.Data.Entity.DbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; }
        public System.Data.Entity.DbSet<CurrentProductList> CurrentProductLists { get; set; }
        public System.Data.Entity.DbSet<Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        public System.Data.Entity.DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public System.Data.Entity.DbSet<Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<Invoice> Invoices { get; set; }
        public System.Data.Entity.DbSet<Order> Orders { get; set; }
        public System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; }
        public System.Data.Entity.DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        public System.Data.Entity.DbSet<OrdersQry> OrdersQries { get; set; }
        public System.Data.Entity.DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        public System.Data.Entity.DbSet<Product> Products { get; set; }
        public System.Data.Entity.DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        public System.Data.Entity.DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; }
        public System.Data.Entity.DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        public System.Data.Entity.DbSet<Region> Regions { get; set; }
        public System.Data.Entity.DbSet<SalesByCategory> SalesByCategories { get; set; }
        public System.Data.Entity.DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        public System.Data.Entity.DbSet<Shipper> Shippers { get; set; }
        public System.Data.Entity.DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        public System.Data.Entity.DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        public System.Data.Entity.DbSet<Supplier> Suppliers { get; set; }
        public System.Data.Entity.DbSet<Territory> Territories { get; set; }

        public FakeNorthwindDbContext()
        {
            AlphabeticalListOfProducts = new FakeDbSet<AlphabeticalListOfProduct>("ProductId", "ProductName", "Discontinued", "CategoryName");
            Categories = new FakeDbSet<Category>("CategoryId");
            CategorySalesFor1997 = new FakeDbSet<CategorySalesFor1997>("CategoryName");
            CurrentProductLists = new FakeDbSet<CurrentProductList>("ProductId", "ProductName");
            Customers = new FakeDbSet<Customer>("CustomerId");
            CustomerAndSuppliersByCities = new FakeDbSet<CustomerAndSuppliersByCity>("CompanyName", "Relationship");
            CustomerDemographics = new FakeDbSet<CustomerDemographic>("CustomerTypeId");
            Employees = new FakeDbSet<Employee>("EmployeeId");
            Invoices = new FakeDbSet<Invoice>("CustomerName", "Salesperson", "OrderId", "ShipperName", "ProductId", "ProductName", "UnitPrice", "Quantity", "Discount");
            Orders = new FakeDbSet<Order>("OrderId");
            OrderDetails = new FakeDbSet<OrderDetail>("OrderId", "ProductId");
            OrderDetailsExtendeds = new FakeDbSet<OrderDetailsExtended>("OrderId", "ProductId", "ProductName", "UnitPrice", "Quantity", "Discount");
            OrdersQries = new FakeDbSet<OrdersQry>("OrderId", "CompanyName");
            OrderSubtotals = new FakeDbSet<OrderSubtotal>("OrderId");
            Products = new FakeDbSet<Product>("ProductId");
            ProductsAboveAveragePrices = new FakeDbSet<ProductsAboveAveragePrice>("ProductName");
            ProductSalesFor1997 = new FakeDbSet<ProductSalesFor1997>("CategoryName", "ProductName");
            ProductsByCategories = new FakeDbSet<ProductsByCategory>("CategoryName", "ProductName", "Discontinued");
            Regions = new FakeDbSet<Region>("RegionId");
            SalesByCategories = new FakeDbSet<SalesByCategory>("CategoryId", "CategoryName", "ProductName");
            SalesTotalsByAmounts = new FakeDbSet<SalesTotalsByAmount>("OrderId", "CompanyName");
            Shippers = new FakeDbSet<Shipper>("ShipperId");
            SummaryOfSalesByQuarters = new FakeDbSet<SummaryOfSalesByQuarter>("OrderId");
            SummaryOfSalesByYears = new FakeDbSet<SummaryOfSalesByYear>("OrderId");
            Suppliers = new FakeDbSet<Supplier>("SupplierId");
            Territories = new FakeDbSet<Territory>("TerritoryId");

            InitializePartial();
        }
        
        public int SaveChangesCount { get; private set; } 
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
        public System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId)
        {
            int procResult;
            return CustOrderHist(customerId, out procResult);
        }

        public System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<CustOrderHistReturnModel>();
        }

        public System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId)
        {
            int procResult;
            return CustOrdersDetail(orderId, out procResult);
        }

        public System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<CustOrdersDetailReturnModel>();
        }

        public System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId)
        {
            int procResult;
            return CustOrdersOrders(customerId, out procResult);
        }

        public System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<CustOrdersOrdersReturnModel>();
        }

        public System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return EmployeeSalesByCountry(beginningDate, endingDate, out procResult);
        }

        public System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<EmployeeSalesByCountryReturnModel>();
        }

        public System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return SalesByYear(beginningDate, endingDate, out procResult);
        }

        public System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SalesByYearReturnModel>();
        }

        public System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear)
        {
            int procResult;
            return SalesByCategory(categoryName, ordYear, out procResult);
        }

        public System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SalesByCategoryReturnModel>();
        }

        public System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts()
        {
            int procResult;
            return TenMostExpensiveProducts(out procResult);
        }

        public System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts(out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<TenMostExpensiveProductsReturnModel>();
        }

    }
}
// </auto-generated>
