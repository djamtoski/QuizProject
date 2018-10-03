using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Maps
{
    public class QuizQuestionMap : EntityTypeConfiguration<QuizQuestion>
    {
        public QuizQuestionMap()
        {
            HasKey(t => t.QuestionId);

            Property(t => t.QuestionId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(t => t.QuestionText).HasMaxLength(256).IsRequired();

            HasMany(t => t.Answers).WithRequired(t => t.QuizQuestion).HasForeignKey(t => t.ForQuestionId);
        }
    }
}
