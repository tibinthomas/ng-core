using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Controllers.Resources
{
    public class MakeResource
    {
         public int Id { get; set; }

        
        public string Name { get; set; }
        public ICollection<ModelResource> Model { get; set; }

        public MakeResource()
        {
            Model = new Collection<ModelResource>();
        }
    }
}