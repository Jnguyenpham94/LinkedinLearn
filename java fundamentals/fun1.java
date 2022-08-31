public class fun1 {

    public static void main(String[] args) {
        Student dude1 = new Student();
        dude1.addclass("English 101");
        dude1.addclass("CECS 444");
        System.out.println(dude1.classes);

        Student dude2 = new Student();
        dude2.addclass("CECS 100");
        dude2.addclass("Biology 200");
        System.out.println(dude2.classes);
    }

}
