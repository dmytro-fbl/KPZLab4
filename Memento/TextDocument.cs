using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocument
    {
        public string Text { get; set; } = "";
        public DocumentMemento SaveToMemento()
        {
            return new DocumentMemento(Text);
        }
        public void RestoreFromMemento(DocumentMemento memento)
        {
            Text = memento.Text;
        }
    }
}
