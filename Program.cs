namespace HashSetPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> warehouseA = new HashSet<int>();
            HashSet<int> warehouseB = new HashSet<int>();

            Console.WriteLine("Enter product IDs for warehouse A. 'Type done to finish'");
            while (true)
            {
                string inputA = Console.ReadLine() ?? throw new Exception();

                if (inputA.ToLower() == "done") break;

                    string[] idsA = inputA.Split(',');
                    foreach (var id in idsA)

                    {
                        if (int.TryParse(id.Trim(), out int inputWarehouseA))
                        {
                            warehouseA.Add(inputWarehouseA);
                        }
                    }
            }

            Console.WriteLine("Enter product IDs for warehouse B. ('Type done to finish')");
            while (true)
            {
                string inputB = Console.ReadLine() ?? throw new Exception();

                if (inputB.ToLower() == "done") break;

                    string[] idsB = inputB.Split(",");
                    foreach (var id in idsB)
                    {
                        if (int.TryParse(id.Trim(), out int inputWareHouseB))
                        {
                            warehouseB.Add(inputWareHouseB);
                        }
                    }   
            }

            HashSet<int> combinedHashSets = new HashSet<int>(warehouseA);
            combinedHashSets.UnionWith(warehouseB);
            
            Console.WriteLine("Combined IDs:");
            Console.Write(string.Join(", ", combinedHashSets));
           
        }
    }
}