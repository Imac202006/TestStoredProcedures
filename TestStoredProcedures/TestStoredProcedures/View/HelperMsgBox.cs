using System.Windows.Forms;

namespace TestStoredProcedures.View
{
    public class HelperMsgBox
    {
        public HelperMsgBox() { }

        public static void PromptMsgBoxOK(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK);
        }

        public static bool PromptMsgBoxYesNo(string msg, string caption)
        {
            DialogResult dialogResult = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
