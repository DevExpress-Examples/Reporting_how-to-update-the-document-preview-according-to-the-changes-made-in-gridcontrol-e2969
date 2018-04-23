using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// ...

namespace SilverlightApplication28 {
    public class MainPageViewModel {
        IEnumerable<Person> persons;

        public IEnumerable<Person> Persons {
            get {
                return persons;
            }
            set {
                persons = value;
            }
        }

        public MainPageViewModel() {
            persons = new List<Person>(new Person[] { 
                new Person("John", 25),
                new Person("Mary", 33)
            });
        }
    }
}
