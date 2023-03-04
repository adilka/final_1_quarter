class Program {
    static void Main(string[] args) {
        
        List<string> shortStrings = new List<string>();
        
        Console.Write("Vvedite kolichestvo strok: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            Console.Write("Vvedite stroku: ");
            string s = Console.ReadLine();
            if (s.Length <= 3) {
                shortStrings.Add(s);
            }
        }
        Console.WriteLine("Stroki kotorie i<=3:");
        foreach (string s in shortStrings) {
            Console.WriteLine(s);
        }
    }
}
