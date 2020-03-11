
using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo02.Lista01
{
    class Program
    {
        static string EntradaUsuario()
        {
            Console.WriteLine("Digite seu usuário: ");
            string usuario = Console.ReadLine();
            return usuario;

        }
        static string EntradaSenha()
        {
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();
            return senha;

        }
        static void Main()
        {

            int opt = 0;

            do
            {

                Console.WriteLine("\n## ESCOLHA UMA OPÇÃO DE AUTENTICAÇÃO ##");
                Console.WriteLine("## 1 - Gmail ##");
                Console.WriteLine("## 2 - Instagram ##");
                Console.WriteLine("## 3 - Facebook ##");
                Console.WriteLine("## 4 - Sair ##");
                opt = int.Parse(Console.ReadLine());

                if (opt == (int)TipoLogin.Gmail)
                {

                    string usuario = EntradaUsuario();
                    string senha = EntradaSenha();
                    LoginGmail objLogin = new LoginGmail();

                    bool resultValidacao = objLogin.Login(usuario, senha);
                    
                    if (resultValidacao)
                        Console.WriteLine("Login do Gmail realizado com sucesso.");
                    else
                        Console.WriteLine("Login do Gmail falhou.");
                    objLogin.Logout();
                }
                else if (opt == (int)TipoLogin.Facebook)
                {
                    string usuario = EntradaUsuario();
                    string senha = EntradaSenha();
                    LoginFacebook objLogin = new LoginFacebook();
                    objLogin.Login(usuario, senha);
                    objLogin.Logout();
                }
                else if (opt == (int)TipoLogin.Instagram)
                {
                    string usuario = EntradaUsuario();
                    string senha = EntradaSenha();
                    LoginInstagram objLogin = new LoginInstagram();
                    objLogin.Login(usuario, senha);
                    objLogin.Logout();
                }
                else if (opt == 4)
                    break;
            } while (opt != 4);


        }
    }

    enum TipoLogin
    {
        Gmail = 1,
        Facebook = 2,
        Instagram = 3,
    }

    public abstract class SuperLogin
    {
        public abstract bool Login(string usuario, dynamic senha);
        protected virtual bool Autentica(string usuario, dynamic senha)
        {
            if (senha == "123456")
                return true;
            else
                return false;
        }
        public abstract void Logout();
    }

    public class LoginGmail : SuperLogin
    {
        public override bool Login(string usuario, dynamic senha)
        {
            bool resultValidacao = Autentica(usuario, senha);
            return resultValidacao;
        }
        protected override bool Autentica(string usuario, dynamic senha)
        {
            if (senha == "gmail12345")
                return true;
            else
                return false;
        }
        public override void Logout()
        {
            Console.WriteLine("Logout Gmail realizado.");

        }

    }

    public class LoginFacebook : SuperLogin
    {
        public override bool Login(string usuario, dynamic senha)
        {
            bool resultValidacao = Autentica(usuario, senha);
            return resultValidacao;
        }
        protected override bool Autentica(string usuario, dynamic senha)
        {
            if (senha == "facebook12345")
                return true;
            else
                return false;
        }
        public override void Logout()
        {
            Console.WriteLine("Logout Facebook realizado.");

        }

    }

    public class LoginInstagram : SuperLogin
    {
        public override bool Login(string usuario, dynamic senha)
        {
            bool resultValidacao = Autentica(usuario, senha);
            return resultValidacao;
        }
        protected override bool Autentica(string usuario, dynamic senha)
        {
            if (senha == "instagram12345")
                return true;
            else
                return false;
        }
        public override void Logout()
        {
            Console.WriteLine("Logout Instagram realizado.");

        }

    }
}
