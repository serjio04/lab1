using System;
using System.Collections.Generic;
using System.Linq;

// Определение класса "трек"
public class Track
{
    // Поля класса
    public string Title { get; set; }
    public double Duration { get; set; }
    public bool IsRemix { get; set; }

    // Конструктор класса
    public Track(string title, double duration, bool isRemix)
    {
        Title = title;
        Duration = duration;
        IsRemix = isRemix;
    }

    // Переопределение метода ToString()
    public override string ToString()
    {
        if (IsRemix)
            return $"{Title} (remix) - {Duration}";
        else
            return $"{Title} - {Duration}";
    }
}

// Определение класса "альбом"
public class Album
{
    // Поля класса
    private List<Track> tracks;

    // Конструктор класса
    public Album()
    {
        // Инициализация коллекции треков
        tracks = new List<Track>();
    }

    // Метод добавления трека в альбом
    public void AddTrack(Track track)
    {
        tracks.Add(track);
    }

    // Переопределение метода ToString()
    public override string ToString()
    {
        // Формирование строки с информацией о треках альбома
        string result = "";
        for (int i = 0; i < tracks.Count; i++)
        {
            result += $"{i + 1}. {tracks[i]}\n";
        }
        return result;
    }

    // Метод сортировки треков по алфавиту
    public void SortTracks()
    {
        tracks = tracks.OrderBy(track => track.Title).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание треков
        Track track1 = new Track("song 1", 4.32, false);
        Track track2 = new Track("song 2", 3.45, true);
        Track track3 = new Track("song 3", 5.12, false);
        Track track4 = new Track("song 4", 4.20, false);
        Track track5 = new Track("song 5", 6.08, true);

        // Создание альбома
        Album album = new Album();

        // Добавление треков в альбом
        album.AddTrack(track1);
        album.AddTrack(track2);
        album.AddTrack(track3);
        album.AddTrack(track4);
        album.AddTrack(track5);

        // Вывод информации о треках в альбоме
        Console.WriteLine("Tracks in the album:");
        Console.WriteLine(album);

        // Сортировка треков по алфавиту
        album.SortTracks();

        // Вывод информации о треках после сортировки
        Console.WriteLine("\nTracks in the album after sorting:");
        Console.WriteLine(album);
    }
}