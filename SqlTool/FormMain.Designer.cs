namespace SqlTool
{
    partial class FormSqlTool
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtbType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtbGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtbEff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtbSubMain = new System.Windows.Forms.TextBox();
            this.LabelBackup = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtbMain = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LabelPrice = new System.Windows.Forms.Label();
            this.TxtbPrice = new System.Windows.Forms.TextBox();
            this.LabelIsEnabled = new System.Windows.Forms.Label();
            this.TxtbIsEnabled = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtbId
            // 
            this.TxtbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbId.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbId.Location = new System.Drawing.Point(64, 12);
            this.TxtbId.MaxLength = 7;
            this.TxtbId.Name = "TxtbId";
            this.TxtbId.Size = new System.Drawing.Size(160, 22);
            this.TxtbId.TabIndex = 0;
            this.TxtbId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.Location = new System.Drawing.Point(233, 14);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(112, 33);
            this.BtnInsert.TabIndex = 2;
            this.BtnInsert.Text = "INSERTAR";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // TxtbType
            // 
            this.TxtbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbType.Location = new System.Drawing.Point(64, 38);
            this.TxtbType.MaxLength = 10;
            this.TxtbType.Name = "TxtbType";
            this.TxtbType.Size = new System.Drawing.Size(160, 22);
            this.TxtbType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sex:";
            // 
            // TxtbGender
            // 
            this.TxtbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbGender.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbGender.Location = new System.Drawing.Point(64, 144);
            this.TxtbGender.MaxLength = 1;
            this.TxtbGender.Name = "TxtbGender";
            this.TxtbGender.Size = new System.Drawing.Size(160, 22);
            this.TxtbGender.TabIndex = 5;
            this.TxtbGender.Text = "0";
            this.TxtbGender.TextChanged += new System.EventHandler(this.TxtbGender_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eff:";
            // 
            // TxtbEff
            // 
            this.TxtbEff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbEff.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbEff.Location = new System.Drawing.Point(64, 170);
            this.TxtbEff.MaxLength = 3;
            this.TxtbEff.Name = "TxtbEff";
            this.TxtbEff.Size = new System.Drawing.Size(160, 22);
            this.TxtbEff.TabIndex = 7;
            this.TxtbEff.Text = "14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "SMain:";
            // 
            // TxtbSubMain
            // 
            this.TxtbSubMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbSubMain.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbSubMain.Location = new System.Drawing.Point(64, 118);
            this.TxtbSubMain.MaxLength = 1;
            this.TxtbSubMain.Name = "TxtbSubMain";
            this.TxtbSubMain.Size = new System.Drawing.Size(160, 22);
            this.TxtbSubMain.TabIndex = 9;
            this.TxtbSubMain.Text = "1";
            this.TxtbSubMain.TextChanged += new System.EventHandler(this.TxtbSubMain_TextChanged);
            // 
            // LabelBackup
            // 
            this.LabelBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBackup.AutoSize = true;
            this.LabelBackup.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBackup.Location = new System.Drawing.Point(230, 129);
            this.LabelBackup.Name = "LabelBackup";
            this.LabelBackup.Size = new System.Drawing.Size(105, 14);
            this.LabelBackup.TabIndex = 11;
            this.LabelBackup.Text = "Ultimo backup:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Main:";
            // 
            // TxtbMain
            // 
            this.TxtbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbMain.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbMain.Location = new System.Drawing.Point(64, 90);
            this.TxtbMain.MaxLength = 1;
            this.TxtbMain.Name = "TxtbMain";
            this.TxtbMain.Size = new System.Drawing.Size(160, 22);
            this.TxtbMain.TabIndex = 12;
            this.TxtbMain.Text = "1";
            this.TxtbMain.TextChanged += new System.EventHandler(this.TxtbMain_TextChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(232, 53);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(112, 33);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "ACTUALIZAR";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(233, 92);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 33);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "ELIMINAR";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // SToolTip
            // 
            this.SToolTip.IsBalloon = true;
            this.SToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SToolTip.ToolTipTitle = "Details:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(12, 67);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(49, 14);
            this.LabelPrice.TabIndex = 17;
            this.LabelPrice.Text = "Price:";
            // 
            // TxtbPrice
            // 
            this.TxtbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbPrice.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbPrice.Location = new System.Drawing.Point(64, 64);
            this.TxtbPrice.MaxLength = 3;
            this.TxtbPrice.Name = "TxtbPrice";
            this.TxtbPrice.Size = new System.Drawing.Size(160, 22);
            this.TxtbPrice.TabIndex = 16;
            this.TxtbPrice.Text = "4";
            // 
            // LabelIsEnabled
            // 
            this.LabelIsEnabled.AutoSize = true;
            this.LabelIsEnabled.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIsEnabled.Location = new System.Drawing.Point(12, 199);
            this.LabelIsEnabled.Name = "LabelIsEnabled";
            this.LabelIsEnabled.Size = new System.Drawing.Size(42, 14);
            this.LabelIsEnabled.TabIndex = 19;
            this.LabelIsEnabled.Text = "IsOn:";
            // 
            // TxtbIsEnabled
            // 
            this.TxtbIsEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbIsEnabled.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbIsEnabled.Location = new System.Drawing.Point(64, 196);
            this.TxtbIsEnabled.MaxLength = 1;
            this.TxtbIsEnabled.Name = "TxtbIsEnabled";
            this.TxtbIsEnabled.Size = new System.Drawing.Size(160, 22);
            this.TxtbIsEnabled.TabIndex = 18;
            this.TxtbIsEnabled.Text = "1";
            // 
            // FormSqlTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 224);
            this.Controls.Add(this.LabelIsEnabled);
            this.Controls.Add(this.TxtbIsEnabled);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.TxtbPrice);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtbMain);
            this.Controls.Add(this.LabelBackup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtbSubMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtbEff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtbGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtbType);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtbId);
            this.MaximumSize = new System.Drawing.Size(373, 262);
            this.MinimumSize = new System.Drawing.Size(373, 262);
            this.Name = "FormSqlTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TxtbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtbEff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtbSubMain;
        private System.Windows.Forms.Label LabelBackup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtbMain;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ToolTip SToolTip;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox TxtbPrice;
        private System.Windows.Forms.Label LabelIsEnabled;
        private System.Windows.Forms.TextBox TxtbIsEnabled;
    }
}

