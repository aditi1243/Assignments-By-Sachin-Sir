using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myapp
{
	public class Employeemodel
	{

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public  Addressid { get; set; }
		public string Code { get; set; }

	public Addressmodel Address { get; set; }
	}
}