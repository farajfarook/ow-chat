/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package owchat.source;


import java.util.HashSet;
import java.util.Set;

/**
 *
 * @author Hirantha Neranjan
 */
public class User implements java.io.Serializable {

    private String userName;
    private String password;
    private boolean online;
    private String keyString;
    private Set<User> friends = new HashSet<User>(0);
    private Set<Message> waitingMessages = new HashSet<Message>(0);


    public User() {
        online = false;
    }

    public Set<User> getFriends() {
        return friends;
    }

    public boolean isOnline() {
        return online;
    }

    public Set<Message> getWaitingMessages() {
        return waitingMessages;
    }

    public void setKeyString(String keyString) {
        this.keyString = keyString;
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

    public boolean insertMessage(Message newMsg){
        waitingMessages.add(newMsg);
        return true;
    }

    public void clearMessage()
    {
        waitingMessages.clear();
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

    @Override
    public int hashCode() {
        int hash = 7;
        hash = 37 * hash + (this.userName != null ? this.userName.hashCode() : 0);
        return hash;
    }

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
