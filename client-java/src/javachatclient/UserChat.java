/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * UserChat.java
 *
 * Created on Sep 13, 2010, 10:29:14 AM
 */

package javachatclient;

import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;
import owchat.source.Message;

/**
 *
 * @author KPathirana
 */
public class UserChat extends javax.swing.JFrame {

    /** Creates new form UserChat */
    String friendName = null;
    static String key = null;
//    ChatService sendChat = new ChatService();
    static List<Message> messages = new ArrayList<Message>();
   // static String title = null;
      //ChatMessage chatMessage = new ChatMessage();
      //Thread recieveMessaage = new Thread(new ChatMessage());

    public UserChat() {
    }

    public UserChat(String friendName,String key){
        initComponents();
        this.friendName = friendName;
        this.key = key;

        this.setTitle(friendName);
        jconversation.setEditable(false);
        //title = this.getTitle();
        //recieveMessaage.start();
        //chatMessage.run();
    }

    public UserChat(Message message, String key){
        initComponents();
        this.friendName = message.getFrom();
        this.key = key;
        jconversation.setEditable(false);

        this.getMessage(message);
        

//        this.setTitle(friendName);
//
//        jconversation.append(friendName + " : " + message.getBody());

    }


    /** This method is called from within the constructor to
     * initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is
     * always regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jconversation = new javax.swing.JTextArea();
        jScrollPane2 = new javax.swing.JScrollPane();
        jChatSend = new javax.swing.JTextArea();
        jButton1 = new javax.swing.JButton();
        menuBar = new javax.swing.JMenuBar();
        javax.swing.JMenu fileMenu = new javax.swing.JMenu();
        javax.swing.JMenuItem exitMenuItem = new javax.swing.JMenuItem();
        javax.swing.JMenu helpMenu = new javax.swing.JMenu();
        javax.swing.JMenuItem aboutMenuItem = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setName("Form"); // NOI18N

        jScrollPane1.setName("jScrollPane1"); // NOI18N

        jconversation.setColumns(20);
        jconversation.setRows(5);
        jconversation.setName("jconversation"); // NOI18N
        jScrollPane1.setViewportView(jconversation);

        jScrollPane2.setName("jScrollPane2"); // NOI18N

        jChatSend.setColumns(20);
        jChatSend.setRows(5);
        jChatSend.setName("jChatSend"); // NOI18N
        jScrollPane2.setViewportView(jChatSend);

        org.jdesktop.application.ResourceMap resourceMap = org.jdesktop.application.Application.getInstance(javachatclient.JavaChatClientApp.class).getContext().getResourceMap(UserChat.class);
        jButton1.setText(resourceMap.getString("jButton1.text")); // NOI18N
        jButton1.setName("jButton1"); // NOI18N
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        menuBar.setName("menuBar"); // NOI18N

        fileMenu.setText(resourceMap.getString("fileMenu.text")); // NOI18N
        fileMenu.setName("fileMenu"); // NOI18N

        exitMenuItem.setText(resourceMap.getString("exitMenuItem.text")); // NOI18N
        exitMenuItem.setName("exitMenuItem"); // NOI18N
        exitMenuItem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                exitMenuItemActionPerformed(evt);
            }
        });
        fileMenu.add(exitMenuItem);

        menuBar.add(fileMenu);

        helpMenu.setText(resourceMap.getString("helpMenu.text")); // NOI18N
        helpMenu.setName("helpMenu"); // NOI18N

        javax.swing.ActionMap actionMap = org.jdesktop.application.Application.getInstance(javachatclient.JavaChatClientApp.class).getContext().getActionMap(UserChat.class, this);
        aboutMenuItem.setAction(actionMap.get("showAboutBox")); // NOI18N
        aboutMenuItem.setName("aboutMenuItem"); // NOI18N
        helpMenu.add(aboutMenuItem);

        menuBar.add(helpMenu);

        setJMenuBar(menuBar);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 390, Short.MAX_VALUE)
                    .addComponent(jButton1, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 390, Short.MAX_VALUE))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jButton1))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed

        //jconversation.append(chatMessage.message);
        String chatSend = jChatSend.getText();
        jconversation.append("me : " + chatSend + "\n");
        jChatSend.setText("");

        boolean send = ChatService.chatService.sendMessage(friendName, chatSend, key);

        if(!send){
            JOptionPane.showMessageDialog(null, "Your Message was not sent", "Failed", 0);
        }


    }//GEN-LAST:event_jButton1ActionPerformed

    private void exitMenuItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_exitMenuItemActionPerformed
            //JavaMessenger.closeChatWindow(this);
//        System.out.println(JavaMessenger.openWindows);
//        JavaMessenger.openWindows.put(this.getTitle(), 0);
//        System.out.println(JavaMessenger.openWindows);
        this.dispose();
    }//GEN-LAST:event_exitMenuItemActionPerformed
//
//    public void recieveMessage(){
//        for (Iterator<Message> it = messages.iterator(); it.hasNext();) {
//            Message message = it.next();
//
//            if (message.getFrom() == this.getTitle()) {
//
//                this.jconversation.append(message.getFrom() + " : " + message.getBody());
//
//            }
//
//        }
//    }

    public void getMessage(Message message){

        this.setTitle(friendName);
        //jconversation.setEditable(false);

        jconversation.append(friendName + " : " + message.getBody());

    }
    /**
    * @param args the command line arguments
    */
    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new UserChat().setVisible(true);
//                ChatMessage recieve = new ChatMessage(key);
//                new Thread(recieve).start();
//                messages = recieve.recieveMessages(key);
            }
         
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JTextArea jChatSend;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTextArea jconversation;
    private javax.swing.JMenuBar menuBar;
    // End of variables declaration//GEN-END:variables

}