using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<DocumentMemento> _history;

        public TextEditor(TextDocument document)
        {
            _document = document;
            _history = new Stack<DocumentMemento>();
        }

        public void Write(string text)
        {
            _document.Text += text;
        }

        public void ShowContent()
        {
            Console.WriteLine($"ТЕКСТ: {_document.Text}");
        }

        public void HitSave()
        {
            _history.Push(_document.SaveToMemento());
        }

        public void HitUndo()
        {
            if(_history.Count > 0 )
            {
                Console.WriteLine("Натиснута дія відмінити");
                DocumentMemento lastSave = _history.Pop();
                _document.RestoreFromMemento(lastSave);
            }
            else
            {
                Console.WriteLine("Немає історії");
            }
        }
    }
}
