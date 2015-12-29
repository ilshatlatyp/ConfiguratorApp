﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Package>().HasMany<Option>(x => x.Options)
                .WithRequired()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Package>().HasMany<Option>(x=>x.Options)
                .WithMany(p=>p.Packages)
                .Map(po =>
                {
                    po.MapLeftKey("PackageId");
                    po.MapRightKey("OptionId");
                    po.ToTable("PackageOptions");
                });
        }
    }
}
