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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_write_yaml
            // 
            this.button_write_yaml.Location = new System.Drawing.Point(347, 12);
            this.button_write_yaml.Name = "button_write_yaml";
            this.button_write_yaml.Size = new System.Drawing.Size(309, 23);
            this.button_write_yaml.TabIndex = 0;
            this.button_write_yaml.Text = "写入数据到Yaml文件";
            this.button_write_yaml.UseVisualStyleBackColor = true;
            this.button_write_yaml.Click += new System.EventHandler(this.button_write_yaml_Click);
            // 
            // button_read_yaml
            // 
            this.button_read_yaml.Location = new System.Drawing.Point(347, 41);
            this.button_read_yaml.Name = "button_read_yaml";
            this.button_read_yaml.Size = new System.Drawing.Size(309, 23);
            this.button_read_yaml.TabIndex = 1;
            this.button_read_yaml.Text = "读取Yaml文件数据到代码";
            this.button_read_yaml.UseVisualStyleBackColor = true;
            this.button_read_yaml.Click += new System.EventHandler(this.button_read_yaml_Click);
            // 
            // textBox_display
            // 
            this.textBox_display.Location = new System.Drawing.Point(12, 12);
            this.textBox_display.Multiline = true;
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_display.Size = new System.Drawing.Size(310, 426);
            this.textBox_display.TabIndex = 2;
            // 
            // button_yaml_to_json
            // 
            this.button_yaml_to_json.Location = new System.Drawing.Point(347, 70);
            this.button_yaml_to_json.Name = "button_yaml_to_json";
            this.button_yaml_to_json.Size = new System.Drawing.Size(309, 23);
            this.button_yaml_to_json.TabIndex = 3;
            this.button_yaml_to_json.Text = "Yaml_To_Json";
            this.button_yaml_to_json.UseVisualStyleBackColor = true;
            this.button_yaml_to_json.Click += new System.EventHandler(this.button_yaml_to_json_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "多个文件名变化（剪切文件）";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "测试找不到halcon模块";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "获取一个文件夹下的所有文件的路径";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(309, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "图片的平均灰度值";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(309, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "浏览模型点";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(347, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(309, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "测试画处理dll在release模式下输出log出错的行列号";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(347, 273);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(309, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "打开相机显示画面";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_yaml_to_json);
            this.Controls.Add(this.textBox_display);
            this.Controls.Add(this.button_read_yaml);
            this.Controls.Add(this.button_write_yaml);
            this.Name = "Form1";
            this.Text = "WorkDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_write_yaml;
        private System.Windows.Forms.Button button_read_yaml;
        private System.Windows.Forms.TextBox textBox_display;
        private System.Windows.Forms.Button button_yaml_to_json;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

