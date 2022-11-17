using System.Reflection;

namespace Voicer.UserInterface
{
    public partial class BaseWindow : Form
    {
        protected virtual string? WindowTitle => Assembly.GetExecutingAssembly().GetName().Name;

        public BaseWindow()
        {
            InitializeComponent();
        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {
            ForeColor = Color.FromArgb(0x0);
            BackColor = Color.FromArgb(0xEE, 0xEE, 0xEE);

            Text = WindowTitle;

            Icon = Resource.speech_icon_2797263_1280;
        }
    }
}
