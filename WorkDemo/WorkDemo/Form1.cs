using HalconDotNet;
using HCSharpInterface.imageProcess;
using HCSharpInterface.matching;
using HCSharpInterface.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WorkDemo.tools;

namespace WorkDemo
{
    public partial class Form1 : Form
    {
        LogHelper logHelper;
        object yamlData;
        public Form1()
        {
            InitializeComponent();
            logHelper = new LogHelper(textBox_display);
            yamlData = null;
        }

        private void button_write_yaml_Click(object sender, EventArgs e)
        {
            var test = new YamlClass();
            test.yamlClass = new List<YamlClass.YamlClassCell> { };
            var newCell = new YamlClass.YamlClassCell
            {
                arraytest = new string[] { "ABC1", "BCD", "123" },
                stringtest = "这是测试",
                inttest = 5,
                dictionarytest = new Dictionary<string, string> {
                    { "KEY1", "VAL1"},
                    {"KEY2", "VAL2" },
                    {"KEY3", "VAL3" }
                },
            };
            test.yamlClass.Add(newCell);
            newCell = new YamlClass.YamlClassCell
            {
                arraytest = new string[] { "A", "B", "123" },
                stringtest = "这是测试2",
                inttest = 5,
                dictionarytest = new Dictionary<string, string> {
                    { "KEY1", "VAL1"},
                    {"KEY2", "VAL2" },
                    {"KEY3", "VAL3" }
                },
            };
            test.yamlClass.Add(newCell);
            YamlHelper.WriteToYaml<YamlClass>("test.yaml", test);
        }

        private void button_read_yaml_Click(object sender, EventArgs e)
        {
            var test = YamlHelper.ReadYaml<YamlClass>("test.yaml");
            yamlData = test;
            logHelper.Info(String.Join(",", test.yamlClass[0].arraytest));
            logHelper.Info(test.yamlClass[0].stringtest.ToString());
            logHelper.Info(test.yamlClass[0].inttest.ToString());
            logHelper.Info(test.yamlClass[0].dictionarytest.Count.ToString());
        }

        private void button_yaml_to_json_Click(object sender, EventArgs e)
        {
            if (yamlData == null)
            {
                MessageBox.Show("yaml 数据为空。");
                return;
            }
            var serializer = new JsonSerializer();
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented; // For pretty-printed JSON

            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, yamlData);

                // 解析 JSON 字符串
                var jsonData = JsonConvert.DeserializeObject<YamlClass>(stringWriter.ToString());
                // 获取某一个关键字的值
                //Console.WriteLine(jsonData.stringtest);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string originalFile = @"D:\own\2024\4G\Code\DTE_ImageProcessing\test\testData\CalibrateFiducail\数据正常,标定成功"; // 原本路径
            string newFile = @"D:\own\2024\4G\Code\DTE_ImageProcessing\test\testData\CalibrateFiducail\数据正常,标定成功\1"; // 更改名字后的路径

            try
            {
                // 获取指定文件夹中的所有文件
                string[] files = Directory.GetFiles(originalFile);

                int pictureIndex = 1;
                // 遍历文件数组并重命名每个文件
                foreach (string file in files)
                {
                    // 获取文件的原始名称（不含扩展名）和扩展名
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string extension = Path.GetExtension(file);

                    // 构建新的文件名
                    string newFileName = pictureIndex + extension;

                    // 构建新的文件路径
                    string newFilePath = Path.Combine(newFile, newFileName);

                    // 重命名文件
                    File.Move(file, newFilePath);
                    Console.WriteLine($"Renamed '{file}' to '{newFilePath}'");
                    pictureIndex++;
                }
            }
            catch (Exception ex)
            {
                // 处理可能发生的异常，如路径不存在、没有权限等
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Local iconic variables 

            HObject ho_image;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_image);
            ho_image.Dispose();
            HOperatorSet.ReadImage(out ho_image, "C://Users//qiwa//Desktop//111.png");
            ho_image.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 指定要读取的文件夹路径
            string folderPath = @"D:\own\2024\4G\Code\DTE_ImageProcessing\test\testData\Matching\字母"; // 请替换为实际的文件夹路径

            try
            {
                // 读取文件夹及其所有子文件夹中的文件路径
                string[] filePaths = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

                // 输出文件路径
                foreach (string filePath in filePaths)
                {
                    Console.WriteLine(filePath);
                }
            }
            catch (Exception ex)
            {
                // 处理任何异常，例如文件夹不存在或没有访问权限等
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// 计算图片平均灰度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            HObject image = new HObject();
            HObject region = new HObject();
            HTuple mean = new HTuple();
            HTuple deviation = new HTuple();

            HOperatorSet.ReadImage(out image, @"C:\Users\qiwa\Pictures\Saved Pictures\th.jpg");//图片路径另外添加
            HOperatorSet.Threshold(image, out region, 1, 255);
            HOperatorSet.Intensity(region, image, out mean, out deviation);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShapeModel shapeModel = new ShapeModel();
            HObject hObject = new HObject();
            HImage image = new HImage();
            Matching matching = new Matching();
            List<ShapeModel> shapeModelList = new List<ShapeModel>();

            HOperatorSet.ReadImage(out hObject, @"C:\Users\qiwa\Desktop\pictures\pictures\pictures\Z.bmp");
            image = new HImage(hObject);
            shapeModel = new ShapeModel(image,
                new RoiRect(1566.35000000f, 2235.15000000f, 1906.58000000f, 2630.78000000f),
                0, 360, 0.35f, 5, new PointF((1566.35000000f + 1906.58000000f) / 2, (2235.15000000f + 2630.78000000f) / 2));
            shapeModel.CreateShapeModel();
            shapeModelList.Add(shapeModel);
            matching = new Matching(shapeModelList);

            HOperatorSet.ReadImage(out hObject, @"C:\Users\qiwa\Desktop\pictures\pictures\pictures\Z_1.bmp");
            image = new HImage(hObject);
            (ReturnCode returnCode, List<List<double[]>> transMarixResult) result = matching.FindShapeModels(image);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ImageProcess.ReadImage(@"");
            }
            catch (Exception ex)
            {
                string t = ex.Message.ToString() + ex.StackTrace.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
