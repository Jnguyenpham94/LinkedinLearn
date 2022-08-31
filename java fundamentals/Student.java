import java.util.ArrayList;

public class Student {

    Double GPA;
    String fname, lname;
    ArrayList<String> classes = new ArrayList<>();

    public Student() {
        this.GPA = 0.0;
        this.fname = "NONAME";
        this.lname = "NONAME";
    }

    public Student(Double gpa, String first, String last) {
        this.GPA = gpa;
        this.fname = first;
        this.lname = last;
    }

    public void addclass(String classname) {
        this.classes.add(classname);
    }
}
