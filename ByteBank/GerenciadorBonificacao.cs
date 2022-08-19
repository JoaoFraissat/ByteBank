using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalbonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalbonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalbonificacao;
        }
    }
}
