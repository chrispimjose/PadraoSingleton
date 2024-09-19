namespace PPSingleton
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Tenta criar duas instâncias diferentes de Singleton.
			Singleton s1 = Singleton.GetInstance();
			Singleton s2 = Singleton.GetInstance();

			// Chama um método da instância Singleton.
			s1.ShowMessage();

			// Verifica se s1 e s2 são a mesma instância (devem ser).
			if (s1 == s2)
			{
				Console.WriteLine("s1 e s2 são a mesma instância.");
			}
			else
			{
				Console.WriteLine("s1 e s2 são instâncias diferentes.");
			}
		}
	}
}
