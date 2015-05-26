using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.SqlPersistances;

namespace MvvmApplication.Repositories
{
    public interface IRelationRepository
    {
        IEnumerable<Relation> GetAll();
        Relation GetRelation(long id);
        IEnumerable<Relation> GetRelationsByUserId(long userId);
        IEnumerable<Relation> GetRelationsByBrandId(long brandId);
        void AddVisitCount(long id);
    }

    public class RelationRepository : IRelationRepository
    {
        private readonly IRelationSqlPersistence _relationSqlPersistence;

        public RelationRepository(IRelationSqlPersistence relationSqlPersistence)
        {
            _relationSqlPersistence = relationSqlPersistence;
        }

        public IEnumerable<Relation> GetAll()
        {
            return _relationSqlPersistence.GetAll();
        }

        public Relation GetRelation(long id)
        {
            return _relationSqlPersistence.GetRelation(id);
        }

        public IEnumerable<Relation> GetRelationsByUserId(long userId)
        {
            return _relationSqlPersistence.GetRelationsByUserId(userId);
        }

        public IEnumerable<Relation> GetRelationsByBrandId(long brandId)
        {
            return _relationSqlPersistence.GetRelationsByBrandId(brandId);
        }

        public void AddVisitCount(long id)
        {
            _relationSqlPersistence.AddVisitCount(id);
        }
    }
}