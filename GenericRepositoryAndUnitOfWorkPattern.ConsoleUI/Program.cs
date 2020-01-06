using GenericRepositoryAndUnitOfWorkPattern.Business.UnitOfWork.Concrete;
using GenericRepositoryAndUnitOfWorkPattern.DataAccess;
using GenericRepositoryAndUnitOfWorkPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var Personeller = new List<Personel>()
            {
                new Personel(){Ad="Ahmet",Soyad="Yılmaz"},
                new Personel(){Ad="Mehmet",Soyad="Akkuyu"},
                new Personel(){Ad="Hayrettin",Soyad="Aksoy"},
                new Personel(){Ad="Ali",Soyad="Şanslı"}
            };

            var projeMobil = new Proje();
            projeMobil.İsim = "Mobile Aplication";
            projeMobil.Personeller.Add(Personeller[0]);
            projeMobil.Personeller.Add(Personeller[1]);
            projeMobil.Personeller.Add(Personeller[2]);

            var projeWeb = new Proje();
            projeWeb.İsim = "Web Aplication";
            projeWeb.Personeller.Add(Personeller[1]);
            projeWeb.Personeller.Add(Personeller[2]);
            projeWeb.Personeller.Add(Personeller[3]);

            UnitOfWork unitOfWork = new UnitOfWork(new GenericRepositoryAndUnitOfWorkPatternDbContext());
            unitOfWork.PersonelRepository.CokluEkle(Personeller);
            unitOfWork.ProjeRepository.Ekle(projeMobil);
            unitOfWork.ProjeRepository.Ekle(projeWeb);

            unitOfWork.Complete();
            unitOfWork.Dispose();

            Console.WriteLine("İşlem tamam");
            Console.ReadLine();
        }
    }
}
