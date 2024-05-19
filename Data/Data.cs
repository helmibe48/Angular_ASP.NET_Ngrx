using System;
using System.Collections.Generic;

namespace Summaries.Data
{
    public static class Data
{
    public static List<Book> Books => allBooks;
    static List<Book> allBooks = new List<Book>()
    {
        new Book()
        {
            Id=1,
            Title="Managing Oneself",
            Description="We live in an age of unprecedented opportunity: with ambition, drive, and talent, you can rise to the top of your chosen profession, regardless of where you started out...",
            Author= "Peter Ducker",
            Rate= (double)4.9,
            DateStart = new DateTime(2019,01,20),
            DateRead = null
        },
        new Book()
        {
            Id=2,
            Title="Evolutionary Psychology",
            Description="Evolutionary Psychology: The New Science of the Mind, 5th edition provides students with the conceptual tools of evolutionary psychology, and applies them to empirical research on the human mind...",
            Author= "David Buss",
            Rate= (double)4.8,
            DateStart= null,
            DateRead= null
        },
        new Book()
        {
            Id=3,
            Title="How to Win Friends & Influence People",
            Description="Millions of people around the world have improved their lives based on the teachings of Dale Carnegie. In How to Win Friends and Influence People, he offers practical advice and techniques for how to get out of a mental rut and make life more rewarding...",
            Author= "Dale Carnegie",
            Rate= (double)4.9,
            DateStart= new DateTime(2019,02,23),
            DateRead= new DateTime(2019,03,23)
        },
        new Book()
        {
            Id = 4,
            Title = "The Selfish Gene",
            Description = "Professor Dawkins articulates a gene’s eye view of evolution. A view giving center stage to these persistent units of information, and in which organisms can be seen as vehicles for their replication. This imaginative, powerful, and stylistically brilliant work not only brought the insights of Neo-Darwinism to a wide audience. But galvanized the biology community, generating much debate and stimulating whole new areas of research...",
            Author = "Richard Dawkins",
            Rate = (double)4.4,
            DateStart = null,
            DateRead = null,
        },
        new Book()
        {
            Id = 5,
            Title = "The Lessons of History",
            Description = "Will and Ariel Durant have succeeded in distilling for the reader the accumulated store of knowledge and experience from their five decades of work on the eleven monumental volumes of The Story of Civilization...",
            Author = "Will & Ariel Durant",
            Rate = (double)4.3,
            DateStart = new DateTime(2019,05,16),
            DateRead = null
        },
        new Book()
        {
            Id = 6,
            Title = "Kon Tiki",
            Description = "“Kon-Tiki” is the record of an astonishing adventure across the Pacific Ocean. Intrigued by Polynesian folklore, biologist Thor Heyerdahl suspected that the South Sea Islands had been settled by an ancient race from thousands of miles to the east...",
            Author = "Thor Heyerdahl",
            Rate = (double)4.4,
            DateStart = new DateTime(2019,06,26),
            DateRead = new DateTime(2019,06,26),
        },
        new Book()
        {
            Id = 7,
            Title = "Civilization & It’s Discontents",
            Description = "Sigmund Freud enumerates the fundamental tensions between civilization and the individual. The primary friction stems from the individual’s quest for instinctual freedom and civilization’s contrary demand for conformity and instinctual repression...",
            Author = "Sigmund Freud",
            Rate = (double)4.0,
            DateStart = new DateTime(2019,07,19),
            DateRead = new DateTime(2019,07,19),
        },
        new Book()
        {
            Id = 8,
            Title = "The Story of The Human Body",
            Description = "This ground-breaking book of popular science explores how the way we use our bodies is all wrong...",
            Author = "Daniel Lieberman",
            Rate = (double)4.1,
            DateStart = new DateTime(2019,08,19),
            DateRead = new DateTime(2019,08,19),
        },
        new Book()
        {
            Id = 9,
            Title = "The Story of The Human Body",
            Description = "You want fewer distractions and less on your plate. The daily barrage of e-mails, texts, tweets, messages, and meetings distract you and stress you out. The simultaneous demands of work and family are taking a toll. And what’s the cost? Second-rate work, missed deadlines, smaller paycheques, fewer promotions and lots of stress...",
            Author = "Gary Keller",
            Rate = (double)4.1,
            DateStart = new DateTime(2019,07,18),
            DateRead = new DateTime(2019,09,18),
        },
        new Book()
        {
            Id = 10,
            Title = "Riveted",
            Description = "Professor Jim Davies’ fascinating and highly accessible book, Riveted, reveals the evolutionary underpinnings of why we find things compelling, from art to religion and from sports to superstition...",
            Author = "Jim Davies",
            Rate = (double)4.6,
            DateStart = new DateTime(2019,09,20),
            DateRead = new DateTime(2019,10,28)
        }
    };

}
}