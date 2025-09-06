using GraphicEditor.Interfaces;

namespace GraphicEditor;

public class GraphicEditorr
{
    public void DrawShape(IShape shape)
    {
        Console.WriteLine($"I'm a {shape.GetType().Name}");
    }
}