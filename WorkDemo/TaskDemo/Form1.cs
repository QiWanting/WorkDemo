namespace TaskDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"���߳�ִ��ҵ����.\n";
            //��������
            Task task = new Task(() =>
            {
                this.Invoke(new EventHandler(delegate
                {
                    textBox1.Text = textBox1.Text + $"ʹ��System.Threading.Tasks.Taskִ���첽����.\n";
                }));
                for (int i = 0; i < 10; i++)
                {
                    this.Invoke(new EventHandler(delegate
                    {
                        textBox1.Text = textBox1.Text + $"\n";
                    }));
                }
            });
            //��������,�����ŵ���ǰ��������߳���ִ������
            task.Start();
            textBox1.Text = textBox1.Text + $"���߳�ִ����������\n";
        }
    }
}
