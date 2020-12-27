using MamasRezepte.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamasRezepte.Shared.Helper
{
    public class Filter
    {

        public List<Category> FCategories { get; set; } = new List<Category>();
        public List<DurationCategory> FDurationCategories { get; set; } = new List<DurationCategory>();
        public List<Tag> FTags { get; set; } = new List<Tag>();
        public string FSearch { get; set; } = "";

        public bool IsEmpty() => !FTags.Any() && !FDurationCategories.Any() && !FCategories.Any() && FSearch == ""; // maybe wrong result?

        public void AddToFilter(object _Object)
        {
            if (Contains(_Object)) return;
            if (_Object is Category)
            {
                FCategories.Add(_Object as Category);
            }
            else if (_Object is DurationCategory)
            {
                FDurationCategories.Add(_Object as DurationCategory);
            }
            else if (_Object is Tag)
            {
                FTags.Add(_Object as Tag);
            }
            else if (_Object is string)
            {
                FSearch = (string)_Object;
            }
        }

        public void RemoveFromFilter(object _Object)
        {
            if (_Object is Category)
            {
                FCategories.Remove(_Object as Category);
            }
            else if (_Object is DurationCategory)
            {
                FDurationCategories.Remove(_Object as DurationCategory);
            }
            else if (_Object is Tag)
            {
                FTags.Remove(_Object as Tag);
            }
        }

        public bool Contains(object _Object)
        {
            if(_Object is Category)
            {
                return FCategories.Contains(_Object);
            } 
            else if (_Object is DurationCategory)
            {
                return FDurationCategories.Contains(_Object);
            }
            else if (_Object is Tag)
            {
                return FTags.Contains(_Object);
            }
            else if (_Object is string)
            {
                return FSearch == (string)_Object;
            }
            return false;
        }

        public void ClearFilter()
        {
            FCategories.Clear();
            FTags.Clear();
            FDurationCategories.Clear();
            FSearch = "";
        }

        public void ClearSearch()
        {
            FSearch = "";
        }

        public bool HasSearch()
        {
            return FSearch != null && FSearch != "";
        }

    }
}
