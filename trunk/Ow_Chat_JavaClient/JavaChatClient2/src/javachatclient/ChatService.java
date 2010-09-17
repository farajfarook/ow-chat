/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package javachatclient;

import java.net.MalformedURLException;
import java.net.URL;
import java.util.Iterator;
import java.util.List;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.xml.ws.soap.SOAPFaultException;
import owchat.source.Exception_Exception;
import owchat.source.Message;
import owchat.source.OWChat;
import owchat.source.OWChatException_Exception;
import owchat.source.OWChatService;

/**
 *
 * @author KPathirana
 */
public class ChatService implements Runnable{

    String message;
    OWChat chat;

    static OWChatService service;
    List<Message> messages = null;
    private String key = null;

    public static ChatService chatService;


    private ChatService(){
        try {
            service = new OWChatService(new URL("http://localhost:8080/ow-chat/OWChatService?wsdl"));

            chat = service.getOWChatPort();

            //chat.resetChatServer();

//            chat.registerUser("Kasun", "123");
//            chat.registerUser("Hirantha", "123");
//            chat.registerUser("Dasun", "123");

        } catch (MalformedURLException ex) {
            Logger.getLogger(ChatService.class.getName()).log(Level.SEVERE, null, ex);
        }
//        catch(OWChatException_Exception ex){
//            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
//            ex.printStackTrace();
//        }
    }

    public static ChatService getInstance(){
            if (chatService == null) {

                chatService = new ChatService();
                return chatService;

        } else {

                return chatService;
        }
    }

     private ChatService(String key){
        try {
            service = new OWChatService(new URL("http://localhost:8080/ow-chat/OWChatService?wsdl"));

            chat = service.getOWChatPort();
            this.key = key;

            //chat.resetChatServer();

//            chat.registerUser("Kasun", "123");
//            chat.registerUser("Hirantha", "123");
//            chat.registerUser("Dasun", "123");

        } catch (MalformedURLException ex) {
            Logger.getLogger(ChatService.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

     public static ChatService getInstanceWithKey(String key){
        return new ChatService(key);
     }

    public void resetServer(){

        chat.resetChatServer();
    }

    public boolean registerUser(String username, String password) {
        try {
            return chat.registerUser(username, password);
        } catch (OWChatException_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            ex.printStackTrace();
            return false;
        }
    }

    public boolean unregisterUser(String key){
        try {
            return chat.unregisterUser(key);
        } catch (OWChatException_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            ex.printStackTrace();
            return false;
        }
    }

    public String signIn(String username, String password){
        try {
            return chat.signIn(username, password);
        } catch (OWChatException_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            ex.printStackTrace();
            return null;
        }
    }

    public boolean signOut(String key){
        try {
            return chat.signOut(key);
        } catch (OWChatException_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            ex.printStackTrace();
            return false;
        }
    }

    public boolean addAsFriend(String friendName, String key){
        try {
            return chat.addAsFriend(friendName, key);
        } catch (OWChatException_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            ex.printStackTrace();
            return false;
        }
    }

    public boolean removeFromFriends(String friendName, String key){
        try {
            return chat.removeFromFriends(friendName, key);
        } catch (OWChatException_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            ex.printStackTrace();
            return false;
        }

    }

    public boolean sendMessage(String friendName, String message, String key){
        try {
            return chat.sendMessage(friendName, message, key);
        } catch(SOAPFaultException ex){
            
            ex.printStackTrace();
            JOptionPane.showMessageDialog(null, "User Offline", "Cannot send message", 0);

        }
        catch (Exception_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println("Problem in send message");
            ex.printStackTrace();
//            return false;
        }
        return false;
    }


    public Vector getAllFriends(String key){
        Vector friendList = new Vector();

        try {
            List<String> friends = chat.getAllFriends(key);

            Iterator i = friends.iterator();
            //Vector nameList = new Vector();
            while(i.hasNext()){
            String []s = i.next().toString().trim().split(" ");
            friendList.add(s[0]);
    }
            

           // friendList.addAll(friends);

//            for (Iterator<String> it = friends.iterator(); it.hasNext();it.next()) {
//                 friendList.a
//
//            }
        } catch (OWChatException_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            ex.printStackTrace();
        }

        return friendList;

    }

    public List recieveMessages(String key){
        //this.key = key;
        List messageList = null;
        try {
            messageList = chat.receiveMessages(key);
        } catch (OWChatException_Exception ex) {
            //Logger.getLogger(ChatMessage.class.getName()).log(Level.SEVERE, null, ex);
            ex.printStackTrace();
        }
        return messageList;
    }


    public void run() {
        
        while (true) {
            
            messages = this.recieveMessages(key);
//            JavaMessenger.recieveMessages();
//            System.out.println(messages);
            
        }




        }

  
        //this.recieveMessages(key);
        
        //throw new UnsupportedOperationException("Not supported yet.");


}
