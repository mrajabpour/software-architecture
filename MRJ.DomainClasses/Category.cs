﻿using System.Collections.Generic;

namespace MRJ.DomainClasses
{
  public class Category
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public virtual ICollection<Product> Products { get; set; }
    }
}
