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

        public Dictionary<string, List<Action>> _eventListeners;

        public LightElementNode(string tagName, DisplayType display, ClosingType closing, List<string> cssClasses = null)
        {
            TagName = tagName;
            Display = display;
            ClosingType = closing;
            CssClasses = cssClasses ?? new List<string>();
            Children = new List<LightNode>();
            _eventListeners = new Dictionary<string, List<Action>>();
        }

        public void Add(LightNode node)
        {
            Children.Add(node);
        }

        public void AddEventListener(string eventType, Action listener)
        {
            if (!_eventListeners.ContainsKey(eventType))
            {
                _eventListeners[eventType] = new List<Action>();
            }
            _eventListeners[eventType].Add(listener);
        }

        public void TriggerEvent(string eventType)
        {
            if (_eventListeners.ContainsKey(eventType))
            {
                Console.WriteLine($" Сталася подія '{eventType}' на тезі <{TagName}>");
                foreach (var listener in _eventListeners[eventType])
                {
                    listener.Invoke();
                }
            }
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
