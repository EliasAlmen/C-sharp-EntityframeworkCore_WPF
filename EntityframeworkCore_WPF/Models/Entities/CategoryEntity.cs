using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkCore_WPF.Models.Entities
{
    internal class CategoryEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductEntity>
            Products
        { get; private set; } =
            new ObservableCollection<ProductEntity>();
    }
}
