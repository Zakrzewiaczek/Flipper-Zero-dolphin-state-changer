using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Flipper_zero_dolphin_state_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PrivateFontCollection pfc = new();
            int fontLength = Resources.haxrcorp_font.Length;
            byte[] fontData = Resources.haxrcorp_font;
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);



            dolphin_exp_lbl.Font = new Font(pfc.Families[0], dolphin_exp_lbl.Font.Size * 3);
            dolphin_exp_lbl2.Font = dolphin_exp_lbl.Font;
            dolphin_state_lbl.Font = dolphin_exp_lbl.Font;
            dolphin_exp.Font = new Font(pfc.Families[0], dolphin_exp.Font.Size * 3);
            dolphin_state.Font = new Font(pfc.Families[0], dolphin_state.Font.Size * 3);
            github_link.Font = new Font(pfc.Families[0], github_link.Font.Size * 3);
            title_lbl.Font = new Font(pfc.Families[0], title_lbl.Font.Size * 3);
            butthurt_lbl.Font = new Font(pfc.Families[0], butthurt_lbl.Font.Size * 2);

            dolphin_state.SelectedIndex = 0;
        }

        private void GitHub_otworz(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new()
                {
                    FileName = "cmd",
                    Arguments = $"/c start {Resources.GitHubAddr}",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process.Start(psi);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DolphinExp_ValueChanged(object sender, EventArgs e)
        {
            int val = (int)dolphin_exp.Value;
            int level = (val >= 2940) ? 3 : ((val >= 735) ? 2 : 1);

            dolphin_exp_lbl2.Text = $"EXP (level {level})";
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int icounter_value = (int)dolphin_exp.Value;
                    int butthurt_value = dolphin_state.SelectedIndex;

                    byte[] buffer = Resources.dolphin;

                    if (icounter_value != 0)
                    {
                        buffer = DolphinFile.UpdateIcounter(buffer, icounter_value);
                    }

                    if (butthurt_value != 0)
                    {
                        buffer = DolphinFile.UpdateButthurt(buffer, butthurt_value);
                    }

                    _ = DolphinFile.DolphinStateSave(buffer, Path.Combine(folderBrowserDialog.SelectedPath, ".dolphin.state"));

                    MessageBox.Show(@"File creation was successful! Now copy the "".dolphin.state"" file from the previously selected location to ""Internal Flash"" in Flipper Zero and then restart your device.", "File creating success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
