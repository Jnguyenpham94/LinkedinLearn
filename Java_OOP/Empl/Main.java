package Java_OOP.Empl;

class Main {

    public static void main(String[] args) {
        Employee bob = new Employee("Bob Hope", 40, 40000, "New York");
        Employee mary = new Employee("Mary Poppins", 20, 50000, "London");

        bob.raiseSalary();
        mary.raiseSalary();

        bob.printSalary();
        mary.printSalary();
    }
}