using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GainCall.Entity;

namespace GainCall.Web.Models
{
    public class ProductSearchInfo
    {
        public List<State> States { get; set; }
        public List<City> Cities { get; set; }

        public List<ProductType> ProductTypes { get; set; }

        [Required(ErrorMessage = "Search Text is Required.")]
        [MinLength(3,ErrorMessage = "Enter minimum of 3 characters.")]
        [MaxLength(10,ErrorMessage = "Maximum 10 characters allowed.")]
        public string SearchText { get; set; }

        [Required(ErrorMessage = "State is Required.")]
        public int StateId { get; set; }

        [Required(ErrorMessage = "City is Required.")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "Type is Required.")]
        public int ProductTypeId { get; set; }
    }

    public class FileDetail
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int SupportId { get; set; }
        public virtual Support Support { get; set; }

    }

    public class Support
    {
        public int SupportId { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [Display(Name = "Name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Summary")]
        [Display(Name = "Summary")]
        [MaxLength(500)]
        public string Summary { get; set; }

        public virtual ICollection<FileDetail> FileDetails { get; set; }

    }
}