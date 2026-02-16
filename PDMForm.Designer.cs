using System.Drawing;

namespace ChangePDMArchiveServer
{
    partial class PDMForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDMForm));
            this.lblTargetServer = new MaterialSkin.Controls.MaterialLabel();
            this.comboTargetServer = new MaterialSkin.Controls.MaterialComboBox();
            this.comboVault = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxResults = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblCurrentServerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentServerValue = new MaterialSkin.Controls.MaterialLabel();
            this.btn_restartPdm = new MaterialSkin.Controls.MaterialButton();
            this.checkBoxRestartOnUpdate = new System.Windows.Forms.CheckBox();
            this.lblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblTargetServer
            // 
            this.lblTargetServer.AutoSize = true;
            this.lblTargetServer.Depth = 0;
            this.lblTargetServer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTargetServer.Location = new System.Drawing.Point(6, 81);
            this.lblTargetServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTargetServer.Name = "lblTargetServer";
            this.lblTargetServer.Size = new System.Drawing.Size(95, 19);
            this.lblTargetServer.TabIndex = 1;
            this.lblTargetServer.Text = "Target Server";
            // 
            // comboTargetServer
            // 
            this.comboTargetServer.AutoResize = false;
            this.comboTargetServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboTargetServer.Depth = 0;
            this.comboTargetServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboTargetServer.DropDownHeight = 174;
            this.comboTargetServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTargetServer.DropDownWidth = 121;
            this.comboTargetServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboTargetServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboTargetServer.FormattingEnabled = true;
            this.comboTargetServer.IntegralHeight = false;
            this.comboTargetServer.ItemHeight = 43;
            this.comboTargetServer.Location = new System.Drawing.Point(6, 100);
            this.comboTargetServer.MaxDropDownItems = 4;
            this.comboTargetServer.MouseState = MaterialSkin.MouseState.OUT;
            this.comboTargetServer.Name = "comboTargetServer";
            this.comboTargetServer.Size = new System.Drawing.Size(322, 49);
            this.comboTargetServer.StartIndex = 0;
            this.comboTargetServer.TabIndex = 2;
            this.comboTargetServer.SelectedIndexChanged += new System.EventHandler(this.comboTargetServer_SelectedIndexChanged);
            // 
            // comboVault
            // 
            this.comboVault.AutoResize = false;
            this.comboVault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboVault.Depth = 0;
            this.comboVault.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboVault.DropDownHeight = 174;
            this.comboVault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVault.DropDownWidth = 121;
            this.comboVault.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboVault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboVault.FormattingEnabled = true;
            this.comboVault.IntegralHeight = false;
            this.comboVault.ItemHeight = 43;
            this.comboVault.Location = new System.Drawing.Point(6, 176);
            this.comboVault.MaxDropDownItems = 4;
            this.comboVault.MouseState = MaterialSkin.MouseState.OUT;
            this.comboVault.Name = "comboVault";
            this.comboVault.Size = new System.Drawing.Size(322, 49);
            this.comboVault.StartIndex = 0;
            this.comboVault.TabIndex = 4;
            this.comboVault.SelectedIndexChanged += new System.EventHandler(this.comboVault_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 157);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Vault";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(4, 281);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(199, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Update Archive Server";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtBoxResults
            // 
            this.txtBoxResults.AnimateReadOnly = false;
            this.txtBoxResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxResults.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxResults.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxResults.Depth = 0;
            this.txtBoxResults.HideSelection = true;
            this.txtBoxResults.Location = new System.Drawing.Point(4, 338);
            this.txtBoxResults.MaxLength = 32767;
            this.txtBoxResults.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxResults.Name = "txtBoxResults";
            this.txtBoxResults.PasswordChar = '\0';
            this.txtBoxResults.ReadOnly = false;
            this.txtBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxResults.SelectedText = "";
            this.txtBoxResults.SelectionLength = 0;
            this.txtBoxResults.SelectionStart = 0;
            this.txtBoxResults.ShortcutsEnabled = true;
            this.txtBoxResults.Size = new System.Drawing.Size(784, 87);
            this.txtBoxResults.TabIndex = 6;
            this.txtBoxResults.TabStop = false;
            this.txtBoxResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxResults.UseSystemPasswordChar = false;
            // 
            // lblCurrentServerLabel
            // 
            this.lblCurrentServerLabel.AutoSize = true;
            this.lblCurrentServerLabel.Depth = 0;
            this.lblCurrentServerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentServerLabel.Location = new System.Drawing.Point(390, 100);
            this.lblCurrentServerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentServerLabel.Name = "lblCurrentServerLabel";
            this.lblCurrentServerLabel.Size = new System.Drawing.Size(160, 19);
            this.lblCurrentServerLabel.TabIndex = 7;
            this.lblCurrentServerLabel.Text = "Current Archive Server:";
            // 
            // lblCurrentServerValue
            // 
            this.lblCurrentServerValue.AutoSize = true;
            this.lblCurrentServerValue.Depth = 0;
            this.lblCurrentServerValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentServerValue.Location = new System.Drawing.Point(560, 100);
            this.lblCurrentServerValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentServerValue.Name = "lblCurrentServerValue";
            this.lblCurrentServerValue.Size = new System.Drawing.Size(1, 0);
            this.lblCurrentServerValue.TabIndex = 8;
            // 
            // btn_restartPdm
            // 
            this.btn_restartPdm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_restartPdm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_restartPdm.Depth = 0;
            this.btn_restartPdm.HighEmphasis = true;
            this.btn_restartPdm.Icon = null;
            this.btn_restartPdm.Location = new System.Drawing.Point(235, 281);
            this.btn_restartPdm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_restartPdm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_restartPdm.Name = "btn_restartPdm";
            this.btn_restartPdm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_restartPdm.Size = new System.Drawing.Size(120, 36);
            this.btn_restartPdm.TabIndex = 9;
            this.btn_restartPdm.Text = "Restart PDM";
            this.btn_restartPdm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_restartPdm.UseAccentColor = false;
            this.btn_restartPdm.UseVisualStyleBackColor = true;
            this.btn_restartPdm.Click += new System.EventHandler(this.btn_restartPdm_Click);
            // 
            // checkBoxRestartOnUpdate
            // 
            this.checkBoxRestartOnUpdate.AutoSize = true;
            this.checkBoxRestartOnUpdate.Checked = true;
            this.checkBoxRestartOnUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRestartOnUpdate.Location = new System.Drawing.Point(9, 245);
            this.checkBoxRestartOnUpdate.Name = "checkBoxRestartOnUpdate";
            this.checkBoxRestartOnUpdate.Size = new System.Drawing.Size(142, 17);
            this.checkBoxRestartOnUpdate.TabIndex = 10;
            this.checkBoxRestartOnUpdate.Text = "Restart PDM On Update";
            this.checkBoxRestartOnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Depth = 0;
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.lblVersion.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblVersion.Location = new System.Drawing.Point(730, 432);
            this.lblVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(44, 13);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "v1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // PDMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 454);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.checkBoxRestartOnUpdate);
            this.Controls.Add(this.btn_restartPdm);
            this.Controls.Add(this.lblCurrentServerValue);
            this.Controls.Add(this.lblCurrentServerLabel);
            this.Controls.Add(this.txtBoxResults);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.comboVault);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.comboTargetServer);
            this.Controls.Add(this.lblTargetServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDMForm";
            this.Padding = new System.Windows.Forms.Padding(3, 55, 3, 3);
            this.Text = "Change PDM Archive Server";
            this.Load += new System.EventHandler(this.PDMForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblTargetServer;
        private MaterialSkin.Controls.MaterialComboBox comboTargetServer;
        private MaterialSkin.Controls.MaterialComboBox comboVault;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtBoxResults;
        private MaterialSkin.Controls.MaterialLabel lblCurrentServerLabel;
        private MaterialSkin.Controls.MaterialLabel lblCurrentServerValue;
        private MaterialSkin.Controls.MaterialButton btn_restartPdm;
        private CheckBox checkBoxRestartOnUpdate;
        private MaterialSkin.Controls.MaterialLabel lblVersion;
    }
}