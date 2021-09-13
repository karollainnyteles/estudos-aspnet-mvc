using DevIo.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Business.Core.Data
{
    interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
    }
}
