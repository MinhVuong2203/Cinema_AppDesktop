using DTO;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.SqlServer;

namespace DAL
{
    public partial class CinemaDBContext : DbContext
    {
        // Dòng này ??m b?o provider ???c load ?úng lúc runtime
        static CinemaDBContext()
        {
            var ensureDLLIsCopied = SqlProviderServices.Instance;
        }
        public static readonly string conn = "data source=arenaapp.database.windows.net;" +
              "initial catalog=arenaapp;" +
              "persist security info=False;" +
              "user id=arenaapp;" +
              "password=Minh@212005;" +
              "trustservercertificate=True;" +
              "Encrypt=True;" +
              "MultipleActiveResultSets=True;";
             
        public CinemaDBContext() : base(conn)
        {
            
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceProduct> InvoiceProducts { get; set; }
        public virtual DbSet<InvoiceTicket> InvoiceTickets { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieProduct> MovieProducts { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<ShowTime> ShowTimes { get; set; }
        public virtual DbSet<TextTranslation> TextTranslations { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<WorkShift> WorkShifts { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<CustomerVoucher> CustomerVouchers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
            .HasRequired(a => a.Employee)
            .WithOptional(e => e.Account);


            modelBuilder.Entity<Employee>()
            .HasOptional(e => e.Account)
            .WithRequired(a => a.Employee)
            .WillCascadeOnDelete(true);


            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                 .HasOptional(e => e.Setting)
                 .WithRequired(s => s.Employee)
                 .WillCascadeOnDelete(true);


            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.TextTranslations)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seat>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Seat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<TextTranslation>()
                .Property(e => e.TextKey)
                .IsUnicode(false);

            modelBuilder.Entity<TextTranslation>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Operations)
                .WithMany(o => o.Employees)
                .Map(m =>
                {
                    m.ToTable("Employee_Operation");
                    m.MapLeftKey("EmployeeID");
                    m.MapRightKey("OperationId");
                });

            // VOUCHER

            // Voucher configurations
            modelBuilder.Entity<Voucher>()
                .Property(e => e.VoucherCode)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Voucher>()
                .HasIndex(e => e.VoucherCode)
                .IsUnique();

            modelBuilder.Entity<Voucher>()
                .Property(e => e.DiscountValue)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.MaxDiscountAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.MinOrderAmount)
                .HasPrecision(18, 2);

            // Voucher - Employee relationship (CreatedBy)
            modelBuilder.Entity<Voucher>()
                .HasOptional(v => v.Employee)
                .WithMany(e => e.CreatedVouchers)
                .HasForeignKey(v => v.CreatedBy)
                .WillCascadeOnDelete(false);

            // CustomerVoucher configurations
            modelBuilder.Entity<CustomerVoucher>()
                .Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(30);

            // CustomerVoucher - Voucher relationship
            modelBuilder.Entity<CustomerVoucher>()
                .HasRequired(cv => cv.Voucher)
                .WithMany(v => v.CustomerVouchers)
                .HasForeignKey(cv => cv.VoucherID)
                .WillCascadeOnDelete(true);

            // CustomerVoucher - Customer relationship
            modelBuilder.Entity<CustomerVoucher>()
                .HasRequired(cv => cv.Customer)
                .WithMany(c => c.CustomerVouchers)
                .HasForeignKey(cv => cv.CustomerID)
                .WillCascadeOnDelete(true);

            // CustomerVoucher - Employee relationship (RedeemedBy)
            modelBuilder.Entity<CustomerVoucher>()
                .HasOptional(cv => cv.Employee)
                .WithMany(e => e.RedeemedVouchers)
                .HasForeignKey(cv => cv.RedeemedBy)
                .WillCascadeOnDelete(false);

            // CustomerVoucher - Invoice relationship
            modelBuilder.Entity<CustomerVoucher>()
                .HasOptional(cv => cv.Invoice)
                .WithMany(i => i.CustomerVouchers)
                .HasForeignKey(cv => cv.InvoiceID)
                .WillCascadeOnDelete(false);
        }
    }
}
