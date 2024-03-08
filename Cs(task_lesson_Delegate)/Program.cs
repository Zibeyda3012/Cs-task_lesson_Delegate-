
using Cs_task_lesson_Delegate_.Models;

Start_Program();

static void Start_Program()
{
    string _key;


    Console.Write("Enter Key (basic/pro/expert): ");
    _key = Console.ReadLine();

    if (_key != null)
    {
        if (_key == "basic")
        {
            Console.Clear();
            DocumentProgram docProgram = new DocumentProgram();
            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();
        }

        else if (_key == "pro")
        {
            Console.Clear();
            DocumentProgram docProgram = new ProDocumentProgram();
            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();

        }

        else if (_key == "expert")
        {
            Console.Clear();
            DocumentProgram docProgram = new ExpertDocument();
            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();
        }
        else
            throw new Exception("Incorrect key");
    }
    else
    {
        Console.WriteLine("Key is null");
        return;
    }


}