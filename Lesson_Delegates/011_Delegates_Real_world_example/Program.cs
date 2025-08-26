namespace _011_Delegates_Real_world_example
{
    //https://stackoverflow.com/questions/31497/where-do-i-use-delegates
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a button instance
            Button button = new Button();

            // Connect the button to a delegate
            button.Click += ()=> { };

            // Simulate button click
            button.OnClick();
        }

 
    }

    // Button class
    class Button
    {
        // Delegate for button click event
        public delegate void ClickEventHandler();

        // Event for button click
        public event ClickEventHandler Click;

        // Method to simulate button click
        public void OnClick()
        {
            // Check if there are any subscribers to the Click event
            if (Click != null)
            {
                // Invoke the Click event
                Click.Invoke();
            }
        }
    }
}
