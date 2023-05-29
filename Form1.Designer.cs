namespace WinFormsApp_37_SlideShow
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
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
            {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            btnstartStop = new Button();
            btnPrevious = new Button();
            BTNNext = new Button();
            BTNfolderBrowse = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(945, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(40, 605);
            button1.Name = "button1";
            button1.Size = new Size(105, 45);
            button1.TabIndex = 1;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // btnstartStop
            // 
            btnstartStop.BackColor = Color.FromArgb(255, 224, 192);
            btnstartStop.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnstartStop.Location = new Point(703, 605);
            btnstartStop.Name = "btnstartStop";
            btnstartStop.Size = new Size(146, 45);
            btnstartStop.TabIndex = 2;
            btnstartStop.Text = "Start|Stop";
            btnstartStop.UseVisualStyleBackColor = false;
            btnstartStop.Click += btnstartStop_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(255, 224, 192);
            btnPrevious.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(592, 605);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(105, 45);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // BTNNext
            // 
            BTNNext.BackColor = Color.FromArgb(255, 224, 192);
            BTNNext.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTNNext.Location = new Point(855, 605);
            BTNNext.Name = "BTNNext";
            BTNNext.Size = new Size(105, 45);
            BTNNext.TabIndex = 4;
            BTNNext.Text = "Next";
            BTNNext.UseVisualStyleBackColor = false;
            BTNNext.Click += BTNNext_Click;
            // 
            // BTNfolderBrowse
            // 
            BTNfolderBrowse.BackColor = Color.FromArgb(255, 224, 192);
            BTNfolderBrowse.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTNfolderBrowse.Location = new Point(151, 605);
            BTNfolderBrowse.Name = "BTNfolderBrowse";
            BTNfolderBrowse.Size = new Size(196, 45);
            BTNfolderBrowse.TabIndex = 5;
            BTNfolderBrowse.Text = "Folder Browse";
            BTNfolderBrowse.UseVisualStyleBackColor = false;
            BTNfolderBrowse.Click += BTNfolderBrowse_Click;
            // 
            // timer2
            // 
            timer2.Interval = 2000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1011, 691);
            Controls.Add(BTNfolderBrowse);
            Controls.Add(BTNNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnstartStop);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "SlideShow | IPBSES";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog openFileDialog1;
        private Button btnstartStop;
        private Button btnPrevious;
        private Button BTNNext;
        private Button BTNfolderBrowse;
        private System.Windows.Forms.Timer timer2;
        private FolderBrowserDialog folderBrowserDialog1;
        }
    }