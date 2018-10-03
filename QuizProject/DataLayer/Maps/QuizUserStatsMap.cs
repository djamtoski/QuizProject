using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Maps
{
    public class QuizUserStatsMap : EntityTypeConfiguration<QuizUserStats>
    {
        public QuizUserStatsMap()
        {
            HasKey(t => t.QuizStatsId);

            Property(t => t.QuizStatsId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(t => t.TimePlayed).IsRequired();

            HasRequired(t => t.Quiz).WithOptional(t => t.QuizUserStats);
            HasRequired(t => t.User).WithOptional(t => t.QuizUserStats);
        }
    }
}
