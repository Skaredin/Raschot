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
            this.txtResporens.Location = new System.Drawing.Point(11, 98);
            this.txtResporens.Name = "txtResporens";
            this.txtResporens.Size = new System.Drawing.Size(776, 340);
            this.txtResporens.TabIndex = 0;
            this.txtResporens.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(677, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 51);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удаление";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPt
            // 
            this.btnPt.Location = new System.Drawing.Point(596, 31);
            this.btnPt.Name = "btnPt";
            this.btnPt.Size = new System.Drawing.Size(75, 50);
            this.btnPt.TabIndex = 2;
            this.btnPt.Text = "Пут";
            this.btnPt.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(515, 31);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 50);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Пост";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(153, 31);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 52);
            this.btnGetAll.TabIndex = 4;
            this.btnGetAll.Text = "Гет Алл";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(234, 60);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 23);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "Гет";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(234, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(409, 59);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(100, 22);
            this.txtJob.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(409, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Код страницы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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