
namespace The_Tartan_Paint_Launcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.setupbutton = new System.Windows.Forms.Button();
            this.removekeys = new System.Windows.Forms.Button();
            this.consoleOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // setupbutton
            // 
            this.setupbutton.Location = new System.Drawing.Point(89, 54);
            this.setupbutton.Name = "setupbutton";
            this.setupbutton.Size = new System.Drawing.Size(75, 23);
            this.setupbutton.TabIndex = 0;
            this.setupbutton.Text = "setup";
            this.setupbutton.UseVisualStyleBackColor = true;
            this.setupbutton.Click += new System.EventHandler(this.setupbutton_Click);
            // 
            // removekeys
            // 
            this.removekeys.Location = new System.Drawing.Point(89, 83);
            this.removekeys.Name = "removekeys";
            this.removekeys.Size = new System.Drawing.Size(75, 23);
            this.removekeys.TabIndex = 1;
            this.removekeys.Text = "remove";
            this.removekeys.UseVisualStyleBackColor = true;
            // 
            // consoleOut
            // 
            this.consoleOut.Location = new System.Drawing.Point(437, 10);
            this.consoleOut.Name = "consoleOut";
            this.consoleOut.Size = new System.Drawing.Size(351, 160);
            this.consoleOut.TabIndex = 0;
            this.consoleOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consoleOut);
            this.Controls.Add(this.removekeys);
            this.Controls.Add(this.setupbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setupbutton;
        private System.Windows.Forms.Button removekeys;
        private System.Windows.Forms.RichTextBox consoleOut;
    }
}

