using LAS.Context;
using LAS.Model.Entities.Abstract;
using LAS.Model.Entities.Concrete;
using LAS.Repository.Abstract;
using LAS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAS.Repository.Concrete
{
    public class UyeRepository : BaseRepository<Uye>, IUye
    {
        public UyeRepository(LasDbContext lasDbContext) : base(lasDbContext)
        {

        }
    }
}
