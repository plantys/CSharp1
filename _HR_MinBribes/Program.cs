namespace _HR_MinBribes {
    internal class Program {
        static void Main(string[] args) {
            List<int> final = new List<int> { 2, 1, 5, 3, 4 };
            List<int> initial = Enumerable.Range(1, final.Count).ToList();
            Swap(final,0);

            Console.WriteLine("Hello, World!");
        }
        public static void minimumBribes(List<int> q) {

        }

static void Swap(List<int> list, int index1) {int temp = list[index1];list[index1] = list[index1+1];list[index1+1] = temp;}
    }
}