﻿using System.Collections.Generic;
using Moq;
using MvvmApplication.Models;
using MvvmApplication.Repositories;
using MvvmApplication.SqlPersistances;
using NUnit.Framework;

namespace MvvmApplication.Tests.Repositories
{
    internal class CompanyRepositoryTests
    {
        private readonly List<Company> _companies = new List<Company>();
        private CompanyRepository _self;

        [SetUp]
        public void Setup()
        {
            _companies.Add(new Company());
            _companies.Add(new Company());
        }

        [Test]
        public void Getll()
        {
            var companySqlPersistence = new Mock<ICompanySqlPersistence>();
            companySqlPersistence.Setup(x => x.GetAll()).Returns(_companies);
            _self = new CompanyRepository(companySqlPersistence.Object);
            var allCompanies = _self.GetAll();
            companySqlPersistence.Verify(x => x.GetAll(), Times.Once);
            Assert.AreEqual(allCompanies, _companies);
        }
    }
}