using System.Linq;

namespace ThePicturesOfChaos
{
    public class SystemGenerator
    {
        public struct Rule
        {
            public Rule(string a, string b)
            {
                A = a;
                B = b;
            }

            public string A { get; }

            public string B { get; }
        }

        private readonly Rule[] _rules;

        public SystemGenerator(Rule[] rules) => _rules = rules;

        public string Generate(string axiom)
        {
            var buffer = "";
            for (var currentIndex = 0; currentIndex < axiom.Length; currentIndex++)
            {
                var found = false;
                var currentChar = axiom.ElementAt(currentIndex).ToString();
                foreach (var rule in _rules)
                    if (currentChar == rule.A)
                    {
                        found = true;
                        buffer += rule.B;
                        break;
                    }

                if (!found)
                    buffer += currentChar;
            }

            axiom = buffer;
            return axiom;
        }
    }
}
