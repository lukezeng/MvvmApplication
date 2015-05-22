using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.Repositories;

namespace MvvmApplication.Services
{
    public interface IRelationService
    {
        IEnumerable<Relation> GetAll();
        Relation GetRelation(int id);
        void AddVisitCount(int id);
    }

    public class RelationService : IRelationService
    {
        private readonly RelationRepository _relationRepository;

        public RelationService(RelationRepository relationRepository)
        {
            _relationRepository = relationRepository;
        }

        public IEnumerable<Relation> GetAll()
        {
            return _relationRepository.GetAll();
        }

        public Relation GetRelation(int id)
        {
            return _relationRepository.GetRelation(id);
        }

        public void AddVisitCount(int id)
        {
            _relationRepository.AddVisitCount(id);
        }
    }
}