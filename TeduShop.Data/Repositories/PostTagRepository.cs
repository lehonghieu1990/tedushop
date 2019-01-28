using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedushop.Model.Models;
using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    }
    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
