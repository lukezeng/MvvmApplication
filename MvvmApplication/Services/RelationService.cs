using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.Repositories;

namespace MvvmApplication.Services
{
    public interface IRelationService
    {
        IEnumerable<Relation> GetAll();
        Relation GetRelation(long id);
        void AddVisitCount(long id);
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

        public Relation GetRelation(long id)
        {
            return _relationRepository.GetRelation(id);
        }

        public void AddVisitCount(long id)
        {
            _relationRepository.AddVisitCount(id);
        }
    }
}