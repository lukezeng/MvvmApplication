using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.Repositories;

namespace MvvmApplication.Services
{
    public interface ICountService
    {
        void Add(string token);
    }

    public class CountService : ICountService
    {
        private readonly ICountRepository _countRepository;

        public CountService(ICountRepository countRepository)
        {
            _countRepository = countRepository;
        }

        public void Add(string token)
        {
            _countRepository.Add(token);
        }
    }
}