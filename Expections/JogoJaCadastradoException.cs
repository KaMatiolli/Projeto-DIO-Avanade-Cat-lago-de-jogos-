using System;

namespace APICatalogodeJogos.Exceptions
{
    public class JogoJaCadastradoException : Exceptions
    {
        public JogoJaCadastradoException()
            : base("Este jogo já está cadastrado")
        { }
    }
}