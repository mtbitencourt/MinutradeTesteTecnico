using Core.Model;
using Core.Service;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutradeService.Service
{
    public class MinutradeClienteService : IService<Cliente>
    {
        private MinutradeContext context;

        public IEnumerable<Cliente> GetAll()
        {
            using (context = new MinutradeContext())
            {
                return context.Cliente.ToList();
            }
        }

        public Cliente Get(int id)
        {
            using (context = new MinutradeContext())
            {
                return context.Cliente.Find(id);
            }
        }

        public IEnumerable<Cliente> Where(System.Linq.Expressions.Expression<Func<Cliente, bool>> predicate)
        {
            using (context = new MinutradeContext())
            {
                return context.Cliente.Where(predicate);
            }
        }

        public void Save(int id, Cliente o)
        {
            using (context = new MinutradeContext())
            {
                Cliente c = context.Cliente.Find(o.Id);
                if (c == null)
                    throw new Exception("Cliente não existe no sistema");
                c.TelefoneCelular = o.TelefoneCelular;
                c.DataNascimento = o.DataNascimento;
                context.SaveChanges();
            }
        }
    }
}
