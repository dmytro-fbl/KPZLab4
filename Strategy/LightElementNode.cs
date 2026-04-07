using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public enum DisplayType { Block, Inline }
    public enum ClosingType { Paired, Single }
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType Display {  get; set; }
        public ClosingType ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public int ChildCount => Children.Count;

        public LightElementNode(string tagName, DisplayType display, ClosingType closing, List<string> cssClasses = null)
        {
            TagName = tagName;
            Display = display;
            ClosingType = closing;
            CssClasses = cssClasses ?? new List<string>();
            Children = new List<LightNode>();
        }

        public void Add(LightNode node)
        {
            Children.Add(node);
        }

        public override string InnerHtml
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHtml);
                }
                return sb.ToString();
            }
        }

        public override string OuterHtml
        {
            get
            {
                string classString = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

                
                if (ClosingType == ClosingType.Single)
                {
                    return $"<{TagName}{classString} />";
                }
                else
                {
                    return $"<{TagName}{classString}>{InnerHtml}</{TagName}>";
                }
            }
        }
    }
}
