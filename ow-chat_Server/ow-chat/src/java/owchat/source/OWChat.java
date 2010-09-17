/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package owchat.source;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;



/**
 *
 * @author Hirantha Neranjan
 */
@WebService()
public class OWChat {

    ChatSystem chatSystem;

    public OWChat() {
        chatSystem = ChatSystem.initializeChatSystem();
    }


    /**
     * Web service operation
     */
    @WebMethod(operationName = "registerUser")
    public Boolean registerUser(@WebParam(name = "userName")
    String userName, @WebParam(name = "password")
    String password) throws OWChatException {
        return chatSystem.registerUser(userName, password);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "signIn")
    public String signIn(@WebParam(name = "userName")
    String userName, @WebParam(name = "password")
    String password) throws OWChatException {
        return chatSystem.signIn(userName, password);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "getAllUsers")      /////// Only for testing!!!
    public java.lang.String[] getAllUsers() {
        return chatSystem.getAllUsers();
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "getAllFriends")
    public java.lang.String[] getAllFriends(@WebParam(name = "keyString")
            String keyString) throws OWChatException {
        return chatSystem.getAllFriends(keyString);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "resetChatServer")      /////// Only for testing!!!
    public Boolean resetChatServer() {
        return chatSystem.resetSystem();
    }


    /**
     * Web service operation
     */
    @WebMethod(operationName = "signOut")
    public Boolean signOut(@WebParam(name = "keyString")
    String keyString) throws OWChatException {
        return chatSystem.signOut(keyString);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "addAsFriend")
    public Boolean addAsFriend(@WebParam(name = "friendName")
    String friendName, @WebParam(name = "keyString")
    String keyString) throws OWChatException {
        return chatSystem.addFriend(friendName, keyString);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "sendMessage")
    public Boolean sendMessage(@WebParam(name = "friendName")
    String friendName, @WebParam(name = "message")
    String message, @WebParam(name = "keyString")
    String keyString) throws java.lang.Exception {
        return chatSystem.sendMessage(friendName, message, keyString);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "receiveMessages")
    public owchat.source.Message[] receiveMessages(@WebParam(name = "keyString")
    String keyString) throws OWChatException {
        return chatSystem.receiveMessages(keyString);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "unregisterUser")
    public Boolean unregisterUser(@WebParam(name = "keyString")
    String keyString) throws OWChatException {
        return chatSystem.unregisterUser(keyString);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "removeFromFriends")
    public Boolean removeFromFriends(@WebParam(name = "friendName")
    String friendName, @WebParam(name = "keyString")
    String keyString) throws OWChatException {
        return chatSystem.removeFriend(friendName, keyString);
    }


}
