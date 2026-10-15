   using ApprovalWorkflow.Domain;
   using Microsoft.EntityFrameworkCore;

   namespace ApprovalWorkflow.Infrastructure;

   public class AppDbContext : DbContext
   {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
       {
       }

       public DbSet<ApprovalRequest> ApprovalRequests => Set<ApprovalRequest>();

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<ApprovalRequest>().HasData(
               new ApprovalRequest { Id = 1, Title = "Laptop purchase", RequestedBy = "Aman", Status = RequestStatus.Submitted, CreatedAt = new DateTime(2026, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
               new ApprovalRequest { Id = 2, Title = "Leave request", RequestedBy = "Riya", Status = RequestStatus.Approved, CreatedAt = new DateTime(2026, 10, 2, 0, 0, 0, DateTimeKind.Utc) },
               new ApprovalRequest { Id = 3, Title = "Travel claim", RequestedBy = "Karan", Status = RequestStatus.Draft, CreatedAt = new DateTime(2026, 10, 3, 0, 0, 0, DateTimeKind.Utc) }
           );
       }
   }