//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompService.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CompServiceEntities : DbContext
    {
        public CompServiceEntities()
            : base("name=CompServiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DeletedService> DeletedServices { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public virtual DbSet<MasterInfo> MasterInfoes { get; set; }
        public virtual DbSet<OrderInfo> OrderInfoes { get; set; }
        public virtual DbSet<OrderInfoWithPart> OrderInfoWithParts { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<FullOrderInfoWhenNotCompleted> FullOrderInfoWhenNotCompleteds { get; set; }
        public virtual DbSet<FullOrderInfo> FullOrderInfoes { get; set; }
    
        [DbFunction("CompServiceEntities", "OrderInfoById")]
        public virtual IQueryable<OrderInfoById_Result> OrderInfoById(Nullable<int> idOrder)
        {
            var idOrderParameter = idOrder.HasValue ?
                new ObjectParameter("idOrder", idOrder) :
                new ObjectParameter("idOrder", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<OrderInfoById_Result>("[CompServiceEntities].[OrderInfoById](@idOrder)", idOrderParameter);
        }
    
        [DbFunction("CompServiceEntities", "PartsByIdOrder")]
        public virtual IQueryable<PartsByIdOrder_Result> PartsByIdOrder(Nullable<int> idOrder)
        {
            var idOrderParameter = idOrder.HasValue ?
                new ObjectParameter("idOrder", idOrder) :
                new ObjectParameter("idOrder", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<PartsByIdOrder_Result>("[CompServiceEntities].[PartsByIdOrder](@idOrder)", idOrderParameter);
        }
    
        [DbFunction("CompServiceEntities", "ServicesByIdOrder")]
        public virtual IQueryable<ServicesByIdOrder_Result> ServicesByIdOrder(Nullable<int> idOrder)
        {
            var idOrderParameter = idOrder.HasValue ?
                new ObjectParameter("idOrder", idOrder) :
                new ObjectParameter("idOrder", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ServicesByIdOrder_Result>("[CompServiceEntities].[ServicesByIdOrder](@idOrder)", idOrderParameter);
        }
    
        public virtual int DeleteService(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteService", nameParameter);
        }
    
        public virtual int WindowsSale(Nullable<int> discount, ObjectParameter rowCount)
        {
            var discountParameter = discount.HasValue ?
                new ObjectParameter("discount", discount) :
                new ObjectParameter("discount", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("WindowsSale", discountParameter, rowCount);
        }
    
        [DbFunction("CompServiceEntities", "IncomeByMonthAndYear")]
        public virtual IQueryable<IncomeByMonthAndYear_Result> IncomeByMonthAndYear(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<IncomeByMonthAndYear_Result>("[CompServiceEntities].[IncomeByMonthAndYear](@month, @year)", monthParameter, yearParameter);
        }
    }
}
