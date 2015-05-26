using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.SqlPersistances;

namespace MvvmApplication.Repositories
{
    public interface IRelationRepository
    {
        IEnumerable<Relation> GetAll();
        Relation GetRelation(int id);
        IEnumerable<Relation> GetRelationsByUserId(int userId);
        IEnumerable<Relation> GetRelationsByBrandId(int brandId);
        void AddVisitCount(int id);
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

        public Relation GetRelation(int id)
        {
            return _relationSqlPersistence.GetRelation(id);
        }

        public IEnumerable<Relation> GetRelationsByUserId(int userId)
        {
            return _relationSqlPersistence.GetRelationsByUserId(userId);
        }

        public IEnumerable<Relation> GetRelationsByBrandId(int brandId)
        {
            return _relationSqlPersistence.GetRelationsByBrandId(brandId);
        }

        public void AddVisitCount(int id)
        {
            _relationSqlPersistence.AddVisitCount(id);
        }
    }
}