using System;
using System.Threading.Tasks;

namespace ConsoleApplication {
    public class Program {
        public static void Main(string[] args) {
			System.Threading.Thread d;	
			Task s = Task.Run(() => {
				while (true) {
					Console.WriteLine("Hello World!");
				}
			});

			s.Wait();
			
			Console.WriteLine("Hello World2!");
        }
    }
}
