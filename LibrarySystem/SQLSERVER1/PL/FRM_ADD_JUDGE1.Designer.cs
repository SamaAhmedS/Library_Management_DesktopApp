namespace SQLSERVER1
{
    partial class FRM_JUDGE1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_JUDGE1));
            this.txtRef = new System.Windows.Forms.Label();
            this.lblBJ1 = new System.Windows.Forms.Label();
            this.lblRJ1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtRef
            // 
            this.txtRef.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.txtRef, "txtRef");
            this.txtRef.Name = "txtRef";
            this.txtRef.UseWaitCursor = true;
            // 
            // lblBJ1
            // 
            resources.ApplyResources(this.lblBJ1, "lblBJ1");
            this.lblBJ1.ForeColor = System.Drawing.Color.Blue;
            this.lblBJ1.Name = "lblBJ1";
            this.lblBJ1.UseWaitCursor = true;
            // 
            // lblRJ1
            // 
            resources.ApplyResources(this.lblRJ1, "lblRJ1");
            this.lblRJ1.ForeColor = System.Drawing.Color.Red;
            this.lblRJ1.Name = "lblRJ1";
            this.lblRJ1.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_JUDGE1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRJ1);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblBJ1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_JUDGE1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRM_JUDGE1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FRM_JUDGE1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FRM_JUDGE1_MouseDoubleClick);
            this.MouseCaptureChanged += new System.EventHandler(this.FRM_JUDGE1_MouseCaptureChanged);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FRM_JUDGE1_MouseUp);
            this.ImeModeChanged += new System.EventHandler(this.FRM_JUDGE1_ImeModeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRef;
        private System.Windows.Forms.Label lblBJ1;
        private System.Windows.Forms.Label lblRJ1;
        private System.Windows.Forms.Timer timer1;
    }
}