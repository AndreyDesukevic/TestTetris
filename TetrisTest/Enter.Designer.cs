namespace TetrisTest
{
    partial class Enter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthField = new System.Windows.Forms.TextBox();
            this.heightField = new System.Windows.Forms.TextBox();
            this.AddNewShape = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.widthField);
            this.panel1.Controls.Add(this.heightField);
            this.panel1.Controls.Add(this.AddNewShape);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 447);
            this.panel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(0, 341);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(464, 53);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(97, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Размер игрового поля:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(97, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ширина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Высота:";
            // 
            // widthField
            // 
            this.widthField.Location = new System.Drawing.Point(200, 280);
            this.widthField.Name = "widthField";
            this.widthField.Size = new System.Drawing.Size(102, 27);
            this.widthField.TabIndex = 3;
            this.widthField.Enter += new System.EventHandler(this.widthField_Enter);
            this.widthField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthField_KeyPress);
            this.widthField.Leave += new System.EventHandler(this.widthField_Leave);
            // 
            // heightField
            // 
            this.heightField.ForeColor = System.Drawing.Color.Black;
            this.heightField.Location = new System.Drawing.Point(200, 223);
            this.heightField.Name = "heightField";
            this.heightField.Size = new System.Drawing.Size(102, 27);
            this.heightField.TabIndex = 2;
            this.heightField.Enter += new System.EventHandler(this.heightField_Enter);
            this.heightField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightField_KeyPress);
            this.heightField.Leave += new System.EventHandler(this.heightField_Leave);
            // 
            // AddNewShape
            // 
            this.AddNewShape.BackColor = System.Drawing.Color.DarkGray;
            this.AddNewShape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewShape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddNewShape.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.AddNewShape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddNewShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewShape.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewShape.Location = new System.Drawing.Point(0, 394);
            this.AddNewShape.Name = "AddNewShape";
            this.AddNewShape.Size = new System.Drawing.Size(464, 53);
            this.AddNewShape.TabIndex = 1;
            this.AddNewShape.Text = "Добавить новые фигуры";
            this.AddNewShape.UseVisualStyleBackColor = false;
            this.AddNewShape.Click += new System.EventHandler(this.AddNewShape_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 139);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "TETRIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 447);
            this.Controls.Add(this.panel1);
            this.Name = "Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button AddNewShape;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox widthField;
        private TextBox heightField;
        private Button buttonStart;
    }
}