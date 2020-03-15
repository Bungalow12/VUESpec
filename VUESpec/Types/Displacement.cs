using System.ComponentModel;

namespace VUESpec.Types
{
    [TypeConverter(typeof(DisplacementConverter))]
    public class Displacement
    {
        private int x = 0;
        private int y = 0;
        private int z = 0;
        private int parallax = 0;

        [Browsable(true)]
        [Description("Displacement along the X-Axis.")]
        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                x = value;
            }
        }

        [Browsable(true)]
        [Description("Displacement along the Y-Axis.")]
        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                y = value;
            }
        }

        [Browsable(true)]
        [Description("Displacement along the Z-Axis.")]
        public int Z
        {
            get
            {
                return this.z;
            }

            set
            {
                z = value;
            }
        }

        [Browsable(true)]
        [Description("Displacement parallax rate.")]
        public int Parallax
        {
            get
            {
                return this.parallax;
            }

            set
            {
                parallax = value;
            }
        }

        public override string ToString()
        {
            return $"{this.x}, {this.y}, {this.z}, {this.parallax}";
        }
    }
}
