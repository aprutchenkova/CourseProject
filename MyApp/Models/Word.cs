using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string EnglishWord { get; set; }
        public string Translation { get; set; }
        public string ExampleSentence { get; set; }
        public string ExampleSentenceTranslation { get; set; }

        public int ThemeId { get; set; }
        public Theme Theme { get; set; }
    }
}