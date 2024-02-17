using ProductShop.Data;
using System.Linq;
using System.Xml.Linq;
using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Serialization;
using ProductShop.Dtos.Import;
using System.IO;
using AutoMapper;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile<ProductShopProfile>());

            var mapper = config.CreateMapper();

            using (var db = new ProductShopContext())
            {
                var xmlInput = File.ReadAllText($"./../../../Datasets/users.xml");

                var result = ImportUsers(db, xmlInput, mapper);

                Console.WriteLine(result);
            }
        }

        // Query 1. Import Users
        public static string ImportUsers(ProductShopContext context, string inputXml, IMapper mapper)
        {
            var xmlSerializer = new XmlSerializer(
                typeof(ImportUserDto[]), 
                new XmlRootAttribute("Users"));

            ImportUserDto[] usersDtos;

            using (var reader = new StringReader(inputXml))
            {
                usersDtos = (ImportUserDto[])xmlSerializer.Deserialize(reader);                
            }

            var users = mapper.Map<User[]>(usersDtos);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Length}";
        }
    }
}