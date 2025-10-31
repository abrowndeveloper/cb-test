using System;

namespace Chillblast.Interview.API;

public class Category
{
    public Guid CategoryId { get; set; }
    public bool IsActive { get; set; }
    public string Name { get; set; }
}