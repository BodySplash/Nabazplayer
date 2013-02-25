namespace NabazRemote.GUI
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
            this.nabaztagList1 = new NabazRemote.GUI.NabaztagList();
            this.newNabaztagView1 = new NabazRemote.GUI.NewNabaztagView();
            this.SuspendLayout();
            // 
            // nabaztagList1
            // 
            this.nabaztagList1.Location = new System.Drawing.Point(208, 7);
            this.nabaztagList1.Name = "nabaztagList1";
            this.nabaztagList1.Size = new System.Drawing.Size(241, 117);
            this.nabaztagList1.TabIndex = 1;
            // 
            // newNabaztagView1
            // 
            this.newNabaztagView1.Location = new System.Drawing.Point(12, 7);
            this.newNabaztagView1.Name = "newNabaztagView1";
            this.newNabaztagView1.Size = new System.Drawing.Size(190, 117);
            this.newNabaztagView1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 136);
            this.Controls.Add(this.nabaztagList1);
            this.Controls.Add(this.newNabaztagView1);
            this.Name = "Main";
            this.Text = "NabazRemote";
            this.ResumeLayout(false);

        }

        #endregion

        private NewNabaztagView newNabaztagView1;
        private NabaztagList nabaztagList1;
    }
}

