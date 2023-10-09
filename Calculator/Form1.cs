namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        sbyte indexBtnMath = -1;

        private void btnNum1_Click(object sender, EventArgs e) => textNum.Text += "1";
        private void btnNum2_Click(object sender, EventArgs e) => textNum.Text += "2";
        private void btnNum3_Click(object sender, EventArgs e) => textNum.Text += "3";
        private void btnNum4_Click(object sender, EventArgs e) => textNum.Text += "4";
        private void btnNum5_Click(object sender, EventArgs e) => textNum.Text += "5";
        private void btnNum6_Click(object sender, EventArgs e) => textNum.Text += "6";
        private void btnNum7_Click(object sender, EventArgs e) => textNum.Text += "7";
        private void btnNum8_Click(object sender, EventArgs e) => textNum.Text += "8";
        private void btnNum9_Click(object sender, EventArgs e) => textNum.Text += "9";
        private void btnNum0_Click(object sender, EventArgs e) => textNum.Text += "0";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textNum.Text);
            textNum.Text += "+ ";
            indexBtnMath = 0;
        }
        private void btnSubtr_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textNum.Text);
            textNum.Text += "- ";
            indexBtnMath = 1;
        }
        private void btnDivis_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textNum.Text);
            textNum.Text += "/ ";
            indexBtnMath = 3;
        }
        private void btnMultip_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textNum.Text);
            textNum.Text += "* ";
            indexBtnMath = 2;
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            textNum.Text = "";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string str_num = null;
            int spaceIndex = -1;
            for (int i = 0; i < textNum.Text.Length; i++)
            {
                if (textNum.Text[i] == ' ')
                {
                    spaceIndex = i;
                    break;
                }
            }

            string numbersPart = textNum.Text.Substring(spaceIndex + 1);
            num2 = int.Parse(numbersPart);

            switch (indexBtnMath)
            {
                case 0:
                    textNum.Text = (num1 + num2).ToString();
                    indexBtnMath = -1;
                    break;
                case 1:
                    textNum.Text = (num1 - num2).ToString();
                    indexBtnMath = -1;
                    break;
                case 2:
                    textNum.Text = (num1 * num2).ToString();
                    indexBtnMath = -1;
                    break;
                case 3:
                    textNum.Text = (num1 / num2).ToString();
                    indexBtnMath = -1;
                    break;
            }
        }
    }
}