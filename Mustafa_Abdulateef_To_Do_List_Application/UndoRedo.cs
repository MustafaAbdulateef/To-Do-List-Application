using Mustafa_Abdulateef_To_Do_List_Application;
using System.Windows.Forms;

public abstract class Command
{
    public abstract void Execute();
    public abstract void Undo();
}

public class AddItemCommand : Command
{
    private FlowLayoutPanel _flp;
    private UC_Display _item;

    public AddItemCommand(FlowLayoutPanel flp, UC_Display item)
    {
        _flp = flp;
        _item = item;
    }

    public override void Execute()
    {
        _flp.Controls.Add(_item);
    }

    public override void Undo()
    {
        _flp.Controls.Remove(_item);
    }
}

public class RemoveItemCommand : Command
{
    private FlowLayoutPanel _flp;
    private UC_Display _item;

    public RemoveItemCommand(FlowLayoutPanel flp, UC_Display item)
    {
        _flp = flp;
        _item = item;
    }

    public override void Execute()
    {
        _flp.Controls.Remove(_item);
    }

    public override void Undo()
    {
        _flp.Controls.Add(_item);
    }
}

public class TextChangeCommand : Command
{
    private TextBox _textBox;
    private string _oldText;
    private string _newText;

    public TextChangeCommand(TextBox textBox, string oldText, string newText)
    {
        _textBox = textBox;
        _oldText = oldText;
        _newText = newText;
    }

    public override void Execute()
    {
        _textBox.Text = _newText;
    }

    public override void Undo()
    {
        _textBox.Text = _oldText;
    }
}