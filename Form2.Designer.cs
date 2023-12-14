namespace Sae_2._3_Réseau
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_Txt = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Txt
            // 
            this.lbl_Txt.AutoSize = true;
            this.lbl_Txt.Location = new System.Drawing.Point(45, 22);
            this.lbl_Txt.Name = "lbl_Txt";
            this.lbl_Txt.Size = new System.Drawing.Size(708, 195);
            this.lbl_Txt.TabIndex = 0;
            this.lbl_Txt.Text = resources.GetString("lbl_Txt.Text");
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(114)))));
            this.btn_OK.Location = new System.Drawing.Point(352, 232);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(108, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "C\'est compris !";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 265);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_Txt);
            this.Name = "Form2";
            this.Text = "Aide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Txt;
        private Button btn_OK;
    }
}