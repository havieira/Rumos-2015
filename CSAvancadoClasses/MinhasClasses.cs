using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CSAvancadoClasses
{
    public class Empregado
    
    {
        // declaração de atributos
        
        #region " Atributos "

        private string _nome;
        private DateTime _dataNascimento;
        private string _departamento;
        private decimal _salario;
        private int _id;
        public static int _newID;

        

        #endregion

        #region " Propriedades {get; set; } "
        
        public string Nome //propriedade Nome
        { 
            get { return _nome; }   //returna o valor do atributo
            set { _nome = value; }  //atribui um valor ao atributo. 
                                    //'value' representa qualquer valor que seja passado para este atributo
                                    // é possível definir restrições (ex. if(_nome = "xxxx")), apenas atribui se o atributo for
                                    // igual a "xxxx".
        }

        public DateTime DataNascimento //propriedade DataNascimento
        {
            get { return _dataNascimento;           }
            set { _dataNascimento = value;   }
        }

        public byte Idade //propriedade Idade, propriedade read-only, não contém um setter, apenas retorna
        {
            get { return (byte)DateAndTime.DateDiff(DateInterval.Year, DataNascimento, DateTime.Now);}
        }

        public decimal Salario //propriedade Salário
        {
            get { return _salario;  }
            set { _salario = value;     }
        }

        public string Departamento //propriedade Departamento
        {
            get { return _departamento; }
            set { _departamento = value;   } //value representa qualquer valor que seja passado para este atributo
        }

        public int NumEmp
        {
            get { return _id; }
            set { _id = value; }
        }

        #endregion

        #region " Construtores "

        public Empregado() 
        {
            this.Nome = "";
            this.DataNascimento = new DateTime(1900, 1, 1);
            this.Departamento = "";
            this.Salario = 0;
            Empregado._newID++;
            this.NumEmp = Empregado._newID;
        }

        public Empregado(string nome, DateTime dataNasc, int idEmp) : this()
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
            this.NumEmp = idEmp;
        }

        public Empregado(string nome, decimal salario, int idEmp) : this()
        {
            this.Nome = nome;
            this.Salario = salario;
            this.NumEmp = idEmp;
        }

        public Empregado(string nome, DateTime dataNasc, decimal salario, string departamento, int idEmp)
            : this()
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
            this.Salario = salario;
            this.Departamento = departamento;
            this.NumEmp = idEmp;
        }

        #endregion

        #region " Métodos "

        public string imprimeTodosDados()
        {
            // como método foi criado dentro da própria classe é possível utilizar directamento os atributos da mesma.
            // método retorna uma string com todos os valores atribuidos
            return string.Format("Nome: {0}; Data de Nasc: {1}; Salário: {2}; Departamento: {3}; ID: {4}",
                Nome, DataNascimento, Salario, Departamento, NumEmp);
        }

       public string imprimeDados()
        {
            return string.Format("Nome: {0}; Salário: {1:C}; ID: {2}", Nome, Salario, NumEmp);    
        }

       public void AumentaSalario(int valor) 
       {
           this.Salario = Salario + valor;
       }

       public void AumentaSalario(decimal percentagem)
       {
           this.Salario = Salario + (Salario * percentagem);
       }

       //public int ComparaSalario(Empregado outroEmpregado)
       //{
       //    return outroEmpregado;
       //}

        #endregion

    }
}
