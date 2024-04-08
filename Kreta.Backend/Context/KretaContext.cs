using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models.SwitchTable;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public class KretaContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<TypeOfEducation> TypeOfEducations {  get; set; } 
        public DbSet<SubjectType> SubjectTypes { get; set; }    
        public DbSet<Address> Addresss { get; set; }
        public DbSet<PublicSpace> PublicSpaces { get; set; }
        public KretaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1:N 
            modelBuilder.Entity<EducationLevel>()
                .HasMany(el => el.Students)
                .WithOne(s => s.EducationLevel)
                .HasForeignKey(s => s.EducationLevelId)
                .IsRequired(false);
            // 1:N TypeOfEducation - SchoolClass
            modelBuilder.Entity<TypeOfEducation>()
                .HasMany(toe => toe.SchoolClasses)
                .WithOne(sc => sc.TypeOfEducation)
                .HasForeignKey(sc => sc.TypeOfEducationId)
                .IsRequired(false);

            // N:M SchoolClass - Subject
            modelBuilder.Entity<SchoolClassSubjects>()
                .HasOne(schoolClassSubject => schoolClassSubject.SchoolClass)
                .WithMany(subject => subject.SchoolClassSubjects)
                .HasForeignKey(schoolClassSubject => schoolClassSubject.SchoolClassId)
                .IsRequired(false);

            modelBuilder.Entity<SchoolClassSubjects>()
                .HasOne(schoolClassSubjects => schoolClassSubjects.Subject)
                .WithMany(schoolClass => schoolClass.SchoolClassSubjects)
                .HasForeignKey(schoolClassSubjects => schoolClassSubjects.SubjectId)
                .IsRequired(false);
        }
    }
}
