using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using VUESpec.Controls;
using VUESpec.Specs;

namespace VUESpec
{
    public partial class Main : Form
    {
        private static readonly string SpecFilenameFormat = @"{0}\{1}Spec.c";

        private Dictionary<string, string> folderMap = new Dictionary<string, string>();
        // TODO: Bad solution here I'll fix it later
        private Dictionary<string, EntitySpec> entitySpecMap = new Dictionary<string, EntitySpec>();
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
                entitySpecMap.Add(filename, entitySpec);

                TabPage tabPage = new TabPage(filename);
                tabPage.Controls.Add(entitySpec);

                this.Tabs.TabPages.Add(tabPage);
            }
        }

        private void generateSpecsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tabName = Tabs.SelectedTab.Text;
            string fullFilePath = folderMap[tabName];
            string specFolder = Path.GetDirectoryName(fullFilePath) + @"\Spec";
            if (!Directory.Exists(specFolder))
            {
                Directory.CreateDirectory(specFolder);
            }

            using (TextWriter writer = new StreamWriter(new FileStream(SpecFilenameFormat.Format(specFolder, tabName), FileMode.OpenOrCreate)))
            {
                writer.Write(entitySpecMap[tabName].RenderCode(tabName));
            }
        }
    }
}
