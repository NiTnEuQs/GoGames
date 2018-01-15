using System;
using System.ComponentModel.DataAnnotations;

namespace SiteWebMVC.Models
{
    public class Reminder
    {
        public int ID { get; set; }
        
        [Display(Name = "Titre")]
        public string Title { get; set; }
        
        [Display(Name = "Description")]
        public string Description { get; set; }
        
        [Display(Name = "Date de rappel")]
        [DataType(DataType.DateTime)]
        public DateTime RemindDate { get; set; }
        
        [Display(Name = "Date de création")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
    }
}