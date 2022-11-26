using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public static class FormHelper 
    {  
        public static void ValidationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
