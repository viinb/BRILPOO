using System;

namespace _20261001
{
    internal class IFSP
    {
        bool erro;
        string codigo;
        public string Codigo
        {
            get
            {
                return codigo;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    codigo = value;
                }
                else
                {
                    IFSPException E = new IFSPException("Erro de Sistema", "Código não pode ser vazio");
                    throw (E);
                }
            }
        }

        public void Gravar(string codigo)
        {
            try
            {
                Codigo = codigo;
            }
            catch (Exception E)
            {
                IFSPException IFSPE = (E as IFSPException);
                Console.WriteLine(IFSPE.Titulo + ": " + IFSPE.Message);
                Codigo = "#ERRO#";
                erro = true;
            }
            finally
            {
                if (erro == true)
                {
                    Console.WriteLine("Não foi possivel gravar.");
                }
                else
                {
                    Console.WriteLine("Gravado com sucesso!");
                }
            }
        }

        public override string ToString()
        {
            return "Código: " + this.Codigo;
        }
    }
}
