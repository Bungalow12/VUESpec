using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VUESpec.Specs;
using System.IO;

namespace VUESpec.Controls
{
    public partial class EntitySpec : UserControl
    {
        private static readonly string templateFileName = @"Templates\EntitySpec.c.template";

        public EntitySpec(CharSetSpec charSetSpec)
        {
            InitializeComponent();
            this.CharSetProperties.SelectedObject = charSetSpec;
        }

        public string RenderCode(string imageName)
        {
            using (TextReader reader = new StreamReader(new FileStream(templateFileName, FileMode.Open)))
            {
                string code = reader.ReadToEnd();
                var parts = new Dictionary<string, object>()
                {
                    {"ImageName", imageName},
                    {"CharSetROMSpec", (this.CharSetProperties.SelectedObject as CharSetSpec).RenderCode() },
                    {"TextureName", "NotDone"},
                    {"DefineName", "NotDone"},
                    {"BGMapSpriteName", "NotDone"},
                    {"EntityName", "NotDone"},
                    {"EntityI18N", "EN"},
                };

                return code.Format(parts);
            }
        }
    }
}
