namespace flappy_bird
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
            this.User_Menu = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_Menu
            // 
            this.User_Menu.Controls.Add(this.button2);
            this.User_Menu.Controls.Add(this.tb_user);
            this.User_Menu.Controls.Add(this.label1);
            this.User_Menu.Location = new System.Drawing.Point(12, 12);
            this.User_Menu.Name = "User_Menu";
            this.User_Menu.Size = new System.Drawing.Size(289, 290);
            this.User_Menu.TabIndex = 12;
            this.User_Menu.TabStop = false;
            this.User_Menu.Text = "Registo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(71, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "SAVE";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(129, 88);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(154, 23);
            this.tb_user.TabIndex = 1;
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(313, 314);
            this.Controls.Add(this.User_Menu);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form3";
            this.Text = "Registo do Score";
            this.User_Menu.ResumeLayout(false);
            this.User_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox User_Menu;
        private Button button2;
        private TextBox tb_user;
        private Label label1;
    }
}