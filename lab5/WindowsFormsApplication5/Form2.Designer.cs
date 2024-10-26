namespace WindowsFormsApplication5
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
            this.button_height_plus = new System.Windows.Forms.Button();
            this.button_width_plus = new System.Windows.Forms.Button();
            this.button_height_minus = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_width_minus = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.buttonplayer = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_height_plus
            // 
            this.button_height_plus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_height_plus.Location = new System.Drawing.Point(248, 178);
            this.button_height_plus.Name = "button_height_plus";
            this.button_height_plus.Size = new System.Drawing.Size(39, 23);
            this.button_height_plus.TabIndex = 20;
            this.button_height_plus.Text = "+";
            this.button_height_plus.UseVisualStyleBackColor = true;
            this.button_height_plus.Click += new System.EventHandler(this.button_plus_up_Click);
            // 
            // button_width_plus
            // 
            this.button_width_plus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_width_plus.Location = new System.Drawing.Point(310, 215);
            this.button_width_plus.Name = "button_width_plus";
            this.button_width_plus.Size = new System.Drawing.Size(39, 23);
            this.button_width_plus.TabIndex = 19;
            this.button_width_plus.Text = "+";
            this.button_width_plus.UseVisualStyleBackColor = true;
            this.button_width_plus.Click += new System.EventHandler(this.button_plus_right_Click);
            // 
            // button_height_minus
            // 
            this.button_height_minus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_height_minus.Location = new System.Drawing.Point(248, 261);
            this.button_height_minus.Name = "button_height_minus";
            this.button_height_minus.Size = new System.Drawing.Size(39, 24);
            this.button_height_minus.TabIndex = 18;
            this.button_height_minus.Text = "-";
            this.button_height_minus.UseVisualStyleBackColor = true;
            this.button_height_minus.Click += new System.EventHandler(this.button_minus_down_Click);
            // 
            // button_down
            // 
            this.button_down.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button_down.Location = new System.Drawing.Point(248, 313);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(39, 23);
            this.button_down.TabIndex = 17;
            this.button_down.Text = "v";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_width_minus
            // 
            this.button_width_minus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_width_minus.Location = new System.Drawing.Point(187, 215);
            this.button_width_minus.Name = "button_width_minus";
            this.button_width_minus.Size = new System.Drawing.Size(39, 23);
            this.button_width_minus.TabIndex = 16;
            this.button_width_minus.Text = "-";
            this.button_width_minus.UseVisualStyleBackColor = true;
            this.button_width_minus.Click += new System.EventHandler(this.button_minus_left_Click);
            // 
            // button_right
            // 
            this.button_right.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_right.Location = new System.Drawing.Point(370, 215);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(39, 23);
            this.button_right.TabIndex = 15;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_left.Location = new System.Drawing.Point(132, 216);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(39, 23);
            this.button_left.TabIndex = 14;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // buttonplayer
            // 
            this.buttonplayer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonplayer.Location = new System.Drawing.Point(41, 12);
            this.buttonplayer.Name = "buttonplayer";
            this.buttonplayer.Size = new System.Drawing.Size(79, 40);
            this.buttonplayer.TabIndex = 13;
            this.buttonplayer.Text = "player";
            this.buttonplayer.UseVisualStyleBackColor = true;
            this.buttonplayer.Click += new System.EventHandler(this.buttonplayer_Click);
            // 
            // button_up
            // 
            this.button_up.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_up.Location = new System.Drawing.Point(248, 131);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(39, 23);
            this.button_up.TabIndex = 12;
            this.button_up.Text = "^";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 345);
            this.Controls.Add(this.button_height_plus);
            this.Controls.Add(this.button_width_plus);
            this.Controls.Add(this.button_height_minus);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_width_minus);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.buttonplayer);
            this.Controls.Add(this.button_up);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_height_plus;
        private System.Windows.Forms.Button button_width_plus;
        private System.Windows.Forms.Button button_height_minus;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_width_minus;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button buttonplayer;
        private System.Windows.Forms.Button button_up;
    }
}