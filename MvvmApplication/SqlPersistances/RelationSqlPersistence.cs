using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;

namespace MvvmApplication.SqlPersistances
{
    public interface IRelationSqlPersistence
    {
        IEnumerable<Relation> GetAll();
        Relation GetRelation(int id);
        IEnumerable<Relation> GetRelationsByUserId(int userId);
        void AddVisitCount(int id);
    }

    public class RelationSqlPersistence : IRelationSqlPersistence
    {
        private readonly List<Relation> _tmpRelation = new List<Relation>
        {
            new Relation
            {
                Id = 0,
                UserId = 1,
                BrandId = 1,
                VisitCount = 1000,
                Reason = "我是用户a 我愿意推荐abc"
            },
            new Relation
            {
                Id = 1,
                UserId = 2,
                BrandId = 2,
                VisitCount = 2000,
                Reason = "我是用户b 我愿意推荐abc"
            },
            new Relation
            {
                Id = 2,
                UserId = 3,
                BrandId = 3,
                VisitCount = 3000,
                Reason = "我是用户c 我愿意推荐abc"
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

        public IEnumerable<Relation> GetRelationsByUserId(int userId)
        {
            return _tmpRelation.Where(x => x.UserId == userId);
        }

        public void AddVisitCount(int id)
        {
            
        }
    }
}