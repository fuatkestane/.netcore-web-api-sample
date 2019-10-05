using System.Collections.Generic;
using System;
using NetCoreWebApi.Model;

namespace NetCoreWebApi.DataSource
{
    public class ApiDataSource
    {
        public static ApiDataSource Current { get; } = new ApiDataSource();
        public List<Categories> categories { get; set; }
        public ApiDataSource() => categories = new List<Categories>()
            {
                new Categories()
                {
                    Id=1,
                    Name="Macera",
                    booksOfInterest= new List<BooksOfInterest>()
                    {
                        new BooksOfInterest()
                        {
                            Id=1,
                            Name="Kuantum Casusu",
                            Author="David"
                        },
                        new BooksOfInterest()
                        {
                            Id=2,
                            Name="Sahte Krallık",
                            Author="Bardugo"
                        },
                        new BooksOfInterest()
                        {
                            Id=3,
                            Name="Yaşam Sinyali",
                            Author="Jose Rodrigues"
                        }
                    }
                },
                new Categories()
                {
                    Id=2,
                    Name="Korku",
                    booksOfInterest= new List<BooksOfInterest>()
                    {
                        new BooksOfInterest()
                        {
                            Id=1,
                            Name="Gölgeler",
                            Author="Jack London"
                        },
                        new BooksOfInterest()
                        {
                            Id=2,
                            Name="Cinayet Şirketi",
                            Author="Jack London"
                        },
                        new BooksOfInterest()
                        {
                            Id=3,
                            Name="Ruh Kırıcı",
                            Author="Sebastian"
                        }
                    }
                },
                new Categories()
                {
                    Id=2,
                    Name="Tarih",
                    booksOfInterest= new List<BooksOfInterest>()
                    {
                        new BooksOfInterest()
                        {
                            Id=1,
                            Name="Barbarossa",
                            Author="İskender Pala"
                        },
                        new BooksOfInterest()
                        {
                            Id=2,
                            Name="Home Deus",
                            Author="Noah Harrari"
                        },
                        new BooksOfInterest()
                        {
                            Id=3,
                            Name="Sultanın Korsanları",
                            Author="Emrah Safa"
                        }
                    }
                }
            };
    }
}