using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MovieBase.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Dialogue> Dialogues{ get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEvaluation> EmployeeEvaluations { get; set; }
        public DbSet<EmployeeLabel> EmployeeLabels { get; set; }
        public DbSet<EmployeeReward> EmployeeRewards { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GroupingMark> GroupingMarks { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MovieReward> MovieRewards { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<ServicesRating> ServicesRatings { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnMovieCreating(modelBuilder);
            OnEmployeeCreating(modelBuilder);
            OnGenreCreating(modelBuilder);
            OnRewardCreating(modelBuilder);
            OnImageCreating(modelBuilder);
            OnGroupingMarkCreating(modelBuilder);
            OnUserCreating(modelBuilder);
            OnMessageCreating(modelBuilder);
            OnDialogueCreating(modelBuilder);
            OnEvaluationCreating(modelBuilder);
            OnEmployeeLabel(modelBuilder);
        }

        private void OnMovieCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Movie>().Property(x => x.ReleaseYear).IsRequired();

            modelBuilder.Entity<Movie>().
                HasOne(u => u.ServicesRating).
                WithOne(p => p.Movie).
                HasForeignKey<ServicesRating>(p => p.MovieId);

            modelBuilder.Entity<Movie>().
                HasMany(u => u.Genres).
                WithMany(p => p.Movies).
                UsingEntity(j=>j.ToTable("MovieGenres"));

            modelBuilder.Entity<Movie>().
                HasMany(u => u.Countries).
                WithMany(p => p.Movies).
                UsingEntity(j => j.ToTable("MovieCountries"));

            modelBuilder.Entity<Movie>().
                HasMany(u => u.Images).
                WithMany(p => p.Movies).
                UsingEntity(j => j.ToTable("MovieImages"));

            modelBuilder.Entity<Movie>()
                .HasMany(c => c.Employees)
                .WithMany(s => s.Movies)
                .UsingEntity(j => j.ToTable("MovieEmployees"));

            modelBuilder.Entity<Movie>()
                .HasMany(p => p.MovieRewards)
                .WithOne(t => t.Movie)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private void OnEmployeeCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(x => x.FullName).IsRequired();
            modelBuilder.Entity<Employee>().Property(x => x.Position).IsRequired();

            modelBuilder.Entity<Employee>()
                .HasMany(p => p.EmployeeEvaluations)
                .WithOne(t => t.Employee)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                .HasMany(c => c.Images)
                .WithMany(s => s.Employees)
                .UsingEntity(j => j.ToTable("EmployeeImages"));

            modelBuilder.Entity<Employee>()
                .HasMany(p => p.EmployeeRewards)
                .WithOne(t => t.Employee)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private void OnGenreCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().Property(x => x.Name).IsRequired();
        }
        private void OnRewardCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reward>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Reward>().Property(x => x.Category).IsRequired();

            modelBuilder.Entity<Reward>()
                .HasMany(p => p.EmployeeRewards)
                .WithOne(t => t.Reward)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reward>()
                .HasMany(p => p.MovieRewards)
                .WithOne(t => t.Reward)
                .OnDelete(DeleteBehavior.Cascade);
        }
        private void OnImageCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().Property(x => x.Path).IsRequired();
        }
        private void OnGroupingMarkCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupingMark>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<GroupingMark>()
                .HasMany(p => p.Evaluations)
                .WithOne(t => t.GroupingMark)
                .OnDelete(DeleteBehavior.Restrict);
        }
        private void OnUserCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Login).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Password).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Role).IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(c => c.Dialogues)
                .WithMany(s => s.Users)
                .UsingEntity(j => j.ToTable("UserDialogues"));

            modelBuilder.Entity<User>()
                .HasMany(p => p.Evaluations)
                .WithOne(t => t.User)
                .OnDelete(DeleteBehavior.Cascade);
        }
        private void OnMessageCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().Property(x => x.Text).IsRequired();
            modelBuilder.Entity<Message>().Property(x => x.Date).IsRequired();
        }

        private void OnDialogueCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dialogue>()
                .HasMany(p => p.Messages)
                .WithOne(t => t.Dialogue)
                .OnDelete(DeleteBehavior.Cascade);
        }
        private void OnEvaluationCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evaluation>()
                .HasMany(c => c.EmployeeEvaluations)
                .WithOne(s => s.Evaluation)
                .OnDelete(DeleteBehavior.Cascade);
        }
        private void OnEmployeeLabel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeLabel>()
                .HasMany(p => p.EmployeeEvaluations)
                .WithOne(t => t.EmployeeLabel)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
