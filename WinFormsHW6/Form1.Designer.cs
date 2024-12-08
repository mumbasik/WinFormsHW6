namespace WinFormsHW6
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
            components = new System.ComponentModel.Container();
            Events = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            SuspendLayout();
            // 
            // Events
            // 
            Events.BackColor = SystemColors.Window;
            Events.FormattingEnabled = true;
            Events.ItemHeight = 15;
            Events.Location = new Point(32, 26);
            Events.Name = "Events";
            Events.Size = new Size(120, 94);
            Events.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 8);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Events list";
            // 
            // button1
            // 
            button1.Location = new Point(178, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(178, 97);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 4;
            toolTip1.SetToolTip(textBox1, "Enter your name");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 136);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(32, 200);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(120, 23);
            dateTimePicker1.TabIndex = 6;
            toolTip2.SetToolTip(dateTimePicker1, "Choose date");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 182);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "Date";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(178, 55);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(346, 36);
            progressBar1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 30);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Events);
            Name = "Form1";
            Text = "Events";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Events;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ProgressBar progressBar1;
        private Label label4;
        private CheckBox checkBox1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}
