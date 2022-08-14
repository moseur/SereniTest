using Serenity.Services;

namespace test.Administration
{
	public class UserRoleListRequest : ServiceRequest
	{
		public int? UserID { get; set; }
	}
}