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
            this.SuspendLayout();
            // 
            // button_write_yaml
            // 
            this.button_write_yaml.Location = new System.Drawing.Point(347, 12);
            this.button_write_yaml.Name = "button_write_yaml";
            this.button_write_yaml.Size = new System.Drawing.Size(156, 23);
            this.button_write_yaml.TabIndex = 0;
            this.button_write_yaml.Text = "写入数据到Yaml文件";
            this.button_write_yaml.UseVisualStyleBackColor = true;
            this.button_write_yaml.Click += new System.EventHandler(this.button_write_yaml_Click);
            // 
            // button_read_yaml
            // 
            this.button_read_yaml.Location = new System.Drawing.Point(347, 41);
            this.button_read_yaml.Name = "button_read_yaml";
            this.button_read_yaml.Size = new System.Drawing.Size(156, 23);
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
            this.button_yaml_to_json.Size = new System.Drawing.Size(156, 23);
            this.button_yaml_to_json.TabIndex = 3;
            this.button_yaml_to_json.Text = "Yaml_To_Json";
            this.button_yaml_to_json.UseVisualStyleBackColor = true;
            this.button_yaml_to_json.Click += new System.EventHandler(this.button_yaml_to_json_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
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
    }
}

