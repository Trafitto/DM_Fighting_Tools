namespace DM_Fighting_Tools
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdPG = new System.Windows.Forms.DataGridView();
            this.dbPG = new System.Data.DataSet();
            this.TablePG = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.grupDanni = new System.Windows.Forms.GroupBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnSottrai = new System.Windows.Forms.Button();
            this.txtmodVita = new System.Windows.Forms.TextBox();
            this.lblNomePG = new System.Windows.Forms.Label();
            this.groupIniziativa = new System.Windows.Forms.GroupBox();
            this.txtIniziativa = new System.Windows.Forms.TextBox();
            this.apriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiAccodaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniziativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CA_Contatto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CA_Sprovvista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePG)).BeginInit();
            this.grupDanni.SuspendLayout();
            this.groupIniziativa.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // grdPG
            // 
            this.grdPG.AutoGenerateColumns = false;
            this.grdPG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdPG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iniziativa,
            this.lifeDataGridViewTextBoxColumn,
            this.CA,
            this.CA_Contatto,
            this.CA_Sprovvista});
            this.grdPG.DataMember = "PGdata";
            this.grdPG.DataSource = this.dbPG;
            this.grdPG.Location = new System.Drawing.Point(12, 61);
            this.grdPG.Name = "grdPG";
            this.grdPG.Size = new System.Drawing.Size(467, 385);
            this.grdPG.TabIndex = 1;
            this.grdPG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdPG_CellMouseClick);
            // 
            // dbPG
            // 
            this.dbPG.DataSetName = "dbPB";
            this.dbPG.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.dbPG.Tables.AddRange(new System.Data.DataTable[] {
            this.TablePG});
            // 
            // TablePG
            // 
            this.TablePG.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.TablePG.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.TablePG.TableName = "PGdata";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.Caption = "Nome";
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.ColumnName = "Iniziativa";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.AllowDBNull = false;
            this.dataColumn3.Caption = "Vita";
            this.dataColumn3.ColumnName = "Life";
            this.dataColumn3.DataType = typeof(int);
            // 
            // openFile
            // 
            this.openFile.FileName = "Personaggi.txt";
            // 
            // grupDanni
            // 
            this.grupDanni.Controls.Add(this.btnAggiungi);
            this.grupDanni.Controls.Add(this.btnSottrai);
            this.grupDanni.Controls.Add(this.txtmodVita);
            this.grupDanni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupDanni.Location = new System.Drawing.Point(534, 75);
            this.grupDanni.Name = "grupDanni";
            this.grupDanni.Size = new System.Drawing.Size(283, 340);
            this.grupDanni.TabIndex = 2;
            this.grupDanni.TabStop = false;
            this.grupDanni.Text = "Danni";
            this.grupDanni.Visible = false;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(225, 48);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(34, 23);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "+";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnSottrai
            // 
            this.btnSottrai.Location = new System.Drawing.Point(168, 48);
            this.btnSottrai.Name = "btnSottrai";
            this.btnSottrai.Size = new System.Drawing.Size(34, 23);
            this.btnSottrai.TabIndex = 2;
            this.btnSottrai.Text = "-";
            this.btnSottrai.UseVisualStyleBackColor = true;
            this.btnSottrai.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmodVita
            // 
            this.txtmodVita.Location = new System.Drawing.Point(39, 48);
            this.txtmodVita.Name = "txtmodVita";
            this.txtmodVita.Size = new System.Drawing.Size(100, 26);
            this.txtmodVita.TabIndex = 1;
            this.txtmodVita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomePG
            // 
            this.lblNomePG.AutoSize = true;
            this.lblNomePG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePG.Location = new System.Drawing.Point(649, 52);
            this.lblNomePG.Name = "lblNomePG";
            this.lblNomePG.Size = new System.Drawing.Size(43, 20);
            this.lblNomePG.TabIndex = 0;
            this.lblNomePG.Text = "Title";
            // 
            // groupIniziativa
            // 
            this.groupIniziativa.Controls.Add(this.label1);
            this.groupIniziativa.Controls.Add(this.txtIniziativa);
            this.groupIniziativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIniziativa.Location = new System.Drawing.Point(534, 81);
            this.groupIniziativa.Name = "groupIniziativa";
            this.groupIniziativa.Size = new System.Drawing.Size(283, 340);
            this.groupIniziativa.TabIndex = 5;
            this.groupIniziativa.TabStop = false;
            this.groupIniziativa.Text = "Dati: Iniziativa ecc.";
            this.groupIniziativa.Visible = false;
            // 
            // txtIniziativa
            // 
            this.txtIniziativa.Location = new System.Drawing.Point(128, 45);
            this.txtIniziativa.Name = "txtIniziativa";
            this.txtIniziativa.Size = new System.Drawing.Size(100, 26);
            this.txtIniziativa.TabIndex = 1;
            this.txtIniziativa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIniziativa.TextChanged += new System.EventHandler(this.txtIniziativa_TextChanged);
            // 
            // apriToolStripMenuItem1
            // 
            this.apriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoMenu,
            this.aggiungiAccodaMenu});
            this.apriToolStripMenuItem1.Name = "apriToolStripMenuItem1";
            this.apriToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.apriToolStripMenuItem1.Text = "Apri";
            // 
            // nuovoMenu
            // 
            this.nuovoMenu.Name = "nuovoMenu";
            this.nuovoMenu.Size = new System.Drawing.Size(168, 22);
            this.nuovoMenu.Text = "Nuovo";
            this.nuovoMenu.Click += new System.EventHandler(this.nuovoMenu_Click);
            // 
            // aggiungiAccodaMenu
            // 
            this.aggiungiAccodaMenu.Name = "aggiungiAccodaMenu";
            this.aggiungiAccodaMenu.Size = new System.Drawing.Size(168, 22);
            this.aggiungiAccodaMenu.Text = "Aggiungi/Accoda";
            this.aggiungiAccodaMenu.Click += new System.EventHandler(this.aggiungiAccodaMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iniziativa:";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "CA";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "CA_Contatto";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "CA_Sprovvista";
            this.dataColumn6.DataType = typeof(int);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // iniziativa
            // 
            this.iniziativa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iniziativa.DataPropertyName = "Iniziativa";
            this.iniziativa.Frozen = true;
            this.iniziativa.HeaderText = "Iniziativa";
            this.iniziativa.Name = "iniziativa";
            this.iniziativa.ReadOnly = true;
            this.iniziativa.Width = 73;
            // 
            // lifeDataGridViewTextBoxColumn
            // 
            this.lifeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lifeDataGridViewTextBoxColumn.DataPropertyName = "Life";
            this.lifeDataGridViewTextBoxColumn.Frozen = true;
            this.lifeDataGridViewTextBoxColumn.HeaderText = "Vita";
            this.lifeDataGridViewTextBoxColumn.Name = "lifeDataGridViewTextBoxColumn";
            this.lifeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lifeDataGridViewTextBoxColumn.Width = 50;
            // 
            // CA
            // 
            this.CA.DataPropertyName = "CA";
            this.CA.Frozen = true;
            this.CA.HeaderText = "CA";
            this.CA.Name = "CA";
            this.CA.Width = 46;
            // 
            // CA_Contatto
            // 
            this.CA_Contatto.DataPropertyName = "CA_Contatto";
            this.CA_Contatto.Frozen = true;
            this.CA_Contatto.HeaderText = "CA_Contatto";
            this.CA_Contatto.Name = "CA_Contatto";
            this.CA_Contatto.Width = 92;
            // 
            // CA_Sprovvista
            // 
            this.CA_Sprovvista.DataPropertyName = "CA_Sprovvista";
            this.CA_Sprovvista.Frozen = true;
            this.CA_Sprovvista.HeaderText = "CA_Sprovvista";
            this.CA_Sprovvista.Name = "CA_Sprovvista";
            this.CA_Sprovvista.Width = 102;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 475);
            this.Controls.Add(this.groupIniziativa);
            this.Controls.Add(this.grupDanni);
            this.Controls.Add(this.grdPG);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblNomePG);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DM_Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePG)).EndInit();
            this.grupDanni.ResumeLayout(false);
            this.grupDanni.PerformLayout();
            this.groupIniziativa.ResumeLayout(false);
            this.groupIniziativa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdPG;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Data.DataSet dbPG;
        private System.Data.DataTable TablePG;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.GroupBox grupDanni;
        private System.Windows.Forms.Label lblNomePG;
        private System.Windows.Forms.Button btnSottrai;
        private System.Windows.Forms.TextBox txtmodVita;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.GroupBox groupIniziativa;
        private System.Windows.Forms.TextBox txtIniziativa;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuovoMenu;
        private System.Windows.Forms.ToolStripMenuItem aggiungiAccodaMenu;
        private System.Windows.Forms.Label label1;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniziativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn lifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA_Contatto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA_Sprovvista;
    }
}

