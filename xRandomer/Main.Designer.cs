namespace xRandomer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.boxGenerated = new System.Windows.Forms.TextBox();
            this.boxTemplate = new System.Windows.Forms.TextBox();
            this.btnGenerate = new PearXLib.Engine.Flat.FlatButton();
            this.btnCopy = new PearXLib.Engine.Flat.FlatButton();
            this.btnHelp = new PearXLib.Engine.Flat.FlatButton();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnTemplates = new PearXLib.Engine.Flat.FlatButton();
            this.listPatterns = new System.Windows.Forms.ListBox();
            this.btnDelPattern = new PearXLib.Engine.Flat.FlatButton();
            this.btnAddPattern = new PearXLib.Engine.Flat.FlatButton();
            this.panelPatterns = new System.Windows.Forms.Panel();
            this.panelAutogen = new System.Windows.Forms.Panel();
            this.lblWorking = new System.Windows.Forms.Label();
            this.btnStopAutogen = new PearXLib.Engine.Flat.FlatButton();
            this.btnStartAutogen = new PearXLib.Engine.Flat.FlatButton();
            this.boxAutogenCount = new System.Windows.Forms.TextBox();
            this.btnAutogen = new PearXLib.Engine.Flat.FlatButton();
            this.bwAutogen = new System.ComponentModel.BackgroundWorker();
            this.panelPatterns.SuspendLayout();
            this.panelAutogen.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxGenerated
            // 
            this.boxGenerated.Location = new System.Drawing.Point(12, 43);
            this.boxGenerated.Name = "boxGenerated";
            this.boxGenerated.Size = new System.Drawing.Size(470, 40);
            this.boxGenerated.TabIndex = 0;
            this.boxGenerated.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxGenerated_KeyDown);
            // 
            // boxTemplate
            // 
            this.boxTemplate.Font = new System.Drawing.Font("Yanone Kaffeesatz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxTemplate.Location = new System.Drawing.Point(11, 89);
            this.boxTemplate.Name = "boxTemplate";
            this.boxTemplate.Size = new System.Drawing.Size(470, 30);
            this.boxTemplate.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Border = 0;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Yanone Kaffeesatz", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.Location = new System.Drawing.Point(12, 125);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(470, 45);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Border = 0;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.Location = new System.Drawing.Point(488, 44);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(76, 40);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Border = 0;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.Location = new System.Drawing.Point(541, 90);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 29);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "?";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Yanone Kaffeesatz", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(570, 43);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(250, 114);
            this.lblHelp.TabIndex = 5;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            this.lblHelp.Visible = false;
            // 
            // btnTemplates
            // 
            this.btnTemplates.Border = 0;
            this.btnTemplates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemplates.Font = new System.Drawing.Font("Yanone Kaffeesatz", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTemplates.ForeColor = System.Drawing.Color.White;
            this.btnTemplates.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemplates.Location = new System.Drawing.Point(488, 89);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(47, 29);
            this.btnTemplates.TabIndex = 6;
            this.btnTemplates.Text = "Patterns";
            this.btnTemplates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTemplates.Click += new System.EventHandler(this.btnTemplates_Click);
            // 
            // listPatterns
            // 
            this.listPatterns.Font = new System.Drawing.Font("Yanone Kaffeesatz", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPatterns.FormattingEnabled = true;
            this.listPatterns.ItemHeight = 24;
            this.listPatterns.Location = new System.Drawing.Point(0, 0);
            this.listPatterns.Name = "listPatterns";
            this.listPatterns.Size = new System.Drawing.Size(248, 124);
            this.listPatterns.TabIndex = 7;
            this.listPatterns.SelectedIndexChanged += new System.EventHandler(this.listPatterns_SelectedIndexChanged);
            // 
            // btnDelPattern
            // 
            this.btnDelPattern.Border = 0;
            this.btnDelPattern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelPattern.ForeColor = System.Drawing.Color.White;
            this.btnDelPattern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelPattern.Location = new System.Drawing.Point(251, 99);
            this.btnDelPattern.Name = "btnDelPattern";
            this.btnDelPattern.Size = new System.Drawing.Size(22, 25);
            this.btnDelPattern.TabIndex = 8;
            this.btnDelPattern.Text = "X";
            this.btnDelPattern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelPattern.Click += new System.EventHandler(this.btnDelPattern_Click);
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Border = 0;
            this.btnAddPattern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPattern.ForeColor = System.Drawing.Color.White;
            this.btnAddPattern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPattern.Location = new System.Drawing.Point(251, 3);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(22, 25);
            this.btnAddPattern.TabIndex = 9;
            this.btnAddPattern.Text = "+";
            this.btnAddPattern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // panelPatterns
            // 
            this.panelPatterns.Controls.Add(this.btnDelPattern);
            this.panelPatterns.Controls.Add(this.btnAddPattern);
            this.panelPatterns.Controls.Add(this.listPatterns);
            this.panelPatterns.Location = new System.Drawing.Point(574, 44);
            this.panelPatterns.Name = "panelPatterns";
            this.panelPatterns.Size = new System.Drawing.Size(276, 128);
            this.panelPatterns.TabIndex = 10;
            // 
            // panelAutogen
            // 
            this.panelAutogen.Controls.Add(this.lblWorking);
            this.panelAutogen.Controls.Add(this.btnStopAutogen);
            this.panelAutogen.Controls.Add(this.btnStartAutogen);
            this.panelAutogen.Controls.Add(this.boxAutogenCount);
            this.panelAutogen.Location = new System.Drawing.Point(574, 44);
            this.panelAutogen.Name = "panelAutogen";
            this.panelAutogen.Size = new System.Drawing.Size(276, 128);
            this.panelAutogen.TabIndex = 11;
            this.panelAutogen.Visible = false;
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.ForeColor = System.Drawing.Color.White;
            this.lblWorking.Location = new System.Drawing.Point(3, 82);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(100, 32);
            this.lblWorking.TabIndex = 14;
            this.lblWorking.Text = "Working...";
            this.lblWorking.Visible = false;
            // 
            // btnStopAutogen
            // 
            this.btnStopAutogen.Border = 0;
            this.btnStopAutogen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopAutogen.ForeColor = System.Drawing.Color.White;
            this.btnStopAutogen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStopAutogen.Location = new System.Drawing.Point(144, 39);
            this.btnStopAutogen.Name = "btnStopAutogen";
            this.btnStopAutogen.Size = new System.Drawing.Size(129, 40);
            this.btnStopAutogen.TabIndex = 13;
            this.btnStopAutogen.Text = "Stop";
            this.btnStopAutogen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStopAutogen.Click += new System.EventHandler(this.btnStopAutogen_Click);
            // 
            // btnStartAutogen
            // 
            this.btnStartAutogen.Border = 0;
            this.btnStartAutogen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartAutogen.ForeColor = System.Drawing.Color.White;
            this.btnStartAutogen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartAutogen.Location = new System.Drawing.Point(3, 39);
            this.btnStartAutogen.Name = "btnStartAutogen";
            this.btnStartAutogen.Size = new System.Drawing.Size(135, 40);
            this.btnStartAutogen.TabIndex = 12;
            this.btnStartAutogen.Text = "Start";
            this.btnStartAutogen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartAutogen.Click += new System.EventHandler(this.btnStartAutogen_Click);
            // 
            // boxAutogenCount
            // 
            this.boxAutogenCount.Font = new System.Drawing.Font("Yanone Kaffeesatz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxAutogenCount.Location = new System.Drawing.Point(3, 3);
            this.boxAutogenCount.MaxLength = 19;
            this.boxAutogenCount.Name = "boxAutogenCount";
            this.boxAutogenCount.Size = new System.Drawing.Size(270, 30);
            this.boxAutogenCount.TabIndex = 12;
            this.boxAutogenCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxAutogenCount_KeyPress);
            // 
            // btnAutogen
            // 
            this.btnAutogen.Border = 0;
            this.btnAutogen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutogen.Font = new System.Drawing.Font("Yanone Kaffeesatz", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAutogen.ForeColor = System.Drawing.Color.White;
            this.btnAutogen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutogen.Location = new System.Drawing.Point(488, 125);
            this.btnAutogen.Name = "btnAutogen";
            this.btnAutogen.Size = new System.Drawing.Size(76, 45);
            this.btnAutogen.TabIndex = 11;
            this.btnAutogen.Text = "AutoGen";
            this.btnAutogen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutogen.Click += new System.EventHandler(this.btnAutogen_Click);
            // 
            // bwAutogen
            // 
            this.bwAutogen.WorkerSupportsCancellation = true;
            this.bwAutogen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAutogen_DoWork);
            this.bwAutogen.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAutogen_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 184);
            this.Controls.Add(this.btnAutogen);
            this.Controls.Add(this.panelAutogen);
            this.Controls.Add(this.panelPatterns);
            this.Controls.Add(this.btnTemplates);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.boxTemplate);
            this.Controls.Add(this.boxGenerated);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "xRandomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.panelPatterns.ResumeLayout(false);
            this.panelAutogen.ResumeLayout(false);
            this.panelAutogen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxGenerated;
        private System.Windows.Forms.TextBox boxTemplate;
        private PearXLib.Engine.Flat.FlatButton btnGenerate;
        private PearXLib.Engine.Flat.FlatButton btnCopy;
        private PearXLib.Engine.Flat.FlatButton btnHelp;
        private System.Windows.Forms.Label lblHelp;
        private PearXLib.Engine.Flat.FlatButton btnTemplates;
        private System.Windows.Forms.ListBox listPatterns;
        private PearXLib.Engine.Flat.FlatButton btnDelPattern;
        private PearXLib.Engine.Flat.FlatButton btnAddPattern;
        private System.Windows.Forms.Panel panelPatterns;
        private System.Windows.Forms.Panel panelAutogen;
        private PearXLib.Engine.Flat.FlatButton btnAutogen;
        private PearXLib.Engine.Flat.FlatButton btnStopAutogen;
        private PearXLib.Engine.Flat.FlatButton btnStartAutogen;
        private System.Windows.Forms.TextBox boxAutogenCount;
        private System.ComponentModel.BackgroundWorker bwAutogen;
        private System.Windows.Forms.Label lblWorking;
    }
}