   using ApprovalWorkflow.Domain;

   var builder = WebApplication.CreateBuilder(args);
   builder.Services.AddOpenApi();

   var app = builder.Build();

   if (app.Environment.IsDevelopment())
   {
       app.MapOpenApi();
   }

   app.UseHttpsRedirection();

   app.MapGet("/requests", () =>
   {
       var requests = new List<ApprovalRequest>
       {
           new() { Id = 1, Title = "Laptop purchase", RequestedBy = "Aman", Status = RequestStatus.Submitted },
           new() { Id = 2, Title = "Leave request", RequestedBy = "Riya", Status = RequestStatus.Approved },
           new() { Id = 3, Title = "Travel claim", RequestedBy = "Karan", Status = RequestStatus.Draft }
       };
       return requests;
   });

   app.Run();