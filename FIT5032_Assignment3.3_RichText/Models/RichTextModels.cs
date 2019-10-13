namespace FIT5032_Assignment3._3_RichText.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RichTextModels : DbContext
    {
        public RichTextModels()
            : base("name=RichTextModels")
        {
        }

        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .Property(e => e.Contents)
                .IsUnicode(false);
        }
    }
}
