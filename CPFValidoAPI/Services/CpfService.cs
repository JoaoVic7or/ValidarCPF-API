using CPFValidoAPI.Interface;
using System.Text.RegularExpressions;

namespace CPFValidoAPI.Services
{
    public class CpfService : ICpfService
    {
        public bool ValidarCPF(string cpf)
        {
            int[] primeiroMultiplicador = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] segundoMultiplicador = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = Regex.Replace(cpf, @"\D", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            if (cpf.Distinct().Count() == 1)
            {
                return false;
            }

            string temCPF = cpf.Substring(0, 9);

            int soma = temCPF.Select((t, i) => (t - '0') * primeiroMultiplicador[i]).Sum();

            int resto = soma % 11;

            int primeiroDigito = resto < 2 ? 0 : 11 - resto;

            temCPF += primeiroDigito;

            soma = temCPF.Select((t, i) => (t - '0') * segundoMultiplicador[i]).Sum();

            resto = soma % 11;

            int segundoDigito = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith($"{primeiroDigito}{segundoDigito}");
        }
    }
}
