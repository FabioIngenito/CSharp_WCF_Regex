using System;
using System.Windows.Forms;

namespace waTestaValidacaoC
{
    public partial class frmTestaValidacao : Form
    {
        // criando uma instância do nosso serviço WCF
        ServiceReference1.ValidacaoClient WCF_Valida = new ServiceReference1.ValidacaoClient();
        ServiceReference1.TipoComposto WCF_Valida_Dados = new ServiceReference1.TipoComposto();

        public frmTestaValidacao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Essa regra é para permitir usuários com nome de 3 a 30 caracteres, alfanuméricos e acentuados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// É possível testar em: https://regex101.com/
        /// IMPORTANTE - Veja isso também: http://aurelio.net/regex/guia/acentuacao.html
        /// </remarks>
        private void btnValidarNomeUsuario_Click(object sender, EventArgs e)
        {
            //usando o método ValidarNomeUsuario do nosso serviço
            if (WCF_Valida.ValidarNomesUsuarios(txtNomeUsuario.Text))
                MessageBox.Show("Nome do Usuário Válido.");
            else
                MessageBox.Show("Nome do Usuário Inválido");
        }

        private void btnValidarNumeroTelefonico_Click(object sender, EventArgs e)
        {
            //usando o método ValidarNumerosTelefonicos do nosso serviço
            if (WCF_Valida.ValidarNumerosTelefonicos(mskNumeroTelefonico.Text))
                MessageBox.Show("Número telefônico Válido.");
            else
                MessageBox.Show("Número telefônico Inválido");
        }

        private void btnValidarEmail_Click(object sender, EventArgs e)
        {
            //usando o método ValidarEmail do nosso serviço
            if (WCF_Valida.ValidarEmail(txtEmail.Text))
                MessageBox.Show("Email Válido.");
            else
                MessageBox.Show("Email Inválido");
        }

        private void btnValidarCodigoPostal_Click(object sender, EventArgs e)
        {
            //usando o método ValidarCodigosPostais do nosso serviço
            if (WCF_Valida.ValidarCodigosPostais(mskCodigoPostal.Text))
                MessageBox.Show("Código Postal Válido.");
            else
                MessageBox.Show("Código Postal Inválido");
        }

        private void btnValidarEnderecoIP_Click(object sender, EventArgs e)
        {
            //usando o método ValidarEnderecosIP do nosso serviço
            if (WCF_Valida.ValidarEnderecosIP(txtEnderecoIP.Text))
                MessageBox.Show("Endereco IP Válido.");
            else
                MessageBox.Show("Endereco IP Inválido");
        }

        private void btnValidarCorHexadecimal_Click(object sender, EventArgs e)
        {
            //usando o método ValidarCoresHexadecimais do nosso serviço
            if (WCF_Valida.ValidarCoresHexadecimais(mskCorHexadecimal.Text))
                MessageBox.Show("Cor Hexadecimal Válido.");
            else
                MessageBox.Show("Cor Hexadecimal Inválido");
        }

        private void btnValidarComentarioMultiLinha_Click(object sender, EventArgs e)
        {
            //usando o método ValidarComentariosMultiLinha do nosso serviço
            if (WCF_Valida.ValidarComentariosMultiLinha(txtComentarioMultiLinha.Text))
                MessageBox.Show("Comentário Válido.");
            else
                MessageBox.Show("Comentário Inválido");
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //usando o método ValidarDatas do nosso serviço
            if (WCF_Valida.ValidarDatas(mskData.Text))
                MessageBox.Show("Data Válida.");
            else
                MessageBox.Show("Data Inválida");
        }

        /// <summary>
        /// Digitar somente números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoceDigitou_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8) e.Handled = true;
        }

        private void btnVoceDigitou_Click(object sender, EventArgs e)
        {
            //usando o método ObterDados do nosso serviço
            MessageBox.Show(WCF_Valida.ObterDados(Convert.ToInt16(txtVoceDigitou.Text)));
        }

        private void btnContratoDeDados_Click(object sender, EventArgs e)
        {
            WCF_Valida_Dados.ValorString = txtContratoDeDados.Text;
            WCF_Valida_Dados.ValorBoolean = chkContratoDeDados.Checked;
            WCF_Valida_Dados.ValorDate = dtpContratoDeDados.Value;

            WCF_Valida_Dados = WCF_Valida.ObterDadosUsandoContratoDeDados(WCF_Valida_Dados);

            lblContratoDeDadosResposta.Text = WCF_Valida_Dados.ValorString;
        }
    }
}