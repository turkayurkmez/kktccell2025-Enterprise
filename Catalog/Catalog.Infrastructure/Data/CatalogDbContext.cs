using Catalog.Entities;
using Catalog.Entities.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Data
{
    public class CatalogDbContext : DbContext
    {

        private readonly IMediator mediator;

    

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////yukarıdaki tablolar(DbSet<>) nasıl oluşturulacak?
            //// one - to - many
            //// not null gibi ayarlar.


            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired()
                                                                .HasMaxLength(200);

            modelBuilder.Entity<Product>().HasOne(x => x.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(x => x.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);


            DateTime sampleCreatedDate = new DateTime(2025, 11, 10);

            modelBuilder.Entity<Category>().HasData(new Category(
                1, 
                "Elektronik", 
                "Elektronik ürünler") { CreatedDate = sampleCreatedDate },

                new Category(
                2,
                "Kırtasiye",
                "Kırtasiye işte...")
                { CreatedDate = sampleCreatedDate },

                new Category(
                3,
                "Mobilya",
                "Mobilya ürünleri...")
                { CreatedDate = sampleCreatedDate }
                );

            modelBuilder.Entity<Product>().HasData(new Product("Lenovo X1 Carbon ", "Hafif Business", 980000, 100, null, 1) { Id= Guid.Parse("17225ee5-4716-4fe8-9462-02f160d24afd"), CreatedDate = sampleCreatedDate },
                new Product("DELL XPS 15 ", "Eski Business", 980000, 100, null, 1) { CreatedDate = sampleCreatedDate, Id = Guid.Parse("53ad4035-c80c-4595-aae1-c9ce0505bb4b") },

                new Product("A4 Defter ", ".....", 500, 100, null, 2) { CreatedDate = sampleCreatedDate, Id = Guid.Parse("1b79b23e-2df0-477d-b8c0-47e14ecc1388") },
                new Product("Faber Castell", ".....", 500, 100, null, 2) { CreatedDate = sampleCreatedDate, Id = Guid.Parse("74db89f8-6462-4e9e-9bd4-910833e3f15a") },

                 new Product("Sehpa", ".....", 500, 100, null, 3) { CreatedDate = sampleCreatedDate, Id = Guid.Parse("aeded193-f269-4dc8-a781-3c5712ae7af1") },
                  new Product("Koltuk", ".....", 500, 100, null, 3) { CreatedDate = sampleCreatedDate, Id = Guid.Parse("c15a9f7f-7406-4eb5-b46d-600032a5a68e") }      
                  
                  );

            /*
             *   { new Guid("17225ee5-4716-4fe8-9462-02f160d24afd"), 3, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ".....", null, "Koltuk", 500m, 100, null },
                    { new Guid("1b79b23e-2df0-477d-b8c0-47e14ecc1388"), 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hafif Business", null, "Lenovo X1 Carbon ", 980000m, 100, null },
                    { new Guid("53ad4035-c80c-4595-aae1-c9ce0505bb4b"), 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eski Business", null, "DELL XPS 15 ", 980000m, 100, null },
                    { new Guid("74db89f8-6462-4e9e-9bd4-910833e3f15a"), 3, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ".....", null, "Sehpa", 500m, 100, null },
                    { new Guid("aeded193-f269-4dc8-a781-3c5712ae7af1"), 2, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ".....", null, "A4 Defter ", 500m, 100, null },
                    { new Guid("c15a9f7f-7406-4eb5-b46d-600032a5a68e"), 2, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ".....", null, "Faber Castell", 500m, 100, null }
             */

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer()
        //    ////db nerede?
        //    //base.OnConfiguring(optionsBuilder);
        //}

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options, IMediator mediator) : base(options)
        {
            this.mediator = mediator;
            
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            //db'ye kayıt gerçekleşirken yapılacak ekstra işlemler:
            //Örnek: Domain olayını fırlatmak!!!!!

            /*
             * Db'ye gönderilen entity'nin olayı var mı?
             * Eğer varsa, db'ye kaydettikten sonra hepsini fırlat.
             */


            var domainEvents = ChangeTracker.Entries<IAggregateRoot>()
                                            .Where(e => e.Entity.DomainEvents != null && e.Entity.DomainEvents.Any())
                                            .SelectMany(e => e.Entity.DomainEvents)
                                            .ToList();



            var output = await base.SaveChangesAsync(cancellationToken);

            foreach (var @event in domainEvents)
            {
                //olayı fırlat....
                 mediator.Publish(@event, cancellationToken).ConfigureAwait(true);
            }


            return output;

        }


    }
}
