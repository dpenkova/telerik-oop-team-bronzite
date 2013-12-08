using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheButcherCalculator
{
    public class AddAnimalException : Exception
    {
        private string animalClassAndKind;

        public string AnimalClassAndKind
        {
            get
            {
                return animalClassAndKind;
            }
        }
        public AddAnimalException(string message, Exception causeException = null)
            : this(message, null, causeException)
        {
        }

        public AddAnimalException(string message, string animalClassAndKind,
            Exception causeException = null)
            : base(message, causeException)
        {
            this.animalClassAndKind = animalClassAndKind;
        }
    }
}