﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace VUESpec.Specs
{
    [DefaultProperty("Name")]
    public class CharSetSpec : ISpec
    {
        private static readonly string templateFileName = @"Templates\CharSetROMSpec.c.template";

        private static readonly Dictionary<AllocationTypes, string> AllocationTypeDefines = new Dictionary<AllocationTypes, string>() 
        {
            {AllocationTypes.NotAnimated, "__NOT_ANIMATED"},
            {AllocationTypes.AnimatedSingle, "__ANIMATED_SINGLE"},
            {AllocationTypes.AnimatedSingleOptimized, "__ANIMATED_SINGLE_OPTIMIZED"},
            {AllocationTypes.AnimatedShared, "__ANIMATED_SHARED"},
            {AllocationTypes.AnimatedSharedCoordinated, "__ANIMATED_SHARED_COORDINATED"},
            {AllocationTypes.AnimatedMulti, "__ANIMATED_MULTI"}
        };

        private string definitionName = "";

        public CharSetSpec(string imageName)
        {
            this.CharSpec = imageName + "Spec";
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
                // Standardize separators
                string name = value.ToUpper().Replace(" ", "_").Replace("-", "_"); 
                this.definitionName = name;
                
                if(!name.EndsWith("_CH"))
                {
                    this.definitionName += "_CH";
                }
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
            get;
            internal set;
        }

        /// <summary>
        /// Renders the C Code behind the CharSetSpec
        /// </summary>
        /// <returns>C Code for CharSetSpec</returns>
        public string RenderCode()
        {
            var parts = new Dictionary<string, object>()
            {
                {"CharSetName", this.Name},
                {"NumberOfChars", this.NumberOfChars},
                {"AllocationType", AllocationTypeDefines[this.AllocationType] },
                {"SpecName", this.CharSpec}
            };

            using (TextReader reader = new StreamReader(new FileStream(templateFileName, FileMode.Open)))
            {
                string code = reader.ReadToEnd();
                return code.Format(parts);
            }            
        }
    }
}
