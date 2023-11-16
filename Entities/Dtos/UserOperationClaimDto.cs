namespace Entities.Dtos
{
	public class UserOperationClaimDto
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
        public string OperationName { get; set; }
        public string OperationDescription { get; set; }
    }
}

