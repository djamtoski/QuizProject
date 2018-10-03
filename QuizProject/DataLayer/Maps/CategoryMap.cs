using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Maps
{
    public class CategoryMap : EntityTypeConfiguration<QuizCategory>
    {
        public CategoryMap()
        {
            HasKey(t => t.CategoryId);

            Property(t => t.CategoryId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(t => t.CategoryName).HasMaxLength(50);

            HasMany(t => t.Quizes).WithRequired(t => t.Category).HasForeignKey(t => t.QuizCategoryId);
        }
    }
}
