using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;

namespace MvvmApplication.SqlPersistances
{
    public interface IRelationSqlPersistence
    {
        IEnumerable<Relation> GetAll();
        Relation GetRelation(int id);
    }

    public class RelationSqlPersistence : IRelationSqlPersistence
    {
        private readonly List<Relation> _tmpRelation = new List<Relation>
        {
            new Relation()
            {
                Id = 0,
                UserId = 1,
                BrandId = 1
                
            },
            new Relation()
            {
                Id = 1,
                UserId = 1,
                BrandId = 2
            },
            new Relation()
            {
                Id = 2,
                UserId = 2,
                BrandId = 1
            }
        };

        IEnumerable<Relation> IRelationSqlPersistence.GetAll()
        {
            return _tmpRelation;
        }

        public Relation GetRelation(int id)
        {
            return _tmpRelation.FirstOrDefault(x => x.Id == id);
        }
    }
}