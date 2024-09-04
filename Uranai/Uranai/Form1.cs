namespace Uranai
{
    public partial class FormUranai : Form
    {
        public FormUranai()
        {
            InitializeComponent();
            ptbResult.Image = Uranai.Properties.Resources.Title;
        }

        private void btnUranaiStart_Click(object sender, EventArgs e)
        {
            try
            {
                int uranai = dateTimeUranai.Value.DayOfYear % 5;
                switch (uranai)
                {
                    case 4: // 凶
                        ptbResult.Image = Uranai.Properties.Resources.Kyou;
                        txtResult.Text = "せっかく書いたプログラムがきえるかも。"+ 
                            "まさにしょぼーんなことがおこるかも";
                        break;
                    case 3: // 吉
                        ptbResult.Image = Uranai.Properties.Resources.Kichi;
                        txtResult.Text = "なかなかエラーが修理できないかも";
                        break;
                    case 2: // 小吉
                        ptbResult.Image = Uranai.Properties.Resources.Syoukichi;
                        txtResult.Text = "できた！と思ったらコード書き忘れて動かないところがあるかも";
                        break;
                    case 1: // 中吉
                        ptbResult.Image = Uranai.Properties.Resources.Cyuukichi;
                        txtResult.Text = "書いたコードがビルドエラーも起きず一発で実行できるかも！";
                        break;
                    case 0: // 大吉
                        ptbResult.Image = Uranai.Properties.Resources.Daikichi;
                        txtResult.Text = "思ったことがコードにかけてものすごいアプリがつくれるかも！";
                        break;
                    default:
                        ptbResult.Image = null;
                        break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("該当な日付はありません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
