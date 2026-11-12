namespace ClassExample
{
    partial class SearchView
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
            GrdSearchInformation = new DataGridView();
            TxtName = new Label();
            TxtFilter = new TextBox();
            BtnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdSearchInformation).BeginInit();
            SuspendLayout();
            // 
            // GrdSearchInformation
            // 
            GrdSearchInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdSearchInformation.Location = new Point(47, 128);
            GrdSearchInformation.Name = "GrdSearchInformation";
            GrdSearchInformation.RowHeadersWidth = 51;
            GrdSearchInformation.Size = new Size(859, 421);
            GrdSearchInformation.TabIndex = 0;
            // 
            // TxtName
            // 
            TxtName.AutoSize = true;
            TxtName.Location = new Point(47, 61);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(49, 20);
            TxtName.TabIndex = 1;
            TxtName.Text = "Name";
            // 
            // TxtFilter
            // 
            TxtFilter.Location = new Point(115, 58);
            TxtFilter.Name = "TxtFilter";
            TxtFilter.Size = new Size(192, 27);
            TxtFilter.TabIndex = 2;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(799, 51);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(107, 40);
            BtnSearch.TabIndex = 3;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // SearchView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 611);
            Controls.Add(BtnSearch);
            Controls.Add(TxtFilter);
            Controls.Add(TxtName);
            Controls.Add(GrdSearchInformation);
            Name = "SearchView";
            Text = "SearchView";
            ((System.ComponentModel.ISupportInitialize)GrdSearchInformation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdSearchInformation;
        private Label TxtName;
        private TextBox TxtFilter;
        private Button BtnSearch;
    }
}