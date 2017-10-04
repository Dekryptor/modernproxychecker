using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernProxyChecker
{
    public partial class AddProxyForm : MaterialSkin.Controls.MaterialForm
    {
        public AddProxyForm()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue800, MaterialSkin.Primary.LightBlue900, MaterialSkin.Primary.LightBlue800, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public IList<Proxy> GetData()
        {
            IList<Proxy> proxyList = new List<Proxy>();

            using (StringReader reader = new StringReader(this.proxyTextBox.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Proxy p = Proxy.Parse(line);
                    if (p != null)
                    {
                        proxyList.Add(p);
                    }
                }
            }

            return proxyList;
        }
    }
}
