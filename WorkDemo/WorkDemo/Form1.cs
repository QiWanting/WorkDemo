using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorkDemo.tools;

namespace WorkDemo
{
    public partial class Form1 : Form
    {
        LogHelper logHelper;
        public Form1()
        {
            InitializeComponent();
            logHelper = new LogHelper(textBox_display);
        }

        private void button_write_yaml_Click(object sender, EventArgs e)
        {
            var test = new YamlClass();
            test.arraytest = new string[] { "ABC1", "BCD", "123" };
            test.stringtest = "这是测试";
            test.inttest = 5;
            test.dictionarytest = new Dictionary<string, string>();
            test.dictionarytest.Add("KEY1", "VAL1");
            test.dictionarytest.Add("KEY2", "VAL2");
            test.dictionarytest.Add("KEY3", "VAL3");
            YamlHelper.WriteToYaml<YamlClass>("test.yaml", test);
        }

        private void button_read_yaml_Click(object sender, EventArgs e)
        {
            var test = YamlHelper.ReadYaml<YamlClass>("test.yaml");
            logHelper.Info(String.Join(",", test.arraytest));
            logHelper.Info(test.stringtest.ToString());
            logHelper.Info(test.inttest.ToString());
            logHelper.Info(test.dictionarytest.Count.ToString());
        }
    }
}
