using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LongshoreFactor.Pages
{
    public class BusinessModel : PageModel
    {
        public List<SelectListItem> InitialOptions { get; set; }
        public void OnGet()
        {
            InitialOptions = GetInitialOptions();
        }

        private List<SelectListItem> GetInitialOptions()
        {
            var options = new Dictionary<string, string> {
                { "longYes", "Shipyard, Stevedore, Harbor Worker or Ship Breaker" },
                { "boatBuild", "Boat or Yacht Builder or Manufacturer" },
                { "repair", "Boat Repair, Sales, Cleaning, Maintenance and any other services" },
                { "marina", "Marina" },
                { "food", "Restaurant or Caterer" },
                { "club", "Yacht, Boat Club or Camp" },
                { "operator", "Boat or Vessel Operator" },
                { "fishFarm", "Fish Farmer or Processors" },
                { "marCont", "Marine Contractor" },
                { "other", "Other" }
            };

            var selectList = new List<SelectListItem>();
            foreach (var option in options)
            {
                selectList.Add(new SelectListItem {Text=option.Value, Value=option.Key });
            }

            return selectList;
        }
    }
}
