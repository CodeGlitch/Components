using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Model
{
    public class MyDataStructure
    {
        [Display(Name = "ID")]
        public int? PK_MyDataStructure { get; set; }//will be generated on SQL INSERT, sql server side

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Date"), Required(ErrorMessage = "Please fill the date"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DataDate { get; set; }

        [Display(Name = "Type"), Required(ErrorMessage = "Please select the type")]
        public int? FK_Type { get; set; }

        [Display(Name = "Active"), Required(ErrorMessage = "Please select if this data is active or not")]
        public bool Active { get; set; }

        [Display(Name = "Usage"), Required(ErrorMessage = "Please select the usage")]
        public int? FK_Usage { get; set; }
    }
}
