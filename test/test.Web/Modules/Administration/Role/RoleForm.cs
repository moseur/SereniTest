using Serenity.ComponentModel;
using System;

namespace test.Administration.Forms
{
	[FormScript("Administration.Role")]
	[BasedOnRow(typeof(Entities.RoleRow), CheckNames = true)]
	public class RoleForm
	{
		public String RoleName { get; set; }
	}
}