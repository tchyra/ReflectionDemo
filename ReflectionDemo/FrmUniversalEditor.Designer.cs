
namespace ReflectionDemo
{
    partial class FrmUniversalEditor
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
            this._flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this._btnZapisz = new System.Windows.Forms.Button();
            this._btnAnuluj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this._flpControls, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnZapisz, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._btnAnuluj, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _flpControls
            // 
            this._flpControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._flpControls, 2);
            this._flpControls.Location = new System.Drawing.Point(3, 3);
            this._flpControls.Name = "_flpControls";
            this._flpControls.Size = new System.Drawing.Size(794, 415);
            this._flpControls.TabIndex = 0;
            // 
            // _btnZapisz
            // 
            this._btnZapisz.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnZapisz.Location = new System.Drawing.Point(722, 424);
            this._btnZapisz.Name = "_btnZapisz";
            this._btnZapisz.Size = new System.Drawing.Size(75, 23);
            this._btnZapisz.TabIndex = 1;
            this._btnZapisz.Text = "Zapisz";
            this._btnZapisz.UseVisualStyleBackColor = true;
            // 
            // _btnAnuluj
            // 
            this._btnAnuluj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnAnuluj.Location = new System.Drawing.Point(641, 424);
            this._btnAnuluj.Name = "_btnAnuluj";
            this._btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this._btnAnuluj.TabIndex = 1;
            this._btnAnuluj.Text = "Anuluj";
            this._btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // FrmUniversalEditor
            // 
            this.AcceptButton = this._btnZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnAnuluj;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmUniversalEditor";
            this.Text = "Edytor uniwersalny";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel _flpControls;
        private System.Windows.Forms.Button _btnZapisz;
        private System.Windows.Forms.Button _btnAnuluj;
    }
}