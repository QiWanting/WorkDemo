namespace WorkDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_write_yaml = new System.Windows.Forms.Button();
            this.button_read_yaml = new System.Windows.Forms.Button();
            this.textBox_display = new System.Windows.Forms.TextBox();
            this.button_yaml_to_json = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.hSmartWindowControl1 = new HalconDotNet.HSmartWindowControl();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_open_image = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_write_yaml
            // 
            this.button_write_yaml.Location = new System.Drawing.Point(29, 33);
            this.button_write_yaml.Name = "button_write_yaml";
            this.button_write_yaml.Size = new System.Drawing.Size(207, 29);
            this.button_write_yaml.TabIndex = 0;
            this.button_write_yaml.Text = "写入数据到Yaml文件";
            this.button_write_yaml.UseVisualStyleBackColor = true;
            this.button_write_yaml.Click += new System.EventHandler(this.button_write_yaml_Click);
            // 
            // button_read_yaml
            // 
            this.button_read_yaml.Location = new System.Drawing.Point(29, 68);
            this.button_read_yaml.Name = "button_read_yaml";
            this.button_read_yaml.Size = new System.Drawing.Size(207, 29);
            this.button_read_yaml.TabIndex = 1;
            this.button_read_yaml.Text = "读取Yaml文件数据到代码";
            this.button_read_yaml.UseVisualStyleBackColor = true;
            this.button_read_yaml.Click += new System.EventHandler(this.button_read_yaml_Click);
            // 
            // textBox_display
            // 
            this.textBox_display.Location = new System.Drawing.Point(12, 779);
            this.textBox_display.Multiline = true;
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_display.Size = new System.Drawing.Size(1134, 198);
            this.textBox_display.TabIndex = 2;
            // 
            // button_yaml_to_json
            // 
            this.button_yaml_to_json.Location = new System.Drawing.Point(29, 103);
            this.button_yaml_to_json.Name = "button_yaml_to_json";
            this.button_yaml_to_json.Size = new System.Drawing.Size(207, 29);
            this.button_yaml_to_json.TabIndex = 3;
            this.button_yaml_to_json.Text = "Yaml_To_Json";
            this.button_yaml_to_json.UseVisualStyleBackColor = true;
            this.button_yaml_to_json.Click += new System.EventHandler(this.button_yaml_to_json_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "多个文件名变化（剪切且更名至目标文件）";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "获取一个文件夹下的所有文件的路径";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "图片的平均灰度值";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "浏览模型点";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // hSmartWindowControl1
            // 
            this.hSmartWindowControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl1.HDoubleClickToFitContent = true;
            this.hSmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl1.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl1.HKeepAspectRatio = true;
            this.hSmartWindowControl1.HMoveContent = true;
            this.hSmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl1.Location = new System.Drawing.Point(12, 9);
            this.hSmartWindowControl1.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl1.Name = "hSmartWindowControl1";
            this.hSmartWindowControl1.Size = new System.Drawing.Size(848, 745);
            this.hSmartWindowControl1.TabIndex = 10;
            this.hSmartWindowControl1.WindowSize = new System.Drawing.Size(848, 745);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(29, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(207, 29);
            this.button8.TabIndex = 11;
            this.button8.Text = "Matching";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(897, 684);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(232, 29);
            this.button9.TabIndex = 12;
            this.button9.Text = "刷新";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_write_yaml);
            this.groupBox1.Controls.Add(this.button_read_yaml);
            this.groupBox1.Controls.Add(this.button_yaml_to_json);
            this.groupBox1.Location = new System.Drawing.Point(880, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 158);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yaml与Json";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(880, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 158);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图片处理";
            // 
            // button_open_image
            // 
            this.button_open_image.Location = new System.Drawing.Point(897, 720);
            this.button_open_image.Name = "button_open_image";
            this.button_open_image.Size = new System.Drawing.Size(232, 31);
            this.button_open_image.TabIndex = 15;
            this.button_open_image.Text = "打开图片";
            this.button_open_image.UseVisualStyleBackColor = true;
            this.button_open_image.Click += new System.EventHandler(this.button_open_image_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(880, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 213);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件操作";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "label1";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 989);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_open_image);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.hSmartWindowControl1);
            this.Controls.Add(this.textBox_display);
            this.Name = "Form1";
            this.Text = "WorkDemo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_write_yaml;
        private System.Windows.Forms.Button button_read_yaml;
        private System.Windows.Forms.TextBox textBox_display;
        private System.Windows.Forms.Button button_yaml_to_json;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_open_image;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

