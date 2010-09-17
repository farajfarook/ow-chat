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
import java.util.List;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;

/**
 *
 * @author Hirantha Neranjan
 */
public class UserManager {

    private static ArrayList<User> users = new ArrayList<User>();

    public static void LoginUser(User user)
    {
        users.add(user);
    }

    public static void LogoutUser(User user)
    {
        users.remove(user);
    }

    public static User GetUserByKeyString(String keyString) {
        for (User user : users) {
            if (user.getKeyString().equals(keyString)) {
                return user;
            }
        }
        return null;
    }

    public static User GetUserByName(String userName) {
        SessionFactory sessionFactory = OwChatHibernateUtil.getSessionFactory();
        Session session = sessionFactory.getCurrentSession();
        Transaction tx = null;
        try {
            tx = session.beginTransaction();
            User user = (User)session.load(User.class, userName);
            tx.commit();
            String uname = user.getUserName();
            if(uname!="")
                return user;
            else
                return null;
        } catch (RuntimeException exception) {
            if (tx != null && tx.isActive()) {
                try {
                    tx.rollback();
                } catch (HibernateException e1) {
                    throw exception;
                }
            }
            return null;
        }
    }

    public static void ClearUsers() {
        users = new ArrayList<User>();
    }

    public static Boolean UserExcist(User newUser) {
        return GetUserByName(newUser.getUserName()) != null;
    }

    public static Boolean AddUser(String username, String password) {
        User newUser = new User(username, GetMd5Digest(password));
        if (UserExcist(newUser)) {
            return false;
        }
        SessionFactory sessionFactory = OwChatHibernateUtil.getSessionFactory();
        Session session = sessionFactory.getCurrentSession();
        Transaction tx = null;
        try {
            tx = session.beginTransaction();
            session.save(newUser);
            tx.commit();
            return true;
        } catch (RuntimeException exception) {
            if (tx != null && tx.isActive()) {
                try {
                    tx.rollback();
                } catch (HibernateException e1) {
                    throw exception;
                }
            }
            return false;
        }
    }

    public static Boolean RemoveUser(User newUser) {
        if (UserExcist(newUser)) {
            return false;
        }
        SessionFactory sessionFactory = OwChatHibernateUtil.getSessionFactory();
        Session session = sessionFactory.getCurrentSession();
        Transaction tx = null;
        try {
            tx = session.beginTransaction();
            session.delete(newUser);
            tx.commit();
            return true;
        } catch (RuntimeException exception) {
            if (tx != null && tx.isActive()) {
                try {
                    tx.rollback();
                } catch (HibernateException e1) {
                    throw exception;
                }
            }
            return false;
        }
    }

    public static int UserCount()
    {
        SessionFactory sessionFactory = OwChatHibernateUtil.getSessionFactory();
        Session session = sessionFactory.getCurrentSession();
        Transaction tx = null;
        try {
            tx = session.beginTransaction();
            int count = session.createQuery("select u from userdata as u").list().size();
            tx.commit();
            return count;
        } catch (RuntimeException exception) {
            if (tx != null && tx.isActive()) {
                try {
                    tx.rollback();
                } catch (HibernateException e1) {
                    throw exception;
                }
            }
            return 0;
        }
    }

    public static User[] GetUsers() {
        SessionFactory sessionFactory = OwChatHibernateUtil.getSessionFactory();
        Session session = sessionFactory.getCurrentSession();
        Transaction tx = null;
        try {
            tx = session.beginTransaction();
            List userList = session.createQuery("select u from userdata as u").list();
            tx.commit();
            return toUserArray(userList);
        } catch (RuntimeException exception) {
            if (tx != null && tx.isActive()) {
                try {
                    tx.rollback();
                } catch (HibernateException e1) {
                    throw exception;
                }
            }
            return null;
        }
    }

    public static User[] Search(String searchContent) {
        SessionFactory sessionFactory = OwChatHibernateUtil.getSessionFactory();
        Session session = sessionFactory.getCurrentSession();
        Transaction tx = null;
        try {
            tx = session.beginTransaction();
            List userList = session.createQuery("select u from userdata as u where u.username like '%"+searchContent+"%'").list();
            tx.commit();
            return toUserArray(userList);
        } catch (RuntimeException exception) {
            if (tx != null && tx.isActive()) {
                try {
                    tx.rollback();
                } catch (HibernateException e1) {
                    throw exception;
                }
            }
            return null;
        }
    }

    private static User[] toUserArray(List<User> usersList) {
        Object[] userobjs = usersList.toArray();
        User[] userArr = new User[userobjs.length];
        for (int i = 0; i < userobjs.length; i++) {
            Object object = userobjs[i];
            userArr[i] = (User) object;
        }
        return userArr;
    }

    public static String GetMd5Digest(String input) {
        try {
            MessageDigest md = MessageDigest.getInstance("MD5");
            byte[] messageDigest = md.digest(input.getBytes());
            BigInteger number = new BigInteger(1, messageDigest);
            return number.toString(16);
        } catch (NoSuchAlgorithmException e) {
            throw new RuntimeException(e);
        }
    }
}
