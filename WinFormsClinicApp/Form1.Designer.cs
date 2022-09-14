namespace WinFormsClinicApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.bdConnectButton = new MaterialSkin.Controls.MaterialButton();
            this.dbConnectionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.customerTabPage = new System.Windows.Forms.TabPage();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.animalTabPage = new System.Windows.Forms.TabPage();
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.customerFilterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.customerIdTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.customerSurnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.customerNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.customerPatronymicTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl.SuspendLayout();
            this.loginTabPage.SuspendLayout();
            this.customerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.animalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.loginTabPage);
            this.materialTabControl.Controls.Add(this.customerTabPage);
            this.materialTabControl.Controls.Add(this.animalTabPage);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl.ImageList = this.iconList;
            this.materialTabControl.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl.TabIndex = 0;
            this.materialTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.materialTabControl_Selecting);
            // 
            // loginTabPage
            // 
            this.loginTabPage.BackColor = System.Drawing.Color.White;
            this.loginTabPage.Controls.Add(this.bdConnectButton);
            this.loginTabPage.Controls.Add(this.dbConnectionLabel);
            this.loginTabPage.ImageKey = "icons8-вход-в-систему,-в-кружке,-стрелка-вправо-32.png";
            this.loginTabPage.Location = new System.Drawing.Point(4, 39);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(786, 340);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Вход";
            // 
            // bdConnectButton
            // 
            this.bdConnectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bdConnectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bdConnectButton.Depth = 0;
            this.bdConnectButton.HighEmphasis = true;
            this.bdConnectButton.Icon = null;
            this.bdConnectButton.Location = new System.Drawing.Point(7, 28);
            this.bdConnectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bdConnectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bdConnectButton.Name = "bdConnectButton";
            this.bdConnectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bdConnectButton.Size = new System.Drawing.Size(160, 36);
            this.bdConnectButton.TabIndex = 1;
            this.bdConnectButton.Text = "Выбрать файл БД";
            this.bdConnectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bdConnectButton.UseAccentColor = false;
            this.bdConnectButton.UseVisualStyleBackColor = true;
            this.bdConnectButton.Click += new System.EventHandler(this.bdConnectButton_Click);
            // 
            // dbConnectionLabel
            // 
            this.dbConnectionLabel.AutoSize = true;
            this.dbConnectionLabel.BackColor = System.Drawing.Color.White;
            this.dbConnectionLabel.Depth = 0;
            this.dbConnectionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dbConnectionLabel.Location = new System.Drawing.Point(6, 3);
            this.dbConnectionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dbConnectionLabel.Name = "dbConnectionLabel";
            this.dbConnectionLabel.Size = new System.Drawing.Size(152, 19);
            this.dbConnectionLabel.TabIndex = 0;
            this.dbConnectionLabel.Text = "Подключение к БД: ";
            // 
            // customerTabPage
            // 
            this.customerTabPage.BackColor = System.Drawing.Color.White;
            this.customerTabPage.Controls.Add(this.customerPatronymicTextBox);
            this.customerTabPage.Controls.Add(this.customerNameTextBox);
            this.customerTabPage.Controls.Add(this.customerSurnameTextBox);
            this.customerTabPage.Controls.Add(this.customerIdTextBox);
            this.customerTabPage.Controls.Add(this.customerFilterLabel);
            this.customerTabPage.Controls.Add(this.customerDataGridView);
            this.customerTabPage.ImageKey = "icons8-пользователь-без-половых-признаков-32.png";
            this.customerTabPage.Location = new System.Drawing.Point(4, 39);
            this.customerTabPage.Name = "customerTabPage";
            this.customerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerTabPage.Size = new System.Drawing.Size(786, 340);
            this.customerTabPage.TabIndex = 1;
            this.customerTabPage.Text = "Клиент";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(221, 3);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowTemplate.Height = 25;
            this.customerDataGridView.Size = new System.Drawing.Size(565, 337);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellDoubleClick);
            // 
            // animalTabPage
            // 
            this.animalTabPage.BackColor = System.Drawing.Color.White;
            this.animalTabPage.Controls.Add(this.animalsDataGridView);
            this.animalTabPage.ImageKey = "icons8-пудель-32.png";
            this.animalTabPage.Location = new System.Drawing.Point(4, 39);
            this.animalTabPage.Name = "animalTabPage";
            this.animalTabPage.Size = new System.Drawing.Size(786, 340);
            this.animalTabPage.TabIndex = 2;
            this.animalTabPage.Text = "Животные";
            // 
            // animalsDataGridView
            // 
            this.animalsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.animalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsDataGridView.Location = new System.Drawing.Point(0, 3);
            this.animalsDataGridView.Name = "animalsDataGridView";
            this.animalsDataGridView.RowTemplate.Height = 25;
            this.animalsDataGridView.Size = new System.Drawing.Size(786, 337);
            this.animalsDataGridView.TabIndex = 0;
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "icons8-вход-в-систему,-в-кружке,-стрелка-вправо-32.png");
            this.iconList.Images.SetKeyName(1, "icons8-пользователь-без-половых-признаков-32.png");
            this.iconList.Images.SetKeyName(2, "icons8-пудель-32.png");
            // 
            // customerFilterLabel
            // 
            this.customerFilterLabel.AutoSize = true;
            this.customerFilterLabel.Depth = 0;
            this.customerFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerFilterLabel.Location = new System.Drawing.Point(6, 3);
            this.customerFilterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerFilterLabel.Name = "customerFilterLabel";
            this.customerFilterLabel.Size = new System.Drawing.Size(97, 19);
            this.customerFilterLabel.TabIndex = 1;
            this.customerFilterLabel.Text = "Фильтрация:";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.AnimateReadOnly = false;
            this.customerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerIdTextBox.Depth = 0;
            this.customerIdTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerIdTextBox.Hint = "Id";
            this.customerIdTextBox.LeadingIcon = null;
            this.customerIdTextBox.Location = new System.Drawing.Point(6, 25);
            this.customerIdTextBox.MaxLength = 50;
            this.customerIdTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.customerIdTextBox.Multiline = false;
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(209, 50);
            this.customerIdTextBox.TabIndex = 2;
            this.customerIdTextBox.Text = "";
            this.customerIdTextBox.TrailingIcon = null;
            this.customerIdTextBox.TextChanged += new System.EventHandler(this.customerIdTextBox_TextChanged);
            // 
            // customerSurnameTextBox
            // 
            this.customerSurnameTextBox.AnimateReadOnly = false;
            this.customerSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerSurnameTextBox.Depth = 0;
            this.customerSurnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerSurnameTextBox.Hint = "Фамилия";
            this.customerSurnameTextBox.LeadingIcon = null;
            this.customerSurnameTextBox.Location = new System.Drawing.Point(6, 81);
            this.customerSurnameTextBox.MaxLength = 50;
            this.customerSurnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.customerSurnameTextBox.Multiline = false;
            this.customerSurnameTextBox.Name = "customerSurnameTextBox";
            this.customerSurnameTextBox.Size = new System.Drawing.Size(209, 50);
            this.customerSurnameTextBox.TabIndex = 3;
            this.customerSurnameTextBox.Text = "";
            this.customerSurnameTextBox.TrailingIcon = null;
            this.customerSurnameTextBox.TextChanged += new System.EventHandler(this.customerSurnameTextBox_TextChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.AnimateReadOnly = false;
            this.customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerNameTextBox.Depth = 0;
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerNameTextBox.Hint = "Имя";
            this.customerNameTextBox.LeadingIcon = null;
            this.customerNameTextBox.Location = new System.Drawing.Point(6, 137);
            this.customerNameTextBox.MaxLength = 50;
            this.customerNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.customerNameTextBox.Multiline = false;
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(209, 50);
            this.customerNameTextBox.TabIndex = 4;
            this.customerNameTextBox.Text = "";
            this.customerNameTextBox.TrailingIcon = null;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // customerPatronymicTextBox
            // 
            this.customerPatronymicTextBox.AnimateReadOnly = false;
            this.customerPatronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerPatronymicTextBox.Depth = 0;
            this.customerPatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerPatronymicTextBox.Hint = "Отчество";
            this.customerPatronymicTextBox.LeadingIcon = null;
            this.customerPatronymicTextBox.Location = new System.Drawing.Point(6, 193);
            this.customerPatronymicTextBox.MaxLength = 50;
            this.customerPatronymicTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.customerPatronymicTextBox.Multiline = false;
            this.customerPatronymicTextBox.Name = "customerPatronymicTextBox";
            this.customerPatronymicTextBox.Size = new System.Drawing.Size(209, 50);
            this.customerPatronymicTextBox.TabIndex = 5;
            this.customerPatronymicTextBox.Text = "";
            this.customerPatronymicTextBox.TrailingIcon = null;
            this.customerPatronymicTextBox.TextChanged += new System.EventHandler(this.customerPatronymicTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вет. клиника";
            this.materialTabControl.ResumeLayout(false);
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            this.customerTabPage.ResumeLayout(false);
            this.customerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.animalTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private TabPage loginTabPage;
        private TabPage customerTabPage;
        private TabPage animalTabPage;
        private ImageList iconList;
        private MaterialSkin.Controls.MaterialLabel dbConnectionLabel;
        private MaterialSkin.Controls.MaterialButton bdConnectButton;
        private DataGridView customerDataGridView;
        private DataGridView animalsDataGridView;
        private MaterialSkin.Controls.MaterialTextBox customerPatronymicTextBox;
        private MaterialSkin.Controls.MaterialTextBox customerNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox customerSurnameTextBox;
        private MaterialSkin.Controls.MaterialTextBox customerIdTextBox;
        private MaterialSkin.Controls.MaterialLabel customerFilterLabel;
    }
}