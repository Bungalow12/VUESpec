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

namespace VUESpec.Controls
{
    public partial class EntitySpec : UserControl
    {

        public EntitySpec(CharSetSpec charSetSpec)
        {
            InitializeComponent();
            this.CharSetProperties.SelectedObject = charSetSpec;
        }
    }
}
