using System;
using System.Windows.Forms;

namespace HexOperation
{
    public partial class Main
    {
        public Main()
        {
            InitializeComponent();
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Title = "File",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
                FileName = "*.*",
                Filter = "all file |*.*;*.* ",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtfile.Text = openFileDialog.FileName;
            }
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            HexOperation.HexPatch(txtfile.Text, txtvalue.Text, txtreplace.Text);
        }
    }
}