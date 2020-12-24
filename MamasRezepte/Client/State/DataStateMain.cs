using MamasRezepte.Shared.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamasRezepte.Client.State
{
    public class DataStateMain
    {

        public event Action OnChange;

        public Filter FFilter { get; set; } = new Filter();

        public void UpdateFilter(Filter _Filter)
        {
            FFilter = _Filter;
            
        }


        public void NotifyStateChanged() => OnChange?.Invoke();

    }
}
