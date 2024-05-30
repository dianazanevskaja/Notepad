using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad1
{
    public partial class FontSettings : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;

        public FontSettings()
        {
            InitializeComponent();
            fontBox.SelectedItem = fontBox.Items[0];
            styleBox.SelectedItem = styleBox.Items[0];
        }

        private void OnFontChanged(object sender, EventArgs e)
        {
            ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), ExampleText.Font.Style);
            fontSize = int.Parse(fontBox.SelectedItem.ToString());
        }

        private void OnStyleChanged(object sender, EventArgs e)
        {
            switch (styleBox.SelectedItem.ToString())
            {
                case "обычный":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Regular);
                    break;
                case "курсив":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Italic);
                    break;
                case "полужирный":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Bold);
                    break;
                case "линия по середине":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Strikeout);
                    break;
                case "подчеркивание":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Underline);
                    break;
            }
            fs = ExampleText.Font.Style;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
