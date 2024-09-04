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
                    case 4: // ��
                        ptbResult.Image = Uranai.Properties.Resources.Kyou;
                        txtResult.Text = "���������������v���O�����������邩���B"+ 
                            "�܂��ɂ���ځ[��Ȃ��Ƃ������邩��";
                        break;
                    case 3: // �g
                        ptbResult.Image = Uranai.Properties.Resources.Kichi;
                        txtResult.Text = "�Ȃ��Ȃ��G���[���C���ł��Ȃ�����";
                        break;
                    case 2: // ���g
                        ptbResult.Image = Uranai.Properties.Resources.Syoukichi;
                        txtResult.Text = "�ł����I�Ǝv������R�[�h�����Y��ē����Ȃ��Ƃ��낪���邩��";
                        break;
                    case 1: // ���g
                        ptbResult.Image = Uranai.Properties.Resources.Cyuukichi;
                        txtResult.Text = "�������R�[�h���r���h�G���[���N�����ꔭ�Ŏ��s�ł��邩���I";
                        break;
                    case 0: // ��g
                        ptbResult.Image = Uranai.Properties.Resources.Daikichi;
                        txtResult.Text = "�v�������Ƃ��R�[�h�ɂ����Ă��̂������A�v��������邩���I";
                        break;
                    default:
                        ptbResult.Image = null;
                        break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("�Y���ȓ��t�͂���܂���B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
