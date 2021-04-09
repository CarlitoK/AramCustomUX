namespace AramCustomUX {
    partial class BanList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanList));
            this.banListView = new System.Windows.Forms.ListView();
            this.AbanButton = new System.Windows.Forms.Button();
            this.BbanButton = new System.Windows.Forms.Button();
            this.globalBanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // banListView
            // 
            this.banListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banListView.BackgroundImageTiled = true;
            this.banListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.banListView.FullRowSelect = true;
            this.banListView.GridLines = true;
            this.banListView.HideSelection = false;
            this.banListView.Location = new System.Drawing.Point(12, 61);
            this.banListView.Name = "banListView";
            this.banListView.Size = new System.Drawing.Size(935, 609);
            this.banListView.TabIndex = 0;
            this.banListView.TileSize = new System.Drawing.Size(100, 30);
            this.banListView.UseCompatibleStateImageBehavior = false;
            this.banListView.View = System.Windows.Forms.View.Tile;
            this.banListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.banListView_ItemSelectionChanged);
            // 
            // AbanButton
            // 
            this.AbanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AbanButton.ForeColor = System.Drawing.Color.Red;
            this.AbanButton.Location = new System.Drawing.Point(12, 12);
            this.AbanButton.Name = "AbanButton";
            this.AbanButton.Size = new System.Drawing.Size(272, 43);
            this.AbanButton.TabIndex = 1;
            this.AbanButton.Text = "Team A Ban";
            this.AbanButton.UseVisualStyleBackColor = true;
            this.AbanButton.Click += new System.EventHandler(this.AbanButton_Click);
            // 
            // BbanButton
            // 
            this.BbanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BbanButton.ForeColor = System.Drawing.Color.Blue;
            this.BbanButton.Location = new System.Drawing.Point(675, 12);
            this.BbanButton.Name = "BbanButton";
            this.BbanButton.Size = new System.Drawing.Size(272, 43);
            this.BbanButton.TabIndex = 2;
            this.BbanButton.Text = "Team B Ban";
            this.BbanButton.UseVisualStyleBackColor = true;
            this.BbanButton.Click += new System.EventHandler(this.BbanButton_Click);
            // 
            // globalBanButton
            // 
            this.globalBanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.globalBanButton.ForeColor = System.Drawing.Color.Green;
            this.globalBanButton.Location = new System.Drawing.Point(338, 12);
            this.globalBanButton.Name = "globalBanButton";
            this.globalBanButton.Size = new System.Drawing.Size(272, 43);
            this.globalBanButton.TabIndex = 3;
            this.globalBanButton.Text = "Global Ban";
            this.globalBanButton.UseVisualStyleBackColor = true;
            this.globalBanButton.Click += new System.EventHandler(this.GlobalBanButton_Click);
            // 
            // BanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 682);
            this.Controls.Add(this.globalBanButton);
            this.Controls.Add(this.BbanButton);
            this.Controls.Add(this.AbanButton);
            this.Controls.Add(this.banListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BanList";
            this.Text = "Ban List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView banListView;
        private System.Windows.Forms.Button AbanButton;
        private System.Windows.Forms.Button BbanButton;
        private System.Windows.Forms.Button globalBanButton;
    }
}