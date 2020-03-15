using System.ComponentModel;

namespace VUESpec.Types
{
    [TypeConverter(typeof(PositionConverter))]
    public class Position
    {
        private int x = 0;
        private int y = 0;
        private int z = 0;

        [Browsable(true)]
        [Description("Position along the X-Axis.")]
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
        [Description("Position along the Y-Axis.")]
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
        [Description("Position along the Z-Axis.")]
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

        public override string ToString()
        {
            return $"{this.x}, {this.y}, {this.z}";
        }
    }
}
