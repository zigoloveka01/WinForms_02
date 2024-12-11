using System.Xml;

namespace WinForms_02
{
    public partial class txt_lnput : Form
    {
        public txt_lnput()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CircleArea_Click(object sender, EventArgs e)
        {
            //double r = 0;
            // if (!double.TryParse(txt_Radius.Text, out r)) {
            //     MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิข้อผืดพลาด");

            // }
            // CircleArea(r);
            //lbl_Result.Text = btn_CircleArea(radius);

            CircleArea(txt_Radius);//ใช้เรียก void method แบบส่ง textbox
        }
        void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            lbl_Result.Text = area.ToString();
        }

        void CircleArea(TextBox txt)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิข้อผืดพลาด");
            }
            double area = Math.PI * r * r;
            lbl_Result.Text = area.ToString();
        }
        void CircleArea(TextBox txt, Label lbl)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิข้อผืดพลาด");
            }
            double area = Math.PI * r * r;
            lbl.Text = area.ToString();
        }

        private void btn_Circumference_Click(object sender, EventArgs e)
        {
            double r = 0;
            if (!double.TryParse(txt_Radius.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิข้อผืดพลาด");
            }
            lbl_Result.Text = Circumfernce(r).ToString();
        }

        double Circumfernce(double radius)//ส่งไปประมวณผลอย่างเดี่ยว
        {
            return 2 * Math.PI * radius;
        }

        string triangle(string Letter = "*", int size = 5)
        {
            string result = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += Letter;
                }
                result += Environment.NewLine;
            }
            return result;
        }

        private void bin_Triangle01_Click(object sender, EventArgs e)
        {
            txt_Qutput.Text = triangle(txt_Letter.Text);
            //txt_Qutput.Text = triangle(txt_Qutput.Text,9);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void ImproveName(ref string name)
        {
            name = name.Trim();

            if (name.Length < 2)
            {
                MessageBox.Show("โปรดกรอกชื่อให้ถูกต้อง", "ข้อมูลผิดพลาด");
                return;
            }
        }
        string ImproveName2(string name)
        {
            name = name.Trim();
            if (name.Length < 2)
            {
                MessageBox.Show("โปรดกรอกชื่อให้ถูกต้อง", "ข้อมูลผิดพลาด");
            }
            return name;
        }

        private void btn_RelfParameler_Click(object sender, EventArgs e)
        {
            string FName = txt_Input.Text;
            ImproveName2(FName);
            txt_Input.Text = FName;
            //txt_Input.Text = ImproveName2(FName);
        }

        Boolean improveName3(string name, out string x)
        {
            x = name.Trim();
            if (x.Length < 2)
            {
                x = "";
                return false;
            }
            return true;
        }

        private void btn_OutputParameter_Click(object sender, EventArgs e)
        {
            string Fname = "";
            if (improveName3(txt_Input.Text, out string x))
            {
                txt_Input.Text = Fname;
            }
            else
            {
                MessageBox.Show("ข้อมูลผิดพลาด", "โปรดกรอกชื่อให้ถูกต้อง");
            }
        }

        private void btn_ArrayParameter_Click(object sender, EventArgs e)
        {
            double[] data = new double[] { 1.2 , 2.0 , 3.25 , 0.15 };
            double summary = sum(data); //เรียกใช้ Function
            string result = string.Join("/",data);
            result += Environment.NewLine;
            result += summary.ToString();
            MessageBox.Show(result,"ผลรวมของค่าในArray");
        }
        double sum(double[] dataArray) 
        {
            double sum = 0;
            foreach (double d in dataArray)
            {
                sum += d;
            }
            return sum;
        }
    }
}
