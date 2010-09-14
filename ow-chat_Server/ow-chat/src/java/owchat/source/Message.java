/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package owchat.source;



/**
 *
 * @author Hirantha Neranjan
 */
public class Message {
    public String to;
    public String from;
    public String body;
    private long timeStamp;


    public Message(){}

    public Message(String to, String body, String from) {
        this.to = to;
        this.from = from;
        this.body = body;
        timeStamp = System.currentTimeMillis();
    }


    @Override
    public boolean equals(Object obj){
        if (obj instanceof Message){
            if ( ((Message)obj).timeStamp==this.timeStamp ){
                return true;
            }
        }
        return false;
    }

}
