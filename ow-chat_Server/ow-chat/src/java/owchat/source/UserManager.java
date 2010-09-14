/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package owchat.source;

/**
 *
 * @author Hirantha Neranjan
 */
public class UserManager {

    private static UserManager manager=null;

    private UserManager(){

    }

    public static UserManager InitializeManager(){
        if (manager==null)
            manager = new UserManager();
        return manager;
    }



}
