   namespace ApprovalWorkflow.Domain;

   public class ApprovalRequest
   {
       public int Id { get; set; }
       public string Title { get; set; } = string.Empty;
       public string RequestedBy { get; set; } = string.Empty;
       public RequestStatus Status { get; set; } = RequestStatus.Draft;
       public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
   }