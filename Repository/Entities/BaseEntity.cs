using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Repository.Entities
{
	public class BaseEntity:IEntity//buda core de tanımladığımız generic IEntity
	{
		public int Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public int? CreatedBy { get; set; }
		public int? UpdatedBy { get; set; }
		public int? DeletedBy { get; set; }
		public int RowOrder { get; set; }

	}
}
