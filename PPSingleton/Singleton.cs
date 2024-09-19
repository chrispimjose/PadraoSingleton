using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPSingleton
{
	public class Singleton
	{
		// O campo estático que contém a única instância da classe Singleton
		private static Singleton _instance;

		// Construtor privado garante que a classe não possa ser instanciada de fora.
		private Singleton()
		{
			Console.WriteLine("Instância Singleton criada.");
		}

		// Método estático público que controla o acesso à instância Singleton.
		public static Singleton GetInstance()
		{
			// Verifica se a instância já foi criada; se não, cria uma nova.
			if (_instance == null)
			{
				_instance = new Singleton();
			}

			// Retorna a instância única da classe.
			return _instance;
		}

		// Um exemplo de método que pode ser chamado a partir da instância Singleton
		public void ShowMessage()
		{
			Console.WriteLine("Método do Singleton chamado!");
		}
	}
}
