using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Maps
{
    public class QuizMap : EntityTypeConfiguration<Quize>
    {
        public QuizMap()
        {
            HasKey(t => t.QuizId);

            Property(t => t.QuizId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(t => t.QuizTitle).HasMaxLength(128).IsRequired();
            Property(t => t.QuizDifficulty).HasMaxLength(50).IsRequired();


            HasMany(t => t.QuizQuestions).WithRequired(t => t.Quiz).HasForeignKey(t => t.ForQuizId);
        }
    }
}
