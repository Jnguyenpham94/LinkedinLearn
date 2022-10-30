package Contact;

/**
 * Main for Contact class
 */
public class Main {

    public static void main(String[] args) {

        Contact contactOne = new Contact("Rick Sanchez", new PhoneNumber("1234567890"));
        Contact contactTwo = new Contact("Beth Smith", new PhoneNumber(41, "9876543210"));
        Contact contactThree = new Contact("Morty Smith", new PhoneNumber("1122334455"));
        Contact contactFour = new Contact("Summer Smith", "SummerSmith@gmail.com");
        Contact contactFive = new Contact("Jerry Smith", new PhoneNumber("9988776655"), "atJerryS@gmail.com");

        System.out.println(contactOne);
        System.out.println(contactTwo);
        System.out.println(contactThree);
        System.out.println(contactFour);
        System.out.println(contactFive);
    }
}
