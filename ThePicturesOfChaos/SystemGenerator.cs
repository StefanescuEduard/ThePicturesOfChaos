using System.Linq;

namespace ThePicturesOfChaos
{
    public class SystemGenerator
    {
        private readonly Rule[] rules;

        public SystemGenerator(Rule[] rules)
        {
            this.rules = rules;
        }

        public string Generate(string axiom)
        {
            string buffer = string.Empty;

            for (int currentIndex = 0; currentIndex < axiom.Length; currentIndex++)
            {
                bool found = false;
                string currentChar = axiom.ElementAt(currentIndex).ToString();
                foreach (var rule in rules)
                {
                    if (currentChar == rule.A)
                    {
                        found = true;
                        buffer += rule.B;
                        break;
                    }
                }

                if (!found)
                {
                    buffer += currentChar;
                }
            }

            axiom = buffer;
            return axiom;
        }
    }
}
