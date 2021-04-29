using Builder.Ingridients;
using System.Collections.Generic;

namespace Builder
{
    class Pizza
    {
        public List<Ingridient> Ingridients { get; private set; } = new List<Ingridient>();
    }
}
