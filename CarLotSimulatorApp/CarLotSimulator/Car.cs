using System;
namespace CarLotSimulator
{
	public class Car
	{
		// Default Constructor
		public Car()
		{
		}

		public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
		{
			Year = year;
			Make = make;
			Model = model;
			EngineNoise = engineNoise;
			HonkNoise = honkNoise;
			IsDrivable = isDriveable;
		}

		// PROPERTY
		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDrivable { get; set; }


		//Methods
		public void MakeEngineNoise(string engineNoise)
		{
			Console.WriteLine($"{engineNoise}");
		}

		public void MakeHonkNoise(string honkNoise)
		{
			Console.WriteLine($"{honkNoise}");
		}

	}
}

