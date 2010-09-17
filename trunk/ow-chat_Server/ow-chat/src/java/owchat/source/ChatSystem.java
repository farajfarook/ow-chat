/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package owchat.source;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Set;



/**
 *
 * @author Hirantha Neranjan
 */
public class ChatSystem {

    private static ChatSystem chatSystem = null;
    //MessageQueue messageQueue;

    public static ChatSystem initializeChatSystem(){
        if (chatSystem==null)
            chatSystem = new ChatSystem();
        return chatSystem;
    }

    private ChatSystem() {
        //messageQueue = MessageQueue.initializeMessageQueue();
    }

    public String[] getAllUsers(){
        String[] strs = new String[UserManager.UserCount()];
        User[] users = UserManager.GetUsers();
        for (int i= 0; i < strs.length; i++) {
            strs[i] = users[i].toString();
        }
        return strs;
    }

    public String[] getAllFriends(String keyString) throws OWChatException{
        User user = UserManager.GetUserByKeyString(keyString);
        if (user==null)
            throw new OWChatException("Invalid user name");
        Set<User> friends = user.getFriends();
        String[] strs = new String[friends.size()];
        Iterator<User> friendIterator = friends.iterator();
        for (int i= 0; i < strs.length; i++) {
            User frnd = friendIterator.next();
            strs[i] = frnd.toString();
        }
        return strs;
    }

    public boolean resetSystem(){
        UserManager.ClearUsers();
        //messageQueue.resetQueue();
        return true;
    }

    public boolean registerUser(String userName, String password) throws OWChatException{
        if ( (userName==null) || (password==null))
            return false;
        if (!UserManager.AddUser(userName,password))
            throw new OWChatException("User already exists.");
        return true;
    }

    public String signIn(String userName, String password) throws OWChatException{
        if ( (userName==null) || (password==null))
            return null;
        User user = UserManager.GetUserByName(userName);
        if (user==null)
            throw new OWChatException("Invalid user name");
        if (!user.getPassword().equals(UserManager.GetMd5Digest(password)))
            throw new OWChatException("Incorrect password");
        if (user.getOnline())
            throw new OWChatException("User is already online. Automatic signout feature not yet implemented");
        else{
            user.setOnline(true);
            UserManager.LoginUser(user);
            return user.generateKeyString();
        }
    }

    public boolean signOut(String keyString) throws OWChatException{
        if (keyString==null)
            return false;
        User currentUser = UserManager.GetUserByKeyString(keyString);
        if (currentUser==null)
            throw new OWChatException("Invalid keyString");
        if (currentUser.getOnline()){
            currentUser.generateKeyString();
            currentUser.setOnline(false);
            UserManager.LogoutUser(currentUser);
        }else
            throw new OWChatException("User is not online");
        return true;
    }

    public boolean addFriend(String friendName, String keyString) throws OWChatException{
        if ( (friendName==null) || (keyString==null))
            throw new OWChatException("Friend name or keyString cannot be null");
        User currentUser = UserManager.GetUserByKeyString(keyString);
        if (currentUser==null)
           throw new OWChatException("Invalid keyString");
        User friend = UserManager.GetUserByName(friendName);
        if (friend==null)
            throw new OWChatException("Invalid user name");
        return (currentUser.addFriend(friend) && friend.addFriend(currentUser)) ;
    }

    public boolean removeFriend(String friendName, String keyString) throws OWChatException{
        if ( (friendName==null) || (keyString==null))
            throw new OWChatException("Friend name or keyString cannot be null");
        User currentUser = UserManager.GetUserByKeyString(keyString);
        if (currentUser==null)
           throw new OWChatException("Invalid keyString");
        User friend = UserManager.GetUserByName(friendName);
        if (friend==null)
            throw new OWChatException("Invalid user name");
        return (currentUser.removeFriend(friend) && friend.removeFriend(currentUser)) ;
    }


    public Boolean sendMessage(String friendName, String msgBody, String keyString) throws OWChatException{
        
        if ( (friendName==null) || (msgBody==null) || (keyString==null) )
            return false;

        User currentUser = UserManager.GetUserByKeyString(keyString);
        User friend = UserManager.GetUserByName(friendName);
        
        if (currentUser==null)
            throw new OWChatException("Invalid key string.");
        if (friend==null)
            throw new OWChatException("No such user in the friends list.");

        if (friend.getOnline()==false)
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
        User receiver = UserManager.GetUserByKeyString(keyString);
        if (receiver==null)
            throw new OWChatException("Invalid keyString");
        //return messageQueue.removeMessages(receiver);
        return receiver.getWaitingMessages();
    }

    public boolean unregisterUser(String keyString) throws OWChatException{
        User user = UserManager.GetUserByKeyString(keyString);
        if (user==null)
            throw new OWChatException("Invalid keyString");
        return UserManager.RemoveUser(user);
    }

    public String[] searchUser(String searchContent) throws OWChatException{
        User[] users = UserManager.Search(searchContent);
        String[] strs = new String[0];
        if(users != null)
        {
            strs = new String[users.length];
        }
        for (int i= 0; i < strs.length; i++) {
            strs[i] = users[i].toString();
        }
        return strs;
    }
}
