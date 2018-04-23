// ...

namespace SilverlightApplication28 {
    public class MainPageViewModel {
        public Person[] Persons { get; set; }

        public MainPageViewModel() {
            Persons = new[] { 
                new Person("John", 25),
                new Person("Mary", 33)
            };
        }
    }
}
