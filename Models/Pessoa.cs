using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace One_21MAR.Models
{
    public class Pessoa
    {
        private int _num;
        protected String _nome;
        protected String _telefone;

        public int Num { 
        
            get { return _num; }
            set { 
                if (value > 0) this._num = value;
            }
        }
         public String Nome
        {
            get { return this._nome; }

            set { 
                this._nome = value;
            }
        }

        public string Telefone
        {
            get { return this._telefone; }  
            set { this._telefone = value; }
        }
           
        public Pessoa(int pnum, string pnome, string ptelefone)
        {
            this.Num = pnum;
            this._nome = pnome;
            this._telefone = ptelefone;

        }
        
    }
}