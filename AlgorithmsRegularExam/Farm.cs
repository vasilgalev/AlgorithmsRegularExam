using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsRegularExam
{
    public class Farm
    {
		private string name;
		private List<Animal> animals;

        public Farm()
        {}

        public Farm(string name)
        {
            this.Name = name;
            this.Animals = new List<Animal>();
        }

        public List<Animal> Animals
        {
			get { return animals; }
			set { animals = value; }
		}


		public string Name
		{
			get { return name; }
			set { name = value; }
		}

        public void AddAnimal(string name, int weight)
        {
            animals.Add(new Animal(name, weight));
        }

        public double AverageWeight()
        {
            var avg = animals.Average(x=>x.Weight);
            return avg;
        }
        public List<string> FilterAnimalsByWeight(int weight)
        {
            var filtering = animals.Where(x=> x.Weight < weight).Select(x=> x.Type).ToList();
            return filtering;
        }
        public List<Animal> SortAscendingByType()
        {
            animals = animals.OrderBy(x=>x.Type).ToList();
            return animals;
        }
        public List<Animal> SortDescendingByWeight()
        {
            animals = animals.OrderByDescending(x => x.Weight).ToList();
                return animals;
        }
        public bool CheckAnimalIsInFarm(string name)
        {
            var search = animals.FirstOrDefault(x=>x.Type == name);
            if (search != null)
            { return true; }
            return false;
        }
        public string[] ProvideInformationAboutAllAnimals()
        {
            string[] info = animals.Select(x=>x.ToString()).ToArray();
            return info;
        }


    }
}
