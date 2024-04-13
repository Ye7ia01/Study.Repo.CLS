using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Entities;

public class Category
{
    public int Id { get; set; }
    public  string CategoryName   { get; set; }
    public string?  Desc  { get; set; }
    public string? Image   { get; set; }
    public int? ParentCategoryId { get; set; }
}
