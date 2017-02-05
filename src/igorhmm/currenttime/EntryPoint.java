package igorhmm.currenttime;

/**
 * Entry point to software to get current time,
 * No input parameters from CL are used
 */
public class EntryPoint {
    public static void main(String[] args) {		
        //TODO: make time format as constant value 
	    System.out.println("Current time is " + CurrentTime.getTime("HH:mm"));
    }
}