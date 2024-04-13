using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public abstract class BaseEntity
	{
		[Column(TypeName = "nvarchar(50)")]
		public string?  CreateBy { get; set; }
		[Column(TypeName = "datetime")] 
		public DateTime? CreateDate { get; set; } = DateTime.Now;
		[Column(TypeName = "nvarchar(50)")]
		public string? UpdateBy { get; set; }
		public DateTime? UpdateDate { get; set; }
		[Column(TypeName = "nvarchar(50)")]
		public string? DeleteBy { get; set; }	
		public DateTime? DeleteDate { get; set; }
		[Column(TypeName = "char(1)")]
		public string? RecordStatus { get; set; } = "A";
	}
}
