using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsRegularExam
{
    public class Animal
    {
		private string type;
		private int weight;

        public Animal(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public int Weight
        {
			get { return weight; }
			set { weight = value; }
		}

		public string Type
        {
			get { return type; }
			set { type = value; }
		}

        public override string ToString()
        {
            return $"Animal {this.Type} weights {this.Weight} kg.";
        }
    }
}
