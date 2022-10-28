package Bank;

public class Main {

    public static void main(String[] args) {
        BankAccount bob = new BankAccount("Bob Hope", 20000);
        System.out.println(bob.getOwner() + "'s: " + bob.getBalance());

        bob.withdraw(20);
        System.out.println(bob.getOwner() + "'s: " + bob.getBalance());

        bob.deposit(50);
        System.out.println(bob.getOwner() + "'s: " + bob.getBalance());

    }
}
