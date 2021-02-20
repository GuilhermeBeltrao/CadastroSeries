using System;
namespace CadastroSeries
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string userOption = GetUserOptions();
            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        AddSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        RemoveSerie();
                        break;
                    case "5":
                        ViewSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        private static void ListSeries()
        {
            Console.WriteLine("List Series");
            var list = repository.List();
            if (list.Count == 0) 
            {
                Console.WriteLine("no series registered");
                return;
            }
            foreach (var serie in list)
            {
                Console.WriteLine($"ID {serie.ReturnId()} - {serie.ReturnTitle()}");

            }
        }

        private static string GetUserOptions()
        {
            Console.WriteLine("1 - list series");
            Console.WriteLine("2 - add new Serie");
            Console.WriteLine("3 - Update Serie");
            Console.WriteLine("4 - remove Serie");
            Console.WriteLine("5 - View Serie");
            Console.WriteLine("C - Clear history");
            Console.WriteLine("0 - Exit");
            Console.WriteLine();   
            string UserOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return UserOption;

        }
        private static void AddSerie()
        {
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{Enum.GetNames(typeof(Genre))} - {i}");
            }
            Console.Write("Choose the desired genre between the options above: ");
            int entryGenre= int.Parse(Console.ReadLine());
			Console.Write("Enter the Title of the serie: ");
			string entryTitle = Console.ReadLine();

			Console.Write("Enter the year the serie was launched: ");
			int entryYear = int.Parse(Console.ReadLine());

			Console.Write("Enter the Description of the serie: ");
			string entryDescription = Console.ReadLine();
			Serie NewSerie = new Serie(id: repository.NextId(),
									    genre: (Genre)entryGenre,
							            title: entryTitle,
										year: entryYear,
										description: entryDescription);

			repository.Add(NewSerie);
        }
        private static void UpdateSerie()
		{
			Console.Write("Enter the Serie ID: ");
			int indexSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genre)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
			}
			Console.Write("Choose the genre between the options above: ");
			int entryGenre = int.Parse(Console.ReadLine());

			Console.Write("Enter the Title of the Serie: ");
			string entryTitle = Console.ReadLine();

			Console.Write("Enter the Year of the Serie: ");
			int entryYear = int.Parse(Console.ReadLine());

			Console.Write("Enter the description of the Serie: ");
			string entryDescription = Console.ReadLine();

			Serie updateSerie = new Serie(id: indexSerie,
										genre: (Genre)entryGenre,
										title: entryTitle,
										year: entryYear,
										description: entryDescription);

			repository.Update(indexSerie, updateSerie);
		}
        private static void ViewSerie()
		{
			Console.Write("Enter the Id of the Serie: ");
			int indexSerie = int.Parse(Console.ReadLine());
			var serie = repository.ReturnById(indexSerie);
			Console.WriteLine(serie);
		}
        private static void RemoveSerie()
		{
			Console.Write("Enter the id of the Serie: ");
			int indexSerie = int.Parse(Console.ReadLine());

			repository.Remove(indexSerie);
		}
    }
}
