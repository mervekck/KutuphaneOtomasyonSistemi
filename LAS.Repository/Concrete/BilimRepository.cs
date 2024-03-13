using LAS.Context;
using LAS.Model.Entities.Abstract;
using LAS.Model.Entities.Concrete.Kitap;
using LAS.Repository.Abstract;
using LAS.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAS.Repository.Concrete
{
    public class KitapBilimRepository : BaseRepository<Bilim>, IBilim
    {
        public KitapBilimRepository(LasDbContext dbContext) : base(dbContext)
        {
        }
    }
}
