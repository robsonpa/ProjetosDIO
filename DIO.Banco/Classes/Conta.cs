using System;

namespace DIO.Banco
{
    public class Conta
    {
        // Atributos
		private TipoConta TipoConta { get; set; }
		private double Saldo { get; set; }
		//private double Credito { get; set; }
		private string Nome { get; set; }

		// Métodos
		public Conta(TipoConta tipoConta, double saldo, string nome)
		{
			this.TipoConta = tipoConta;
			this.Saldo = saldo;
			//this.Credito = credito;
			this.Nome = nome;
		}

		public bool Sacar(double valorSaque)
		{
            // Validação de saldo suficiente
            this.Saldo -= valorSaque;

            if(this.Saldo <= 0){
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }else{                    

                Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);            

                return true;
            }
		}

		public void Depositar(double valorDeposito)
		{
			this.Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
		}

		public void Transferir(double valorTransferencia, Conta contaDestino)
		{
			if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Tipo de conta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            //retorno += "Crédito: " + this.Credito;
			return retorno;
		}
        
    }
}