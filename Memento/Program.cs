namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            TextDocument document = new TextDocument();
            TextEditor editor = new TextEditor(document);

            editor.Write("перший рядок\n");
            editor.HitSave();

            editor.Write("другий рядок\n");
            editor.HitSave();

            editor.Write("Авпвапвап помилка клавіатури");
            editor.ShowContent();

            editor.HitUndo();
            editor.ShowContent();

            editor.HitUndo();
            editor.ShowContent();

            editor.HitUndo();
        }
    }
}
