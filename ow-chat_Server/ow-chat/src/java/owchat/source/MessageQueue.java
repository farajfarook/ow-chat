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
public class MessageQueue {
    private static MessageQueue msgQueue=null;

    private ArrayList<Message> messages = new ArrayList<Message>();

    private MessageQueue() {
    }

    public static MessageQueue initializeMessageQueue(){
        if (msgQueue==null)
            msgQueue = new MessageQueue();
        return msgQueue;
    }

    public void addMessage(Message msg){
        messages.add(msg);
    }

    public Message[] removeMessages(User receiver){
        ArrayList<Message> selectedMsgs= new ArrayList<Message>();

        for (Message message : messages) {
            if (message.to.equals(receiver.getUserName())){
                selectedMsgs.add(message);
                messages.remove(message);
            }
        }
        Message[] msgs = null;
        return selectedMsgs.<Message>toArray(msgs);
    }

    public boolean resetQueue(){
        msgQueue = new MessageQueue();
        return true;
    }
    


}
