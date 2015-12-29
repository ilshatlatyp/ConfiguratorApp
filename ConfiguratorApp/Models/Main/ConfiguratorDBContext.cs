using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConfiguratorApp.Models.Main
{
    public class ConfiguratorDBContext: DbContext
    {
        /// <summary>
        /// Свойство. Сущность связанная с таблицей Закладки
        /// </summary>
        public DbSet<Bookmark> EFBookmark { get; set; }

        /// <summary>
        /// Свойство. Сущность связанная с таблицей Компания
        /// </summary>
        public DbSet<Company> EFCompany { get; set; }

        /// <summary>
        /// Свойство. Сущность связанная с таблицей Емайл
        /// </summary>
        public DbSet<Email> EFEmail { get; set; }

        /// <summary>
        /// Свойство. Сущность связанная с таблицей Опция
        /// </summary>
        public DbSet<Option> EFOption { get; set; }

        /// <summary>
        /// Свойство. Сущность связанная с таблицей Пакет
        /// </summary>
        public DbSet<Package> EFPackage { get; set; }

        /// <summary>
        /// Свойство. Сущность связанная с таблицей Картинка
        /// </summary>
        public DbSet<Picture> EFPicture { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Option>().HasMany<Package>(x => x.Packages)
                .WithMany(p => p.Options)
                .Map(po =>
                {
                    po.MapLeftKey("PackId");
                    po.MapRightKey("OptId");
                    po.ToTable("PackageOptions");
                });
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
