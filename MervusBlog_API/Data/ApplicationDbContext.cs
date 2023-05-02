using System;
using MervusBlog_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MervusBlog_API.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {

		}
		public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Merve",
                    LastName = "TURKMEN",
                    Mobile = "+905063694208",
                    Email = "admin@merveturkmen.com",
                    Password = "admin",
                    RegisteredDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    IsActive = true
                });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 2,
                    FirstName = "Ali",
                    MiddleName = "Kaan",
                    LastName = "TURKMEN",
                    Mobile = "+905542985313",
                    Email = "admin@alikaanturkmen.com",
                    Password = "admin",
                    RegisteredDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    IsActive = true
                });

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    NickName = "Kaan",
                    Mobile = "+905542985313",
                    Email = "admin@alikaanturkmen.com",
                    Profile = "Engineer",
                    UpdatedDate = DateTime.UtcNow,
                    IsActive = true
                });

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 2,
                    NickName = "Mervus",
                    Mobile = "+905542985313",
                    Email = "admin@merveturkmen.com",
                    Profile = "Manager",
                    UpdatedDate = DateTime.UtcNow,
                    IsActive = true
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Title = "Science",
                    Context = "This category includes posts about science",
                    IsActive = true
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 2,
                    Title = "Politics",
                    Context = "This category includes posts about politics",
                    IsActive = true
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 3,
                    Title = "Movies",
                    Context = "This category includes posts about Movies",
                    IsActive = true
                });

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    AuthorId = 1,
                    CategoryId = 1,
                    Title = "Exploring the Strange and Fascinating World of Quantum Physics",
                    Summary = "This blog post is an introduction to the world of quantum physics, which explores the behavior of matter and energy at the subatomic level. The post discusses two of the most significant concepts in quantum physics: superposition and entanglement. It also highlights the potential applications of quantum physics, including revolutionizing the way we communicate, process information, and harness energy. The post concludes by emphasizing the importance of quantum physics in challenging our understanding of the universe and unlocking its mysteries. The title \"Exploring the Strange and Fascinating World of Quantum Physics\" captures the essence of the blog post, which aims to provide a brief yet engaging overview of this exciting field.",
                    IsPublished = true,
                    Content = "Quantum physics is the study of the behavior of matter and energy at the subatomic level. It is a field that explores the strange and fascinating world of particles, waves, and probabilities. In this world, particles can exist in multiple places at once, and their behavior is influenced by the act of observation.\n\nOne of the most significant concepts in quantum physics is superposition, which describes how particles can exist in multiple states simultaneously. This phenomenon is demonstrated by the famous Schrödinger's cat thought experiment, which explores the idea of a cat being in a state of being both alive and dead at the same time.\n\nAnother crucial concept is entanglement, where particles become connected in such a way that the state of one particle is dependent on the state of the other, regardless of the distance between them. This phenomenon has the potential to revolutionize the way we communicate and process information.\n\nQuantum physics is a fascinating and rapidly evolving field that continues to challenge our understanding of the universe. Its applications have the potential to revolutionize the world of computing, communication, and energy.",
                    CreatedDate = DateTime.UtcNow,
                    PublishedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    IsActive = true
                });

            modelBuilder.Entity<PostCategory>().HasNoKey();
        }
    }
}

