using MamasRezepte.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MamasRezepte.Shared.Helper
{
    public static class FilterConverter
    {

        public static string BuildQuery(Filter _Filter)
        {
            var hSb = new StringBuilder();
            hSb.Append($"search={ _Filter.FSearch }");
            hSb.Append("&");
            hSb.Append("tags=");
            foreach(var hTag in _Filter.FTags)
            {
                hSb.Append(hTag.Name);
                if (_Filter.FTags[_Filter.FTags.Count - 1] != hTag) hSb.Append(",");
            }

            hSb.Append("&");
            hSb.Append("categories=");
            foreach (var hCategory in _Filter.FCategories)
            {
                hSb.Append(hCategory.Name);
                if (_Filter.FCategories[_Filter.FCategories.Count - 1] != hCategory) hSb.Append(",");
            }

            hSb.Append("&");
            hSb.Append("durationcategories=");
            foreach (var hDurationCategory in _Filter.FDurationCategories)
            {
                hSb.Append(hDurationCategory.Name);
                if (_Filter.FDurationCategories[_Filter.FDurationCategories.Count - 1] != hDurationCategory) hSb.Append(",");
            }

            return hSb.ToString();
        }

        public static Filter ParseQuery(string _Search, string _Tags, string _Categories, string _DurationCategories)
        {
            if (_Search == null && _Tags == null && _Categories == null && _DurationCategories == null) return null;
            var hFilter = new Filter();

            hFilter.FSearch = _Search ?? "";

            if(_Tags != null)
            {
                foreach(var hElemString in _Tags.Split(","))
                {
                    hFilter.FTags.Add(new Tag() { Name = hElemString });
                }
            }
            if (_Categories != null)
            {
                foreach (var hElemString in _Categories.Split(","))
                {
                    hFilter.FCategories.Add(new Category() { Name = hElemString });
                }
            }
            if (_DurationCategories != null)
            {
                foreach (var hElemString in _DurationCategories.Split(","))
                {
                    hFilter.FDurationCategories.Add(new DurationCategory() { Name = hElemString });
                }
            }

            return hFilter;
        }


    }
}
