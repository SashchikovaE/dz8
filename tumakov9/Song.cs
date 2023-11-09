﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov9
{
    internal class Song
    {
        string name;
        string author;
        Song prev;
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void SetPrev(Song prev)
        {
            this.prev = prev;
        }
        public string Print()
        {
            return Title();
        }
        public string Title()
        {
            string t = $"{name} - {author}";
            return t;
        }
        public override bool Equals(object d)
        {
            if (d == null || GetType() != d.GetType())
            {
                return false;
            }
            Song otherSong = (Song)d;
            return name == otherSong.name && author == otherSong.author;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public Song(string Name, string Author)
        {
            name = Name;
            author = Author;
            prev = null;
        }
        public Song(string Name, string Author, Song Prev)
        {
            name = Name;
            author = Author;
            prev = Prev;
        }
        public Song()
        {

        }
    }
}
