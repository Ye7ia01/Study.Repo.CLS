using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Product:BaseEntity
{
	[Key]
	public int ProductId { get; set; }
	public string ProductName { get; set; }
	public string? Desc { get; set; }
	public int Price { get; set; }
	public string? DefaultImage { get; set; }
	public string? Images { get; set; }
	public double Review { get; set; }
	public int CategoryId { get; set; }
	public Category Category { get; set; }
}
