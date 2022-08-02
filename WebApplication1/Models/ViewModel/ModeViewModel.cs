using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModel
{
    public class ModeViewModel
    {
        public Model Model { get; set; }
        public IEnumerable<Make> Makes { get; set; }

        public IEnumerable<SelectListItem> CSelectListItem(IEnumerable<Make> items)
        {
            List<SelectListItem> MakeList = new List<SelectListItem>();
            SelectListItem list = new SelectListItem
            {
                Text = "-----Select----",
                Value = "0"
            };
            MakeList.Add(list);

            foreach(Make make in items)
            {
                list = new SelectListItem
                {
                    Text = make.Name,
                    Value = make.Id.ToString()
                };
                MakeList.Add(list);
            }
            return MakeList;
        }
    }
}
