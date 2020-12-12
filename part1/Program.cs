using System;
using System.IO;
namespace part1
{
    class Program
    {
        static void Main(string[] args)
		{
			NamesDemo nd = new NamesDemo();
			nd.readData("boynames.txt");
			nd.readData("girlnames.txt");
			nd.getNameData();

		}


		public class NamesDemo
		{
			private String[] nameBoys = new String[1000], nameGirls = new String[1000];
			private int[] numBoys = new int[1000], numGirls = new int[1000];

			public void readData(String fName)
			{

				String[] names = new String[1000];
				int[] total = new int[1000];
				try
				{
					using (StreamReader sr = new StreamReader("boynames.txt"))
					{
						string line;
						while ((line = sr.ReadLine()) != null)
						{
							Console.WriteLine(line);
						}
				}
					//String line = null;
					//int countNum = 0;
					//System.IO.StreamReader file = new System.IO.StreamReader(@"boynames.txt");
					//while ((line = file.ReadLine()) != null)
					//{
					//	System.Console.WriteLine(line);
					//	countNum++;
					//}

				if (fName == "boynames.txt")
					{
						this.nameBoys = names;
						this.numBoys = total;
					}
					else
					{
						this.nameGirls = names;
						this.numGirls = total;
					}
					//file.Close();

				}
				catch (FileNotFoundException e)
				{
					Console.Out.WriteLine("File not found.");
					Console.WriteLine(System.Environment.StackTrace);
				}
				catch (IOException e)
				{
					Console.Out.WriteLine("An error contains in input file");
					Console.WriteLine(System.Environment.StackTrace);
				}
			}
			public void getNameData()
			{
				Console.Out.WriteLine("Enter a boy or girl name:");
				string name = Console.ReadLine();

				if (File.ReadAllText("boynames.txt").Contains(name))
				{

					int index = Array.IndexOf(nameBoys, name);
					int occurences = numBoys[index];
					Console.Out.WriteLine(name + " is ranked " + (index + 1) + " in popularity " + "among boys with " + occurences
							+ " namings.");
				}
				else
					Console.Out.WriteLine(name + " is not ranked among the top 1000 girl names.");

				if (File.ReadAllText("girlnames.txt").Contains(name))
				{
					int index = Array.IndexOf(nameGirls, name);
					int occurences = numGirls[index];
					Console.Out.WriteLine(name + " is ranked " + (index + 1) + " in popularity " + "among girls with " + occurences
							+ " namings.");
				}
				else
					Console.Out.WriteLine(name + " is not ranked among the top 1000 girl names.");

			}




		}
	}
}
