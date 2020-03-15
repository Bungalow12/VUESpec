using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using VUESpec.Types;

namespace VUESpec.Specs
{
    public class BGMapSpriteSpec : ISpec
    {
        private static readonly string templateFileName = @"Templates\BgmapSpriteROMSpec.c.template";

        private static readonly Dictionary<TransparencySettings, string> TransparencySettingsMap = new Dictionary<TransparencySettings, string>()
        {
            {TransparencySettings.None, "__TRANSPARENCY_NONE"},
            {TransparencySettings.Even, "__TRANSPARENCY_EVEN"},
            {TransparencySettings.Odd, "__TRANSPARENCY_ODD"},
        };

        private static readonly Dictionary<BGMapModes, string> BGMapModesMap = new Dictionary<BGMapModes, string>()
        {
            {BGMapModes.BGMap, "__WORLD_BGMAP"},
            {BGMapModes.Affine, "__WORLD_AFFINE"},
            {BGMapModes.Object, "__WORLD_OBJECT"},
            {BGMapModes.HBias, "__WORLD_HBIAS"},
        };

        private static readonly Dictionary<DisplayModes, string> DosplayModesMap = new Dictionary<DisplayModes, string>()
        {
            {DisplayModes.BothDisplays, "__WORLD_ON"},
            {DisplayModes.LeftDisplay, "__WORLD_LON"},
            {DisplayModes.RightDisplay, "__WORLD_RON"},
        };

        public enum TransparencySettings
        {
            None,
            Even,
            Odd
        }

        public enum BGMapModes
        {
            BGMap,
            Affine,
            Object,
            HBias
        }

        public enum DisplayModes
        {
            BothDisplays,
            LeftDisplay,
            RightDisplay
        }

        private string definitionName = "";
        private string affineHBiasFunction = "NULL";

        public BGMapSpriteSpec()
        {
            this.Displacement = new Displacement();
        }

        [Description("Static C definition name to be used. Example 'MY_IMAGE'. This will be auto-appended with '_SPRITE'")]
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

                if (!name.EndsWith("_SPRITE"))
                {
                    this.definitionName += "_SPRITE";
                }
            }
        }

        [Description("The TextureSpec name ending with _TX")]
        public string TextureSpecName
        {
            get;
            set;
        }

        [Description("The displacement for the sprite")]
        public Displacement Displacement
        {
            get;
            set;
        }

        [Description("Pointer to the Affine/HBias manipulation function")]
        public string AffineHBiasFunction
        {
            get
            {
                return this.affineHBiasFunction;
            }

            set
            {
                this.affineHBiasFunction = string.IsNullOrWhiteSpace(value) ? "NULL" : value;
            }
        }

        [Description("Transparency Setting for the Sprite.")]
        public TransparencySettings Transparency
        {
            get;
            set;
        }

        [Description("Background Map Mode")]
        public BGMapModes BackgroundMapMode
        {
            get;
            set;
        }

        [Description("Display Mode")]
        public DisplayModes DisplayMode
        {
            get;
            set;
        }

        /// <summary>
        /// Renders the C Code behind the BGMapSpriteSpec
        /// </summary>
        /// <returns>C Code for BGMapSpriteSpec</returns>
        public string RenderCode()
        {
            var parts = new Dictionary<string, object>()
            {
                {"BGMapSpriteName", this.Name},
                {"TextureSpecName", this.TextureSpecName },
                {"TransparencySetting", TransparencySettingsMap[this.Transparency]},
                {"Displacement", this.Displacement},
                {"BGMapMode", BGMapModesMap[this.BackgroundMapMode]},
                {"AffineHbiasFunction", this.AffineHBiasFunction },
                {"DisplayMode", this.DisplayMode}
            };

            using (TextReader reader = new StreamReader(new FileStream(templateFileName, FileMode.Open)))
            {
                string code = reader.ReadToEnd();
                return code.Format(parts);
            }
        }
    }
}
