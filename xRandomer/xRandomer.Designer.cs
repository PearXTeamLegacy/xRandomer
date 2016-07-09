namespace xRandomer
{
    partial class xRandomer
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
            this.boxGenerated = new System.Windows.Forms.TextBox();
            this.boxTemplate = new System.Windows.Forms.TextBox();
            this.btnGenerate = new PearXLib.Engine.Flat.FlatButton();
            this.btnCopy = new PearXLib.Engine.Flat.FlatButton();
            this.btnTemplates = new PearXLib.Engine.Flat.FlatButton();
            this.listPatterns = new System.Windows.Forms.ListBox();
            this.btnDelPattern = new PearXLib.Engine.Flat.FlatButton();
            this.btnAddPattern = new PearXLib.Engine.Flat.FlatButton();
            this.panelPatterns = new System.Windows.Forms.Panel();
            this.panelAutogen = new System.Windows.Forms.Panel();
            this.lblWorking = new PearXLib.Engine.Flat.FlatLabel();
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
            this.boxGenerated.Location = new System.Drawing.Point(11, 43);
            this.boxGenerated.Name = "boxGenerated";
            this.boxGenerated.Size = new System.Drawing.Size(425, 40);
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
            this.btnGenerate.Font = new System.Drawing.Font("Yanone Kaffeesatz", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 125);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(470, 45);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Border = 0;
            this.btnCopy.Font = new System.Drawing.Font("Yanone Kaffeesatz", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(442, 43);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(39, 40);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnTemplates
            // 
            this.btnTemplates.Border = 0;
            this.btnTemplates.Font = new System.Drawing.Font("Yanone Kaffeesatz", 20.25F);
            this.btnTemplates.Location = new System.Drawing.Point(248, 176);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(233, 43);
            this.btnTemplates.TabIndex = 6;
            this.btnTemplates.Text = "Patterns";
            this.btnTemplates.Click += new System.EventHandler(this.btnTemplates_Click);
            // 
            // listPatterns
            // 
            this.listPatterns.Font = new System.Drawing.Font("Yanone Kaffeesatz", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPatterns.FormattingEnabled = true;
            this.listPatterns.ItemHeight = 24;
            this.listPatterns.Location = new System.Drawing.Point(0, 0);
            this.listPatterns.Name = "listPatterns";
            this.listPatterns.Size = new System.Drawing.Size(248, 172);
            this.listPatterns.TabIndex = 7;
            this.listPatterns.SelectedIndexChanged += new System.EventHandler(this.listPatterns_SelectedIndexChanged);
            // 
            // btnDelPattern
            // 
            this.btnDelPattern.Border = 0;
            this.btnDelPattern.Location = new System.Drawing.Point(249, 147);
            this.btnDelPattern.Name = "btnDelPattern";
            this.btnDelPattern.Size = new System.Drawing.Size(22, 25);
            this.btnDelPattern.TabIndex = 8;
            this.btnDelPattern.Text = "X";
            this.btnDelPattern.Click += new System.EventHandler(this.btnDelPattern_Click);
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Border = 0;
            this.btnAddPattern.Location = new System.Drawing.Point(251, 3);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(22, 25);
            this.btnAddPattern.TabIndex = 9;
            this.btnAddPattern.Text = "+";
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // panelPatterns
            // 
            this.panelPatterns.Controls.Add(this.btnDelPattern);
            this.panelPatterns.Controls.Add(this.btnAddPattern);
            this.panelPatterns.Controls.Add(this.listPatterns);
            this.panelPatterns.Location = new System.Drawing.Point(488, 43);
            this.panelPatterns.Name = "panelPatterns";
            this.panelPatterns.Size = new System.Drawing.Size(276, 175);
            this.panelPatterns.TabIndex = 10;
            // 
            // panelAutogen
            // 
            this.panelAutogen.Controls.Add(this.lblWorking);
            this.panelAutogen.Controls.Add(this.btnStopAutogen);
            this.panelAutogen.Controls.Add(this.btnStartAutogen);
            this.panelAutogen.Controls.Add(this.boxAutogenCount);
            this.panelAutogen.Location = new System.Drawing.Point(488, 43);
            this.panelAutogen.Name = "panelAutogen";
            this.panelAutogen.Size = new System.Drawing.Size(276, 175);
            this.panelAutogen.TabIndex = 11;
            this.panelAutogen.Visible = false;
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.Location = new System.Drawing.Point(3, 132);
            this.lblWorking.MaximumSize = new System.Drawing.Size(97, 35);
            this.lblWorking.MinimumSize = new System.Drawing.Size(97, 35);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(97, 35);
            this.lblWorking.TabIndex = 14;
            this.lblWorking.Text = "Working...";
            this.lblWorking.Visible = false;
            // 
            // btnStopAutogen
            // 
            this.btnStopAutogen.Border = 0;
            this.btnStopAutogen.Location = new System.Drawing.Point(3, 82);
            this.btnStopAutogen.Name = "btnStopAutogen";
            this.btnStopAutogen.Size = new System.Drawing.Size(268, 40);
            this.btnStopAutogen.TabIndex = 13;
            this.btnStopAutogen.Text = "Stop";
            this.btnStopAutogen.Click += new System.EventHandler(this.btnStopAutogen_Click);
            // 
            // btnStartAutogen
            // 
            this.btnStartAutogen.Border = 0;
            this.btnStartAutogen.Location = new System.Drawing.Point(3, 39);
            this.btnStartAutogen.Name = "btnStartAutogen";
            this.btnStartAutogen.Size = new System.Drawing.Size(268, 40);
            this.btnStartAutogen.TabIndex = 12;
            this.btnStartAutogen.Text = "Start";
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
            this.btnAutogen.Font = new System.Drawing.Font("Yanone Kaffeesatz", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAutogen.Location = new System.Drawing.Point(11, 176);
            this.btnAutogen.Name = "btnAutogen";
            this.btnAutogen.Size = new System.Drawing.Size(231, 43);
            this.btnAutogen.TabIndex = 11;
            this.btnAutogen.Text = "AutoGen";
            this.btnAutogen.Click += new System.EventHandler(this.btnAutogen_Click);
            // 
            // bwAutogen
            // 
            this.bwAutogen.WorkerSupportsCancellation = true;
            this.bwAutogen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAutogen_DoWork);
            this.bwAutogen.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAutogen_RunWorkerCompleted);
            // 
            // xRandomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 231);
            this.Controls.Add(this.panelAutogen);
            this.Controls.Add(this.panelPatterns);
            this.Controls.Add(this.btnAutogen);
            this.Controls.Add(this.btnTemplates);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.boxTemplate);
            this.Controls.Add(this.boxGenerated);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xRandomer";
            this.Text = "Randomer";
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
        private PearXLib.Engine.Flat.FlatButton btnTemplates;
        private PearXLib.Engine.Flat.FlatButton btnDelPattern;
        private PearXLib.Engine.Flat.FlatButton btnAddPattern;
        private System.Windows.Forms.Panel panelPatterns;
        private System.Windows.Forms.Panel panelAutogen;
        private PearXLib.Engine.Flat.FlatButton btnAutogen;
        private PearXLib.Engine.Flat.FlatButton btnStopAutogen;
        private PearXLib.Engine.Flat.FlatButton btnStartAutogen;
        private System.Windows.Forms.TextBox boxAutogenCount;
        private System.ComponentModel.BackgroundWorker bwAutogen;
        private PearXLib.Engine.Flat.FlatLabel lblWorking;
        public System.Windows.Forms.ListBox listPatterns;
    }
}