
namespace ReflectionDemo
{
    partial class FrmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnOsobyDodaj = new System.Windows.Forms.Button();
            this._btnOsobyEdytuj = new System.Windows.Forms.Button();
            this._btnOsobyUsun = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnZamowieniaDodaj = new System.Windows.Forms.Button();
            this._btnZamowieniaEdytuj = new System.Windows.Forms.Button();
            this._btnZamowieniaUsun = new System.Windows.Forms.Button();
            this._dgvOsoby = new System.Windows.Forms.DataGridView();
            this._dgvZamowienia = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvOsoby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._dgvOsoby, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 395);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this._btnOsobyDodaj);
            this.flowLayoutPanel1.Controls.Add(this._btnOsobyEdytuj);
            this.flowLayoutPanel1.Controls.Add(this._btnOsobyUsun);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // _btnOsobyDodaj
            // 
            this._btnOsobyDodaj.Location = new System.Drawing.Point(3, 3);
            this._btnOsobyDodaj.Name = "_btnOsobyDodaj";
            this._btnOsobyDodaj.Size = new System.Drawing.Size(75, 23);
            this._btnOsobyDodaj.TabIndex = 0;
            this._btnOsobyDodaj.Text = "Dodaj";
            this._btnOsobyDodaj.UseVisualStyleBackColor = true;
            // 
            // _btnOsobyEdytuj
            // 
            this._btnOsobyEdytuj.Location = new System.Drawing.Point(84, 3);
            this._btnOsobyEdytuj.Name = "_btnOsobyEdytuj";
            this._btnOsobyEdytuj.Size = new System.Drawing.Size(75, 23);
            this._btnOsobyEdytuj.TabIndex = 1;
            this._btnOsobyEdytuj.Text = "Edytuj";
            this._btnOsobyEdytuj.UseVisualStyleBackColor = true;
            // 
            // _btnOsobyUsun
            // 
            this._btnOsobyUsun.Location = new System.Drawing.Point(165, 3);
            this._btnOsobyUsun.Name = "_btnOsobyUsun";
            this._btnOsobyUsun.Size = new System.Drawing.Size(75, 23);
            this._btnOsobyUsun.TabIndex = 2;
            this._btnOsobyUsun.Text = "Usuń";
            this._btnOsobyUsun.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1357, 426);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osoby";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(681, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 420);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zamówienia";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._dgvZamowienia, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(661, 395);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this._btnZamowieniaDodaj);
            this.flowLayoutPanel2.Controls.Add(this._btnZamowieniaEdytuj);
            this.flowLayoutPanel2.Controls.Add(this._btnZamowieniaUsun);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // _btnZamowieniaDodaj
            // 
            this._btnZamowieniaDodaj.Location = new System.Drawing.Point(3, 3);
            this._btnZamowieniaDodaj.Name = "_btnZamowieniaDodaj";
            this._btnZamowieniaDodaj.Size = new System.Drawing.Size(75, 23);
            this._btnZamowieniaDodaj.TabIndex = 0;
            this._btnZamowieniaDodaj.Text = "Dodaj";
            this._btnZamowieniaDodaj.UseVisualStyleBackColor = true;
            // 
            // _btnZamowieniaEdytuj
            // 
            this._btnZamowieniaEdytuj.Location = new System.Drawing.Point(84, 3);
            this._btnZamowieniaEdytuj.Name = "_btnZamowieniaEdytuj";
            this._btnZamowieniaEdytuj.Size = new System.Drawing.Size(75, 23);
            this._btnZamowieniaEdytuj.TabIndex = 1;
            this._btnZamowieniaEdytuj.Text = "Edytuj";
            this._btnZamowieniaEdytuj.UseVisualStyleBackColor = true;
            // 
            // _btnZamowieniaUsun
            // 
            this._btnZamowieniaUsun.Location = new System.Drawing.Point(165, 3);
            this._btnZamowieniaUsun.Name = "_btnZamowieniaUsun";
            this._btnZamowieniaUsun.Size = new System.Drawing.Size(75, 23);
            this._btnZamowieniaUsun.TabIndex = 2;
            this._btnZamowieniaUsun.Text = "Usuń";
            this._btnZamowieniaUsun.UseVisualStyleBackColor = true;
            // 
            // _dgvOsoby
            // 
            this._dgvOsoby.AllowUserToAddRows = false;
            this._dgvOsoby.AllowUserToDeleteRows = false;
            this._dgvOsoby.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvOsoby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvOsoby.Location = new System.Drawing.Point(3, 38);
            this._dgvOsoby.Name = "_dgvOsoby";
            this._dgvOsoby.ReadOnly = true;
            this._dgvOsoby.Size = new System.Drawing.Size(654, 354);
            this._dgvOsoby.TabIndex = 2;
            // 
            // _dgvZamowienia
            // 
            this._dgvZamowienia.AllowUserToAddRows = false;
            this._dgvZamowienia.AllowUserToDeleteRows = false;
            this._dgvZamowienia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvZamowienia.Location = new System.Drawing.Point(3, 38);
            this._dgvZamowienia.Name = "_dgvZamowienia";
            this._dgvZamowienia.ReadOnly = true;
            this._dgvZamowienia.Size = new System.Drawing.Size(655, 354);
            this._dgvZamowienia.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FrmMain";
            this.Text = "Reflection Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvOsoby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvZamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _btnOsobyDodaj;
        private System.Windows.Forms.Button _btnOsobyEdytuj;
        private System.Windows.Forms.Button _btnOsobyUsun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button _btnZamowieniaDodaj;
        private System.Windows.Forms.Button _btnZamowieniaEdytuj;
        private System.Windows.Forms.Button _btnZamowieniaUsun;
        private System.Windows.Forms.DataGridView _dgvOsoby;
        private System.Windows.Forms.DataGridView _dgvZamowienia;
    }
}

