using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfValidacao
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IValidacao
    {

        [OperationContract]
        string ObterDados(int valor);

        [OperationContract]
        TipoComposto ObterDadosUsandoContratoDeDados(TipoComposto composicao);

#region "Validação"

    /// <summary>
    /// Validar nomes de usuários
    /// </summary>
    /// <param name="nomeUsuario">Nome do Usuário</param>
    /// <returns>Verdadeiro ou Falso</returns>
    /// <remarks>
    /// Essa regra é para permitir usuários com nome de 4 a 28 caracteres, alfanuméricos e acentuados:
    /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    /// </remarks>
    [OperationContract]
    Boolean ValidarNomesUsuarios(String nomeUsuario);

    /// <summary>
    /// Validar números telefônicos
    /// </summary>
    /// <param name="numeroTelefonico">Número telefônico</param>
    /// <returns>Verdadeiro ou Falso</returns>
    /// <remarks>
    /// Essa regra é para validar números de telefone, e os números devem ser escritos da seguinte maneira (###)###-####:
    /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    /// </remarks>
        [OperationContract]
    Boolean ValidarNumerosTelefonicos(String numeroTelefonico );

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
        [OperationContract]
        Boolean ValidarEmail(String email);

    /// <summary>
    /// Validar códigos postais
    /// </summary>
    /// <param name="codigoPostal">Código Postal</param>
    /// <returns>Verdadeiro ou Falso</returns>
    /// <remarks>
    /// Permite utilizar números no seguinte formato: xxxxx e xxxxx-xxxx:
    /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    /// </remarks>
    [OperationContract]
    Boolean ValidarCodigosPostais(String codigoPostal);

    /// <summary>
    /// Validar endereços IP
    /// </summary>
    /// <param name="EnderecoIP">Endereço IP</param>
    /// <returns>Verdadeiro ou Falso</returns>
    /// <remarks>
    /// Não é necessário efetuar PING ou qualquer coisa do tipo, essa regra é válida para verificar se os IPs foram escritos corretamente, como esse exemplo 255.255.255.0:
    /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    /// </remarks>
    [OperationContract]
    Boolean ValidarEnderecosIP(String EnderecoIP);

    /// <summary>
    /// Validar cores hexadecimais
    /// </summary>
    /// <param name="corHexadecimal">Cor hexadecimal</param>
    /// <returns>Verdadeiro ou Falso</returns>
    /// <remarks>
    /// Você também pode verificar valores hexadecimais em suas 2 formas, a normal e a abreviada: (#333, 333, #333333 o 333333) com o símbolo # opcional:
    /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    /// </remarks>
    [OperationContract]
    Boolean ValidarCoresHexadecimais(String corHexadecimal);

    /// <summary>
    /// Validar comentários multi-linha
    /// </summary>
    /// <param name="comentarioMultiLinha">Comentário multi-linha</param>
    /// <returns>Verdadeiro ou Falso</returns>
    /// <remarks>
    /// Uma forma simples de buscar e eliminar comentários multi-linha em PHP, CSS e outras linguagens:
    /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    /// </remarks>
    [OperationContract]
    Boolean ValidarComentariosMultiLinha(String comentarioMultiLinha);

    /// <summary>
    /// Validar datas
    /// </summary>
    /// <param name="data">Data</param>
    /// <returns>Verdadeiro ou Falso</returns>
    /// <remarks>
    /// Um formato de data típico MM/DD/YYYY e sua validação é a seguinte:
    /// http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    /// </remarks>
    [OperationContract]
    Boolean ValidarDatas(String data);

#endregion
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // Use um contrato de dados, como ilustrado no exemplo abaixo, para adicionar tipos de compostos para operações de serviços.
    [DataContract]
    public class TipoComposto
    {
        bool valorBoolean = true;
        string valorString = "Olá ";
        private DateTime valorDate;

        [DataMember]
        public bool ValorBoolean
        {
            get { return valorBoolean; }
            set { valorBoolean = value; }
        }

        [DataMember]
        public string ValorString
        {
            get { return valorString; }
            set { valorString = value; }
        }

        [DataMember]
        public DateTime ValorDate
        {
            get { return valorDate; }
            set { valorDate = value; }
        }
        

    }
}
