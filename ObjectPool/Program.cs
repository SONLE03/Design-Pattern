namespace ObjectPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<Circle> circlePool = new ObjectPool<Circle>(5);

            for (int i = 0; i < 3; i++)
            {
                Circle circle = circlePool.BorrowObject();
                circle.Color = "Red";
                circle.Draw();
                circlePool.ReturnObject(circle);
            }

            for (int i = 0; i < 3; i++)
            {
                Circle circle = circlePool.BorrowObject();
                circle.Color = "Green";
                circle.Draw();
                circlePool.ReturnObject(circle);
            }
            Console.ReadKey();
        }
    }
}