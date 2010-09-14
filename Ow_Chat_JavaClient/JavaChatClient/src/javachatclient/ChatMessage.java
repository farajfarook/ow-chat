/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package javachatclient;

/**
 *
 * @author KPathirana
 */
public class ChatMessage implements Runnable{

    String message;
    public ChatMessage(){
        
    }

    public boolean validateUser(){
        return true;
    }

    public String recieveMessage(){
        return "Hello";
    }

    public void run() {
        message = recieveMessage();
        throw new UnsupportedOperationException("Not supported yet.");
    }

}
