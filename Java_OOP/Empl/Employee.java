package Java_OOP.Empl;

class Employee {
    String name;
    int age;
    double salary;
    String location;

    enum level {
        EXECUTIVE,
        SUPERVISOR,
        DIRECTOR
    }

    Employee(String name, int age, double salary, String location) {
        this.name = name;
        this.age = age;
        this.salary = salary;
        this.location = location;
    }

    void raiseSalary() {
        this.salary *= 1.1;
    }

    void printSalary() {
        System.out.println(this.name + " salary is now: " + this.salary);
    }
}