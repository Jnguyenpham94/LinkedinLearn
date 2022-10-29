package modArray;

public class Main {

    public static void main(String[] args) {
        modArrayList<Integer> list = new modArrayList<>();
        list.add(0);
        list.add(10);
        list.add(20);
        list.add(30);

        System.out.println(list.getModArrayList(1));
        System.out.println(list.getModArrayList(-2));
        System.out.println(list.getModArrayList(40));
    }
}
