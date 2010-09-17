
package owchat.source;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the owchat.source package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _SendMessageResponse_QNAME = new QName("http://source.owchat/", "sendMessageResponse");
    private final static QName _GetAllFriends_QNAME = new QName("http://source.owchat/", "getAllFriends");
    private final static QName _SendMessage_QNAME = new QName("http://source.owchat/", "sendMessage");
    private final static QName _AddAsFriendResponse_QNAME = new QName("http://source.owchat/", "addAsFriendResponse");
    private final static QName _RemoveFromFriendsResponse_QNAME = new QName("http://source.owchat/", "removeFromFriendsResponse");
    private final static QName _ResetChatServerResponse_QNAME = new QName("http://source.owchat/", "resetChatServerResponse");
    private final static QName _GetAllUsersResponse_QNAME = new QName("http://source.owchat/", "getAllUsersResponse");
    private final static QName _RegisterUserResponse_QNAME = new QName("http://source.owchat/", "registerUserResponse");
    private final static QName _SignOut_QNAME = new QName("http://source.owchat/", "signOut");
    private final static QName _ReceiveMessagesResponse_QNAME = new QName("http://source.owchat/", "receiveMessagesResponse");
    private final static QName _OWChatException_QNAME = new QName("http://source.owchat/", "OWChatException");
    private final static QName _SignIn_QNAME = new QName("http://source.owchat/", "signIn");
    private final static QName _ReceiveMessages_QNAME = new QName("http://source.owchat/", "receiveMessages");
    private final static QName _Exception_QNAME = new QName("http://source.owchat/", "Exception");
    private final static QName _SignInResponse_QNAME = new QName("http://source.owchat/", "signInResponse");
    private final static QName _ResetChatServer_QNAME = new QName("http://source.owchat/", "resetChatServer");
    private final static QName _AddAsFriend_QNAME = new QName("http://source.owchat/", "addAsFriend");
    private final static QName _UnregisterUser_QNAME = new QName("http://source.owchat/", "unregisterUser");
    private final static QName _SignOutResponse_QNAME = new QName("http://source.owchat/", "signOutResponse");
    private final static QName _RegisterUser_QNAME = new QName("http://source.owchat/", "registerUser");
    private final static QName _RemoveFromFriends_QNAME = new QName("http://source.owchat/", "removeFromFriends");
    private final static QName _UnregisterUserResponse_QNAME = new QName("http://source.owchat/", "unregisterUserResponse");
    private final static QName _GetAllUsers_QNAME = new QName("http://source.owchat/", "getAllUsers");
    private final static QName _GetAllFriendsResponse_QNAME = new QName("http://source.owchat/", "getAllFriendsResponse");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: owchat.source
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link ResetChatServerResponse }
     * 
     */
    public ResetChatServerResponse createResetChatServerResponse() {
        return new ResetChatServerResponse();
    }

    /**
     * Create an instance of {@link ResetChatServer }
     * 
     */
    public ResetChatServer createResetChatServer() {
        return new ResetChatServer();
    }

    /**
     * Create an instance of {@link SendMessageResponse }
     * 
     */
    public SendMessageResponse createSendMessageResponse() {
        return new SendMessageResponse();
    }

    /**
     * Create an instance of {@link GetAllUsersResponse }
     * 
     */
    public GetAllUsersResponse createGetAllUsersResponse() {
        return new GetAllUsersResponse();
    }

    /**
     * Create an instance of {@link GetAllFriendsResponse }
     * 
     */
    public GetAllFriendsResponse createGetAllFriendsResponse() {
        return new GetAllFriendsResponse();
    }

    /**
     * Create an instance of {@link ReceiveMessages }
     * 
     */
    public ReceiveMessages createReceiveMessages() {
        return new ReceiveMessages();
    }

    /**
     * Create an instance of {@link UnregisterUser }
     * 
     */
    public UnregisterUser createUnregisterUser() {
        return new UnregisterUser();
    }

    /**
     * Create an instance of {@link RemoveFromFriends }
     * 
     */
    public RemoveFromFriends createRemoveFromFriends() {
        return new RemoveFromFriends();
    }

    /**
     * Create an instance of {@link SignInResponse }
     * 
     */
    public SignInResponse createSignInResponse() {
        return new SignInResponse();
    }

    /**
     * Create an instance of {@link UnregisterUserResponse }
     * 
     */
    public UnregisterUserResponse createUnregisterUserResponse() {
        return new UnregisterUserResponse();
    }

    /**
     * Create an instance of {@link RemoveFromFriendsResponse }
     * 
     */
    public RemoveFromFriendsResponse createRemoveFromFriendsResponse() {
        return new RemoveFromFriendsResponse();
    }

    /**
     * Create an instance of {@link GetAllUsers }
     * 
     */
    public GetAllUsers createGetAllUsers() {
        return new GetAllUsers();
    }

    /**
     * Create an instance of {@link Message }
     * 
     */
    public Message createMessage() {
        return new Message();
    }

    /**
     * Create an instance of {@link RegisterUserResponse }
     * 
     */
    public RegisterUserResponse createRegisterUserResponse() {
        return new RegisterUserResponse();
    }

    /**
     * Create an instance of {@link RegisterUser }
     * 
     */
    public RegisterUser createRegisterUser() {
        return new RegisterUser();
    }

    /**
     * Create an instance of {@link SignOutResponse }
     * 
     */
    public SignOutResponse createSignOutResponse() {
        return new SignOutResponse();
    }

    /**
     * Create an instance of {@link ReceiveMessagesResponse }
     * 
     */
    public ReceiveMessagesResponse createReceiveMessagesResponse() {
        return new ReceiveMessagesResponse();
    }

    /**
     * Create an instance of {@link GetAllFriends }
     * 
     */
    public GetAllFriends createGetAllFriends() {
        return new GetAllFriends();
    }

    /**
     * Create an instance of {@link SignOut }
     * 
     */
    public SignOut createSignOut() {
        return new SignOut();
    }

    /**
     * Create an instance of {@link AddAsFriendResponse }
     * 
     */
    public AddAsFriendResponse createAddAsFriendResponse() {
        return new AddAsFriendResponse();
    }

    /**
     * Create an instance of {@link AddAsFriend }
     * 
     */
    public AddAsFriend createAddAsFriend() {
        return new AddAsFriend();
    }

    /**
     * Create an instance of {@link SignIn }
     * 
     */
    public SignIn createSignIn() {
        return new SignIn();
    }

    /**
     * Create an instance of {@link SendMessage }
     * 
     */
    public SendMessage createSendMessage() {
        return new SendMessage();
    }

    /**
     * Create an instance of {@link Exception }
     * 
     */
    public Exception createException() {
        return new Exception();
    }

    /**
     * Create an instance of {@link OWChatException }
     * 
     */
    public OWChatException createOWChatException() {
        return new OWChatException();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link SendMessageResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "sendMessageResponse")
    public JAXBElement<SendMessageResponse> createSendMessageResponse(SendMessageResponse value) {
        return new JAXBElement<SendMessageResponse>(_SendMessageResponse_QNAME, SendMessageResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetAllFriends }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "getAllFriends")
    public JAXBElement<GetAllFriends> createGetAllFriends(GetAllFriends value) {
        return new JAXBElement<GetAllFriends>(_GetAllFriends_QNAME, GetAllFriends.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link SendMessage }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "sendMessage")
    public JAXBElement<SendMessage> createSendMessage(SendMessage value) {
        return new JAXBElement<SendMessage>(_SendMessage_QNAME, SendMessage.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AddAsFriendResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "addAsFriendResponse")
    public JAXBElement<AddAsFriendResponse> createAddAsFriendResponse(AddAsFriendResponse value) {
        return new JAXBElement<AddAsFriendResponse>(_AddAsFriendResponse_QNAME, AddAsFriendResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link RemoveFromFriendsResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "removeFromFriendsResponse")
    public JAXBElement<RemoveFromFriendsResponse> createRemoveFromFriendsResponse(RemoveFromFriendsResponse value) {
        return new JAXBElement<RemoveFromFriendsResponse>(_RemoveFromFriendsResponse_QNAME, RemoveFromFriendsResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ResetChatServerResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "resetChatServerResponse")
    public JAXBElement<ResetChatServerResponse> createResetChatServerResponse(ResetChatServerResponse value) {
        return new JAXBElement<ResetChatServerResponse>(_ResetChatServerResponse_QNAME, ResetChatServerResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetAllUsersResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "getAllUsersResponse")
    public JAXBElement<GetAllUsersResponse> createGetAllUsersResponse(GetAllUsersResponse value) {
        return new JAXBElement<GetAllUsersResponse>(_GetAllUsersResponse_QNAME, GetAllUsersResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link RegisterUserResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "registerUserResponse")
    public JAXBElement<RegisterUserResponse> createRegisterUserResponse(RegisterUserResponse value) {
        return new JAXBElement<RegisterUserResponse>(_RegisterUserResponse_QNAME, RegisterUserResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link SignOut }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "signOut")
    public JAXBElement<SignOut> createSignOut(SignOut value) {
        return new JAXBElement<SignOut>(_SignOut_QNAME, SignOut.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ReceiveMessagesResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "receiveMessagesResponse")
    public JAXBElement<ReceiveMessagesResponse> createReceiveMessagesResponse(ReceiveMessagesResponse value) {
        return new JAXBElement<ReceiveMessagesResponse>(_ReceiveMessagesResponse_QNAME, ReceiveMessagesResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link OWChatException }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "OWChatException")
    public JAXBElement<OWChatException> createOWChatException(OWChatException value) {
        return new JAXBElement<OWChatException>(_OWChatException_QNAME, OWChatException.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link SignIn }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "signIn")
    public JAXBElement<SignIn> createSignIn(SignIn value) {
        return new JAXBElement<SignIn>(_SignIn_QNAME, SignIn.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ReceiveMessages }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "receiveMessages")
    public JAXBElement<ReceiveMessages> createReceiveMessages(ReceiveMessages value) {
        return new JAXBElement<ReceiveMessages>(_ReceiveMessages_QNAME, ReceiveMessages.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Exception }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "Exception")
    public JAXBElement<Exception> createException(Exception value) {
        return new JAXBElement<Exception>(_Exception_QNAME, Exception.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link SignInResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "signInResponse")
    public JAXBElement<SignInResponse> createSignInResponse(SignInResponse value) {
        return new JAXBElement<SignInResponse>(_SignInResponse_QNAME, SignInResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ResetChatServer }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "resetChatServer")
    public JAXBElement<ResetChatServer> createResetChatServer(ResetChatServer value) {
        return new JAXBElement<ResetChatServer>(_ResetChatServer_QNAME, ResetChatServer.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AddAsFriend }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "addAsFriend")
    public JAXBElement<AddAsFriend> createAddAsFriend(AddAsFriend value) {
        return new JAXBElement<AddAsFriend>(_AddAsFriend_QNAME, AddAsFriend.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link UnregisterUser }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "unregisterUser")
    public JAXBElement<UnregisterUser> createUnregisterUser(UnregisterUser value) {
        return new JAXBElement<UnregisterUser>(_UnregisterUser_QNAME, UnregisterUser.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link SignOutResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "signOutResponse")
    public JAXBElement<SignOutResponse> createSignOutResponse(SignOutResponse value) {
        return new JAXBElement<SignOutResponse>(_SignOutResponse_QNAME, SignOutResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link RegisterUser }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "registerUser")
    public JAXBElement<RegisterUser> createRegisterUser(RegisterUser value) {
        return new JAXBElement<RegisterUser>(_RegisterUser_QNAME, RegisterUser.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link RemoveFromFriends }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "removeFromFriends")
    public JAXBElement<RemoveFromFriends> createRemoveFromFriends(RemoveFromFriends value) {
        return new JAXBElement<RemoveFromFriends>(_RemoveFromFriends_QNAME, RemoveFromFriends.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link UnregisterUserResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "unregisterUserResponse")
    public JAXBElement<UnregisterUserResponse> createUnregisterUserResponse(UnregisterUserResponse value) {
        return new JAXBElement<UnregisterUserResponse>(_UnregisterUserResponse_QNAME, UnregisterUserResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetAllUsers }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "getAllUsers")
    public JAXBElement<GetAllUsers> createGetAllUsers(GetAllUsers value) {
        return new JAXBElement<GetAllUsers>(_GetAllUsers_QNAME, GetAllUsers.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetAllFriendsResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://source.owchat/", name = "getAllFriendsResponse")
    public JAXBElement<GetAllFriendsResponse> createGetAllFriendsResponse(GetAllFriendsResponse value) {
        return new JAXBElement<GetAllFriendsResponse>(_GetAllFriendsResponse_QNAME, GetAllFriendsResponse.class, null, value);
    }

}
