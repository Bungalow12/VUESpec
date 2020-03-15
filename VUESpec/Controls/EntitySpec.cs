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
    public partial class EntitySpec : UserControl, ISpec
    {
        private static readonly string templateFileName = @"Templates\EntitySpec.c.template";

        private string entityName;

        public EntitySpec(
            string entityName,
            CharSetSpec charSetSpec, 
            TextureSpec textureSpec, 
            BGMapSpriteSpec bgMapSpriteSpec,
            EntityRomSpec entityRomSpec)
        {
            InitializeComponent();
            this.entityName = entityName;
            this.CharSetProperties.SelectedObject = charSetSpec;
            this.TextureProperties.SelectedObject = textureSpec;
            this.BgMapProperties.SelectedObject = bgMapSpriteSpec;
            this.EntitySpecProperties.SelectedObject = entityRomSpec;
        }

        public string RenderCode()
        {
            using (TextReader reader = new StreamReader(new FileStream(templateFileName, FileMode.Open)))
            {
                string code = reader.ReadToEnd();
                var parts = new Dictionary<string, object>()
                {
                    {"ImageName", entityName},
                    {"CharSetROMSpec", (this.CharSetProperties.SelectedObject as ISpec).RenderCode()},
                    {"TextureROMSpec", (this.TextureProperties.SelectedObject as ISpec).RenderCode()},
                    {"BgmapSpriteROMSpec", (this.BgMapProperties.SelectedObject as ISpec).RenderCode()},
                    {"EntityROMSpec", (this.EntitySpecProperties.SelectedObject as ISpec).RenderCode()},
                };

                return code.Format(parts);
            }
        }
    }
}
