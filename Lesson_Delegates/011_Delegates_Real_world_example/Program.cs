namespace _011_Delegates_Real_world_example
{
    //https://stackoverflow.com/questions/31497/where-do-i-use-delegates
    internal class Program
    {
        // Define a delegate type for the funeral delegate
        delegate void FuneralDelegate(string condolences);

        static void Main(string[] args)
        {
            // Create an instance of the FuneralDelegate
            FuneralDelegate funeralDelegate;

            // Assign a particular person to the funeral delegate
            funeralDelegate = AttendFuneral;

            // Invoke the funeral delegate
            funeralDelegate("Sending condolences and kind words");

            Console.WriteLine("Hello, World!");

            //// Create a button instance
            //Button button = new Button();

            //// Connect the button to a delegate
            //button.Click += HandleButtonClick;

            //// Simulate button click
            //button.OnClick();
        }

        // Method to attend the funeral
        static void AttendFuneral(string condolences)
        {
            Console.WriteLine("Attending the funeral...");
            Console.WriteLine("Sending: " + condolences);
            Console.WriteLine("Receiving: Good will");
        }

        // Method to handle button click
        static void HandleButtonClick()
        {
            Console.WriteLine("Button clicked!");
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
