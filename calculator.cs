class Calculator {
	static void Main(string[] args) {
		int a = 10;
		int b = 9;
		
		Console.WriteLine("Hasil penjumlahan angka {0} dan {1} adalah {2}", a, b, sum(a, b));
		Console.WriteLine("Hasil pengurangan angka {0} dan {1} adalah {2}", a, b, min(a, b));
	}
	
	static int sum(int a, int b) {
		return a + b;
	}
	
	static int min(int a, int b) {
		return a - b;
	}
}