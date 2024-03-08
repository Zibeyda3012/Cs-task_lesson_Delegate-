

namespace Cs_task_lesson_Delegate_.Models
{
    public class ProDocumentProgram : DocumentProgram
    {
        public new void OpenDocument()
        {
            base.OpenDocument();
        }

        sealed public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }


    }
}
