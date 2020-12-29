using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TuikProject.Data;
using TuikProject.Helper;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.TüketiciFiyatEndeksiModels;
using Xunit;

namespace TuikProjectXUnitTest
{
    public class UnitTest1
    {


        [Fact]
        public void DbHelper_GetİştekiDurumVeEkonomikFaaliyet()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var İştekiDurumVeEkonomikFaaliyet = Enumerable.Range(1, 10)
                    .Select(i => new İştekiDurumVeEkonomikFaaliyet { Id = i, Aciklama = $"ExampleData{i}" });
                context.İştekiDurumVeEkonomikFaaliyet.AddRange(İştekiDurumVeEkonomikFaaliyet);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getİştekiDurumVeEkonomikFaaliyet();

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }

        [Fact]
        public void DbHelper_GetSosyalGüvenlikKuruluşunaKayitlilik()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var SosyalGüvenlikKuruluşunaKayitlilik = Enumerable.Range(1, 10)
                    .Select(i => new SosyalGüvenlikKuruluşunaKayitlilik { Id = i, Aciklama = $"ExampleData{i}" });
                context.SosyalGüvenlikKuruluşunaKayitlilik.AddRange(SosyalGüvenlikKuruluşunaKayitlilik);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getSosyalGüvenlikKuruluşunaKayitlilik();

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }

        [Fact]
        public void DbHelper_GetİstatistikiBolgeBirimleriSiniflamasi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var istatistikiBolgeBirimleriSiniflamasi = Enumerable.Range(1, 10)
                    .Select(i => new İstatistikiBolgeBirimleriSiniflamasi { Id = i, Aciklama = $"ExampleData{i}" });
                context.İstatistikiBolgeBirimleriSiniflamasi.AddRange(istatistikiBolgeBirimleriSiniflamasi);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getİstatistikiBolgeBirimleriSiniflamasi();

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }


        [Fact]
        public void DbHelper_GetAnaHarcamaGruplari()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var anaHarcamaGruplari = Enumerable.Range(1, 10)
                    .Select(i => new AnaHarcamaGruplari { Id = i, Agirliklari = $"ExampleData{i}" });
                context.AnaHarcamaGruplari.AddRange(anaHarcamaGruplari);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getAnaHarcamaGruplari();

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }


        [Fact]
        public void DbHelper_GetTüketiciFiyatEndeksiVeDeğişimOranları()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var tüketiciFiyatEndeksiVeDeğişimOranları = Enumerable.Range(1, 10)
                    .Select(i => new TüketiciFiyatEndeksiVeDeğişimOranları { Id = i, Aciklama = $"ExampleData{i}" });
                context.TüketiciFiyatEndeksiVeDeğişimOranları.AddRange(tüketiciFiyatEndeksiVeDeğişimOranları);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getTüketiciFiyatEndeksiVeDeğişimOranları();

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }
    }
}
