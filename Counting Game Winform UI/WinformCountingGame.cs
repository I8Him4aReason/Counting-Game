using Counting_Game_Library;                                     // בס"ד
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Game_Winform_UI
{
    public class WinformCountingGame : CountingGame
    {
        // Helpful Winform Methods

        public void ChangeLabelSize(Label l, int FontSize)
        {
            l.Font = new Font(l.Font.FontFamily, FontSize);
        }


        public void CenterLabelHorizontallyInPanel(Panel p, params Label[] labels)
        {
            foreach (Label label in labels)
                label.Left = (p.ClientSize.Width - label.Width) / 2;
        }

        public void CenterLabelHorizontallyInForm(Form form, params Label[] labels)
        {
            foreach (Label label in labels)
                label.Left = (form.ClientSize.Width - label.Width) / 2;
        }


        public void AddKeyDownEventToNumericUpDownThatPressesButton(Button button, params NumericUpDown[] numericalUpDowns)
        {
            foreach (NumericUpDown n in numericalUpDowns)
                n.KeyDown += (sender, e) => NumericUpDown_KeyDown(sender, e, button);
        }

        public void NumericUpDown_KeyDown(object sender, KeyEventArgs e, Button button)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                button.PerformClick();
            }
        }


        public void AddEventThatExitsApplicationWhenPressESC(Form form)
        {
            form.KeyDown += (sender, e) => Form_KeyDown(sender, e);
            form.KeyPreview = true; // even when in a texbox or something it will work
        }

        public void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Close the application
            }
        }
    }
}