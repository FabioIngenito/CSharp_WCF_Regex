namespace waTestaValidacaoC
{
    partial class frmTestaValidacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcValidacao = new System.Windows.Forms.TabControl();
            this.tbpValidacao = new System.Windows.Forms.TabPage();
            this.mskCorHexadecimal = new System.Windows.Forms.MaskedTextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.mskCodigoPostal = new System.Windows.Forms.MaskedTextBox();
            this.btnData = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.btnValidarComentarioMultiLinha = new System.Windows.Forms.Button();
            this.txtComentarioMultiLinha = new System.Windows.Forms.TextBox();
            this.lblComentarioMultiLinha = new System.Windows.Forms.Label();
            this.btnValidarCorHexadecimal = new System.Windows.Forms.Button();
            this.lblCorHexadecimal = new System.Windows.Forms.Label();
            this.btnValidarEnderecoIP = new System.Windows.Forms.Button();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.lblEnderecoIP = new System.Windows.Forms.Label();
            this.btnValidarCodigoPostal = new System.Windows.Forms.Button();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.mskNumeroTelefonico = new System.Windows.Forms.MaskedTextBox();
            this.btnValidarNumeroTelefonico = new System.Windows.Forms.Button();
            this.lblNumeroTelefonico = new System.Windows.Forms.Label();
            this.btnValidarNomeUsuario = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.btnValidarEmail = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbpOutros = new System.Windows.Forms.TabPage();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblContratoDeDadosResposta = new System.Windows.Forms.Label();
            this.dtpContratoDeDados = new System.Windows.Forms.DateTimePicker();
            this.chkContratoDeDados = new System.Windows.Forms.CheckBox();
            this.btnContratoDeDados = new System.Windows.Forms.Button();
            this.txtContratoDeDados = new System.Windows.Forms.TextBox();
            this.lblContratoDeDados = new System.Windows.Forms.Label();
            this.btnVoceDigitou = new System.Windows.Forms.Button();
            this.txtVoceDigitou = new System.Windows.Forms.TextBox();
            this.lblVoceDigitou = new System.Windows.Forms.Label();
            this.tbcValidacao.SuspendLayout();
            this.tbpValidacao.SuspendLayout();
            this.tbpOutros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcValidacao
            // 
            this.tbcValidacao.Controls.Add(this.tbpValidacao);
            this.tbcValidacao.Controls.Add(this.tbpOutros);
            this.tbcValidacao.Location = new System.Drawing.Point(12, 12);
            this.tbcValidacao.Name = "tbcValidacao";
            this.tbcValidacao.SelectedIndex = 0;
            this.tbcValidacao.Size = new System.Drawing.Size(539, 340);
            this.tbcValidacao.TabIndex = 39;
            // 
            // tbpValidacao
            // 
            this.tbpValidacao.Controls.Add(this.mskCorHexadecimal);
            this.tbpValidacao.Controls.Add(this.mskData);
            this.tbpValidacao.Controls.Add(this.mskCodigoPostal);
            this.tbpValidacao.Controls.Add(this.btnData);
            this.tbpValidacao.Controls.Add(this.lblData);
            this.tbpValidacao.Controls.Add(this.btnValidarComentarioMultiLinha);
            this.tbpValidacao.Controls.Add(this.txtComentarioMultiLinha);
            this.tbpValidacao.Controls.Add(this.lblComentarioMultiLinha);
            this.tbpValidacao.Controls.Add(this.btnValidarCorHexadecimal);
            this.tbpValidacao.Controls.Add(this.lblCorHexadecimal);
            this.tbpValidacao.Controls.Add(this.btnValidarEnderecoIP);
            this.tbpValidacao.Controls.Add(this.txtEnderecoIP);
            this.tbpValidacao.Controls.Add(this.lblEnderecoIP);
            this.tbpValidacao.Controls.Add(this.btnValidarCodigoPostal);
            this.tbpValidacao.Controls.Add(this.lblCodigoPostal);
            this.tbpValidacao.Controls.Add(this.mskNumeroTelefonico);
            this.tbpValidacao.Controls.Add(this.btnValidarNumeroTelefonico);
            this.tbpValidacao.Controls.Add(this.lblNumeroTelefonico);
            this.tbpValidacao.Controls.Add(this.btnValidarNomeUsuario);
            this.tbpValidacao.Controls.Add(this.txtNomeUsuario);
            this.tbpValidacao.Controls.Add(this.lblNomeUsuario);
            this.tbpValidacao.Controls.Add(this.btnValidarEmail);
            this.tbpValidacao.Controls.Add(this.txtEmail);
            this.tbpValidacao.Controls.Add(this.lblEmail);
            this.tbpValidacao.Location = new System.Drawing.Point(4, 22);
            this.tbpValidacao.Name = "tbpValidacao";
            this.tbpValidacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbpValidacao.Size = new System.Drawing.Size(531, 314);
            this.tbpValidacao.TabIndex = 0;
            this.tbpValidacao.Text = "Validação";
            this.tbpValidacao.UseVisualStyleBackColor = true;
            // 
            // mskCorHexadecimal
            // 
            this.mskCorHexadecimal.Location = new System.Drawing.Point(276, 101);
            this.mskCorHexadecimal.Mask = "\\#AAAAAA";
            this.mskCorHexadecimal.Name = "mskCorHexadecimal";
            this.mskCorHexadecimal.Size = new System.Drawing.Size(241, 20);
            this.mskCorHexadecimal.TabIndex = 54;
            this.mskCorHexadecimal.Text = "0000FF";
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(276, 257);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(241, 20);
            this.mskData.TabIndex = 53;
            this.mskData.Text = "31122025";
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // mskCodigoPostal
            // 
            this.mskCodigoPostal.Location = new System.Drawing.Point(9, 257);
            this.mskCodigoPostal.Mask = "00000-000";
            this.mskCodigoPostal.Name = "mskCodigoPostal";
            this.mskCodigoPostal.Size = new System.Drawing.Size(241, 20);
            this.mskCodigoPostal.TabIndex = 52;
            this.mskCodigoPostal.Text = "05005000";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(276, 283);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(241, 23);
            this.btnData.TabIndex = 51;
            this.btnData.Text = "Validar &Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(273, 241);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(147, 13);
            this.lblData.TabIndex = 50;
            this.lblData.Text = "Informe a data (dd/MM/yyyy):";
            // 
            // btnValidarComentarioMultiLinha
            // 
            this.btnValidarComentarioMultiLinha.Location = new System.Drawing.Point(276, 206);
            this.btnValidarComentarioMultiLinha.Name = "btnValidarComentarioMultiLinha";
            this.btnValidarComentarioMultiLinha.Size = new System.Drawing.Size(241, 23);
            this.btnValidarComentarioMultiLinha.TabIndex = 49;
            this.btnValidarComentarioMultiLinha.Text = "Validar comentário &multi-linha";
            this.btnValidarComentarioMultiLinha.UseVisualStyleBackColor = true;
            this.btnValidarComentarioMultiLinha.Click += new System.EventHandler(this.btnValidarComentarioMultiLinha_Click);
            // 
            // txtComentarioMultiLinha
            // 
            this.txtComentarioMultiLinha.Location = new System.Drawing.Point(276, 180);
            this.txtComentarioMultiLinha.Multiline = true;
            this.txtComentarioMultiLinha.Name = "txtComentarioMultiLinha";
            this.txtComentarioMultiLinha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentarioMultiLinha.Size = new System.Drawing.Size(241, 20);
            this.txtComentarioMultiLinha.TabIndex = 48;
            this.txtComentarioMultiLinha.Text = "*/ TESTE1\r\nTESTE2\r\nTESTE3\r\nTESTE4\r\nTESTE5\r\n*/";
            // 
            // lblComentarioMultiLinha
            // 
            this.lblComentarioMultiLinha.AutoSize = true;
            this.lblComentarioMultiLinha.Location = new System.Drawing.Point(273, 164);
            this.lblComentarioMultiLinha.Name = "lblComentarioMultiLinha";
            this.lblComentarioMultiLinha.Size = new System.Drawing.Size(188, 13);
            this.lblComentarioMultiLinha.TabIndex = 47;
            this.lblComentarioMultiLinha.Text = "Informe o comentário multi-linha (/* */):";
            // 
            // btnValidarCorHexadecimal
            // 
            this.btnValidarCorHexadecimal.Location = new System.Drawing.Point(276, 127);
            this.btnValidarCorHexadecimal.Name = "btnValidarCorHexadecimal";
            this.btnValidarCorHexadecimal.Size = new System.Drawing.Size(241, 23);
            this.btnValidarCorHexadecimal.TabIndex = 46;
            this.btnValidarCorHexadecimal.Text = "Validar &Cor Hexadecimal";
            this.btnValidarCorHexadecimal.UseVisualStyleBackColor = true;
            this.btnValidarCorHexadecimal.Click += new System.EventHandler(this.btnValidarCorHexadecimal_Click);
            // 
            // lblCorHexadecimal
            // 
            this.lblCorHexadecimal.AutoSize = true;
            this.lblCorHexadecimal.Location = new System.Drawing.Point(273, 85);
            this.lblCorHexadecimal.Name = "lblCorHexadecimal";
            this.lblCorHexadecimal.Size = new System.Drawing.Size(186, 13);
            this.lblCorHexadecimal.TabIndex = 45;
            this.lblCorHexadecimal.Text = "Informe a cor hexadecimal (#000000):";
            // 
            // btnValidarEnderecoIP
            // 
            this.btnValidarEnderecoIP.Location = new System.Drawing.Point(276, 51);
            this.btnValidarEnderecoIP.Name = "btnValidarEnderecoIP";
            this.btnValidarEnderecoIP.Size = new System.Drawing.Size(241, 23);
            this.btnValidarEnderecoIP.TabIndex = 44;
            this.btnValidarEnderecoIP.Text = "Validar Endereço &IP";
            this.btnValidarEnderecoIP.UseVisualStyleBackColor = true;
            this.btnValidarEnderecoIP.Click += new System.EventHandler(this.btnValidarEnderecoIP_Click);
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Location = new System.Drawing.Point(276, 25);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(241, 20);
            this.txtEnderecoIP.TabIndex = 43;
            this.txtEnderecoIP.Text = "128.0.0.1";
            // 
            // lblEnderecoIP
            // 
            this.lblEnderecoIP.AutoSize = true;
            this.lblEnderecoIP.Location = new System.Drawing.Point(273, 9);
            this.lblEnderecoIP.Name = "lblEnderecoIP";
            this.lblEnderecoIP.Size = new System.Drawing.Size(205, 13);
            this.lblEnderecoIP.TabIndex = 42;
            this.lblEnderecoIP.Text = "Informe o endereço IP (000.000.000.000):";
            // 
            // btnValidarCodigoPostal
            // 
            this.btnValidarCodigoPostal.Location = new System.Drawing.Point(9, 283);
            this.btnValidarCodigoPostal.Name = "btnValidarCodigoPostal";
            this.btnValidarCodigoPostal.Size = new System.Drawing.Size(241, 23);
            this.btnValidarCodigoPostal.TabIndex = 41;
            this.btnValidarCodigoPostal.Text = "Validar Código &Postal";
            this.btnValidarCodigoPostal.UseVisualStyleBackColor = true;
            this.btnValidarCodigoPostal.Click += new System.EventHandler(this.btnValidarCodigoPostal_Click);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(6, 241);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(184, 13);
            this.lblCodigoPostal.TabIndex = 40;
            this.lblCodigoPostal.Text = "Informe o código postal \"00000-000\":";
            // 
            // mskNumeroTelefonico
            // 
            this.mskNumeroTelefonico.Location = new System.Drawing.Point(9, 101);
            this.mskNumeroTelefonico.Mask = "(99) 000-000-000";
            this.mskNumeroTelefonico.Name = "mskNumeroTelefonico";
            this.mskNumeroTelefonico.Size = new System.Drawing.Size(241, 20);
            this.mskNumeroTelefonico.TabIndex = 39;
            this.mskNumeroTelefonico.Text = "11123456789";
            // 
            // btnValidarNumeroTelefonico
            // 
            this.btnValidarNumeroTelefonico.Location = new System.Drawing.Point(9, 127);
            this.btnValidarNumeroTelefonico.Name = "btnValidarNumeroTelefonico";
            this.btnValidarNumeroTelefonico.Size = new System.Drawing.Size(241, 23);
            this.btnValidarNumeroTelefonico.TabIndex = 38;
            this.btnValidarNumeroTelefonico.Text = "Validar Numero &Telefônico";
            this.btnValidarNumeroTelefonico.UseVisualStyleBackColor = true;
            this.btnValidarNumeroTelefonico.Click += new System.EventHandler(this.btnValidarNumeroTelefonico_Click);
            // 
            // lblNumeroTelefonico
            // 
            this.lblNumeroTelefonico.AutoSize = true;
            this.lblNumeroTelefonico.Location = new System.Drawing.Point(6, 85);
            this.lblNumeroTelefonico.Name = "lblNumeroTelefonico";
            this.lblNumeroTelefonico.Size = new System.Drawing.Size(189, 13);
            this.lblNumeroTelefonico.TabIndex = 37;
            this.lblNumeroTelefonico.Text = "Informe o telefone \"(99) 000-000-000\":";
            // 
            // btnValidarNomeUsuario
            // 
            this.btnValidarNomeUsuario.Location = new System.Drawing.Point(9, 51);
            this.btnValidarNomeUsuario.Name = "btnValidarNomeUsuario";
            this.btnValidarNomeUsuario.Size = new System.Drawing.Size(241, 23);
            this.btnValidarNomeUsuario.TabIndex = 36;
            this.btnValidarNomeUsuario.Text = "Validar Nome do &Usuário";
            this.btnValidarNomeUsuario.UseVisualStyleBackColor = true;
            this.btnValidarNomeUsuario.Click += new System.EventHandler(this.btnValidarNomeUsuario_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(9, 25);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(241, 20);
            this.txtNomeUsuario.TabIndex = 35;
            this.txtNomeUsuario.Text = "1T2eSTE3Ã0Oé10";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(6, 9);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(174, 13);
            this.lblNomeUsuario.TabIndex = 34;
            this.lblNomeUsuario.Text = "Informe o nome do usuário (3 a 30):";
            // 
            // btnValidarEmail
            // 
            this.btnValidarEmail.Location = new System.Drawing.Point(9, 206);
            this.btnValidarEmail.Name = "btnValidarEmail";
            this.btnValidarEmail.Size = new System.Drawing.Size(241, 23);
            this.btnValidarEmail.TabIndex = 33;
            this.btnValidarEmail.Text = "Validar &Email";
            this.btnValidarEmail.UseVisualStyleBackColor = true;
            this.btnValidarEmail.Click += new System.EventHandler(this.btnValidarEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Text = "teste@teste.com.br";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Informe o email:";
            // 
            // tbpOutros
            // 
            this.tbpOutros.Controls.Add(this.lblResposta);
            this.tbpOutros.Controls.Add(this.lblContratoDeDadosResposta);
            this.tbpOutros.Controls.Add(this.dtpContratoDeDados);
            this.tbpOutros.Controls.Add(this.chkContratoDeDados);
            this.tbpOutros.Controls.Add(this.btnContratoDeDados);
            this.tbpOutros.Controls.Add(this.txtContratoDeDados);
            this.tbpOutros.Controls.Add(this.lblContratoDeDados);
            this.tbpOutros.Controls.Add(this.btnVoceDigitou);
            this.tbpOutros.Controls.Add(this.txtVoceDigitou);
            this.tbpOutros.Controls.Add(this.lblVoceDigitou);
            this.tbpOutros.Location = new System.Drawing.Point(4, 22);
            this.tbpOutros.Name = "tbpOutros";
            this.tbpOutros.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOutros.Size = new System.Drawing.Size(531, 314);
            this.tbpOutros.TabIndex = 1;
            this.tbpOutros.Text = "Outros";
            this.tbpOutros.UseVisualStyleBackColor = true;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(6, 273);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 46;
            // 
            // lblContratoDeDadosResposta
            // 
            this.lblContratoDeDadosResposta.BackColor = System.Drawing.SystemColors.Window;
            this.lblContratoDeDadosResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContratoDeDadosResposta.Location = new System.Drawing.Point(6, 250);
            this.lblContratoDeDadosResposta.Name = "lblContratoDeDadosResposta";
            this.lblContratoDeDadosResposta.Size = new System.Drawing.Size(519, 47);
            this.lblContratoDeDadosResposta.TabIndex = 45;
            this.lblContratoDeDadosResposta.Text = "RESPOSTA DO CONTRATO DE DADOS";
            this.lblContratoDeDadosResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpContratoDeDados
            // 
            this.dtpContratoDeDados.Location = new System.Drawing.Point(9, 193);
            this.dtpContratoDeDados.Name = "dtpContratoDeDados";
            this.dtpContratoDeDados.Size = new System.Drawing.Size(241, 20);
            this.dtpContratoDeDados.TabIndex = 44;
            // 
            // chkContratoDeDados
            // 
            this.chkContratoDeDados.AutoSize = true;
            this.chkContratoDeDados.Checked = true;
            this.chkContratoDeDados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkContratoDeDados.Location = new System.Drawing.Point(9, 170);
            this.chkContratoDeDados.Name = "chkContratoDeDados";
            this.chkContratoDeDados.Size = new System.Drawing.Size(241, 17);
            this.chkContratoDeDados.TabIndex = 43;
            this.chkContratoDeDados.Text = "Mostra a Data e Hora no Contrato de Dados?";
            this.chkContratoDeDados.UseVisualStyleBackColor = true;
            // 
            // btnContratoDeDados
            // 
            this.btnContratoDeDados.Location = new System.Drawing.Point(9, 219);
            this.btnContratoDeDados.Name = "btnContratoDeDados";
            this.btnContratoDeDados.Size = new System.Drawing.Size(241, 23);
            this.btnContratoDeDados.TabIndex = 42;
            this.btnContratoDeDados.Text = "M&ostra o Uso do Contrato de Dados";
            this.btnContratoDeDados.UseVisualStyleBackColor = true;
            this.btnContratoDeDados.Click += new System.EventHandler(this.btnContratoDeDados_Click);
            // 
            // txtContratoDeDados
            // 
            this.txtContratoDeDados.Location = new System.Drawing.Point(9, 144);
            this.txtContratoDeDados.MaxLength = 3;
            this.txtContratoDeDados.Name = "txtContratoDeDados";
            this.txtContratoDeDados.Size = new System.Drawing.Size(241, 20);
            this.txtContratoDeDados.TabIndex = 41;
            this.txtContratoDeDados.Text = "São Paulo";
            // 
            // lblContratoDeDados
            // 
            this.lblContratoDeDados.AutoSize = true;
            this.lblContratoDeDados.Location = new System.Drawing.Point(6, 128);
            this.lblContratoDeDados.Name = "lblContratoDeDados";
            this.lblContratoDeDados.Size = new System.Drawing.Size(114, 13);
            this.lblContratoDeDados.TabIndex = 40;
            this.lblContratoDeDados.Text = "Digite um texto abaixo:";
            // 
            // btnVoceDigitou
            // 
            this.btnVoceDigitou.Location = new System.Drawing.Point(9, 51);
            this.btnVoceDigitou.Name = "btnVoceDigitou";
            this.btnVoceDigitou.Size = new System.Drawing.Size(241, 23);
            this.btnVoceDigitou.TabIndex = 39;
            this.btnVoceDigitou.Text = "Mostra o que digitou &acima usando o WCF";
            this.btnVoceDigitou.UseVisualStyleBackColor = true;
            this.btnVoceDigitou.Click += new System.EventHandler(this.btnVoceDigitou_Click);
            // 
            // txtVoceDigitou
            // 
            this.txtVoceDigitou.Location = new System.Drawing.Point(9, 25);
            this.txtVoceDigitou.MaxLength = 3;
            this.txtVoceDigitou.Name = "txtVoceDigitou";
            this.txtVoceDigitou.Size = new System.Drawing.Size(241, 20);
            this.txtVoceDigitou.TabIndex = 38;
            this.txtVoceDigitou.Text = "2";
            this.txtVoceDigitou.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoceDigitou_KeyPress);
            // 
            // lblVoceDigitou
            // 
            this.lblVoceDigitou.AutoSize = true;
            this.lblVoceDigitou.Location = new System.Drawing.Point(6, 9);
            this.lblVoceDigitou.Name = "lblVoceDigitou";
            this.lblVoceDigitou.Size = new System.Drawing.Size(77, 13);
            this.lblVoceDigitou.TabIndex = 37;
            this.lblVoceDigitou.Text = "Você Digitou...";
            // 
            // frmTestaValidacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 366);
            this.Controls.Add(this.tbcValidacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestaValidacao";
            this.ShowIcon = false;
            this.Text = "Testa Validação C# (form for test validation)";
            this.tbcValidacao.ResumeLayout(false);
            this.tbpValidacao.ResumeLayout(false);
            this.tbpValidacao.PerformLayout();
            this.tbpOutros.ResumeLayout(false);
            this.tbpOutros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl tbcValidacao;
        internal System.Windows.Forms.TabPage tbpValidacao;
        internal System.Windows.Forms.MaskedTextBox mskCorHexadecimal;
        internal System.Windows.Forms.MaskedTextBox mskData;
        internal System.Windows.Forms.MaskedTextBox mskCodigoPostal;
        internal System.Windows.Forms.Button btnData;
        internal System.Windows.Forms.Label lblData;
        internal System.Windows.Forms.Button btnValidarComentarioMultiLinha;
        internal System.Windows.Forms.TextBox txtComentarioMultiLinha;
        internal System.Windows.Forms.Label lblComentarioMultiLinha;
        internal System.Windows.Forms.Button btnValidarCorHexadecimal;
        internal System.Windows.Forms.Label lblCorHexadecimal;
        internal System.Windows.Forms.Button btnValidarEnderecoIP;
        internal System.Windows.Forms.TextBox txtEnderecoIP;
        internal System.Windows.Forms.Label lblEnderecoIP;
        internal System.Windows.Forms.Button btnValidarCodigoPostal;
        internal System.Windows.Forms.Label lblCodigoPostal;
        internal System.Windows.Forms.MaskedTextBox mskNumeroTelefonico;
        internal System.Windows.Forms.Button btnValidarNumeroTelefonico;
        internal System.Windows.Forms.Label lblNumeroTelefonico;
        internal System.Windows.Forms.Button btnValidarNomeUsuario;
        internal System.Windows.Forms.TextBox txtNomeUsuario;
        internal System.Windows.Forms.Label lblNomeUsuario;
        internal System.Windows.Forms.Button btnValidarEmail;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.TabPage tbpOutros;
        internal System.Windows.Forms.Label lblResposta;
        internal System.Windows.Forms.Label lblContratoDeDadosResposta;
        internal System.Windows.Forms.DateTimePicker dtpContratoDeDados;
        internal System.Windows.Forms.CheckBox chkContratoDeDados;
        internal System.Windows.Forms.Button btnContratoDeDados;
        internal System.Windows.Forms.TextBox txtContratoDeDados;
        internal System.Windows.Forms.Label lblContratoDeDados;
        internal System.Windows.Forms.Button btnVoceDigitou;
        internal System.Windows.Forms.TextBox txtVoceDigitou;
        internal System.Windows.Forms.Label lblVoceDigitou;
    }
}

