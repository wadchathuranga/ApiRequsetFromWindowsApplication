namespace ApiRequsetFromWindowsApplication
{
    partial class HttpCRUDForm
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
            this.btnGetAll = new System.Windows.Forms.Button();
            this.txtById = new System.Windows.Forms.TextBox();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(60, 25);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(107, 57);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // txtById
            // 
            this.txtById.Location = new System.Drawing.Point(189, 25);
            this.txtById.Name = "txtById";
            this.txtById.Size = new System.Drawing.Size(100, 22);
            this.txtById.TabIndex = 1;
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(189, 53);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(100, 29);
            this.btnGetById.TabIndex = 2;
            this.btnGetById.Text = "Get by Id";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(454, 25);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(93, 57);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(325, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(325, 53);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(123, 22);
            this.txtJob.TabIndex = 5;
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(553, 25);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(93, 57);
            this.btnPut.TabIndex = 6;
            this.btnPut.Text = "PUT";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(652, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 57);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(60, 107);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(685, 319);
            this.txtResponse.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.txtById);
            this.Controls.Add(this.btnGetAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.TextBox txtById;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtResponse;
    }
}

