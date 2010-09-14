/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package wstestapp;

import java.net.URL;
import java.util.List;

/**
 *
 * @author Hirantha Neranjan
 */
public class Main {

    static OWChatService service;
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws java.lang.Exception {
        try {
            service = new OWChatService(new URL("http://localhost:8080/ow-chat/OWChatService?wsdl"));
            OWChat chat = service.getOWChatPort();

            chat.resetChatServer();             // deletes all users (use only for testing)

            System.out.println("Jack registered : " + chat.registerUser("Jack", "123"));
            System.out.println("Jill registered : " + chat.registerUser("Jill", "321"));
            System.out.println();

            String jacksKey = chat.signIn("Jack", "123");
            String jillsKey = chat.signIn("Jill", "321");

            System.out.println("Jack is online. Session key : " + jacksKey);
            System.out.println("Jill is online. Session key : " + jillsKey);
            System.out.println();
            

            System.out.println("All registered users");
            List<String> allUsers = chat.getAllUsers(); // use only for testing
            for (String userStr : allUsers) {
                System.out.println(userStr);
            }
            System.out.println();

            System.out.println("Jack adds Jill as a friend : " + chat.addAsFriend("Jill", jacksKey));
            System.out.println();

            System.out.println("Friends of (Jack) " + jacksKey + ":");
            allUsers = chat.getAllFriends(jacksKey);
            for (String frnd : allUsers) {
                System.out.println(frnd);
            }
            System.out.println();

            System.out.println("Friends of (Jill) " + jillsKey + ":");
            allUsers = chat.getAllFriends(jillsKey);
            for (String frnd : allUsers) {
                System.out.println(frnd);
            }
            System.out.println();

            System.out.println("Jacks -> Jill : Hi Jill  " + chat.sendMessage("Jill", "Hi Jill", jacksKey));
            System.out.println("Jacks -> Jill : Lets go up to the hill..  " + chat.sendMessage("Jill", "Lets go up to the hill..", jacksKey));
            System.out.println();
            
            System.out.println("Messages received by Jill");
            List<Message> msgs = chat.receiveMessages(jillsKey);
            for (Message msg : msgs) {
                System.out.println("from: " + msg.from + "  Msg: "+ msg.body);
            }
            System.out.println();

            System.out.println("Jill removes Jack from friends : " + chat.removeFromFriends("Jack", jillsKey));
            System.out.println();

            System.out.println("Friends of (Jack) " + jacksKey + ":");
            allUsers = chat.getAllFriends(jacksKey);
            for (String frnd : allUsers) {
                System.out.println(frnd);
            }
            System.out.println();

            System.out.println("Friends of (Jill) " + jillsKey + ":");
            allUsers = chat.getAllFriends(jillsKey);
            for (String frnd : allUsers) {
                System.out.println(frnd);
            }
            System.out.println();

            System.out.println("Unregister Jack : " + chat.unregisterUser(jacksKey));
            System.out.println();

            System.out.println("All registered users");
            allUsers = chat.getAllUsers();      //use only for testing
            for (String userStr : allUsers) {
                System.out.println(userStr);
            }
            System.out.println();

        } catch (java.lang.Exception ex) {
            ex.printStackTrace();
        }
    }

}
