using GameSelling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Abstract
{
    public interface ISaleService
    {
        void Add(Sale sale);
        void Delete(Sale sale);
        void Update(Sale sale);
    }
}
