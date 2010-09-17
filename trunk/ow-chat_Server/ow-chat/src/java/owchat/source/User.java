/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package owchat.source;

import java.util.AbstractSet;
import java.util.EnumSet;
import java.util.HashSet;
import java.util.Iterator;
import java.util.LinkedHashSet;
import java.util.Set;
import sun.security.provider.MD5;

/**
 *
 * @author Hirantha Neranjan
 */
public class User {

    private String userName;
    private String password;
    private boolean online;
    private String keyString;
    private Set<User> friends;
    private Set<Message> waitingMessages;


    public User() {
        online = false;
        friends = new HashSet<User>();
        waitingMessages = new HashSet<Message>();
    }

    public User(String userName, String pasword) {
        this();
        this.userName = userName;
        this.password = pasword;
    }

    public boolean addFriend(User friend) {
        if (isFriendsWtih(friend)) {
            return false;
        }
        friends.add(friend);
        return true;
    }

    public boolean removeFriend(User friend) {
        if (isFriendsWtih(friend)) {
            friends.remove(friend);
            return true;
        } else {
            return false;
        }
    }

    public boolean isFriendsWtih(User friend) {

        return friends.contains(friend);
    }

    public Set getFriends() {
        return friends;
    }

    public boolean insertMessage(Message newMsg){
        waitingMessages.add(newMsg);
        return true;
    }

    public Message[] getWaitingMessages(){
        Message[] messages = new Message[waitingMessages.size()];
        Iterator<Message> it = waitingMessages.iterator();
        for (int i=0; i< messages.length;i++) {
            messages[i] = it.next();
        }
        return messages;
    }

    @Override
    public boolean equals(Object obj) {
        if (obj instanceof User) {
            if (((User) obj).userName.equals(this.userName)) {
                return true;
            }
        }
        return false;
    }

//    @Override
//    public int hashCode() {
//        int hash = 7;
//        hash = 37 * hash + (this.userName != null ? this.userName.hashCode() : 0);
//        return hash;
//    }
    public String getKeyString() {
        return keyString;
    }

    public void setFriends(Set<User> friends) {
        this.friends = friends;
    }

    public void setWaitingMessages(Set<Message> waitingMessages) {
        this.waitingMessages = waitingMessages;
    }

    public String generateKeyString() {
        keyString = "" + ( (userName.hashCode() * 5) + System.currentTimeMillis()
                + (password.hashCode() * 3) )  + "@ow-chat";
        return keyString;
    }

    /**
     * @return the userName
     */
    public String getUserName() {
        return userName;
    }

    /**
     * @param userName the userName to set
     */
    public void setUserName(String userName) {
        this.userName = userName;
    }

    /**
     * @return the password
     */
    public String getPassword() {
        return password;
    }

    /**
     * @param password the password to set
     */
    public void setPassword(String password) {
        this.password = password;
    }

    /**
     * @return the Online
     */
    public boolean getOnline() {
        return online;
    }

    /**
     * @param Online the Online to set
     */
    public void setOnline(boolean Online) {
        this.online = Online;
    }

    @Override
    public String toString() {
        return getUserName()
               + " " +
               getOnline();
    }


}
