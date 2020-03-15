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
using VUESpec.Controls;
using VUESpec.Specs;

namespace VUESpec
{
    public partial class Main : Form
    {
        private static readonly string SpecFilenameFormat = "{0}Spec.c";

        private Dictionary<string, string> folderMap = new Dictionary<string, string>();
        public Main()
        {
            InitializeComponent();
        }

        private void entitySpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.OpenImage.ShowDialog() == DialogResult.OK)
            {
                string fullFilename = this.OpenImage.FileName;
                string filename = Path.GetFileNameWithoutExtension(fullFilename);

                this.folderMap.Add(filename, fullFilename);

                EntitySpec entitySpec = new EntitySpec(new CharSetSpec(filename));
                entitySpec.Dock = DockStyle.Fill;
                TabPage tabPage = new TabPage(filename);
                tabPage.Controls.Add(entitySpec);

                this.Tabs.TabPages.Add(tabPage);
            }
        }
    }
}
