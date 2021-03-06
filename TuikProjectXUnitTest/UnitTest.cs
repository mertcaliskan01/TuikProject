using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TuikProject.Data;
using TuikProject.Helper;
using TuikProject.Models.CezaInfazKurumuIstatistikleriModels;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.KulturEkonomisiModels;
using TuikProject.Models.SaglikHarcamalariIstatistikleriModels;
using TuikProject.Models.SosyalKorumaIstatistikleriModels;
using TuikProject.Models.TüketiciFiyatEndeksiModels;
using Xunit;

namespace TuikProjectXUnitTest
{
    public class UnitTest
    {
        [Fact]
        public void CezaInfazKurumuIstatistikleri_CezaInfazKurumlarıSayıKapasiteBilgileri()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new CezaInfazKurumlarıSayıKapasiteBilgileri { Id = i, Aciklama = $"ExampleData{i}" });
                context.CezaInfazKurumlarıSayıKapasiteBilgileri.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getCezaInfazKurumlarıSayıKapasiteBilgileri();
                var resultSearch = controller.getCezaInfazKurumlarıSayıKapasiteBilgileri("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void CezaInfazKurumuIstatistikleri_CezaInfazKurumuCinsiyetStatuUyluk()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new CezaInfazKurumuCinsiyetStatuUyluk { Id = i, Aciklama = $"ExampleData{i}" });
                context.CezaInfazKurumuCinsiyetStatuUyluk.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getCezaInfazKurumuCinsiyetStatuUyluk();
                var resultSearch = controller.getCezaInfazKurumuCinsiyetStatuUyluk("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void IssizlikOrani_GetİştekiDurumVeEkonomikFaaliyet()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var İştekiDurumVeEkonomikFaaliyet = Enumerable.Range(1, 10)
                    .Select(i => new İştekiDurumVeEkonomikFaaliyet { Id = i, Aciklama = $"ExampleData{i}" });
                context.İştekiDurumVeEkonomikFaaliyet.AddRange(İştekiDurumVeEkonomikFaaliyet);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getİştekiDurumVeEkonomikFaaliyet();
                var resultSearch = controller.getİştekiDurumVeEkonomikFaaliyet("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void IssizlikOrani_GetSosyalGüvenlikKuruluşunaKayitlilik()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var SosyalGüvenlikKuruluşunaKayitlilik = Enumerable.Range(1, 10)
                    .Select(i => new SosyalGüvenlikKuruluşunaKayitlilik { Id = i, Aciklama = $"ExampleData{i}" });
                context.SosyalGüvenlikKuruluşunaKayitlilik.AddRange(SosyalGüvenlikKuruluşunaKayitlilik);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getSosyalGüvenlikKuruluşunaKayitlilik();
                var resultSearch = controller.getSosyalGüvenlikKuruluşunaKayitlilik("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void KulturEkonomisi_HarcamaTurlerineGoreHanehalkininHarcamalari()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new HarcamaTurlerineGoreHanehalkininHarcamalari { Id = i, HarcamaTuru = $"ExampleData{i}" });
                context.HarcamaTurlerineGoreHanehalkininHarcamalari.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getHarcamaTurlerineGoreHanehalkininHarcamalari();
                var resultSearch = controller.getHarcamaTurlerineGoreHanehalkininHarcamalari("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void KulturEkonomisi_KulturelAlanlaraGoreGenelDevletHarcamasi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new KulturelAlanlaraGoreGenelDevletHarcamasi { Id = i, KulturelAlanlar = $"ExampleData{i}" });
                context.KulturelAlanlaraGoreGenelDevletHarcamasi.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getKulturelAlanlaraGoreGenelDevletHarcamasi();
                var resultSearch = controller.getKulturelAlanlaraGoreGenelDevletHarcamasi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void SaglikHarcamalariIstatistikleri_SaglikHarcamalarininGenelToplamDagilimi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new SaglikHarcamalarininGenelToplamDagilimi { Id = i, Aciklama = $"ExampleData{i}" });
                context.SaglikHarcamalarininGenelToplamDagilimi.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getSaglikHarcamalarininGenelToplamDagilimi();
                var resultSearch = controller.getSaglikHarcamalarininGenelToplamDagilimi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void SaglikHarcamalariIstatistikleri_SaglikHizmetiSunucularinaGoreHarcamalar()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new SaglikHizmetiSunucularinaGoreHarcamalar { Id = i, Aciklama = $"ExampleData{i}" });
                context.SaglikHizmetiSunucularinaGoreHarcamalar.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getSaglikHizmetiSunucularinaGoreHarcamalar();
                var resultSearch = controller.getSaglikHizmetiSunucularinaGoreHarcamalar("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void SosyalKorumaIstatistikleri_AyniVeNakdiYardimlarinGruplaraGoreDagilimi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new AyniVeNakdiYardimlarinGruplaraGoreDagilimi { Id = i, Aciklama = $"ExampleData{i}" });
                context.AyniVeNakdiYardimlarinGruplaraGoreDagilimi.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getAyniVeNakdiYardimlarinGruplaraGoreDagilimi();
                var resultSearch = controller.getAyniVeNakdiYardimlarinGruplaraGoreDagilimi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void SosyalKorumaIstatistikleri_GruplaraGoreBrutVeNetSosyalKorumaHarcamaları()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new GruplaraGoreBrutVeNetSosyalKorumaHarcamaları { Id = i, Aciklama = $"ExampleData{i}" });
                context.GruplaraGoreBrutVeNetSosyalKorumaHarcamaları.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getGruplaraGoreBrutVeNetSosyalKorumaHarcamaları();
                var resultSearch = controller.getGruplaraGoreBrutVeNetSosyalKorumaHarcamaları("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void TüketiciFiyatEndeksi_İstatistikiBolgeBirimleriSiniflamasi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var istatistikiBolgeBirimleriSiniflamasi = Enumerable.Range(1, 10)
                    .Select(i => new İstatistikiBolgeBirimleriSiniflamasi { Id = i, Aciklama = $"ExampleData{i}" });
                context.İstatistikiBolgeBirimleriSiniflamasi.AddRange(istatistikiBolgeBirimleriSiniflamasi);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getİstatistikiBolgeBirimleriSiniflamasi();
                var resultSearch = controller.getİstatistikiBolgeBirimleriSiniflamasi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void TüketiciFiyatEndeksi_AnaHarcamaGruplari()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var anaHarcamaGruplari = Enumerable.Range(1, 10)
                    .Select(i => new AnaHarcamaGruplari { Id = i, HarcamaGruplari = $"ExampleData{i}" });
                context.AnaHarcamaGruplari.AddRange(anaHarcamaGruplari);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getAnaHarcamaGruplari();
                var resultSearch = controller.getAnaHarcamaGruplari("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void TüketiciFiyatEndeksi_TüketiciFiyatEndeksiVeDeğişimOranları()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var tüketiciFiyatEndeksiVeDeğişimOranları = Enumerable.Range(1, 10)
                    .Select(i => new TüketiciFiyatEndeksiVeDeğişimOranları { Id = i, Aciklama = $"ExampleData{i}" });
                context.TüketiciFiyatEndeksiVeDeğişimOranları.AddRange(tüketiciFiyatEndeksiVeDeğişimOranları);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getTüketiciFiyatEndeksiVeDeğişimOranları();
                var resultSearch = controller.getTüketiciFiyatEndeksiVeDeğişimOranları("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }
        }
    }
}
