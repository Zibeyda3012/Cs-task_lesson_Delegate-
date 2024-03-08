namespace Cs_task_lesson_Delegate_.Models
{
    public class ExpertDocument : ProDocumentProgram
    {
        new public void OpenDocument()
        {
            base.OpenDocument();
        }

        new public void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }

    }
}
