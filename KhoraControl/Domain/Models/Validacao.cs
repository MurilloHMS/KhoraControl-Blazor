using System.Text.RegularExpressions;

namespace KhoraControl.Domain.Models
{
    public class Validacao
    {
        public string mensagem;
        public int IdUsuario;
        //public async Task<bool> ValidaSenhaLogin(string usuario, string senha)
        //{
        //    Usuarios usuarios = new Usuarios();
        //    Usuarios dados = await await ValidaUsuario(usuario);
        //    IdUsuario = dados.ID;

        //    if (dados != null && dados.Ativo == 'T' && ValidaCredenciais(usuario, senha, dados))
        //    {
        //        mensagem = "Login Efetuado com Sucesso!";
        //        return true;
        //    }
        //    else
        //    {
        //        mensagem = dados != null && dados.Ativo == 'T' ? "Senha Incorreta!" : "Usuário Inativo";
        //        return false;
        //    }


        //}

        //private async Task<Usuarios> ValidaUsuario(string usuario)
        //{
        //    Usuarios usuarios = new Usuarios();
        //    return ValidaEmail(usuario) ? usuarios.BuscaEmail(usuario) : usuarios.BuscaUsuarioPorNome(usuario);
        //}

        private bool ValidaCredenciais(string usuario, string senha, Usuarios dados)
        {
            return (senha == dados.Senha) &&  (usuario.ToUpper() ==(ValidaEmail(usuario) ? dados.Email.ToUpper() : dados.Nome.ToUpper()));
        }

        private static bool ValidaEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }
    }
}
