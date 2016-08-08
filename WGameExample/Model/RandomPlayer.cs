using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGameExample.Model
{
    public class RandomPlayer : Player
    {
        private static readonly List<String> FIRST_NAMES = new List<String>
        {
            "Mason", "Wilma", "Alfred", "Ruth", "Edward", "Lulu", "Winton", "Vivienne", "Furman", "Oma", "Abraham", "Elizabeth", "Phillip", "Hanna", "Frank",
            "Lucy", "Fredrick", "Alyssa", "Gram", "Miranda"
        };

        private static readonly List<String> LAST_NAMES = new List<string>
        {
            "Boggs", "Stinson", "Hutchins", "Flanagan", "Arrington", "Sterling", "Crockett", "Roper", "Starnes", "Waldron", "Houston", "Park", "Hull",
            "Bayram", "Clayton", "Lynn", "Richmond", "Frost", "Leon", "Shandler" };

        private static readonly List<String> MOODS = new List<string>
        {
            "sympathetic", "sad", "lonley", "happy", "angry", "restless", "relaxed", "pissedOff", "mellow", "hyper", "heartbroken", "perfect"
        };

        private static readonly List<String> ALIGNMENTS = new List<string>
        {
            "heroic", "good", "neutral", "bad", "evil"
        };

        private static Random r = new Random();

        public RandomPlayer()
        {
            FirstName = generateRandomFirstName();
            LastName = generateRandomLastName();
            Age = generateRandomAge();
            Alignment = generateRandomAlignment();
            Mood = generateRandomMood();
        }

        private string generateRandomLastName()
        {
            return LAST_NAMES[r.Next() % LAST_NAMES.Count];
        }

        private String generateRandomFirstName()
        {
            return FIRST_NAMES[r.Next() % FIRST_NAMES.Count];
        }

        private int generateRandomAge()
        {
            return r.Next() % 70 + 1;
        }

        private String generateRandomAlignment()
        {
            return ALIGNMENTS[r.Next() % ALIGNMENTS.Count];
        }

        private string generateRandomMood()
        {
            return MOODS[r.Next() % MOODS.Count];
        }
    }
}
