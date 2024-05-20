namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một Originator và đặt trạng thái ban đầu
            Originator originator = new Originator();
            originator.setState(100);
            Console.WriteLine("Current state: " + originator.getState());

            // Lưu trạng thái hiện tại
            Caretaker caretaker = new Caretaker();
            caretaker.setMemento(originator.createMemento());

            // Thay đổi trạng thái của Originator
            originator.setState(200);
            Console.WriteLine("State after change: " + originator.getState());

            // Khôi phục lại trạng thái trước đó từ Memento
            originator.setMemento(caretaker.getMemento());
            Console.WriteLine("State after restoring: " + originator.getState());
        }
    }
}