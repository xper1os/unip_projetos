
namespace wf_hotel
{
    partial class frmListaHospedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaHospedes));
            this.dgListaHospedes = new System.Windows.Forms.DataGridView();
            this._btnUpdateHospede = new System.Windows.Forms.Button();
            this.btnFechaListaHospede = new System.Windows.Forms.Button();
            this.btnSelecionaHospede = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaHospedes
            // 
            this.dgListaHospedes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgListaHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaHospedes.Location = new System.Drawing.Point(12, 12);
            this.dgListaHospedes.Name = "dgListaHospedes";
            this.dgListaHospedes.Size = new System.Drawing.Size(333, 274);
            this.dgListaHospedes.TabIndex = 0;
            // 
            // _btnUpdateHospede
            // 
            this._btnUpdateHospede.BackColor = System.Drawing.Color.White;
            this._btnUpdateHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnUpdateHospede.BackgroundImage")));
            this._btnUpdateHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnUpdateHospede.Location = new System.Drawing.Point(157, 292);
            this._btnUpdateHospede.Name = "_btnUpdateHospede";
            this._btnUpdateHospede.Size = new System.Drawing.Size(44, 50);
            this._btnUpdateHospede.TabIndex = 8;
            this._btnUpdateHospede.UseVisualStyleBackColor = false;
            this._btnUpdateHospede.Click += new System.EventHandler(this._btnUpdateHospede_Click);
            // 
            // btnFechaListaHospede
            // 
            this.btnFechaListaHospede.BackColor = System.Drawing.Color.White;
            this.btnFechaListaHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechaListaHospede.BackgroundImage")));
            this.btnFechaListaHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechaListaHospede.Location = new System.Drawing.Point(301, 292);
            this.btnFechaListaHospede.Name = "btnFechaListaHospede";
            this.btnFechaListaHospede.Size = new System.Drawing.Size(44, 50);
            this.btnFechaListaHospede.TabIndex = 9;
            this.btnFechaListaHospede.UseVisualStyleBackColor = false;
            this.btnFechaListaHospede.Click += new System.EventHandler(this.btnFechaListaHospede_Click);
            // 
            // btnSelecionaHospede
            // 
            this.btnSelecionaHospede.BackColor = System.Drawing.Color.White;
            this.btnSelecionaHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelecionaHospede.BackgroundImage")));
            this.btnSelecionaHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelecionaHospede.Location = new System.Drawing.Point(12, 292);
            this.btnSelecionaHospede.Name = "btnSelecionaHospede";
            this.btnSelecionaHospede.Size = new System.Drawing.Size(44, 50);
            this.btnSelecionaHospede.TabIndex = 10;
            this.btnSelecionaHospede.UseVisualStyleBackColor = false;
            this.btnSelecionaHospede.Click += new System.EventHandler(this.btnSelecionaHospede_Click);
            // 
            // frmListaHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(356, 382);
            this.Controls.Add(this.btnSelecionaHospede);
            this.Controls.Add(this.btnFechaListaHospede);
            this.Controls.Add(this._btnUpdateHospede);
            this.Controls.Add(this.dgListaHospedes);
            this.Name = "frmListaHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóspedes Cadastrados";
            this.Load += new System.EventHandler(this.frmListaHospedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaHospedes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaHospedes;
        private System.Windows.Forms.Button _btnUpdateHospede;
        private System.Windows.Forms.Button btnFechaListaHospede;
        private System.Windows.Forms.Button btnSelecionaHospede;
    }
}