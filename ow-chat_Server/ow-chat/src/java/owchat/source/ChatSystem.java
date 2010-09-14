/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package owchat.source;

import java.util.ArrayList;



/**
 *
 * @author Hirantha Neranjan
 */
public class ChatSystem {

    private static ChatSystem chatSystem = null;

    ArrayList<User> users;
    //MessageQueue messageQueue;

    public static ChatSystem initializeChatSystem(){
        if (chatSystem==null)
            chatSystem = new ChatSystem();
        return chatSystem;
    }

    private ChatSystem() {
        //messageQueue = MessageQueue.initializeMessageQueue();
        users = new ArrayList<User>();
    }

    public String[] getAllUsers(){
        String[] strs = new String[users.size()];
        for (int i= 0; i < strs.length; i++) {
            User usr = users.get(i);
            strs[i] = usr.getUserName() + " " + usr.getPassword() + " " + usr.getKeyString() + " " + usr.isOnline();
        }
        return strs;
    }

    public String[] getAllFriends(String keyString){
        User user = getUserByKeyString(keyString);
        ArrayList<User> friends = user.getFriends();
        String[] strs = new String[friends.size()];
        for (int i= 0; i < strs.length; i++) {
            User frnd = friends.get(i);
            strs[i] =frnd.getUserName() + " " + frnd.getPassword() + " " + frnd.getKeyString() + " " + frnd.isOnline();
        }
        return strs;
    }

    public boolean resetSystem(){
        users = new ArrayList<User>();
        //messageQueue.resetQueue();
        return true;
    }

    public boolean registerUser(String userName, String password) throws OWChatException{
        if ( (userName==null) || (password==null))
            return false;
        User newUser = new User(userName,password);
        if (users.indexOf(newUser)<0)
            users.add(newUser);
        else
            throw new OWChatException("User already exists.");
        return true;
    }

    public String signIn(String userName, String password) throws OWChatException{
        if ( (userName==null) || (password==null))
            return null;
        User user = getUserByName(userName);
        if (user==null)
            throw new OWChatException("Invalid user name");
        if (!user.getPassword().equals(password))
            throw new OWChatException("Incorrect password");
        if (user.isOnline())
            throw new OWChatException("User is already online. Automatic signout feature not yet implemented");
        else{
            user.setOnline(true);
            return user.generateKeyString();
        }
    }

    public boolean signOut(String keyString) throws OWChatException{
        if (keyString==null)
            return false;
        User currentUser = getUserByKeyString(keyString);
        if (currentUser==null)
            throw new OWChatException("Invalid keyString");
        if (currentUser.isOnline()){
            currentUser.generateKeyString();
            currentUser.setOnline(false);
        }else
            throw new OWChatException("User is not online");
        return true;
    }

    public boolean addFriend(String friendName, String keyString) throws OWChatException{
        if ( (friendName==null) || (keyString==null))
            throw new OWChatException("Friend name or keyString cannot be null");
        User currentUser = getUserByKeyString(keyString);
        if (currentUser==null)
           throw new OWChatException("Invalid keyString");
        User friend = getUserByName(friendName);
        if (friend==null)
            throw new OWChatException("Invalid user name");
        return (currentUser.addFriend(friend) && friend.addFriend(currentUser)) ;
    }

    public boolean removeFriend(String friendName, String keyString) throws OWChatException{
        if ( (friendName==null) || (keyString==null))
            throw new OWChatException("Friend name or keyString cannot be null");
        User currentUser = getUserByKeyString(keyString);
        if (currentUser==null)
           throw new OWChatException("Invalid keyString");
        User friend = getUserByName(friendName);
        if (friend==null)
            throw new OWChatException("Invalid user name");
        return (currentUser.removeFriend(friend) && friend.removeFriend(currentUser)) ;
    }


    public Boolean sendMessage(String friendName, String msgBody, String keyString) throws OWChatException{
        
        if ( (friendName==null) || (msgBody==null) || (keyString==null) )
            return false;

        User currentUser = getUserByKeyString(keyString);
        User friend = getUserByName(friendName);
        
        if (currentUser==null)
            throw new OWChatException("Invalid key string.");
        if (friend==null)
            throw new OWChatException("No such user in the friends list.");

        if (friend.isOnline()==false)
            throw new OWChatException("Offline users cannot receive messages.");

        if (currentUser.isFriendsWtih(friend)){
            Message msg = new Message(friendName, msgBody, currentUser.getUserName());
            //messageQueue.addMessage(msg);
            friend.insertMessage(msg);
        }else{
            throw new OWChatException("Receiver is not a friend of sender.");
        }
        return true;
    }

    public Message[] receiveMessages(String keyString) throws OWChatException{
        User receiver = getUserByKeyString(keyString);
        if (receiver==null)
            throw new OWChatException("Invalid keyString");
        //return messageQueue.removeMessages(receiver);
        return receiver.getWaitingMessages();
    }

    public boolean unregisterUser(String keyString) throws OWChatException{
        User user = getUserByKeyString(keyString);
        if (user==null)
            throw new OWChatException("Invalid keyString");

        return users.remove(user);
    }

    private User getUserByKeyString(String keyString){
        for (User user : users) {
            if (user.getKeyString().equals(keyString))
                return user;
        }
        return null;
    }

    private User getUserByName(String userName){
        for (User user : users) {
            if (user.getUserName().equals(userName))
                return user;
        }
        return null;
    }

    

}
