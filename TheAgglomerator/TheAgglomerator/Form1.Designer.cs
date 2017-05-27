namespace TheAgglomerator
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
            this.components = new System.ComponentModel.Container();
            this.agglomBox = new System.Windows.Forms.PictureBox();
            this.numOfDrop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxVeloc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.TextBox();
            this.green = new System.Windows.Forms.TextBox();
            this.blue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tickLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agglomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // agglomBox
            // 
            this.agglomBox.BackColor = System.Drawing.Color.White;
            this.agglomBox.Location = new System.Drawing.Point(0, 0);
            this.agglomBox.Name = "agglomBox";
            this.agglomBox.Size = new System.Drawing.Size(751, 609);
            this.agglomBox.TabIndex = 0;
            this.agglomBox.TabStop = false;
            // 
            // numOfDrop
            // 
            this.numOfDrop.Location = new System.Drawing.Point(866, 8);
            this.numOfDrop.Name = "numOfDrop";
            this.numOfDrop.Size = new System.Drawing.Size(136, 20);
            this.numOfDrop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Droplets ";
            // 
            // maxVeloc
            // 
            this.maxVeloc.Location = new System.Drawing.Point(866, 48);
            this.maxVeloc.Name = "maxVeloc";
            this.maxVeloc.Size = new System.Drawing.Size(136, 20);
            this.maxVeloc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximum Velocity";
            // 
            // dropSize
            // 
            this.dropSize.Location = new System.Drawing.Point(866, 93);
            this.dropSize.Name = "dropSize";
            this.dropSize.Size = new System.Drawing.Size(133, 20);
            this.dropSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Droplet Size";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(785, 170);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 34);
            this.start.TabIndex = 7;
            this.start.Text = "Start ";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(887, 170);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(82, 34);
            this.stop.TabIndex = 8;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(762, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color";
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(814, 130);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(46, 20);
            this.red.TabIndex = 11;
            this.red.Text = "0";
            this.red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(887, 130);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(46, 20);
            this.green.TabIndex = 12;
            this.green.Text = "0";
            this.green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(956, 130);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(46, 20);
            this.blue.TabIndex = 13;
            this.blue.Text = "0";
            this.blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(775, 237);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(194, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(786, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tick Speed";
            // 
            // tickLabel
            // 
            this.tickLabel.AutoSize = true;
            this.tickLabel.Location = new System.Drawing.Point(967, 237);
            this.tickLabel.Name = "tickLabel";
            this.tickLabel.Size = new System.Drawing.Size(19, 13);
            this.tickLabel.TabIndex = 16;
            this.tickLabel.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 607);
            this.Controls.Add(this.tickLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxVeloc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfDrop);
            this.Controls.Add(this.agglomBox);
            this.Name = "Form1";
            this.Text = "The Agglomerator";
            ((System.ComponentModel.ISupportInitialize)(this.agglomBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox agglomBox;
        private System.Windows.Forms.TextBox numOfDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxVeloc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dropSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.TextBox blue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tickLabel;
    }
}

