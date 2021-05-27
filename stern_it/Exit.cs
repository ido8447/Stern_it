using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace stern_it
{
    class Exit
    {
        public void UExut()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
