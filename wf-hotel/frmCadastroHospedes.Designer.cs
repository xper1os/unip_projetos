
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
            this.SuspendLayout();
            // 
            // _btnSalvarHospede
            // 
            this._btnSalvarHospede.BackColor = System.Drawing.Color.White;
            this._btnSalvarHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnSalvarHospede.BackgroundImage")));
            this._btnSalvarHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSalvarHospede.Location = new System.Drawing.Point(521, 113);
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
            this.lblPrimeiroNomeHospede.Location = new System.Drawing.Point(12, 113);
            this.lblPrimeiroNomeHospede.Name = "lblPrimeiroNomeHospede";
            this.lblPrimeiroNomeHospede.Size = new System.Drawing.Size(146, 19);
            this.lblPrimeiroNomeHospede.TabIndex = 1;
            this.lblPrimeiroNomeHospede.Text = "PRIMEIRO NOME:";
            // 
            // txtPrimeiroNomeHospede
            // 
            this.txtPrimeiroNomeHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeiroNomeHospede.Location = new System.Drawing.Point(177, 99);
            this.txtPrimeiroNomeHospede.Multiline = true;
            this.txtPrimeiroNomeHospede.Name = "txtPrimeiroNomeHospede";
            this.txtPrimeiroNomeHospede.Size = new System.Drawing.Size(301, 33);
            this.txtPrimeiroNomeHospede.TabIndex = 2;
            // 
            // txtUltimoNomeHospede
            // 
            this.txtUltimoNomeHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoNomeHospede.Location = new System.Drawing.Point(177, 138);
            this.txtUltimoNomeHospede.Multiline = true;
            this.txtUltimoNomeHospede.Name = "txtUltimoNomeHospede";
            this.txtUltimoNomeHospede.Size = new System.Drawing.Size(301, 33);
            this.txtUltimoNomeHospede.TabIndex = 4;
            // 
            // lblUltimoNomeHospede
            // 
            this.lblUltimoNomeHospede.AutoSize = true;
            this.lblUltimoNomeHospede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoNomeHospede.Location = new System.Drawing.Point(12, 153);
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
            this.txtCodigoHospede.Location = new System.Drawing.Point(177, 19);
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
            this._btnUpdateHospede.Location = new System.Drawing.Point(571, 113);
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
            this.btnExcluirHospede.Location = new System.Drawing.Point(621, 113);
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
            this.btnBuscaHospede.Location = new System.Drawing.Point(671, 113);
            this.btnBuscaHospede.Name = "btnBuscaHospede";
            this.btnBuscaHospede.Size = new System.Drawing.Size(44, 50);
            this.btnBuscaHospede.TabIndex = 9;
            this.btnBuscaHospede.UseVisualStyleBackColor = false;
            this.btnBuscaHospede.Click += new System.EventHandler(this.btnBuscaHospede_Click);
            // 
            // frmCadastroHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(770, 554);
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
    }
}