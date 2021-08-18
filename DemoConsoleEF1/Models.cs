using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoConsoleEF1
{
    public class Blog
    {
        public int BlogId { get; set; } //com o nome BlogId(nome da classe e "Id"), o EF identifica que esta é a primary key da tabela
        public string Url { get; set; }
        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        public int PostId { get; set; } //com o nome PostId(nome da classe e "Id"), o EF identifica que esta é a primary key da tabela
        public int Title { get; set; }
        public int Content { get; set; }
        public Blog Blog{ get; set; }
        public int BlogId{ get; set; }
    }

    //implementando classes ao banco de dados
    public class BloggingContext : DbContext 
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public string DbPath { get; private set; }
        public BloggingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;//buscando diretorio onde está o projeto
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}blogging.db";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}