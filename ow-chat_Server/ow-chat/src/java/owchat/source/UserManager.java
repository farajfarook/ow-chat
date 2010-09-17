/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package owchat.source;

import java.math.BigInteger;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.ArrayList;
import java.util.Iterator;

/**
 *
 * @author Hirantha Neranjan
 */
public class UserManager
{
    private static ArrayList<User> users = new ArrayList<User>();

    public static User GetUserByKeyString(String keyString){
        for (User user : users) {
            if (user.getKeyString().equals(keyString))
                return user;
        }
        return null;
    }

    public static User GetUserByName(String userName){
        for (User user : users) {
            if (user.getUserName().equals(userName))
                return user;
        }
        return null;
//        User user = null;
//        Session session = OwChatpersistantUtil.getSessionFactory().getCurrentSession();
//        try
//        {
//            session.beginTransaction();
//            user = (User)session.get(User.class,userName);
//            session.getTransaction().commit();
//        }
//        finally
//        {
//            session.close();
//            return user;
//        }
    }

    public static void ClearUsers()
    {
        users = new ArrayList<User>();
    }

    public static Boolean UserExcist(User newUser)
    {
//        for (int i = 0; i < users.size(); i++) {
//            User user = users.get(i);
//            if(user.equals(newUser)) return true;
//        }
//        return false;
         return GetUserByName(newUser.getUserName())!=null;
    }

    public static Boolean AddUser(String username, String password)
    {
        User newUser = new User(username, GetMd5Digest(password));
        if(UserExcist(newUser)) return false;
        users.add(newUser);
        return true;
//        Session session = OwChatpersistantUtil.getSessionFactory().getCurrentSession();
//        try
//        {
//            session.beginTransaction();
//            session.save(newUser);
//            session.getTransaction().commit();
//            return true;
//        }
//        finally
//        {
//            session.close();
//            return false;
//        }
    }

    public static Boolean RemoveUser(User newUser)
    {
        if(UserExcist(newUser)) return false;
        users.remove(newUser);
        return true;
//        Session session = OwChatpersistantUtil.getSessionFactory().getCurrentSession();
//        try
//        {
//            session.beginTransaction();
//            session.delete(newUser);
//            session.getTransaction().commit();
//            return true;
//        }
//        finally
//        {
//            session.close();
//            return false;
//        }
    }

    public static int UserCount()
    {
        return users.size();
//        Session session = OwChatpersistantUtil.getSessionFactory().getCurrentSession();
//        try
//        {
//            session.beginTransaction();
//            List list = session.createQuery("select u from user as u").list();
//            session.getTransaction().commit();
//            return list.size();
//        }
//        finally
//        {
//            session.close();
//            return -1;
//        }

    }

    public static User[] GetUsers()
    {
        return toUserArray(users);
//        Session session = OwChatpersistantUtil.getSessionFactory().getCurrentSession();
//        try
//        {
//            session.beginTransaction();
//            List list = session.createQuery("select u from user as u").list();
//            session.getTransaction().commit();
//            User[] users = new User[list.size()];
//            Iterator it = list.iterator();
//            for (int i = 0; i < users.length; i++) {
//                users[i] = (User) it.next();
//            }
//        }
//        finally
//        {
//            session.close();
//            return null;
//        }
    }

    public static User GetByIndex(int index)
    {
        return users.get(index);
    }

    public static User[] Search(String searchContent)
    {
        ArrayList<User> matchedUsers = new ArrayList<User>();
        for (Iterator<User> it = users.iterator(); it.hasNext();) {
            User user = it.next();
            if(user.getUserName().toLowerCase().indexOf(searchContent.toLowerCase())>=0)
                matchedUsers.add(user);
        }
        return toUserArray(matchedUsers);
    }

    private static User[] toUserArray(ArrayList<User> usersList)
    {
        Object[] userobjs = usersList.toArray();
        User[] userArr = new User[userobjs.length];
        for (int i = 0; i < userobjs.length; i++) {
            Object object = userobjs[i];
            userArr[i] = (User) object;
        }
        return userArr;
    }

    public static String GetMd5Digest(String input)
    {
        try
        {
            MessageDigest md = MessageDigest.getInstance("MD5");
            byte[] messageDigest = md.digest(input.getBytes());
            BigInteger number = new BigInteger(1,messageDigest);
            return number.toString(16);
        }
        catch(NoSuchAlgorithmException e)
        {
            throw new RuntimeException(e);
        }
    }
}
