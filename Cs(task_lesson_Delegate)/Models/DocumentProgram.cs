using Cs_task_lesson_Delegate_.Interfaces;

namespace Cs_task_lesson_Delegate_.Models
{
    public class DocumentProgram:IPro,IExpert
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }

        void IExpert.EditDocument()
        {
            Console.WriteLine("Edit in EXPERT version");
        }

        void IPro.EditDocument()
        {
            Console.WriteLine("Edit in PRO version ");
        }

        void IExpert.SaveDocument()
        {
            Console.WriteLine("save in Expert version");
        }

        void IPro.SaveDocument()
        {
            Console.WriteLine("save in Pro version");
        }


        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
}
