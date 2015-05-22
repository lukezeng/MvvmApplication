using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.SqlPersistances;

namespace MvvmApplication.Repositories
{
    public interface IRelationRepository
    {
        IEnumerable<Relation> GetAll();
        Relation GetRelation(int id);
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

        public void AddVisitCount(int id)
        {
            _relationSqlPersistence.AddVisitCount(id);
        }
    }
}