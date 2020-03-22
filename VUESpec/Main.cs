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

        public Main()
        {
            InitializeComponent();
        }
        private void entitySpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.OpenImage.ShowDialog() == DialogResult.OK)
            {
                string filePath = Path.GetDirectoryName(this.OpenImage.FileName);
                string filename = Path.GetFileNameWithoutExtension(this.OpenImage.FileName);

                this.folderMap.Add(filename, filePath);

                EntitySpec entitySpec = new EntitySpec(
                    filename,
                    new CharSetSpec(filename),
                    new TextureSpec(filename),
                    new BGMapSpriteSpec(),
                    new EntityRomSpec());
                entitySpec.Name = filename;
                entitySpec.Dock = DockStyle.Fill;

                TabPage tabPage = new TabPage(filename);
                tabPage.Controls.Add(entitySpec);

                this.Tabs.TabPages.Add(tabPage);
            }
        }

        private void renderSpecsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabs.TabPages.Count; ++i)
            {
                var tabPage = Tabs.TabPages[i];
                string tabName = tabPage.Text;
                string fullFilePath = folderMap[tabName];
                string specFolder = fullFilePath + @"\Spec";
                if (!Directory.Exists(specFolder))
                {
                    Directory.CreateDirectory(specFolder);
                }

                using (TextWriter writer = new StreamWriter(new FileStream(SpecFilenameFormat.Format(specFolder, tabName), FileMode.OpenOrCreate)))
                {
                    var spec = tabPage.Controls.Find(tabName, false)[0] as ISpec;
                    writer.Write(spec.RenderCode());
                }
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Tabs.TabPages.Clear();
        }
    }
}
