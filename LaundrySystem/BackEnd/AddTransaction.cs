using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.BackEnd
{
    internal class AddTransaction
    {
        private MySqlProcedure sqlProcedure;

        public void AddTransactions()
        {
            sqlProcedure = new MySqlProcedure();
        }

    }
}
