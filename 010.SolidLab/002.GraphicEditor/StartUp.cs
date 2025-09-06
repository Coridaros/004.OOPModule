//SOLID - lab, Task 002
//28.08.2025, 15:48

using GraphicEditor;
using GraphicEditor.Interfaces;

public class StartUp
{
    static void Main()
    {
        IShape circle = new Circle();
        IShape rectangle = new Rectangle();

        GraphicEditorr editor = new GraphicEditorr();

        editor.DrawShape(circle);
        editor.DrawShape(rectangle);
    }
}