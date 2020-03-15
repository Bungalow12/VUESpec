﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUESpec.Specs
{
    [DefaultProperty("Name")]
    public class CharSetSpec
    {
        private readonly string imageName = "";
        private string definitionName = "";
        private readonly string specName = "";

        public CharSetSpec(string imageName)
        {
            this.imageName = imageName;
            this.specName = imageName + "Spec";
        }

        public enum AllocationTypes
        {
            NotAnimated,
            AnimatedSingle,
            AnimatedSingleOptimized,
            AnimatedShared,
            AnimatedSharedCoordinated,
            AnimatedMulti
        }

        [Description("Static C definition name to be used. Example 'MY_IMAGE'. This will be auto-appended with '_CH'")]
        public string Name
        {
            get
            {
                return this.definitionName;
            }
            set
            {
                this.definitionName = value.ToUpper() + "_CH";
            }
        }

        [Description("The number of chars, depending on the allocation type.")]
        public string NumberOfChars
        {
            get;
            set;
        }

        [Description("The allocation type")]
        public AllocationTypes AllocationType
        {
            get;
            set;
        }

        [Description("The name of the image. This is autogenerated based on image filename via Grit.")]
        public string CharSpec
        {
            get
            {
                return this.specName;
            }
        }
    }
}