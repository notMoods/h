// The class SampleControl defines two event properties, MouseUp and MouseDown.
using System.ComponentModel;

 
class MouseEventArgs : EventArgs
{
    //class to hold some event data
}

 
class SampleControl : Component
{
    //list of event delegates
    protected EventHandlerList listEventDelegates = new EventHandlerList();

 
    //keys
    static readonly object mouseDownEventKey = new object();
    static readonly object mouseUpEventKey = new object();

 
    // public delegate void MouseEventHandler(object? o, MouseEventArgs e);

    //public EventHandler<MouseEventArgs>? hoo;
   
    public event EventHandler<MouseEventArgs> MouseDown
    {
        add
        {
            listEventDelegates.AddHandler(mouseDownEventKey, value);
        }
        remove
        {
            listEventDelegates.RemoveHandler(mouseDownEventKey, value);
        }
    }

 
    public event EventHandler<MouseEventArgs> MouseUp
    {
        add
        {
            listEventDelegates.AddHandler(mouseUpEventKey, value);
        }
        remove
        {
            listEventDelegates.RemoveHandler(mouseUpEventKey, value);
        }
    }

 
    private void OnMouseDown(MouseEventArgs e)
    {
        EventHandler<MouseEventArgs>? mouseEventDelegate = (EventHandler<MouseEventArgs>?)listEventDelegates[mouseDownEventKey];
        mouseEventDelegate?.Invoke(this, e);
    }

 
    private void OnMouseUp(MouseEventArgs e)
    {
        EventHandler<MouseEventArgs>? mouseEventDelegate = (EventHandler<MouseEventArgs>?)listEventDelegates[mouseUpEventKey];
        mouseEventDelegate?.Invoke(this, e);
    }
}