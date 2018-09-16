using System;

namespace CamadaTransfDados
{
    class dto_Cliente
    {
        private int id, cep;
        private long cpf, telefoneCel, telefoneRes;
        private string nome, endereco, bairro, cidade, email, uf;

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public int Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public long TelefoneCel
        {
            get
            {
                return telefoneCel;
            }

            set
            {
                telefoneCel = value;
            }
        }

        public long TelefoneRes
        {
            get
            {
                return telefoneRes;
            }

            set
            {
                telefoneRes = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }
    }
}
