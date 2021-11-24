
namespace wf_hotel
{
    partial class frmCadastroHospedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroHospedes));
            this._btnSalvarHospede = new System.Windows.Forms.Button();
            this.lblPrimeiroNomeHospede = new System.Windows.Forms.Label();
            this.txtPrimeiroNomeHospede = new System.Windows.Forms.TextBox();
            this.txtUltimoNomeHospede = new System.Windows.Forms.TextBox();
            this.lblUltimoNomeHospede = new System.Windows.Forms.Label();
            this.lblCodigoHospede = new System.Windows.Forms.Label();
            this.txtCodigoHospede = new System.Windows.Forms.TextBox();
            this._btnUpdateHospede = new System.Windows.Forms.Button();
            this.btnExcluirHospede = new System.Windows.Forms.Button();
            this.btnBuscaHospede = new System.Windows.Forms.Button();
            this.lblCpfHospede = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblRgHospede = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblEmailHospede = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouroHospede = new System.Windows.Forms.Label();
            this.lblCidadeHospede = new System.Windows.Forms.Label();
            this.lblBairroHospede = new System.Windows.Forms.Label();
            this.lblComplementoHospede = new System.Windows.Forms.Label();
            this.lblNumeroCasaHospede = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.lblDataCadastroHospede = new System.Windows.Forms.Label();
            this.lblCepHospede = new System.Windows.Forms.Label();
            this.lblUfHospede = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtUfHospede = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnSalvarHospede
            // 
            this._btnSalvarHospede.BackColor = System.Drawing.Color.White;
            this._btnSalvarHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnSalvarHospede.BackgroundImage")));
            this._btnSalvarHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSalvarHospede.Location = new System.Drawing.Point(197, 566);
            this._btnSalvarHospede.Name = "_btnSalvarHospede";
            this._btnSalvarHospede.Size = new System.Drawing.Size(44, 50);
            this._btnSalvarHospede.TabIndex = 0;
            this._btnSalvarHospede.UseVisualStyleBackColor = false;
            this._btnSalvarHospede.Click += new System.EventHandler(this._btnSalvarHospede_Click);
            // 
            // lblPrimeiroNomeHospede
            // 
            this.lblPrimeiroNomeHospede.AutoSize = true;
            this.lblPrimeiroNomeHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroNomeHospede.Location = new System.Drawing.Point(12, 73);
            this.lblPrimeiroNomeHospede.Name = "lblPrimeiroNomeHospede";
            this.lblPrimeiroNomeHospede.Size = new System.Drawing.Size(146, 19);
            this.lblPrimeiroNomeHospede.TabIndex = 1;
            this.lblPrimeiroNomeHospede.Text = "PRIMEIRO NOME:";
            // 
            // txtPrimeiroNomeHospede
            // 
            this.txtPrimeiroNomeHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeiroNomeHospede.Location = new System.Drawing.Point(197, 59);
            this.txtPrimeiroNomeHospede.Multiline = true;
            this.txtPrimeiroNomeHospede.Name = "txtPrimeiroNomeHospede";
            this.txtPrimeiroNomeHospede.Size = new System.Drawing.Size(301, 33);
            this.txtPrimeiroNomeHospede.TabIndex = 2;
            // 
            // txtUltimoNomeHospede
            // 
            this.txtUltimoNomeHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoNomeHospede.Location = new System.Drawing.Point(197, 98);
            this.txtUltimoNomeHospede.Multiline = true;
            this.txtUltimoNomeHospede.Name = "txtUltimoNomeHospede";
            this.txtUltimoNomeHospede.Size = new System.Drawing.Size(301, 33);
            this.txtUltimoNomeHospede.TabIndex = 4;
            // 
            // lblUltimoNomeHospede
            // 
            this.lblUltimoNomeHospede.AutoSize = true;
            this.lblUltimoNomeHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoNomeHospede.Location = new System.Drawing.Point(12, 112);
            this.lblUltimoNomeHospede.Name = "lblUltimoNomeHospede";
            this.lblUltimoNomeHospede.Size = new System.Drawing.Size(127, 19);
            this.lblUltimoNomeHospede.TabIndex = 3;
            this.lblUltimoNomeHospede.Text = "ÚLTIMO NOME:";
            // 
            // lblCodigoHospede
            // 
            this.lblCodigoHospede.AutoSize = true;
            this.lblCodigoHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoHospede.Location = new System.Drawing.Point(12, 33);
            this.lblCodigoHospede.Name = "lblCodigoHospede";
            this.lblCodigoHospede.Size = new System.Drawing.Size(79, 19);
            this.lblCodigoHospede.TabIndex = 5;
            this.lblCodigoHospede.Text = "CÓDIGO:";
            // 
            // txtCodigoHospede
            // 
            this.txtCodigoHospede.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoHospede.Location = new System.Drawing.Point(197, 20);
            this.txtCodigoHospede.Multiline = true;
            this.txtCodigoHospede.Name = "txtCodigoHospede";
            this.txtCodigoHospede.Size = new System.Drawing.Size(52, 33);
            this.txtCodigoHospede.TabIndex = 6;
            // 
            // _btnUpdateHospede
            // 
            this._btnUpdateHospede.BackColor = System.Drawing.Color.White;
            this._btnUpdateHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnUpdateHospede.BackgroundImage")));
            this._btnUpdateHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnUpdateHospede.Location = new System.Drawing.Point(247, 566);
            this._btnUpdateHospede.Name = "_btnUpdateHospede";
            this._btnUpdateHospede.Size = new System.Drawing.Size(44, 50);
            this._btnUpdateHospede.TabIndex = 7;
            this._btnUpdateHospede.UseVisualStyleBackColor = false;
            this._btnUpdateHospede.Click += new System.EventHandler(this._btnUpdateHospede_Click);
            // 
            // btnExcluirHospede
            // 
            this.btnExcluirHospede.BackColor = System.Drawing.Color.White;
            this.btnExcluirHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirHospede.BackgroundImage")));
            this.btnExcluirHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirHospede.Location = new System.Drawing.Point(297, 566);
            this.btnExcluirHospede.Name = "btnExcluirHospede";
            this.btnExcluirHospede.Size = new System.Drawing.Size(44, 50);
            this.btnExcluirHospede.TabIndex = 8;
            this.btnExcluirHospede.UseVisualStyleBackColor = false;
            this.btnExcluirHospede.Click += new System.EventHandler(this.btnExcluirHospede_Click);
            // 
            // btnBuscaHospede
            // 
            this.btnBuscaHospede.BackColor = System.Drawing.Color.White;
            this.btnBuscaHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaHospede.BackgroundImage")));
            this.btnBuscaHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscaHospede.Location = new System.Drawing.Point(347, 566);
            this.btnBuscaHospede.Name = "btnBuscaHospede";
            this.btnBuscaHospede.Size = new System.Drawing.Size(44, 50);
            this.btnBuscaHospede.TabIndex = 9;
            this.btnBuscaHospede.UseVisualStyleBackColor = false;
            this.btnBuscaHospede.Click += new System.EventHandler(this.btnBuscaHospede_Click);
            // 
            // lblCpfHospede
            // 
            this.lblCpfHospede.AutoSize = true;
            this.lblCpfHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfHospede.Location = new System.Drawing.Point(12, 151);
            this.lblCpfHospede.Name = "lblCpfHospede";
            this.lblCpfHospede.Size = new System.Drawing.Size(48, 19);
            this.lblCpfHospede.TabIndex = 10;
            this.lblCpfHospede.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(197, 137);
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(301, 33);
            this.txtCpf.TabIndex = 11;
            // 
            // lblRgHospede
            // 
            this.lblRgHospede.AutoSize = true;
            this.lblRgHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgHospede.Location = new System.Drawing.Point(12, 190);
            this.lblRgHospede.Name = "lblRgHospede";
            this.lblRgHospede.Size = new System.Drawing.Size(39, 19);
            this.lblRgHospede.TabIndex = 12;
            this.lblRgHospede.Text = "RG:";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(197, 176);
            this.txtRg.Multiline = true;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(301, 33);
            this.txtRg.TabIndex = 13;
            // 
            // lblEmailHospede
            // 
            this.lblEmailHospede.AutoSize = true;
            this.lblEmailHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailHospede.Location = new System.Drawing.Point(12, 229);
            this.lblEmailHospede.Name = "lblEmailHospede";
            this.lblEmailHospede.Size = new System.Drawing.Size(64, 19);
            this.lblEmailHospede.TabIndex = 14;
            this.lblEmailHospede.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(197, 215);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 33);
            this.txtEmail.TabIndex = 15;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(197, 254);
            this.txtLogradouro.Multiline = true;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(301, 33);
            this.txtLogradouro.TabIndex = 16;
            // 
            // lblLogradouroHospede
            // 
            this.lblLogradouroHospede.AutoSize = true;
            this.lblLogradouroHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouroHospede.Location = new System.Drawing.Point(12, 268);
            this.lblLogradouroHospede.Name = "lblLogradouroHospede";
            this.lblLogradouroHospede.Size = new System.Drawing.Size(132, 19);
            this.lblLogradouroHospede.TabIndex = 17;
            this.lblLogradouroHospede.Text = "LOGRADOURO:";
            // 
            // lblCidadeHospede
            // 
            this.lblCidadeHospede.AutoSize = true;
            this.lblCidadeHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeHospede.Location = new System.Drawing.Point(12, 424);
            this.lblCidadeHospede.Name = "lblCidadeHospede";
            this.lblCidadeHospede.Size = new System.Drawing.Size(77, 19);
            this.lblCidadeHospede.TabIndex = 21;
            this.lblCidadeHospede.Text = "CIDADE:";
            // 
            // lblBairroHospede
            // 
            this.lblBairroHospede.AutoSize = true;
            this.lblBairroHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroHospede.Location = new System.Drawing.Point(12, 385);
            this.lblBairroHospede.Name = "lblBairroHospede";
            this.lblBairroHospede.Size = new System.Drawing.Size(78, 19);
            this.lblBairroHospede.TabIndex = 20;
            this.lblBairroHospede.Text = "BAIRRO:";
            // 
            // lblComplementoHospede
            // 
            this.lblComplementoHospede.AutoSize = true;
            this.lblComplementoHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplementoHospede.Location = new System.Drawing.Point(12, 346);
            this.lblComplementoHospede.Name = "lblComplementoHospede";
            this.lblComplementoHospede.Size = new System.Drawing.Size(142, 19);
            this.lblComplementoHospede.TabIndex = 19;
            this.lblComplementoHospede.Text = "COMPLEMENTO:";
            // 
            // lblNumeroCasaHospede
            // 
            this.lblNumeroCasaHospede.AutoSize = true;
            this.lblNumeroCasaHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCasaHospede.Location = new System.Drawing.Point(12, 307);
            this.lblNumeroCasaHospede.Name = "lblNumeroCasaHospede";
            this.lblNumeroCasaHospede.Size = new System.Drawing.Size(87, 19);
            this.lblNumeroCasaHospede.TabIndex = 18;
            this.lblNumeroCasaHospede.Text = "NUMERO:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(197, 410);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(301, 33);
            this.txtCidade.TabIndex = 25;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(197, 371);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(301, 33);
            this.txtBairro.TabIndex = 24;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(197, 332);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(301, 33);
            this.txtComplemento.TabIndex = 23;
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(197, 293);
            this.txtNumeroCasa.Multiline = true;
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(301, 33);
            this.txtNumeroCasa.TabIndex = 22;
            // 
            // lblDataCadastroHospede
            // 
            this.lblDataCadastroHospede.AutoSize = true;
            this.lblDataCadastroHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastroHospede.Location = new System.Drawing.Point(12, 533);
            this.lblDataCadastroHospede.Name = "lblDataCadastroHospede";
            this.lblDataCadastroHospede.Size = new System.Drawing.Size(178, 19);
            this.lblDataCadastroHospede.TabIndex = 28;
            this.lblDataCadastroHospede.Text = "DATA DE CADASTRO:";
            // 
            // lblCepHospede
            // 
            this.lblCepHospede.AutoSize = true;
            this.lblCepHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepHospede.Location = new System.Drawing.Point(12, 502);
            this.lblCepHospede.Name = "lblCepHospede";
            this.lblCepHospede.Size = new System.Drawing.Size(49, 19);
            this.lblCepHospede.TabIndex = 27;
            this.lblCepHospede.Text = "CEP:";
            // 
            // lblUfHospede
            // 
            this.lblUfHospede.AutoSize = true;
            this.lblUfHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUfHospede.Location = new System.Drawing.Point(12, 463);
            this.lblUfHospede.Name = "lblUfHospede";
            this.lblUfHospede.Size = new System.Drawing.Size(37, 19);
            this.lblUfHospede.TabIndex = 26;
            this.lblUfHospede.Text = "UF:";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.Location = new System.Drawing.Point(197, 527);
            this.txtDataCadastro.Multiline = true;
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(301, 33);
            this.txtDataCadastro.TabIndex = 31;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(197, 488);
            this.txtCep.Multiline = true;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(301, 33);
            this.txtCep.TabIndex = 30;
            // 
            // txtUfHospede
            // 
            this.txtUfHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUfHospede.Location = new System.Drawing.Point(197, 449);
            this.txtUfHospede.Multiline = true;
            this.txtUfHospede.Name = "txtUfHospede";
            this.txtUfHospede.Size = new System.Drawing.Size(301, 33);
            this.txtUfHospede.TabIndex = 29;
            // 
            // frmCadastroHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(512, 626);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtUfHospede);
            this.Controls.Add(this.lblDataCadastroHospede);
            this.Controls.Add(this.lblCepHospede);
            this.Controls.Add(this.lblUfHospede);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.lblCidadeHospede);
            this.Controls.Add(this.lblBairroHospede);
            this.Controls.Add(this.lblComplementoHospede);
            this.Controls.Add(this.lblNumeroCasaHospede);
            this.Controls.Add(this.lblLogradouroHospede);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmailHospede);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblRgHospede);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpfHospede);
            this.Controls.Add(this.btnBuscaHospede);
            this.Controls.Add(this.btnExcluirHospede);
            this.Controls.Add(this._btnUpdateHospede);
            this.Controls.Add(this.txtCodigoHospede);
            this.Controls.Add(this.lblCodigoHospede);
            this.Controls.Add(this.txtUltimoNomeHospede);
            this.Controls.Add(this.lblUltimoNomeHospede);
            this.Controls.Add(this.txtPrimeiroNomeHospede);
            this.Controls.Add(this.lblPrimeiroNomeHospede);
            this.Controls.Add(this._btnSalvarHospede);
            this.Name = "frmCadastroHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Hóspedes";
            this.Load += new System.EventHandler(this.frmCadastroHospedes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnSalvarHospede;
        private System.Windows.Forms.Label lblPrimeiroNomeHospede;
        private System.Windows.Forms.TextBox txtPrimeiroNomeHospede;
        private System.Windows.Forms.TextBox txtUltimoNomeHospede;
        private System.Windows.Forms.Label lblUltimoNomeHospede;
        private System.Windows.Forms.Label lblCodigoHospede;
        private System.Windows.Forms.TextBox txtCodigoHospede;
        private System.Windows.Forms.Button _btnUpdateHospede;
        private System.Windows.Forms.Button btnExcluirHospede;
        private System.Windows.Forms.Button btnBuscaHospede;
        private System.Windows.Forms.Label lblCpfHospede;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblRgHospede;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblEmailHospede;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouroHospede;
        private System.Windows.Forms.Label lblCidadeHospede;
        private System.Windows.Forms.Label lblBairroHospede;
        private System.Windows.Forms.Label lblComplementoHospede;
        private System.Windows.Forms.Label lblNumeroCasaHospede;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.Label lblDataCadastroHospede;
        private System.Windows.Forms.Label lblCepHospede;
        private System.Windows.Forms.Label lblUfHospede;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtUfHospede;
    }
}