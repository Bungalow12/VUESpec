using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VUESpec.Types;

namespace VUESpec.Specs
{
    public class EntityRomSpec : ISpec
    {
        private static readonly string templateFileName = @"Templates\EntityROMSpec.c.template";

        private static readonly Dictionary<CharacterTypes, string> CharacterTypesMap = new Dictionary<CharacterTypes, string>()
        {
            {CharacterTypes.None, "kTypeNone"},
        };

        private string definitionName = "";
        private string behaviors = "NULL";
        private string shapeSpecName = "NULL";
        private string physicalSpecification = "NULL";


        public enum CharacterTypes
        {
            None
        }

        public EntityRomSpec()
        {
            this.Size = new Position();
        }

        [Description("Static C definition name to be used. Example 'MY_IMAGE'.")]
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
            }
        }

        [Description("The BGMapSpriteSpec name ending with _SPRITES")]
        public string BGMapSpriteSpecName
        {
            get;
            set;
        }

        [Description("Behaviors")]
        public string Behaviors
        {
            get
            {
                return this.behaviors;
            }

            set
            {
                this.behaviors = string.IsNullOrWhiteSpace(value) ? "NULL" : value;
            }
        }

        [Description("Collision Shape Specifcation Name")]
        public string CollisionShapeSpecName
        {
            get
            {
                return this.shapeSpecName;
            }

            set
            {
                this.shapeSpecName = string.IsNullOrWhiteSpace(value) ? "NULL" : value;
            }
        }

        [Description("If 0, width and height will be inferred from the first sprite's texture's size.")]
        public Position Size
        {
            get;
            set;
        }

        [Description("Game World character's type.")]
        public CharacterTypes CharacterType
        {
            get;
            set;
        }

        [Description("Physical Specification")]
        public string PhysicalSpecification
        {
            get
            {
                return this.physicalSpecification;
            }

            set
            {
                this.physicalSpecification = string.IsNullOrWhiteSpace(value) ? "NULL" : value;
            }
        }

        /// <summary>
        /// Renders the C Code behind the EntityROMSpec
        /// </summary>
        /// <returns>C Code for EntityROMSpec</returns>
        public string RenderCode()
        {
            var parts = new Dictionary<string, object>()
            {
                {"EntityName", this.Name},
                {"BGMapSpriteName", this.BGMapSpriteSpecName},
                {"Behaviors", this.Behaviors},
                {"ShapeSpec", this.CollisionShapeSpecName},
                {"Size", this.Size},
                {"CharacterType", CharacterTypesMap[this.CharacterType]},
                {"PhysicalSpecification", this.PhysicalSpecification},
            };

            using (TextReader reader = new StreamReader(new FileStream(templateFileName, FileMode.Open)))
            {
                string code = reader.ReadToEnd();
                return code.Format(parts);
            }
        }
    }
}
