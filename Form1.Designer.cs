namespace Grapple
{
    partial class Grapple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grapple));
            this.findVideoButton = new System.Windows.Forms.Button();
            this.nowPlayingTextBox = new System.Windows.Forms.TextBox();
            this.viewHistory = new System.Windows.Forms.Button();
            this.browserHistoryBox = new System.Windows.Forms.TextBox();
            this.addToLibrary = new System.Windows.Forms.Button();
            this.currentStateBanner = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.hideHistoryButton = new System.Windows.Forms.Button();
            this.newFileBtn = new System.Windows.Forms.Button();
            this.userMessage = new System.Windows.Forms.RichTextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.curPathBanner = new System.Windows.Forms.RichTextBox();
            this.clearPathBtn = new System.Windows.Forms.Button();
            this.clearHistoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findVideoButton
            // 
            this.findVideoButton.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.findVideoButton, "findVideoButton");
            this.findVideoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.findVideoButton.Name = "findVideoButton";
            this.findVideoButton.UseVisualStyleBackColor = false;
            this.findVideoButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nowPlayingTextBox
            // 
            this.nowPlayingTextBox.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.nowPlayingTextBox, "nowPlayingTextBox");
            this.nowPlayingTextBox.ForeColor = System.Drawing.Color.White;
            this.nowPlayingTextBox.Name = "nowPlayingTextBox";
            this.nowPlayingTextBox.TextChanged += new System.EventHandler(this.NowPlayingTextBox_TextChanged);
            // 
            // viewHistory
            // 
            this.viewHistory.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.viewHistory, "viewHistory");
            this.viewHistory.Name = "viewHistory";
            this.viewHistory.UseVisualStyleBackColor = false;
            this.viewHistory.Click += new System.EventHandler(this.ViewHistory_Click);
            // 
            // browserHistoryBox
            // 
            this.browserHistoryBox.AcceptsReturn = true;
            this.browserHistoryBox.AcceptsTab = true;
            this.browserHistoryBox.AllowDrop = true;
            this.browserHistoryBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.browserHistoryBox, "browserHistoryBox");
            this.browserHistoryBox.Name = "browserHistoryBox";
            this.browserHistoryBox.ReadOnly = true;
            this.browserHistoryBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // addToLibrary
            // 
            this.addToLibrary.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.addToLibrary, "addToLibrary");
            this.addToLibrary.ForeColor = System.Drawing.Color.White;
            this.addToLibrary.Name = "addToLibrary";
            this.addToLibrary.UseVisualStyleBackColor = false;
            this.addToLibrary.Click += new System.EventHandler(this.AddToLibrary_Click);
            // 
            // currentStateBanner
            // 
            this.currentStateBanner.BackColor = System.Drawing.Color.BlueViolet;
            resources.ApplyResources(this.currentStateBanner, "currentStateBanner");
            this.currentStateBanner.ForeColor = System.Drawing.Color.White;
            this.currentStateBanner.Name = "currentStateBanner";
            this.currentStateBanner.TextChanged += new System.EventHandler(this.NowPlayingBanner_TextChanged);
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // hideHistoryButton
            // 
            this.hideHistoryButton.AutoEllipsis = true;
            resources.ApplyResources(this.hideHistoryButton, "hideHistoryButton");
            this.hideHistoryButton.ForeColor = System.Drawing.Color.Black;
            this.hideHistoryButton.Name = "hideHistoryButton";
            this.hideHistoryButton.UseVisualStyleBackColor = true;
            this.hideHistoryButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // newFileBtn
            // 
            resources.ApplyResources(this.newFileBtn, "newFileBtn");
            this.newFileBtn.ForeColor = System.Drawing.Color.Black;
            this.newFileBtn.Name = "newFileBtn";
            this.newFileBtn.UseVisualStyleBackColor = true;
            this.newFileBtn.Click += new System.EventHandler(this.NewFileBtn_Click);
            // 
            // userMessage
            // 
            this.userMessage.BackColor = System.Drawing.Color.GreenYellow;
            resources.ApplyResources(this.userMessage, "userMessage");
            this.userMessage.Name = "userMessage";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.LightYellow;
            resources.ApplyResources(this.helpButton, "helpButton");
            this.helpButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpButton.Name = "helpButton";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.filePathTextBox, "filePathTextBox");
            this.filePathTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.TextChanged += new System.EventHandler(this.FilePathTextBox_TextChanged);
            // 
            // curPathBanner
            // 
            this.curPathBanner.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.curPathBanner, "curPathBanner");
            this.curPathBanner.Name = "curPathBanner";
            // 
            // clearPathBtn
            // 
            resources.ApplyResources(this.clearPathBtn, "clearPathBtn");
            this.clearPathBtn.ForeColor = System.Drawing.Color.Black;
            this.clearPathBtn.Name = "clearPathBtn";
            this.clearPathBtn.UseVisualStyleBackColor = true;
            this.clearPathBtn.Click += new System.EventHandler(this.ClearPathBtn_Click);
            // 
            // clearHistoryBtn
            // 
            resources.ApplyResources(this.clearHistoryBtn, "clearHistoryBtn");
            this.clearHistoryBtn.ForeColor = System.Drawing.Color.Black;
            this.clearHistoryBtn.Name = "clearHistoryBtn";
            this.clearHistoryBtn.UseVisualStyleBackColor = true;
            this.clearHistoryBtn.Click += new System.EventHandler(this.ClearHistoryBtn_Click);
            // 
            // Grapple
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.clearHistoryBtn);
            this.Controls.Add(this.clearPathBtn);
            this.Controls.Add(this.curPathBanner);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.userMessage);
            this.Controls.Add(this.newFileBtn);
            this.Controls.Add(this.hideHistoryButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.currentStateBanner);
            this.Controls.Add(this.addToLibrary);
            this.Controls.Add(this.browserHistoryBox);
            this.Controls.Add(this.viewHistory);
            this.Controls.Add(this.nowPlayingTextBox);
            this.Controls.Add(this.findVideoButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Grapple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findVideoButton;
        private System.Windows.Forms.TextBox nowPlayingTextBox;
        private System.Windows.Forms.Button viewHistory;
        private System.Windows.Forms.TextBox browserHistoryBox;
        private System.Windows.Forms.Button addToLibrary;
        private System.Windows.Forms.RichTextBox currentStateBanner;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button hideHistoryButton;
        private System.Windows.Forms.Button newFileBtn;
        private System.Windows.Forms.RichTextBox userMessage;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.RichTextBox curPathBanner;
        private System.Windows.Forms.Button clearPathBtn;
        private System.Windows.Forms.Button clearHistoryBtn;
    }
}

