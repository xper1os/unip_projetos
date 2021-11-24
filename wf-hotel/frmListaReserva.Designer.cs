
namespace wf_hotel
{
    partial class frmListaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaReserva));
            this.dgListaReservas = new System.Windows.Forms.DataGridView();
            this.btnSelecionaHospede = new System.Windows.Forms.Button();
            this.btnFechaListaHospede = new System.Windows.Forms.Button();
            this._btnUpdateHospede = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaReservas
            // 
            this.dgListaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaReservas.Location = new System.Drawing.Point(12, 12);
            this.dgListaReservas.Name = "dgListaReservas";
            this.dgListaReservas.Size = new System.Drawing.Size(841, 265);
            this.dgListaReservas.TabIndex = 0;
            // 
            // btnSelecionaHospede
            // 
            this.btnSelecionaHospede.BackColor = System.Drawing.Color.White;
            this.btnSelecionaHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelecionaHospede.BackgroundImage")));
            this.btnSelecionaHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelecionaHospede.Location = new System.Drawing.Point(249, 283);
            this.btnSelecionaHospede.Name = "btnSelecionaHospede";
            this.btnSelecionaHospede.Size = new System.Drawing.Size(44, 50);
            this.btnSelecionaHospede.TabIndex = 13;
            this.btnSelecionaHospede.UseVisualStyleBackColor = false;
            this.btnSelecionaHospede.Click += new System.EventHandler(this.btnSelecionaHospede_Click);
            // 
            // btnFechaListaHospede
            // 
            this.btnFechaListaHospede.BackColor = System.Drawing.Color.White;
            this.btnFechaListaHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechaListaHospede.BackgroundImage")));
            this.btnFechaListaHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechaListaHospede.Location = new System.Drawing.Point(538, 283);
            this.btnFechaListaHospede.Name = "btnFechaListaHospede";
            this.btnFechaListaHospede.Size = new System.Drawing.Size(44, 50);
            this.btnFechaListaHospede.TabIndex = 12;
            this.btnFechaListaHospede.UseVisualStyleBackColor = false;
            this.btnFechaListaHospede.Click += new System.EventHandler(this.btnFechaListaHospede_Click);
            // 
            // _btnUpdateHospede
            // 
            this._btnUpdateHospede.BackColor = System.Drawing.Color.White;
            this._btnUpdateHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnUpdateHospede.BackgroundImage")));
            this._btnUpdateHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnUpdateHospede.Location = new System.Drawing.Point(394, 283);
            this._btnUpdateHospede.Name = "_btnUpdateHospede";
            this._btnUpdateHospede.Size = new System.Drawing.Size(44, 50);
            this._btnUpdateHospede.TabIndex = 11;
            this._btnUpdateHospede.UseVisualStyleBackColor = false;
            // 
            // frmListaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(865, 344);
            this.Controls.Add(this.btnSelecionaHospede);
            this.Controls.Add(this.btnFechaListaHospede);
            this.Controls.Add(this._btnUpdateHospede);
            this.Controls.Add(this.dgListaReservas);
            this.Name = "frmListaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Reservas";
            this.Load += new System.EventHandler(this.frmListaReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaReservas;
        private System.Windows.Forms.Button btnSelecionaHospede;
        private System.Windows.Forms.Button btnFechaListaHospede;
        private System.Windows.Forms.Button _btnUpdateHospede;
    }
}