namespace FIT5032_Assignment3._3_RichText.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Message")]
    public partial class Message
    {
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string Contents { get; set; }
    }
}
