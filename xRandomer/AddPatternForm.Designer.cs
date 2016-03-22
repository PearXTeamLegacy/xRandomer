namespace xRandomer
{
    partial class AddPatternForm
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
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxTemplate = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.btnOK = new PearXLib.Engine.Flat.FlatButton();
            this.SuspendLayout();
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(12, 67);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(320, 40);
            this.boxName.TabIndex = 0;
            // 
            // boxTemplate
            // 
            this.boxTemplate.Location = new System.Drawing.Point(12, 143);
            this.boxTemplate.Name = "boxTemplate";
            this.boxTemplate.Size = new System.Drawing.Size(320, 40);
            this.boxTemplate.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(137, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 32);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.ForeColor = System.Drawing.Color.White;
            this.lblTemplate.Location = new System.Drawing.Point(132, 110);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(76, 32);
            this.lblTemplate.TabIndex = 3;
            this.lblTemplate.Text = "Pattern";
            // 
            // btnOK
            // 
            this.btnOK.Border = 0;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(12, 189);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(320, 40);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Add Pattern";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddPatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 242);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTemplate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.boxTemplate);
            this.Controls.Add(this.boxName);
            this.Name = "AddPatternForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Pattern";
            this.ToTrayBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxTemplate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTemplate;
        private PearXLib.Engine.Flat.FlatButton btnOK;
    }
}