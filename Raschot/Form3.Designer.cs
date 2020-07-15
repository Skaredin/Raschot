namespace Raschot
{
    partial class Form3
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
            this.txtResporens = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPt = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResporens
            // 
            this.txtResporens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResporens.Location = new System.Drawing.Point(8, 80);
            this.txtResporens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResporens.Name = "txtResporens";
            this.txtResporens.Size = new System.Drawing.Size(583, 277);
            this.txtResporens.TabIndex = 0;
            this.txtResporens.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(508, 24);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удаление";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPt
            // 
            this.btnPt.Location = new System.Drawing.Point(447, 25);
            this.btnPt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPt.Name = "btnPt";
            this.btnPt.Size = new System.Drawing.Size(56, 41);
            this.btnPt.TabIndex = 2;
            this.btnPt.Text = "Пут";
            this.btnPt.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(386, 25);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(56, 41);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Пост";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(115, 25);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(56, 42);
            this.btnGetAll.TabIndex = 4;
            this.btnGetAll.Text = "Гет Алл";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(176, 49);
            this.btnGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 19);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "Гет";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 25);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(307, 48);
            this.txtJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(76, 20);
            this.txtJob.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(307, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Код страницы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnPt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtResporens);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResporens;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPt;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
    }
}