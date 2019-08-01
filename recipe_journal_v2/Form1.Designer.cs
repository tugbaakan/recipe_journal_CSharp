namespace recipe_journal_v2
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_meat = new System.Windows.Forms.Button();
            this.button_chicken = new System.Windows.Forms.Button();
            this.button_vegetable = new System.Windows.Forms.Button();
            this.button_other = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(247, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 204);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_meat
            // 
            this.button_meat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_meat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_meat.Location = new System.Drawing.Point(87, 110);
            this.button_meat.Name = "button_meat";
            this.button_meat.Size = new System.Drawing.Size(125, 72);
            this.button_meat.TabIndex = 4;
            this.button_meat.Text = "Meat Dishes";
            this.button_meat.UseVisualStyleBackColor = false;
            this.button_meat.Click += new System.EventHandler(this.button_meat_Click);
            // 
            // button_chicken
            // 
            this.button_chicken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_chicken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_chicken.Location = new System.Drawing.Point(273, 110);
            this.button_chicken.Name = "button_chicken";
            this.button_chicken.Size = new System.Drawing.Size(125, 72);
            this.button_chicken.TabIndex = 5;
            this.button_chicken.Text = "Chicken Dishes";
            this.button_chicken.UseVisualStyleBackColor = false;
            this.button_chicken.Click += new System.EventHandler(this.button_chicken_Click);
            // 
            // button_vegetable
            // 
            this.button_vegetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_vegetable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_vegetable.Location = new System.Drawing.Point(459, 110);
            this.button_vegetable.Name = "button_vegetable";
            this.button_vegetable.Size = new System.Drawing.Size(125, 72);
            this.button_vegetable.TabIndex = 6;
            this.button_vegetable.Text = "Vegetable Dishes";
            this.button_vegetable.UseVisualStyleBackColor = false;
            this.button_vegetable.Click += new System.EventHandler(this.button_vegetable_Click);
            // 
            // button_other
            // 
            this.button_other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_other.Location = new System.Drawing.Point(649, 110);
            this.button_other.Name = "button_other";
            this.button_other.Size = new System.Drawing.Size(125, 72);
            this.button_other.TabIndex = 7;
            this.button_other.Text = "Other Dishes";
            this.button_other.UseVisualStyleBackColor = false;
            this.button_other.Click += new System.EventHandler(this.button_other_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 509);
            this.Controls.Add(this.button_other);
            this.Controls.Add(this.button_vegetable);
            this.Controls.Add(this.button_chicken);
            this.Controls.Add(this.button_meat);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_meat;
        private System.Windows.Forms.Button button_chicken;
        private System.Windows.Forms.Button button_vegetable;
        private System.Windows.Forms.Button button_other;
    }
}

