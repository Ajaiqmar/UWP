﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace HeroExplorer.Models
{
    public class Thumbnail
    {
        public string path { get; set; }
        public string extension { get; set; }
        public string small { get; set; }
        public string large { get; set; }

    }

    public class Comic
    {
        public object resourceURI { get; set; }
        public string name { get; set; }
    }

    public class Comics
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<Comic> items { get; set; }
        public int returned { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public Thumbnail thumbnail { get; set; }
        public string resourceURI { get; set; }
        public Comics comics { get; set; }
        public List<Url> urls { get; set; }
        public BitmapImage ImageSource { get; set; }
    }

    public class CharacterDataContainer
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<Character> results { get; set; }
    }

    public class CharacterDataWrapper
    {
        public int code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public CharacterDataContainer data { get; set; }
    }
}
