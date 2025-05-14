using System;
using System.Collections.Generic;

// Абстрактный класс Театр
public abstract class Theater // // опечатка Theater b private заменить на public
{
    public int NumberOfSeats { get; set; }
    public int NumberOfRows { get; set; }
    public bool HasOrchestraPit { get; set; } // добавить переменную HasOrchestraPit
    
    public double StageSize { get; set; }

    public Theater(int numberOfSeats, int numberOfRows, bool hasOrchestraPit, double stageSize)
    {
        NumberOfSeats = numberOfSeats;
        NumberOfRows = numberOfRows;
        HasOrchestraPit = hasOrchestraPit;
        StageSize = stageSize;
    }

    public abstract string GetInfo();
}

// Класс Кукольный театр
public class PuppetTheater : Theater
{
    private List<string> puppeteers;

    public PuppetTheater(int numberOfSeats, int numberOfRows, bool hasOrchestraPit, double stageSize)
        : base(numberOfSeats, numberOfRows, hasOrchestraPit, stageSize)
    {
        puppeteers = new List<string>();
    }

    public void AddPuppeteer(string puppeteer)
    {
        puppeteers.Add(puppeteer);
    }

    public override string GetInfo()
    {
        return $"Кукольный театр:\n" +
               $"Мест: {NumberOfSeats}, Ряды: {NumberOfRows}, " +
               $"Оркестровая яма: {HasOrchestraPit}, Размер сцены: {StageSize}\n" +
               $"Кукловоды: {string.Join(", ", puppeteers)}";
    }
}

// Класс Цирковая арена
public class CircusArena : Theater
{
    private List<string> circusArtists;

    public CircusArena(int numberOfSeats, int numberOfRows, bool hasOrchestraPit, double stageSize)
        : base(numberOfSeats, numberOfRows, hasOrchestraPit, stageSize)
    {
        circusArtists = new List<string>();
    }

    public void AddCircusArtist(string artist)
    {
        circusArtists.Add(artist);
    }

    public override string GetInfo()
    {
        return $"Цирковая арена:\n" +
               $"Мест: {NumberOfSeats}, Ряды: {NumberOfRows}, " +
               $"Оркестровая яма: {HasOrchestraPit}, Размер сцены: {StageSize}\n" +
               $"Артисты цирка: {string.Join(", ", circusArtists)}";
    }
}

// Класс Кинотеатр
public class Cinema : Theater
{
    private List<string> filmTechnicians;

    public Cinema(int numberOfSeats, int numberOfRows, bool hasOrchestraPit, double stageSize)
        : base(numberOfSeats, numberOfRows, hasOrchestraPit, stageSize)
    {
        filmTechnicians = new List<string>();
    }

    public void AddFilmTechnician(string technician)
    {
        filmTechnicians.Add(technician);
    }

    public override string GetInfo()
    {
        return $"Кинотеатр:\n" +
               $"Мест: {NumberOfSeats}, Ряды: {NumberOfRows}, " +
               $"Оркестровая яма: {HasOrchestraPit}, Размер сцены: {StageSize}\n" +
               $"Киномеханики: {string.Join(", ", filmTechnicians)}";
    }
}

// Пример использования
class Program
{
    static void Main()
    {
        var puppetTheater = new PuppetTheater(100, 10, false, 50.5);
        puppetTheater.AddPuppeteer("Иван");
        puppetTheater.AddPuppeteer("Мария");

        Console.WriteLine(puppetTheater.GetInfo());

        var circusArena = new CircusArena(200, 15, false, 70.0);
        circusArena.AddCircusArtist("Клоун");
        circusArena.AddCircusArtist("Жонглер");

        Console.WriteLine(circusArena.GetInfo());

        var cinema = new Cinema(150, 12, false, 30.0);
        cinema.AddFilmTechnician("Сергей");
        cinema.AddFilmTechnician("Анастасия");

        Console.WriteLine(cinema.GetInfo());
    }
}
