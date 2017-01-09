using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace WcfValidacao
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTA: Você pode usar o comando "Renomear" no menu de contexto para alterar o nome da interface "IService1" em ambos arquivos: de código e de configuração juntamente.
    public class ServiceValidacao : IValidacao
    {
        public string ObterDados(int valor)
        {
            return string.Format("Você Digitou: {0}", valor);
        }

        public TipoComposto ObterDadosUsandoContratoDeDados(TipoComposto composicao)
        {
            if (composicao == null)
            {
                throw new ArgumentNullException("composição");
            }
            if (composicao.ValorBoolean)
            {
                composicao.ValorString += ", " + String.Format("{0:d \\de MMM \\de yyyy à\\s HH:MM}", composicao.ValorDate);
            }
            return composicao;
        }

        #region "Validação"

        /// <summary>
        /// Validar nomes de usuários
        /// </summary>
        /// <param name="nomeUsuario">Nome do Usuário</param>
        /// <returns>Verdadeiro ou Falso</returns>
        /// <remarks>
        /// Essa regra é para permitir usuários com nome de 3 a 30 caracteres, alfanuméricos e acentuados:
        /// IMPORTANTE sobre Acentuação: 
        /// http://aurelio.net/regex/guia/acentuacao.html
        /// Teste a Expressão Regular aqui:
        /// https://regex101.com/
        /// </remarks>
        public bool ValidarNomesUsuarios(string nomeUsuario)
        {
            String validaUsuario = "^[A-Za-zÀ-ú0-9]{3,30}$";

            return Regex.IsMatch(nomeUsuario, validaUsuario);
        }

        /// <summary>
        /// Validar números telefônicos
        /// </summary>
        /// <param name="numeroTelefonico">Número telefônico - Formato: "(99) 000-000-000":</param>
        /// <returns>Verdadeiro ou Falso</returns>
        /// <remarks>
        /// Essa regra é para validar números de telefone, e os números devem ser escritos da seguinte maneira (##) ###-###-###:
        /// </remarks>
        public bool ValidarNumerosTelefonicos(string numeroTelefonico)
        {
            String validaNumeroTelefonico = "(^\\(?[0-9]{2}\\))[ ][0-9]{3,3}[-. ]?[0-9]{3,3}[-. ]?[0-9]{3,3}$";

            return Regex.IsMatch(numeroTelefonico, validaNumeroTelefonico);
        }

        /// <summary>
        /// Validar email
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>Verdadeiro ou Falso</returns>
        /// <remarks>
        /// http://www.macoratti.net/09/09/net_wcf1.htm
        /// A regra para validar e-mails é a seguinte:
        /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
        /// </remarks>
        public bool ValidarEmail(string email)
        {
            String validaEmail = "^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-z]{2,4}|[0-9]{1,3})(\\]?)$";

            return Regex.IsMatch(email, validaEmail);
        }

        /// <summary>
        /// Validar códigos postais
        /// </summary>
        /// <param name="codigoPostal">Código Postal</param>
        /// <returns>
        /// Permite utilizar números no seguinte formato: xxxx-xxxx
        /// http://www.buscacep.correios.com.br/servicos/dnec/menuAction.do?Metodo=menuEndereco
        /// </returns>
        public bool ValidarCodigosPostais(string codigoPostal)
        {
            String validaCodigoPostal = "^[0-9]{5,5}[-]?[0-9]{3,3}?$";

            return Regex.IsMatch(codigoPostal, validaCodigoPostal);
        }

        /// <summary>
        /// Validar endereços IP
        /// </summary>
        /// <param name="EnderecoIP">Endereço IP</param>
        /// <returns>Verdadeiro ou Falso</returns>
        /// <remarks>
        /// Não é necessário efetuar PING ou qualquer coisa do tipo, essa regra é válida para verificar se os IPs foram escritos corretamente, como esse exemplo 255.255.255.0:
        /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
        /// </remarks>
        public bool ValidarEnderecosIP(string EnderecoIP)
        {
            String validaEnderecoIP = "^(?:25[0-5]|2[0-4]\\d|1\\d\\d|[1-9]\\d|\\d)(?:[.](?:25[0-5]|2[0-4]\\d|1\\d\\d|[1-9]\\d|\\d)){3}$";

            return Regex.IsMatch(EnderecoIP, validaEnderecoIP);
        }

        /// <summary>
        /// Validar cores hexadecimais
        /// </summary>
        /// <param name="corHexadecimal">Cor hexadecimal</param>
        /// <returns>Verdadeiro ou Falso</returns>
        /// <remarks>
        /// Você também pode verificar valores hexadecimais em suas 2 formas, a normal e a abreviada: (#333, 333, #333333 o 333333) com o símbolo # opcional:
        /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
        /// </remarks>
        public bool ValidarCoresHexadecimais(string corHexadecimal)
        {
            String validaCorHexadecimal = "^#(?:(?:[a-fA-F\\d]{3}){1,2})$";

            return Regex.IsMatch(corHexadecimal, validaCorHexadecimal);
        }

        /// <summary>
        /// Validar comentários multi-linha
        /// </summary>
        /// <param name="comentarioMultiLinha">Comentário multi-linha</param>
        /// <returns>Verdadeiro ou Falso</returns>
        /// <remarks>
        /// Uma forma simples de buscar e eliminar comentários multi-linha em PHP, CSS e outras linguagens:
        /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
        /// </remarks>
        public bool ValidarComentariosMultiLinha(string comentarioMultiLinha)
        {
            String validaComentarioMultiLinha = "^[\\/*]+[(*\\/)]";

            return Regex.IsMatch(comentarioMultiLinha, validaComentarioMultiLinha);
        }

        /// <summary>
        /// Validar datas
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns>Verdadeiro ou Falso</returns>
        /// <remarks>
        /// Um formato de data típico MM/DD/YYYY e sua validação é a seguinte:
        /// </remarks>
        public bool ValidarDatas(string data)
        {
            String validaData = "^\\d{1,2}\\/\\d{1,2}\\/\\d{4}$";
            String strDia = data.Substring(0, 2);
            String strMes = data.Substring(3, 2);
            String strAno = data.Substring(6);
            Boolean blnValidarDatas;

            blnValidarDatas = Regex.IsMatch(data, validaData);

            if (blnValidarDatas)
            {

                switch (strMes)
                {
                    case "00":
                        blnValidarDatas = false;
                        break;

                    case "01":
                    case "03":
                    case "05":
                    case "07":
                    case "08":
                    case "10":
                    case "12":
                        if (Convert.ToInt16(strDia) > 31) blnValidarDatas = false;
                        break;

                    case "04":
                    case "06":
                    case "09":
                    case "11":
                        if (Convert.ToInt16(strDia) > 30) blnValidarDatas = false;
                        break;

                    case "02":
                        DateTime dt;

                        if (DateTime.TryParse(("29/02/" + strAno), out dt))
                        {
                            if (Convert.ToInt16(strDia) > 29) blnValidarDatas = false;
                        }
                        else
                            if (Convert.ToInt16(strDia) > 28) blnValidarDatas = false;
                                
                        break;

                    default:
                        blnValidarDatas = false;
                        break;
                }
            }

            return blnValidarDatas;
        }

        #endregion
    }
}
