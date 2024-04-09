namespace Bridge.v2
{
    internal class Program
    {
        interface IMaterial
        {
            string GetName();
        }

        // Concrete Implementor
        class Wood : IMaterial
        {
            public string GetName()
            {
                return "Wood";
            }
        }

        class Metal : IMaterial
        {
            public string GetName()
            {
                return "Metal";
            }
        }

        // Abstraction
        abstract class Furniture
        {
            protected IMaterial _material;

            public Furniture(IMaterial material)
            {
                _material = material;
            }

            public abstract void Assemble();
        }

        // Refined Abstraction
        class Chair : Furniture
        {
            public Chair(IMaterial material) : base(material)
            {
            }

            public override void Assemble()
            {
                Console.WriteLine($"Assembling chair with {_material.GetName()}");
            }
        }

        class Table : Furniture
        {
            public Table(IMaterial material) : base(material)
            {
            }

            public override void Assemble()
            {
                Console.WriteLine($"Assembling table with {_material.GetName()}");
            }
        }

        
        static void Main(string[] args)
        {
            var wood = new Chair(new Wood()); // Metal
            wood.Assemble();

            var metalTable = new Table(new Metal()); //Wood
            metalTable.Assemble();
        }
    }
}