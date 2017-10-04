using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernProxyChecker
{
    public partial class TestProgressForm : MaterialSkin.Controls.MaterialForm
    {
        public TestProgressForm()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue800, MaterialSkin.Primary.LightBlue900, MaterialSkin.Primary.LightBlue800, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }

        public void SetProgress(int progress)
        {
            this.progressBar.Value = progress;
            this.progressLabel.Text = progress.ToString() + "%";
        }
    }
}
