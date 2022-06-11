using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebEnkom.Domain.Entity;

namespace WebEnkom.HtmlHelpers
{
    public static class Helpers
    {
        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<Sex> sexList)
        {
            var result = "";
            foreach (var sex in sexList)
            {
                result = $"{result}<option>{sex.Name}</option>";
            }
            return new HtmlString(result);
        }
    }
}
