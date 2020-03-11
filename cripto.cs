using System;
using System.Collections.Generic;
using System.Text;


namespace Modulo02.Lista01
{
    class Program
    {
        //static void Main()
        //{
        //    Console.WriteLine("Digite seu usuário: ");
        //    string senha = Console.ReadLine();
        //    Console.WriteLine("Senha: " + senha);
        //    Cri objCri = new Cri();
        //    string senhaCriptografada = objCri.CriptografarSenha(SHA512, senha);
        //    Console.WriteLine("Senha cripto: " + senhaCriptografada);

        //}
    }
}


class Cri
{
    public string CriptografarSenha(HashAlgorithm _algoritmo, string senha)
    {
        var encodedValue = Encoding.UTF8.GetBytes(senha);
        var encryptedPassword = _algoritmo.ComputeHash(encodedValue);
        var sb = new StringBuilder();
        foreach (var caracter in encryptedPassword)
        {
            sb.Append(caracter.ToString("X2"));
        }
        return sb.ToString();
    }
    public bool VerificarSenha(HashAlgorithm _algoritmo, string senhaDigitada, string senhaCadastrada)
    {
        if (string.IsNullOrEmpty(senhaCadastrada))
            throw new NullReferenceException("Cadastre uma senha.");
        var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));
        var sb = new StringBuilder();
        foreach (var caractere in encryptedPassword)
        {
            sb.Append(caractere.ToString("X2"));
        }
        return sb.ToString() == senhaCadastrada;
    }
}