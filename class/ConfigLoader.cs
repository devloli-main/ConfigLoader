// This is Helper class for loading configuration from URL

// Required references:
using System;
using System.IO;
using System.Net;
using System.Text;
using UnityEngine;

namespace Renegade
{
    public class ConfigLoader
    {
        private string _url = "https://raw.githubusercontent.com/devloli-main/ConfigLoader/main/config.json";
        public ConfigLoader()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.UserAgent = "ConfigLoader";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string result = reader.ReadToEnd();

            var config = JsonUtility.FromJson<Config>(result);

            Name = config.name;
            Age = config.age;
            Pronouns = config.pronouns;
            Country = config.country;
            Languages = config.languages;
            Hobbies = config.hobbies;
            Status = config.status;
            AskMeAbout = config.askMeAbout;
            CurrentFocus = config.currentFocus;
            Email = config.contact.email;
            Discord = config.contact.discord;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string[] Pronouns { get; private set; }
        public string Country { get; private set; }
        public string[] Languages { get; private set; }
        public string[] Hobbies { get; private set; }
        public string Status { get; private set; }
        public string[] AskMeAbout { get; private set; }
        public string CurrentFocus { get; private set; }
        public string Email { get; private set; }
        public string Discord { get; private set; }

        [Serializable]
        private class Config
        {
            public string name;
            public int age;
            public string[] pronouns;
            public string country;
            public string[] languages;
            public string[] hobbies;
            public string status;
            public string[] askMeAbout;
            public string currentFocus;
            public Contact contact;
        }

        [Serializable]
        private class Contact
        {
            public string email;
            public string discord;
        }
    }
}