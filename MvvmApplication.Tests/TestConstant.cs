using System.Collections.Generic;
using MvvmApplication.Models;

namespace MvvmApplication.Tests
{
    internal static class TestConstant
    {
        public static readonly List<User> Users = new List<User>
        {
            new User
            {
                Id = 0,
                Name = "User 0"
            },
            new User
            {
                Id = 1,
                Name = "user 1"
            },
            new User
            {
                Id = 2,
                Name = "User 2"
            },
            new User
            {
                Id = 3,
                Name = "User 3"
            },
            new User
            {
                Id = 4,
                Name = "User 4"
            }
        };

        public static readonly List<Brand> Brands = new List<Brand>
        {
            new Brand
            {
                Id = 0,
                Name = "Brand 0"
            },
            new Brand
            {
                Id = 1,
                Name = "Brand 1"
            },
            new Brand
            {
                Id = 2,
                Name = "Brand 2"
            },
            new Brand
            {
                Id = 3,
                Name = "Brand 3"
            },
            new Brand
            {
                Id = 4,
                Name = "Brand 4"
            }
        };

        public static readonly List<Relation> Relations = new List<Relation>
        {
            new Relation
            {
                Id = 0,
                UserId = 1,
                BrandId = 2
            },
            new Relation
            {
                Id = 1,
                UserId = 1,
                BrandId = 1
            },
            new Relation
            {
                Id = 2,
                UserId = 1,
                BrandId = 2
            },
            new Relation
            {
                Id = 3,
                UserId = 1,
                BrandId = 3
            },
            new Relation
            {
                Id = 4,
                UserId = 2,
                BrandId = 4
            }
        };
    }
}