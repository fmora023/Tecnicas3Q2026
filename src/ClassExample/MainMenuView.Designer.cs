namespace ClassExample
{
    partial class MainMenuView
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
            BtnSearch = new Button();
            BtnReports = new Button();
            BtnCreateContact = new Button();
            BtnUpdateContact = new Button();
            LblWelcome = new Label();
            LblInfo = new Label();
            SuspendLayout();
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(60, 70);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(132, 68);
            BtnSearch.TabIndex = 0;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnReports
            // 
            BtnReports.Location = new Point(60, 156);
            BtnReports.Name = "BtnReports";
            BtnReports.Size = new Size(132, 68);
            BtnReports.TabIndex = 1;
            BtnReports.Text = "Reports";
            BtnReports.UseVisualStyleBackColor = true;
            // 
            // BtnCreateContact
            // 
            BtnCreateContact.Location = new Point(60, 244);
            BtnCreateContact.Name = "BtnCreateContact";
            BtnCreateContact.Size = new Size(132, 68);
            BtnCreateContact.TabIndex = 2;
            BtnCreateContact.Text = "Create Contact";
            BtnCreateContact.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateContact
            // 
            BtnUpdateContact.Location = new Point(60, 335);
            BtnUpdateContact.Name = "BtnUpdateContact";
            BtnUpdateContact.Size = new Size(132, 68);
            BtnUpdateContact.TabIndex = 3;
            BtnUpdateContact.Text = "Update Contact";
            BtnUpdateContact.UseVisualStyleBackColor = true;
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Location = new Point(531, 39);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(50, 20);
            LblWelcome.TabIndex = 4;
            LblWelcome.Text = "label1";
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Location = new Point(531, 70);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(50, 20);
            LblInfo.TabIndex = 5;
            LblInfo.Text = "label2";
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblInfo);
            Controls.Add(LblWelcome);
            Controls.Add(BtnUpdateContact);
            Controls.Add(BtnCreateContact);
            Controls.Add(BtnReports);
            Controls.Add(BtnSearch);
            Name = "MainMenuView";
            Text = "MainMenuView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSearch;
        private Button BtnReports;
        private Button BtnCreateContact;
        private Button BtnUpdateContact;
        private Label LblWelcome;
        private Label LblInfo;
    }
}