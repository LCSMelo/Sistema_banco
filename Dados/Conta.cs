using System;

namespace Dados{
    public class Conta{
        public string Banco { get; set; }
        public int Agencia { get; set; }  
        public int ContaCorrente { get; set; }
        public double Saldo_ { get; private set; }
        public double Saldo{
            get{
                Console.WriteLine("Get Saldo Atual:" + (this.Saldo_ -10));
                return this.Saldo_ -10;
            }
            set {
                Console.WriteLine("Set Sa ldo Atual:" + (this.Saldo_ +10));
                this.Saldo_ = this.Saldo_ +10;
            }
        }
        /// <summary>
        /// Efetua um saque da conta
        /// </summary>
        /// <param name="valor">Recebe um parametro do tipo double</param>
        public void Sacar(double valor){
            this.Saldo_ -= valor;
        }

        /// <summary>
        /// Efetua um depósito na conta
        /// </summary>
        /// <param name="valor">Recebe um parametro do tipo double</param>
        public void Depositar(double valor){
            this.Saldo_ += valor;
        }

        
        
    }
}